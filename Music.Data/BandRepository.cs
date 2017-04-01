using Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Data
{
    public class BandRepository
    {
        private int Id;
        private List<Band> bands;

        public BandRepository()
        {
            Id = 1;
            bands = new List<Band>();
        }
        public void Save(Band band)
        {
            band.Id = Id++;
            bands.Add(band);
        }
        public Band Get(int? id)
        {
            if (id == null)
                return null;
            return bands.SingleOrDefault(b => b.Id == id);
        }
        public IEnumerable<Band> GetAll()
        {
            return bands;
        }
    }
}
