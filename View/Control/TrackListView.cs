using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusX_v02.Api;
using MusX_v02.Api.Spotify;
using SpotifyAPI.Web.Models;

namespace MusX_v02.View.Control
{
    public partial class TrackListView : UserControl, IResultListView<FullTrack>
    {
        private const int SongColumn = 0;
        private const int ArtistColumn = 1;
        private const int AlbumColumn = 2;
        private static readonly Color DarkGrey = Color.FromArgb(64, 64, 64);

        public bool Filled { get; private set; }

        public TrackListView()
        {
            InitializeComponent();
        }

        public void Fill(IEnumerable<FullTrack> tracks)
        {
            if (tracks == null)
            {
                Clear();
                return;
            }
            var bind = from track in tracks
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
            Filled = true;
        }

        public void Clear()
        {
            dataGridView1.DataSource = null;
            Filled = false;
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
