using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp.Models
{
    public class Song
    {
        public string Id { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public int DurationSeconds { get; set; }
        public int PlayCount { get; set; }
        public DateTime LastPlayed { get; set; }
        public string CoverArtUrl { get; set; }
        public string Format { get; set; }
        public int BitrateKbps { get; set; }
    }
}
