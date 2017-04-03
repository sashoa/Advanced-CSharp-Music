using Music.DataAccess;
using Music.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Service.Interfaces;

namespace Music.Service
{
    public class SongEntityService : ISongEntityService
    {
        private IRepository<BandEntity> _bandRepository;
        private IRepository<MusicianEntity> _musicianRepository;
        private IRepository<AlbumEntity> _albumRepository;
        private IRepository<SongEntity> _songRepository;

        public SongEntityService(IRepository<BandEntity> bandRepository,
                            IRepository<MusicianEntity> musicianRepository,
                            IRepository<AlbumEntity> albumRepository,
                            IRepository<SongEntity> songRepository)
        {
            _bandRepository = bandRepository;
            _musicianRepository = musicianRepository;
            _albumRepository = albumRepository;
            _songRepository = songRepository;
        }

        public SongEntity SaveSong(SongEntity song, int? id = null)
        {
            return _songRepository.Save(song, id);
        }

        public SongEntity DeleteSong(int id)
        {
            return _songRepository.Delete(id);
        }

        public SongEntity GetSong(int id)
        {
            return _songRepository.Get(id);
        }

        public IEnumerable<SongEntity> GetAllSongs()
        {
            return _songRepository.GetAll();
        }
    }
}
