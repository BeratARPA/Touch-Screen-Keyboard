using System.IO;

namespace TouchScreenKeyboard.Class
{
    public static class DefaultSettings
    {
        static double Seffaflık = 1;
        static bool Surukleme = false;
        static bool Boyutlandırma = false;
        static int Renk = 2;

        static IniFile iniFile = new IniFile(Belgeler.isPOSFolderPath + "\\Ayarlar.ini");

        public static void Write()
        {
            if (!File.Exists(Belgeler.isPOSFolderPath + "\\Ayarlar.ini"))
            {
                iniFile.Write("Şeffaflık", Seffaflık.ToString(), "Ayarlar");
                iniFile.Write("Sürükleme", Surukleme.ToString(), "Ayarlar");
                iniFile.Write("Boyutlandırma", Boyutlandırma.ToString(), "Ayarlar");
                iniFile.Write("Renk", Renk.ToString(), "Ayarlar");
            }
        }
    }
}
