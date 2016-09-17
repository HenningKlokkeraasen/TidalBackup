using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenTidl.Methods;
using TidalBackup.App.FileSystemIntegration;
using TidalBackup.App.ThingsToBackup;

namespace TidalBackup.App
{
    public class BackupExecutor
    {
        private readonly OpenTidlSession _session;
        private readonly string _folderName;

        public BackupExecutor(OpenTidlSession session, string folderName)
        {
            _session = session;
            _folderName = folderName;
        }

        public async Task Backup<T>(ISomethingToBackup<T> somethingToBackup)
        {
            var jsonList = await somethingToBackup.GetIt.Invoke(_session);
            var serializedObject = JsonConvert.SerializeObject(jsonList);
            SimpleStringWriter.WriteStringToFile(serializedObject, _folderName, somethingToBackup.Filename);
            Console.WriteLine($"Backed up {somethingToBackup.FriendlyName}");
        }
    }
}