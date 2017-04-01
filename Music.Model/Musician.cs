using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Model
{
    public class Musician : IArtist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? BandId { get; set; } = null;
        public Musician(string name)
        {
            Name = name;
        }
    }
}
