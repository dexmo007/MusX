using System;
using System.Linq;
using System.Xml;
using Google.Apis.YouTube.v3.Data;
using SpotifyAPI.Web.Models;

namespace MusX_v02.Api
{
    public static class ServiceUtil
    {
        public static string ToVideoString(this Video video)
        {
            return $"{video.Snippet.Title} ({video.Snippet.ChannelTitle}) - {video.ContentDetails.Duration.ToDurationString()}";
        }

        public static string ToDurationString(this string isoDuration)
        {
            // convert iso 8601 string of kind "PT#H#M#S"
            var timeSpan = XmlConvert.ToTimeSpan(isoDuration);
            var duration = timeSpan.Minutes.ToString("D2") + ":" + timeSpan.Seconds.ToString("D2");
            if (timeSpan.Hours > 0)
            {
                duration = timeSpan.Hours.ToString("D2") + ":" + duration;
            }
            return duration;
        }

        public static string ToTrackString(this FullTrack track)
        {
            return $"{track.GetArtistsString()} - {track.Name}";
        }

        public static string GetArtistsString(this FullTrack track)
        {
            return string.Join(", ", track.Artists.Select(a => a.Name));
        }

        public static string GetDurationString(this FullTrack track)
        {
            var ts = TimeSpan.FromMilliseconds(track.DurationMs);
            return ts.ToString(@"mm\:ss");
        }
    }
}