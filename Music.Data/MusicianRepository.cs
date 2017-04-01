using Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Data
{
    public class MusicianRepository
    {
        private int Id;
        private List<Musician> musicians;

        public MusicianRepository()
        {
            Id = 1;
            musicians = new List<Musician>();
        }
        public void Save(Musician musician)
        {
            musician.Id = Id++;
            musicians.Add(musician);
        }
        public Musician Get(int? id)
        {
            if (id == null)
                return null;
            return musicians.SingleOrDefault(m => m.Id == id);
        }
        public IEnumerable<Musician> GetAll()
        {
            return musicians;
        }
    }
}
