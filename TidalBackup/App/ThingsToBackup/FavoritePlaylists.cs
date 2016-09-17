using System;
using System.Threading.Tasks;
using OpenTidl.Methods;
using OpenTidl.Models;
using OpenTidl.Models.Base;

namespace TidalBackup.App.ThingsToBackup
{
    public class FavoritePlaylists : ISomethingToBackup<JsonList<JsonListItem<PlaylistModel>>>
    {
        public string FriendlyName => "Favorite Playlists";
        public string Filename => "favorite-playlists.json";
        public Func<OpenTidlSession, Task<JsonList<JsonListItem<PlaylistModel>>>> Func => session => session.GetFavoritePlaylists();
    }
}
