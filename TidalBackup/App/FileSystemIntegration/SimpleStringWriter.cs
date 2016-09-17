using System.IO;

namespace TidalBackup.App.FileSystemIntegration
{
    public class SimpleStringWriter
    {
        private readonly string _baseFolder;
        private readonly DirectoryCreator _directoryCreator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directoryCreator"></param>
        /// <param name="baseFolder">Folder/directory (relative to basePath of DirectoryCreator)</param>
        public SimpleStringWriter(DirectoryCreator directoryCreator, string baseFolder = "Backup")
        {
            _directoryCreator = directoryCreator;
            _baseFolder = baseFolder;
        }

        /// <summary>
        /// Writes a string object to a file on disk.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="folderName"></param>
        /// <param name="fileName"></param>
        public void WriteStringToFile(string content, string folderName, string fileName)
        {
            _directoryCreator.CreateDirectoryIfNotExists(_baseFolder);
            var folder = $"{_baseFolder}\\{folderName}";
            _directoryCreator.CreateDirectoryIfNotExists(folder);
            File.WriteAllText($"{folder}\\{fileName}", content);
        }
    }
}
