using Music.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.BusinessLogic
{
    class DataFormat
    {
        public List<BandEntity> Bands { get; set; }
        public List<MusicianEntity> Musicians { get; set; }
        public List<AlbumEntity> Albums { get; set; }
        public List<MusicianInBandsEntity> MusicianInBands { get; set; }
        public List<SongEntity> Songs { get; set; }
    }
}
