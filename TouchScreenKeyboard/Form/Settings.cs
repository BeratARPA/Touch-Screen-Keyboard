using System;
using System.Windows.Forms;
using TouchScreenKeyboard.Class;

namespace TouchScreenKeyboard
{
    public partial class Settings : Form
    {
        public Settings(Form form, SplitContainer splitContainer)
        {
            InitializeComponent();

            this.form = form;
            this.splitContainer = splitContainer;
        }

        IniFile iniFile = new IniFile(Belgeler.isPOSFolderPath + "\\Ayarlar.ini");
        Form form;
        SplitContainer splitContainer;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000; //WS_EX_COMPOSITED
                return handleParam;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            AyarlarıYukle();
        }

        #region AyarlarıYükle
        public void AyarlarıYukle()
        {
            if (iniFile.KeyExists("Şeffaflık", "Ayarlar"))
            {
                string read = iniFile.Read("Şeffaflık", "Ayarlar").ToString();
                double seffaflık = Convert.ToDouble(read.Replace('.', ',')) * 100;
                tbar_seffaflık.Value = Convert.ToInt32(seffaflık);
            }

            if (iniFile.KeyExists("Sürükleme", "Ayarlar"))
            {
                cBox_surukleme.Checked = Convert.ToBoolean(iniFile.Read("Sürükleme", "Ayarlar"));
                Surukleme();
            }

            if (iniFile.KeyExists("Boyutlandırma", "Ayarlar"))
            {
                if (cBox_surukleme.Checked)
                {
                    cBox_boyutlandırma.Checked = Convert.ToBoolean(iniFile.Read("Boyutlandırma", "Ayarlar"));
                    Boyutlandırma();
                }
            }

            if (iniFile.KeyExists("Renk", "Ayarlar"))
            {
                lBox_renkler.SelectedIndex = Convert.ToInt32(iniFile.Read("Renk", "Ayarlar"));
                Renkler();
            }
        }
        #endregion

        #region Şeffaflık
        private void tbar_seffaflık_ValueChanged(object sender, EventArgs e)
        {
            form.Opacity = ((double)(tbar_seffaflık.Value) / 100.0);
            iniFile.Write("Şeffaflık", form.Opacity.ToString().Replace(',', '.'), "Ayarlar");
        }
        #endregion

        #region Sürükleme
        public void Surukleme()
        {
            if (cBox_surukleme.Checked)
            {
                if (cBox_boyutlandırma.Checked)
                {
                    form.FormBorderStyle = FormBorderStyle.Sizable;
                }
                else
                {
                    form.FormBorderStyle = FormBorderStyle.FixedSingle;
                }

                cBox_boyutlandırma.Visible = true;

                splitContainer.Panel1Collapsed = true;
                Helpers.FormPosition(form);
            }
            else
            {
                cBox_boyutlandırma.Visible = false;

                form.FormBorderStyle = FormBorderStyle.None;
                splitContainer.Panel1Collapsed = false;
                Helpers.FormPosition(form);
            }
        }

        private void cBox_surukleme_CheckedChanged(object sender, EventArgs e)
        {
            Surukleme();

            iniFile.Write("Sürükleme", cBox_surukleme.Checked.ToString(), "Ayarlar");
        }
        #endregion

        #region Boyutlandırma
        public void Boyutlandırma()
        {
            if (cBox_boyutlandırma.Checked)
            {
                form.FormBorderStyle = FormBorderStyle.Sizable;
            }
            else
            {
                form.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
        }

        private void cBox_boyutlandırma_CheckedChanged(object sender, EventArgs e)
        {
            Boyutlandırma();

            iniFile.Write("Boyutlandırma", cBox_boyutlandırma.Checked.ToString(), "Ayarlar");
        }
        #endregion

        #region Renkler
        public void Renkler()
        {
            Theme.FormThemeChange(form, lBox_renkler.SelectedIndex);
            Theme.CharacterButtonThemeChange(form, "Character", lBox_renkler.SelectedIndex);
            Theme.CharacterButtonThemeChange(form, "SpecialCharacters", lBox_renkler.SelectedIndex);
            Theme.ControlButtonThemeChange(form, "Control", lBox_renkler.SelectedIndex);
        }

        private void lBox_renkler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Renkler();

            iniFile.Write("Renk", lBox_renkler.SelectedIndex.ToString(), "Ayarlar");
        }
        #endregion

        #region Konumlandırma
        private void btn_konumlandırma_Click(object sender, EventArgs e)
        {
            Helpers.FormPosition(form);
        }
        #endregion

    }
}