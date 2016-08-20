using System.Collections.Generic;
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
            //Create the auth object
            var auth = new ClientCredentialsAuth()
            {
                //Your client Id
                ClientId = "2caffe56f6cc4c5999afcac6c1e5b682",
                //Your client secret UNSECURE!!
                ClientSecret = "373104a7358c40f5a9297316c0f422b5",
                //How many permissions we need?
                Scope = Scope.UserReadPrivate
            };
            //With this token object, we now can make calls
            var token = auth.DoAuth();
            _spotify = new SpotifyWebAPI()
            {
                TokenType = token.TokenType,
                AccessToken = token.AccessToken,
                UseAuth = false
            };
        }

        public IEnumerable<FullTrack> GetSongs(string key)
        {
            var items = _spotify.SearchItems(key.Replace(" ", "+"), SearchType.Track).Tracks;
            return items.Items;
        }
    }
}