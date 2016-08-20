using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.YouTube.v3.Data;
using MusX_v02.Api;
using MusX_v02.Api.Spotify;
using MusX_v02.Api.YouTube;
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
        private const int SongColumn = 0;
        private const int ArtistColumn = 1;
        private const int AlbumColumn = 2;

        private static readonly Color DarkGrey = Color.FromArgb(64, 64, 64);

        private List<Video> _ytResults;
        private List<FullTrack> _spotifyResults;

        public MusxView()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchKey = searchTextBox.Text;
            if (string.IsNullOrWhiteSpace(searchKey))
            {
                return;
            }
            switch (tabControl.SelectedIndex)
            {
                case YouTubeTab:
                    _ytResults = _ytServiceUtil.GetDetailedResults(searchKey).ToList();

                    youtubeListBox.Items.Clear();
                    // ReSharper disable once CoVariantArrayConversion
                    youtubeListBox.Items.AddRange(_ytResults.Select(ServiceUtil.ToVideoString).ToArray());
                    break;
                case SpotifyTab:
                    _spotifyResults = _spotifyServiceUtil.GetSongs(searchKey).ToList();

                    var bind = from track in _spotifyResults
                               select new TrackData()
                               {
                                   Song = track.Name,
                                   Artist = track.GetArtistsString(),
                                   Album = track.Album.Name,
                                   Duration = track.GetDurationString(),
                                   Id = track.Id
                               };
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = new BindingSource() { DataSource = bind };
                    break;
            }
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            var index = listBox.SelectedIndex;
            string title = null;
            string url = null;
            switch (tabControl.SelectedIndex)
            {
                case YouTubeTab:
                    var video = _ytResults[index];
                    title = video.Snippet.Title;
                    url = $"http://www.youtube.com/embed/{video.Id}?autoplay=1";
                    url = $"http://www.youtube.com/v/{video.Id}";
                    url = $"http://www.youtube.com/watch?v={video.Id}";
                    break;
                case SpotifyTab:
                    // todo error handling
                    var track = _spotifyResults[index];
                    title = track.ToTrackString();
                    url = $"https://embed.spotify.com/?uri=spotify:track:{track.Id}";
                    break;
            }
            var browser = new PreView(url) { Text = title };
            browser.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                // header clicked
                return;
            }
            var track = dataGridView1.Rows[e.RowIndex].DataBoundItem as TrackData;
            switch (e.ColumnIndex)
            {
                case SongColumn:
                    Debug.WriteLine(track.Song);
                    break;
                case ArtistColumn:
                    Debug.WriteLine(track.Artist);
                    break;
                case AlbumColumn:
                    Debug.WriteLine(track.Album);
                    break;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dataGridView1.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = DarkGrey;
                row.DefaultCellStyle.SelectionBackColor = DarkGrey;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var row = dataGridView1.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
                row.DefaultCellStyle.SelectionBackColor = SystemColors.ControlDarkDark;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
