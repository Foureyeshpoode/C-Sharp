using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp.Models
{
    public class AppData
    {
        public UserData User { get; set; }
        public List<Song> Songs { get; set; }
        public List<Playlist> Playlists { get; set; }
    }

    public class UserData
    {
        public string Username { get; set; }
        public UserPreferences Preferences { get; set; }
    }

}
