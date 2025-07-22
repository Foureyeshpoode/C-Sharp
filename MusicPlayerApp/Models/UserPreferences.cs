using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp.Models
{
    public class UserPreferences
    {
        public string Theme { get; set; }
        public bool Shuffle { get; set; }
        public string RepeatMode { get; set; }
    }

}
