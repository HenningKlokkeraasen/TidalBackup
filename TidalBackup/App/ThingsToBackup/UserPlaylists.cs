using System;
using System.Threading.Tasks;
using OpenTidl.Methods;
using OpenTidl.Models;
using OpenTidl.Models.Base;

namespace TidalBackup.App.ThingsToBackup
{
    public class UserPlaylists : ISomethingToBackup<JsonList<PlaylistModel>>
    {
        public string FriendlyName => "Playlists";
        public string Filename => "playlists.json";
        public Func<OpenTidlSession, Task<JsonList<PlaylistModel>>> Func => session => session.GetUserPlaylists();
    }
}
