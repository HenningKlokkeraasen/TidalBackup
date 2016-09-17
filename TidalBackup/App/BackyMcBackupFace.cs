using System;
using System.Threading.Tasks;
using TidalBackup.App.ThingsToBackup;
using TidalBackup.App.TidalIntegration;

namespace TidalBackup.App
{
    public static class BackyMcBackupFace
    {
        public static async Task BackupAllTheThings(string username, string password)
        {
            var session = await TidalIntegrator.LoginUserAsync(username, password);
            if (session == null)
            {
                Console.WriteLine("Could not log in :(");
                return;
            }

            var folderName = BackupFolderNameProvider.ConstructNameBasedOnCurrentDirectoryAndDateTimeNow;
            var backupExecutor = new BackupExecutor(session, folderName);

            await backupExecutor.Backup(new FavoriteArtists());
            await backupExecutor.Backup(new FavoriteTracks());
            await backupExecutor.Backup(new FavoriteAlbums());
            await backupExecutor.Backup(new FavoritePlaylists());
            await backupExecutor.Backup(new UserPlaylists());
        }
    }
}