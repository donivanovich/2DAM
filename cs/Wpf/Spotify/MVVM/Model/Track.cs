using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Spotify.MVVM.Model
{
    public class Track
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Artist> Artists { get; set; } = new List<Artist>();
        public string Duration { get; set; }
        public string AudioUrl { get; set; }
        //Almacenar la caratula de la cancion como una imagen
        public BitmapImage Cover { get; set; }
        public string AlbumId { get; set; }
    }
}
