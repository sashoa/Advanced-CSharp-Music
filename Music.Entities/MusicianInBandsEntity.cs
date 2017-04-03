using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Entities
{
    public class MusicianInBandsEntity : IMusicianInBandsEntity, IEntity
    {
        public int Id { get; set; }
        public int MusicianId { get; set; }
        public int BandId { get; set; }
    }
}
