using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Model
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int AlbumId { get; set; }
        public Song(string title, int duration, int albumId)
        {
            Title = title;
            Duration = Duration;
            AlbumId = albumId;
        }
    }
}
