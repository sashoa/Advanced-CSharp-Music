using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.BusinessLogic.Models
{
    public class Band : IArtist
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
        public string Name { get; set; }
        public List<Album> Albums { get; }
        public List<Musician> Musicians { get; }

        public Band()
        {
            Id = NextId;
            Albums = new List<Album>();
            Musicians = new List<Musician>();
        }

        public void PublishAlbum(Album album)
        {
            Albums.Add(album);
        }
    }
}
