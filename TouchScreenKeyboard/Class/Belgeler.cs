using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace TouchScreenKeyboard.Class
{
    public static class Belgeler
    {
        public static string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string iscFolderPath = Path.Combine(documentsPath, "ISC");
        public static string isPOSFolderPath = Path.Combine(iscFolderPath, "IsPOS");
        public static string databaseBackupsFolderPath = Path.Combine(isPOSFolderPath, "Database Backups");

        public static void KlasorleriOlustur()
        {
            if (!Directory.Exists(iscFolderPath))
            {
                Directory.CreateDirectory(iscFolderPath);
                GrantAccess(iscFolderPath);
            }

            if (!Directory.Exists(isPOSFolderPath))
            {
                Directory.CreateDirectory(isPOSFolderPath);
                GrantAccess(isPOSFolderPath);
            }

            if (!Directory.Exists(databaseBackupsFolderPath))
            {
                Directory.CreateDirectory(databaseBackupsFolderPath);
                GrantAccess(databaseBackupsFolderPath);
            }
        }

        private static void GrantAccess(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();
            directorySecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            directoryInfo.SetAccessControl(directorySecurity);

        }
    }
}
