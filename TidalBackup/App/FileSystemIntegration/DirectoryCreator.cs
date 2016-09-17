using System;
using System.IO;

namespace TidalBackup.App.FileSystemIntegration
{
    public class DirectoryCreator
    {
        private readonly string _basePath;

        /// <summary>
        /// Uses Environment.CurrentDirectory as base path.
        /// </summary>
        public DirectoryCreator()
        {
            _basePath = Environment.CurrentDirectory;
        }

        public DirectoryCreator(string basePath)
        {
            _basePath = basePath;
        }

        /// <summary>
        /// Creates the directory (under the constructed basePath)
        /// </summary>
        /// <param name="directory"></param>
        public void CreateDirectoryIfNotExists(string directory)
        {
            var path = $"{_basePath}\\{directory}";
            Directory.CreateDirectory(path);
        }
    }
}