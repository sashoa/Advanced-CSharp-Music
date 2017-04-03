using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Entities
{
    public class AlbumEntity : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; private set; }
        public int? BandId { get; set; } = null;
        public int? MusicianId { get; set; } = null;

        public AlbumEntity(string title, DateTime pubDate, int? bandId, int? musicianId)
        {
            Title = title;
            PublicationDate = pubDate;
            BandId = bandId;
            MusicianId = musicianId;
        }
    }
}
