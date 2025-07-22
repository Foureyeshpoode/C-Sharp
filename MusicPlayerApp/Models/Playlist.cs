using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp.Models
{
    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> Songs { get; set; } // list of Song IDs
    }

}
