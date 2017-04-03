using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Entities
{
    public class SongEntity : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int AlbumId { get; set; }

        public SongEntity(string title, int duration, int albumId)
        {
            Title = title;
            Duration = duration;
            AlbumId = albumId;
        }
    }
}
