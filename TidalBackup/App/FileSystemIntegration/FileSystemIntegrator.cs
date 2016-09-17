using System;
using System.IO;

namespace TidalBackup.App.FileSystemIntegration
{
    public class FileSystemIntegrator
    {
        private readonly string _basePath;

        /// <summary>
        /// Uses Environment.CurrentDirectory as base path.
        /// </summary>
        public FileSystemIntegrator()
        {
            _basePath = Environment.CurrentDirectory;
        }

        public FileSystemIntegrator(string basePath)
        {
            _basePath = basePath;
        }

        public void CreateFolderIfNotExists(string folderName)
        {
            var dir = $"{_basePath}\\{folderName}";
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}