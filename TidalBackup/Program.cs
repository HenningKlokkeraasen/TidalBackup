using System;
using TidalBackup.App;

namespace TidalBackup
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args == null || args.Length != 2)
            {
                Console.WriteLine("USAGE: tidalbackup.exe [username] [password]");
                Console.ReadLine();
                return;
            }

            var username = args[0];
            var password = args[1];
            
            BackyMcBackupFace.BackupAllTheThings(username, password)
                .Wait();
        }
    }
}
