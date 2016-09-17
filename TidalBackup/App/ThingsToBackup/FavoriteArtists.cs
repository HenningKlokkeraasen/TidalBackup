using System;
using System.Threading.Tasks;
using OpenTidl.Methods;
using OpenTidl.Models;
using OpenTidl.Models.Base;

namespace TidalBackup.App.ThingsToBackup
{
    public class FavoriteArtists : ISomethingToBackup<JsonList<JsonListItem<ArtistModel>>>
    {
        public string FriendlyName => "Favorite Artists";
        public string Filename => "favorite-artists.json";
        public Func<OpenTidlSession, Task<JsonList<JsonListItem<ArtistModel>>>> Func => session => session.GetFavoriteArtists();
    }
}