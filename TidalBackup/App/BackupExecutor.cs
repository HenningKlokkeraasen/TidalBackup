using System;
using Newtonsoft.Json;
using OpenTidl.Methods;
using TidalBackup.App.FileSystemIntegration;
using TidalBackup.App.ThingsToBackup;

namespace TidalBackup.App
{
    public class BackupExecutor
    {
        private readonly OpenTidlSession _session;
        private readonly SimpleStringWriter _simpleStringWriter;
        private readonly string _folderName;

        public BackupExecutor(OpenTidlSession session, SimpleStringWriter simpleStringWriter, string folderName)
        {
            _session = session;
            _simpleStringWriter = simpleStringWriter;
            _folderName = folderName;
        }

        public void Backup<T>(ISomethingToBackup<T> somethingToBackup)
        {
            var jsonList = somethingToBackup.Func.Invoke(_session);
            WriteToFile(jsonList, _simpleStringWriter, _folderName, somethingToBackup.Filename);
            Console.WriteLine($"Backed up {somethingToBackup.FriendlyName}");
        }
        
        protected static void WriteToFile(object obj, SimpleStringWriter simpleStringWriter, string folderName, string fileName)
        {
            var serializedObject = JsonConvert.SerializeObject(obj);
            simpleStringWriter.WriteStringToFile(serializedObject, folderName, fileName);
        }
    }
}
