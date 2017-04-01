using Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Data
{
    public class SongRepository
    {
        private int Id;
        private List<Song> songs;

        public SongRepository()
        {
            Id = 1;
            songs = new List<Song>();
        }
        public void Save(Song song)
        {
            song.Id = Id++;
            songs.Add(song);
        }
        public Song Get(int? id)
        {
            if (id == null)
                return null;
            return songs.SingleOrDefault(s => s.Id == id);
        }
        public IEnumerable<Song> GetAll()
        {
            return songs;
        }
    }
}
