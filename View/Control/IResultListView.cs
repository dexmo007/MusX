using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using SpotifyAPI.Web.Models;

namespace MusX_v02.View.Control
{
    public interface IResultListView<in TItem>
    {
        bool Filled { get; }

        void Fill(IEnumerable<TItem> items);

        void Clear();

    }
}
