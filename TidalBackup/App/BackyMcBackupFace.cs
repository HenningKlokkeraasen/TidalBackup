using System;
using System.Threading.Tasks;
using OpenTidl.Methods;
using TidalBackup.App.FileSystemIntegration;
using TidalBackup.App.ThingsToBackup;
using TidalBackup.App.TidalIntegration;

namespace TidalBackup.App
{
    public class BackyMcBackupFace
    {
        public async Task BackupAllTheThings(string username, string password)
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

            var simpleStringWriter = new SimpleStringWriter(new DirectoryCreator());
            var folderName = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            var backupExecutor = new BackupExecutor(session, simpleStringWriter, folderName);

            await backupExecutor.Backup(new FavoriteArtists());
            await backupExecutor.Backup(new FavoriteTracks());
            await backupExecutor.Backup(new FavoriteAlbums());
            await backupExecutor.Backup(new FavoritePlaylists());
            await backupExecutor.Backup(new UserPlaylists());
        }
    }
}
