using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Entities
{
    public interface IMusicianInBandsEntity
    {
        int Id { get; set; }
        int MusicianId { get; set; }
        int BandId { get; set; }
    }
}
