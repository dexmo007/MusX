using System.Collections.Generic;
using System.Linq;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace MusX_v02.Api.YouTube
{
    public class YoutubeServiceUtil
    {
        private static YoutubeServiceUtil _instance;
        private readonly YouTubeService _youtubeService;

        private YoutubeServiceUtil()
        {
            _youtubeService = new YouTubeService(new BaseClientService.Initializer
            {
                ApiKey = "AIzaSyBjXLMbZ70xUiIuFUJ56GGh6K9k4h8IQNU",
                ApplicationName = GetType().ToString()
            });
        }

        public static YoutubeServiceUtil GetInstance()
        {
            return _instance ?? (_instance = new YoutubeServiceUtil());
        }

        public IEnumerable<SearchResultSnippet> GetResults(string key)
        {
            var searchListRequest = _youtubeService.Search.List("snippet");
            searchListRequest.Type = "video";
            searchListRequest.Q = key; // Replace with your search term.
            searchListRequest.MaxResults = 25;

            // Call the search.list method to retrieve results matching the specified query term.
            //            var searchListResponse = await searchListRequest.ExecuteAsync();//from sample
            var searchListResponse = searchListRequest.Execute();
            // Add each result to the appropriate list, and then display the lists of

            return from searchResult in searchListResponse.Items select searchResult.Snippet;
        }

        public IEnumerable<Video> GetDetailedResults(string key)
        {
            var searchListRequest = _youtubeService.Search.List("snippet");
            searchListRequest.Type = "video";
            searchListRequest.Q = key;
            searchListRequest.MaxResults = 25;
            var searchListResponse = searchListRequest.Execute();
            var ids = from searchResult in searchListResponse.Items select searchResult.Id.VideoId;

            var idString = string.Join(",", ids);

            var videoListRequest = _youtubeService.Videos.List("snippet,contentDetails");
            videoListRequest.Id = idString;
            var response = videoListRequest.Execute();

            return response.Items;
        }
    }
}