using Music.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Service.Interfaces
{
    public interface IMusicianInBandsEntityService
    {
        MusicianInBandsEntity Save(MusicianInBandsEntity band, int? id);
        MusicianInBandsEntity Delete(int id);
        MusicianInBandsEntity Get(int id);
        IEnumerable<MusicianInBandsEntity> GetAll();
    }
}
