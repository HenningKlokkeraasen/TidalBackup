using System;
using System.Threading.Tasks;
using OpenTidl.Methods;
using OpenTidl.Models;
using OpenTidl.Models.Base;

namespace TidalBackup.App.ThingsToBackup
{
    public class FavoriteTracks : ISomethingToBackup<JsonList<JsonListItem<TrackModel>>>
    {
        public string FriendlyName => "Favorite Tracks";
        public string Filename => "favorite-tracks.json";
        public Func<OpenTidlSession, Task<JsonList<JsonListItem<TrackModel>>>> GetIt => session => session.GetFavoriteTracks();
    }
}