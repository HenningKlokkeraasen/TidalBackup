using System;
using System.Threading.Tasks;
using OpenTidl.Methods;

namespace TidalBackup.App.ThingsToBackup
{
    public interface ISomethingToBackup<T>
    {
        string FriendlyName { get; }
        string Filename { get; }
        Func<OpenTidlSession, Task<T>> GetIt { get; }
    }
}