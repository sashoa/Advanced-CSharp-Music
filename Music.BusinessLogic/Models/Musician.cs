using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.BusinessLogic.Models
{
    public class Musician : IArtist
    {
        private static int _id = 0;
        public static int NextId
        {
            get
            {
                return _id++;
            }
            set
            {
                _id = value;
            }
        }
        public int Id { get; set; }
        public List<Album> Albums { get; }
        public List<Band> Bands { get; }

        public string Name { get; set; }

        public Musician()
        {
            Id = NextId;
            Bands = new List<Band>();
            Albums = new List<Album>();
        }

        public void PublishAlbum(Album album)
        {
            Albums.Add(album);
        }
    }
}
