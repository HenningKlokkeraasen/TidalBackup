using System;
using OpenTidl.Methods;
using TidalBackup.App.FileSystemIntegration;
using TidalBackup.App.ThingsToBackup;
using TidalBackup.App.TidalIntegration;

namespace TidalBackup.App
{
    public class BackyMcBackupFace
    {
        public void BackupAllTheThings(string username, string password)
        {
            var tidalIntegrator = new TidalIntegrator();
            OpenTidlSession session;
            try
            {
                session = tidalIntegrator.LoginUserAsync(username, password).Result;
            }
            catch (Exception)
            {
                Console.WriteLine("Could not log in :(");
                return;
            }

            var simpleStringWriter = new SimpleStringWriter(new FileSystemIntegrator());
            var folderName = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            var backupExecutor = new BackupExecutor(session, simpleStringWriter, folderName);

            backupExecutor.Backup(new FavoriteArtists());
            backupExecutor.Backup(new FavoriteTracks());
            backupExecutor.Backup(new FavoriteAlbums());
            backupExecutor.Backup(new FavoritePlaylists());
            backupExecutor.Backup(new UserPlaylists());
        }
    }
}
