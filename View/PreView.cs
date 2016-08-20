using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace MusX_v02.View
{
    public partial class PreView : Form
    {
        private readonly ChromiumWebBrowser _browser;
        public PreView() : this("about:blank")
        {
        }
        public PreView(string url)
        {
            InitializeComponent();
            Cef.Initialize(new CefSettings());
            _browser = new ChromiumWebBrowser(url);
            Controls.Add(_browser);
            _browser.Dock = DockStyle.Fill;
        }

        public void Navigate(string url)
        {
            _browser.Load(url);
        }
    }
}
