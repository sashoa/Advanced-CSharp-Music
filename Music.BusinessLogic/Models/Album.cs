using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.BusinessLogic.Models
{
    public class Album
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
        public List<Song> Songs { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Title { get; set; }
        public IArtist artist { get; set; }

        public Album()
        {
            Id = NextId;
            Songs = new List<Song>();
        }
    }
}
