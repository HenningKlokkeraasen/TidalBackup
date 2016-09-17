using System.IO;

namespace TidalBackup.App.FileSystemIntegration
{
    public static class SimpleStringWriter
    {
        public static void WriteStringToFile(string content, string directory, string fileName)
        {
            Directory.CreateDirectory(directory);
            File.WriteAllText($"{directory}\\{fileName}", content);
        }
    }
}
