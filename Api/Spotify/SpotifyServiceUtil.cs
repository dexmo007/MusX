using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

namespace MusX_v02.Api.Spotify
{
    public class SpotifyServiceUtil
    {
        private readonly SpotifyWebAPI _spotify;

        public SpotifyServiceUtil()
        {
            _spotify = new SpotifyWebAPI()
            {
                UseAuth = false
            };
        }

        public async Task<IEnumerable<FullTrack>> GetSongs(string key)
        {
            try
            {
                var results = await _spotify.SearchItemsAsync(key.Replace(" ", "+"), SearchType.Track);
                return results?.Tracks?.Items;
            }
            catch (Exception)
            {
                throw new HttpRequestException();
            }
        }
    }
}