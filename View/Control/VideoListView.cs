using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.YouTube.v3.Data;
using MusX_v02.Api;

namespace MusX_v02.View.Control
{
    public partial class VideoListView : UserControl, IResultListView<Video>
    {

        public VideoListView()
        {
            InitializeComponent();
        }

        private void youtubeListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = youtubeListBox.SelectedIndex;
            string title = null;
            string url = null;
//            var video = _ytResults[index];
//            title = video.Snippet.Title;
//            url = $"http://www.youtube.com/embed/{video.Id}?autoplay=1";
//            url = $"http://www.youtube.com/v/{video.Id}";
//            url = $"http://www.youtube.com/watch?v={video.Id}";
            //            var browser = new PreView(url) { Text = title };
            //            browser.Show();
        }

        public bool Filled { get; private set; }

        public void Fill(IEnumerable<Video> items)
        {
            // ReSharper disable once CoVariantArrayConversion
            youtubeListBox.Items.AddRange(items.Select(ServiceUtil.ToVideoString).ToArray());
            Filled = true;
        }

        public void Clear()
        {
            youtubeListBox.Items.Clear();
            Filled = false;
        }
    }
}
