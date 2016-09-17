using System.IO;

namespace TidalBackup.App.FileSystemIntegration
{
    public class SimpleStringWriter
    {
        private readonly string _baseFolder;
        private readonly FileSystemIntegrator _fileSystemIntegrator;

        /// <summary>
        /// Writes a string object to a file on disk.
        /// </summary>
        /// <param name="fileSystemIntegrator"></param>
        /// <param name="baseFolder">Folder/directory (relative to basePath of fileSystemIntegrator)</param>
        public SimpleStringWriter(FileSystemIntegrator fileSystemIntegrator, string baseFolder = "Backup")
        {
            _fileSystemIntegrator = fileSystemIntegrator;
            _baseFolder = baseFolder;
        }

        public void WriteStringToFile(string content, string folderName, string fileName)
        {
            _fileSystemIntegrator.CreateFolderIfNotExists(_baseFolder);
            var folder = $"{_baseFolder}\\{folderName}";
            _fileSystemIntegrator.CreateFolderIfNotExists(folder);
            File.WriteAllText($"{folder}\\{fileName}", content);
        }
    }
}
