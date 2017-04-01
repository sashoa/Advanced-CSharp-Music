using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Model;
using Music.Data;

namespace Music.Service.Interfaces
{
    public interface IBandService
    {
        void Save(Band band);
        Band GetById(int id);
        IEnumerable<Band> GetAll();
        IEnumerable<Musician> GetMusicians(Band band);
        IEnumerable<Album> GetAlbums(Band band);
        
    }
}
