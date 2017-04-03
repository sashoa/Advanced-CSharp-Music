using Music.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Service.Interfaces
{
    public interface IBandEntityService
    {
        BandEntity SaveBand(BandEntity band, int? id);
        BandEntity DeleteBand(int id);
        BandEntity GetBand(int id);
        IEnumerable<BandEntity> GetAllBands();
    }
}
