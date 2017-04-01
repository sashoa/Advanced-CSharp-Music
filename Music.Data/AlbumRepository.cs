using Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Data
{
    public class AlbumRepository
    {
        private int Id;
        private List<Album> albums;

        public AlbumRepository()
        {
            Id = 1;
            albums = new List<Album>();
        }
        public void Save(Album album)
        {
            album.Id = Id++;
            albums.Add(album);
        }
        public Album Get(int? id)
        {
            if (id == null)
                return null;
            return albums.SingleOrDefault(a => a.Id == id);
        }
        public IEnumerable<Album> GetAll()
        {
            return albums;
        }
    }
}
