using System;

namespace TidalBackup.App
{
    public static class BackupFolderNameProvider
    {
        public static string ConstructNameBasedOnCurrentDirectoryAndDateTimeNow
        {
            get
            {
                var folderName = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
                var directory = $"{Environment.CurrentDirectory}\\Backup\\{folderName}";
                return directory;
            }
        }
    }
}