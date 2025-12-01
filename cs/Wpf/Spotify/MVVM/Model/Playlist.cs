using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Spotify.MVVM.Model
{
    public class Playlist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }
        public List<Track> Tracks { get; set; } = new List<Track>();
    }
}
