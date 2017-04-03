using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.BusinessLogic.Models
{
    public class Song
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
        public string Title { get; set; }
        public int Duration { get; }
        public Album Album { get; set; }

        public Song()
        {
            Id = NextId;
        }
    }
}
