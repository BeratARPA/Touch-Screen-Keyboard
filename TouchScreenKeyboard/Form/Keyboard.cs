using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TouchScreenKeyboard.Class;

namespace TouchScreenKeyboard
{
    public partial class Keyboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Keyboard()
        {
            InitializeComponent();

            Belgeler.KlasorleriOlustur();

            DefaultSettings.Write();

            this.ResizeBegin += (s, e) => { this.Opacity = 0.50; splitContainer.Visible = false; this.SuspendLayout(); };
            this.ResizeEnd += (s, e) => { string read = iniFile.Read("Şeffaflık", "Ayarlar").ToString(); this.Opacity = Convert.ToDouble(read.Replace('.', ',')); ; splitContainer.Visible = true; this.ResumeLayout(true); Helpers.ButtonFontResize(this); };

            Helpers.FormPosition(this);
            Helpers.ButtonFontResize(this);
        }

        IniFile iniFile = new IniFile(Belgeler.isPOSFolderPath + "\\Ayarlar.ini");
        bool capslock = false, shift = false;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000; //WS_EX_COMPOSITED
                handleParam.ExStyle |= 0x08000000;
                return handleParam;
            }
        }

        private void Keyboard_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        #region LoadSettings
        public void LoadSettings()
        {
            if (iniFile.KeyExists("Şeffaflık", "Ayarlar"))
            {
                string read = iniFile.Read("Şeffaflık", "Ayarlar").ToString();
                this.Opacity = Convert.ToDouble(read.Replace('.', ','));
            }

            if (iniFile.KeyExists("Sürükleme", "Ayarlar"))
            {
                bool surukleme = Convert.ToBoolean(iniFile.Read("Sürükleme", "Ayarlar"));
                bool boyutlandırma = Convert.ToBoolean(iniFile.Read("Boyutlandırma", "Ayarlar"));

                if (surukleme)
                {
                    if (boyutlandırma)
                    {
                        this.FormBorderStyle = FormBorderStyle.Sizable;
                    }
                    else
                    {
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    }

                    splitContainer.Panel1Collapsed = true;
                    Helpers.FormPosition(this);
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    splitContainer.Panel1Collapsed = false;
                    Helpers.FormPosition(this);
                }
            }

            if (iniFile.KeyExists("Boyutlandırma", "Ayarlar"))
            {
                bool surukleme = Convert.ToBoolean(iniFile.Read("Sürükleme", "Ayarlar"));

                if (surukleme)
                {
                    bool boyutlandırma = Convert.ToBoolean(iniFile.Read("Boyutlandırma", "Ayarlar"));

                    if (boyutlandırma)
                    {
                        this.FormBorderStyle = FormBorderStyle.Sizable;
                    }
                    else
                    {
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    }
                }
            }

            if (iniFile.KeyExists("Renk", "Ayarlar"))
            {
                int renk = Convert.ToInt32(iniFile.Read("Renk", "Ayarlar"));
                Theme.FormThemeChange(this, renk);
                Theme.CharacterButtonThemeChange(this, "Character", renk);
                Theme.CharacterButtonThemeChange(this, "SpecialCharacters", renk);
                Theme.ControlButtonThemeChange(this, "Control", renk);
            }
        }
        #endregion

        #region FormEvent
        private void Keyboard_Resize(object sender, EventArgs e)
        {
            Helpers.ButtonFontResize(this);
        }
        #endregion

        #region Settings
        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settingsCheck = (Settings)Application.OpenForms["Settings"];
            if (settingsCheck != null)
            {
                settingsCheck.BringToFront();
            }
            else
            {
                Settings settings = new Settings(this, splitContainer);
                settings.Show();
            }
        }
        #endregion

        #region Close
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Keys

        #region Capslock
        public void CapslockActive()
        {
            int renk = Convert.ToInt32(iniFile.Read("Renk", "Ayarlar"));
            Theme.ActiveButtonThemeChange(renk, btn_caps);

            ShiftPassive();
            Helpers.CharacterButtonTextToUpper(this, "Character");
            Helpers.SpecialCharactersButtonTextChange(this, shift, "SpecialCharacters", '\\');
        }

        public void CapslockPassive()
        {
            int renk = Convert.ToInt32(iniFile.Read("Renk", "Ayarlar"));
            Theme.PassiveButtonThemeChange(renk, btn_caps);

            Helpers.CharacterButtonTextToLower(this, "Character");
            Helpers.SpecialCharactersButtonTextChange(this, shift, "SpecialCharacters", '\\');
        }

        private void btn_caps_Click(object sender, EventArgs e)
        {
            if (!capslock)
            {
                capslock = true;
                shift = false;

                CapslockActive();
            }
            else
            {
                capslock = false;
                shift = false;

                CapslockPassive();
            }
        }
        #endregion

        #region Shift
        public void ShiftActive()
        {
            int renk = Convert.ToInt32(iniFile.Read("Renk", "Ayarlar"));
            Theme.ActiveButtonThemeChange(renk, btn_leftShift);
            Theme.ActiveButtonThemeChange(renk, btn_rightShift);

            CapslockPassive();
            Helpers.CharacterButtonTextToUpper(this, "Character");
            Helpers.SpecialCharactersButtonTextChange(this, shift, "SpecialCharacters", '\\');
        }

        public void ShiftPassive()
        {
            int renk = Convert.ToInt32(iniFile.Read("Renk", "Ayarlar"));
            Theme.PassiveButtonThemeChange(renk, btn_leftShift);
            Theme.PassiveButtonThemeChange(renk, btn_rightShift);

            Helpers.CharacterButtonTextToLower(this, "Character");
            Helpers.SpecialCharactersButtonTextChange(this, shift, "SpecialCharacters", '\\');
        }

        private void Shift_Click(object sender, EventArgs e)
        {
            if (!shift)
            {
                capslock = false;
                shift = true;

                ShiftActive();
            }
            else
            {
                capslock = false;
                shift = false;

                ShiftPassive();
            }
        }
        #endregion

        #region Tab
        private void btn_tab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }
        #endregion

        #region Backspace
        private void btn_backspace_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }
        #endregion

        #region Esc
        private void btn_esc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }
        #endregion

        #region Left
        private void btn_left_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }
        #endregion

        #region Right
        private void btn_right_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }
        #endregion

        #region Up
        private void btn_up_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }
        #endregion

        #region Down
        private void btn_down_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }
        #endregion

        #region Space
        private void btn_space_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }
        #endregion

        #region Enter
        private void btn_enter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }
        #endregion

        #region Character
        private void Character_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (capslock || shift)
            {
                SendKeys.Send(button.Text.ToUpper());
            }
            else
            {
                SendKeys.Send(button.Text.ToLower());
            }
        }
        #endregion

        #region SpecialCharacters
        private void SpecialCharacters_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (shift)
            {
                if (button.Text == "&&")
                {
                    SendKeys.Send("{&}");
                }
                else
                {
                    SendKeys.Send("{" + button.Text + "}");
                }

            }
            else
            {
                SendKeys.Send(button.Text);
            }
        }
        #endregion

        #endregion
    }
}