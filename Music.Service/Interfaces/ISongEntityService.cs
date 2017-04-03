using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Entities;

namespace Music.Service.Interfaces
{
    public interface ISongEntityService
    {
        SongEntity SaveSong(SongEntity song, int? id);
        SongEntity DeleteSong(int id);
        SongEntity GetSong(int id);
        IEnumerable<SongEntity> GetAllSongs();
    }
}
