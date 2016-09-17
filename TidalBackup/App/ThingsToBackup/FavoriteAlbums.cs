using System;
using System.Threading.Tasks;
using OpenTidl.Methods;
using OpenTidl.Models;
using OpenTidl.Models.Base;

namespace TidalBackup.App.ThingsToBackup
{
    public class FavoriteAlbums : ISomethingToBackup<JsonList<JsonListItem<AlbumModel>>>
    {
        public string FriendlyName => "Favorite Albums";
        public string Filename => "favorite-albums.json";
        public Func<OpenTidlSession, Task<JsonList<JsonListItem<AlbumModel>>>> Func => session => session.GetFavoriteAlbums();
    }
}
