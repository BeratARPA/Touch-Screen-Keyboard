using System.IO;

namespace TouchScreenKeyboard.Class
{
    public static class DefaultSettings
    {
        static double Seffaflık = 1;
        static bool Surukleme = false;
        static bool Boyutlandırma = false;
        static int Renk = 2;

        static IniFile iniFile = new IniFile(FolderLocations.barcodePOSFolderPath + "\\KeyboardSettings.ini");

        public static void Write()
        {
            if (!File.Exists(FolderLocations.barcodePOSFolderPath + "\\KeyboardSettings.ini"))
            {
                iniFile.Write("Transparency", Seffaflık.ToString(), "Settings");
                iniFile.Write("Drag", Surukleme.ToString(), "Settings");
                iniFile.Write("Sizing", Boyutlandırma.ToString(), "Settings");
                iniFile.Write("Theme", Renk.ToString(), "Settings");
            }
        }
    }
}
