using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TouchScreenKeyboard.Class
{
    public static class Theme
    {
        #region White-0

        public static string WhiteBackColor = "#ffffff";

        public static string WhiteCharacterButtonBackColor = "#f7f7f7";
        public static string WhiteCharacterButtonForeColor = "#000000";

        public static string WhiteControlButtonBackColor = "#f7f7f7";
        public static string WhiteControlButtonForeColor = "#000000";

        public static string WhiteActiveButtonBackColor = "#000000";
        public static string WhiteActiveButtonForeColor = "#ffffff";

        #endregion

        #region Black-1

        public static string BlackBackColor = "#141414";

        public static string BlackCharacterButtonBackColor = "#3c3c3c";
        public static string BlackCharacterButtonForeColor = "#ffffff";

        public static string BlackControlButtonBackColor = "#3c3c3c";
        public static string BlackControlButtonForeColor = "#ffffff";

        public static string BlackActiveButtonBackColor = "#ffffff";
        public static string BlackActiveButtonForeColor = "#000000";

        #endregion

        #region Dark-2

        public static string DarkBackColor = "#141414";

        public static string DarkCharacterButtonBackColor = "#2e2d2e";
        public static string DarkCharacterButtonForeColor = "#ffffff";

        public static string DarkControlButtonBackColor = "#242424";
        public static string DarkControlButtonForeColor = "#ffffff";

        public static string DarkActiveButtonBackColor = "#695acd";
        public static string DarkActiveButtonForeColor = "#ffffff";

        #endregion

        #region Light-3

        public static string LightBackColor = "#ffffff";

        public static string LightCharacterButtonBackColor = "#f2f2f2";
        public static string LightCharacterButtonForeColor = "#000000";

        public static string LightControlButtonBackColor = "#e6e6e6";
        public static string LightControlButtonForeColor = "#000000";

        public static string LightActiveButtonBackColor = "#000000";
        public static string LightActiveButtonForeColor = "#ffffff";

        #endregion

        #region Silver-4

        public static string SilverBackColor = "#ffffff";

        public static string SilverCharacterButtonBackColor = "#ffffff";
        public static string SilverCharacterButtonForeColor = "#ffffff";

        public static string SilverControlButtonBackColor = "#ffffff";
        public static string SilverControlButtonForeColor = "#ffffff";

        public static string SilverActiveButtonBackColor = "#ffffff";
        public static string SilverActiveButtonForeColor = "#ffffff";

        #endregion

        #region Grey-5

        public static string GreyBackColor = "#a1a1a1";

        public static string GreyCharacterButtonBackColor = "#dedede";
        public static string GreyCharacterButtonForeColor = "#000000";

        public static string GreyControlButtonBackColor = "#bababa";
        public static string GreyControlButtonForeColor = "#000000";

        public static string GreyActiveButtonBackColor = "#000000";
        public static string GreyActiveButtonForeColor = "#ffffff";

        #endregion

        #region Android-6

        public static string AndroidBackColor = "#ffffff";

        public static string AndroidCharacterButtonBackColor = "#ffffff";
        public static string AndroidCharacterButtonForeColor = "#ffffff";

        public static string AndroidControlButtonBackColor = "#ffffff";
        public static string AndroidControlButtonForeColor = "#ffffff";

        public static string AndroidActiveButtonBackColor = "#ffffff";
        public static string AndroidActiveButtonForeColor = "#ffffff";

        #endregion

        #region Mac-7

        public static string MacBackColor = "#ffffff";

        public static string MacCharacterButtonBackColor = "#ffffff";
        public static string MacCharacterButtonForeColor = "#ffffff";

        public static string MacControlButtonBackColor = "#ffffff";
        public static string MacControlButtonForeColor = "#ffffff";

        public static string MacActiveButtonBackColor = "#ffffff";
        public static string MacActiveButtonForeColor = "#ffffff";

        #endregion

        public static void FormThemeChange(Form form, int theme)
        {
            switch (theme)
            {
                case 0:
                    form.BackColor = ColorTranslator.FromHtml(WhiteBackColor);
                    break;
                case 1:
                    form.BackColor = ColorTranslator.FromHtml(BlackBackColor);
                    break;
                case 2:
                    form.BackColor = ColorTranslator.FromHtml(DarkBackColor);
                    break;
                case 3:
                    form.BackColor = ColorTranslator.FromHtml(LightBackColor);
                    break;
                case 4:
                    form.BackColor = ColorTranslator.FromHtml(SilverBackColor);
                    break;
                case 5:
                    form.BackColor = ColorTranslator.FromHtml(GreyBackColor);
                    break;
                case 6:
                    form.BackColor = ColorTranslator.FromHtml(AndroidBackColor);
                    break;
                case 7:
                    form.BackColor = ColorTranslator.FromHtml(MacBackColor);
                    break;
            }
        }

        public static void CharacterButtonThemeChange(Form form, string description, int theme)
        {
            var buttons = Helpers.GetDescriptionAll(form, typeof(Button), description).ToList();

            for (int i = 0; i < buttons.Count; i++)
            {
                switch (theme)
                {
                    case 0:
                        buttons[i].BackColor = ColorTranslator.FromHtml(WhiteCharacterButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(WhiteCharacterButtonForeColor);
                        break;
                    case 1:
                        buttons[i].BackColor = ColorTranslator.FromHtml(BlackCharacterButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(BlackCharacterButtonForeColor);
                        break;
                    case 2:
                        buttons[i].BackColor = ColorTranslator.FromHtml(DarkCharacterButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(DarkCharacterButtonForeColor);
                        break;
                    case 3:
                        buttons[i].BackColor = ColorTranslator.FromHtml(LightCharacterButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(LightCharacterButtonForeColor);
                        break;
                    case 4:
                        buttons[i].BackColor = ColorTranslator.FromHtml(SilverCharacterButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(SilverCharacterButtonForeColor);
                        break;
                    case 5:
                        buttons[i].BackColor = ColorTranslator.FromHtml(GreyCharacterButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(GreyCharacterButtonForeColor);
                        break;
                    case 6:
                        buttons[i].BackColor = ColorTranslator.FromHtml(AndroidCharacterButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(AndroidCharacterButtonForeColor);
                        break;
                    case 7:
                        buttons[i].BackColor = ColorTranslator.FromHtml(MacCharacterButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(MacCharacterButtonForeColor);
                        break;
                }
            }
        }

        public static void ControlButtonThemeChange(Form form, string description, int theme)
        {
            var buttons = Helpers.GetDescriptionAll(form, typeof(Button), description).ToList();

            for (int i = 0; i < buttons.Count; i++)
            {
                switch (theme)
                {
                    case 0:
                        buttons[i].BackColor = ColorTranslator.FromHtml(WhiteControlButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(WhiteControlButtonForeColor);
                        break;
                    case 1:
                        buttons[i].BackColor = ColorTranslator.FromHtml(BlackControlButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(BlackControlButtonForeColor);
                        break;
                    case 2:
                        buttons[i].BackColor = ColorTranslator.FromHtml(DarkControlButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(DarkControlButtonForeColor);
                        break;
                    case 3:
                        buttons[i].BackColor = ColorTranslator.FromHtml(LightControlButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(LightControlButtonForeColor);
                        break;
                    case 4:
                        buttons[i].BackColor = ColorTranslator.FromHtml(SilverControlButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(SilverControlButtonForeColor);
                        break;
                    case 5:
                        buttons[i].BackColor = ColorTranslator.FromHtml(GreyControlButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(GreyControlButtonForeColor);
                        break;
                    case 6:
                        buttons[i].BackColor = ColorTranslator.FromHtml(AndroidControlButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(AndroidControlButtonForeColor);
                        break;
                    case 7:
                        buttons[i].BackColor = ColorTranslator.FromHtml(MacControlButtonBackColor);
                        buttons[i].ForeColor = ColorTranslator.FromHtml(MacControlButtonForeColor);
                        break;
                }
            }
        }

        public static void ActiveButtonThemeChange(int theme, Button button)
        {
            switch (theme)
            {
                case 0:
                    button.BackColor = ColorTranslator.FromHtml(WhiteActiveButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(WhiteActiveButtonForeColor);
                    break;
                case 1:
                    button.BackColor = ColorTranslator.FromHtml(BlackActiveButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(BlackActiveButtonForeColor);
                    break;
                case 2:
                    button.BackColor = ColorTranslator.FromHtml(DarkActiveButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(DarkActiveButtonForeColor);
                    break;
                case 3:
                    button.BackColor = ColorTranslator.FromHtml(LightActiveButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(LightActiveButtonForeColor);
                    break;
                case 4:
                    button.BackColor = ColorTranslator.FromHtml(SilverActiveButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(SilverActiveButtonForeColor);
                    break;
                case 5:
                    button.BackColor = ColorTranslator.FromHtml(GreyActiveButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(GreyActiveButtonForeColor);
                    break;
                case 6:
                    button.BackColor = ColorTranslator.FromHtml(AndroidActiveButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(AndroidActiveButtonForeColor);
                    break;
                case 7:
                    button.BackColor = ColorTranslator.FromHtml(MacActiveButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(MacActiveButtonForeColor);
                    break;
            }
        }

        public static void PassiveButtonThemeChange(int theme, Button button)
        {
            switch (theme)
            {
                case 0:
                    button.BackColor = ColorTranslator.FromHtml(WhiteControlButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(WhiteControlButtonForeColor);
                    break;
                case 1:
                    button.BackColor = ColorTranslator.FromHtml(BlackControlButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(BlackControlButtonForeColor);
                    break;
                case 2:
                    button.BackColor = ColorTranslator.FromHtml(DarkControlButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(DarkControlButtonForeColor);
                    break;
                case 3:
                    button.BackColor = ColorTranslator.FromHtml(LightControlButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(LightControlButtonForeColor);
                    break;
                case 4:
                    button.BackColor = ColorTranslator.FromHtml(SilverControlButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(SilverControlButtonForeColor);
                    break;
                case 5:
                    button.BackColor = ColorTranslator.FromHtml(GreyControlButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(GreyControlButtonForeColor);
                    break;
                case 6:
                    button.BackColor = ColorTranslator.FromHtml(AndroidControlButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(AndroidControlButtonForeColor);
                    break;
                case 7:
                    button.BackColor = ColorTranslator.FromHtml(MacControlButtonBackColor);
                    button.ForeColor = ColorTranslator.FromHtml(MacControlButtonForeColor);
                    break;
            }
        }
    }
}
