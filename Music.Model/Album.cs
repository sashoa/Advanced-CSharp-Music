using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Model
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; private set; }
        public int? BandId { get; set; } = null;
        public int? MusicianId { get; set; } = null;

        public Album(string title, DateTime pubdate)
        {
            PublicationDate = pubdate;
            Title = title;
        }
    }
}
