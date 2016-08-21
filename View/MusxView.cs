using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.YouTube.v3.Data;
using MusX_v02.Api;
using MusX_v02.Api.Spotify;
using MusX_v02.Api.YouTube;
using MusX_v02.View.Control;
using SpotifyAPI.Web.Models;

namespace MusX_v02.View
{
    public partial class MusxView : Form
    {
        private readonly YoutubeServiceUtil _ytServiceUtil = YoutubeServiceUtil.GetInstance();
        private readonly SpotifyServiceUtil _spotifyServiceUtil = new SpotifyServiceUtil();
        private const int YouTubeTab = 0;
        private const int SpotifyTab = 1;
        private const int LocalTab = 2;

        private string _searchKey;

        public MusxView()
        {
            InitializeComponent();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            _searchKey = searchTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(_searchKey))
            {
                return;
            }
            // clear old results
            trackListView1.Clear();
            videoListView1.Clear();
            try
            {
                switch (tabControl.SelectedIndex)
                {
                    case YouTubeTab:
                        var ytResults = await _ytServiceUtil.GetResultsAsync(_searchKey);
                        if (!ytResults.Any())
                        {
                            StatusError(@"No results.");
                        }
                        videoListView1.Fill(ytResults);
                        break;
                    case SpotifyTab:
                        var spResults = await _spotifyServiceUtil.GetSongs(_searchKey);
                        trackListView1.Fill(spResults);
                        break;
                }
                StatusReady();
            }
            catch (HttpRequestException)
            {
                StatusError(@"No internet connection.");
            }

        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }

        private async void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTextBox.Select();
            if (string.IsNullOrWhiteSpace(_searchKey))
            {
                return;
            }
            switch (tabControl.SelectedIndex)
            {
                case YouTubeTab:
                    if (!videoListView1.Filled)
                    {
                        var ytResults = await _ytServiceUtil.GetResultsAsync(_searchKey);
                        videoListView1.Fill(ytResults);
                    }
                    break;
                case SpotifyTab:
                    if (!trackListView1.Filled)
                    {
                        var spResults = await _spotifyServiceUtil.GetSongs(_searchKey);
                        trackListView1.Fill(spResults);
                    }
                    break;
            }
        }

        private void StatusError(string msg)
        {
            statusLabel.ForeColor = Color.Red;
            statusLabel.Text = msg;
        }

        private void StatusReady()
        {
            statusLabel.ForeColor = Color.Black;
            statusLabel.Text = @"StatusReady";
        }
    }
}
