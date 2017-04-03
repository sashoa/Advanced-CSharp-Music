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
    public class MusicianEntityService : IMusicianEntityService
    {
        private IRepository<BandEntity> _bandRepository;
        private IRepository<MusicianEntity> _musicianRepository;
        private IRepository<AlbumEntity> _albumRepository;
        private IRepository<SongEntity> _songRepository;

        public MusicianEntityService(IRepository<BandEntity> bandRepository,
                            IRepository<MusicianEntity> musicianRepository,
                            IRepository<AlbumEntity> albumRepository,
                            IRepository<SongEntity> songRepository)
        {
            _bandRepository = bandRepository;
            _musicianRepository = musicianRepository;
            _albumRepository = albumRepository;
            _songRepository = songRepository;
        }

        public MusicianEntity SaveMusician(MusicianEntity musician, int? id = null)
        {
            return _musicianRepository.Save(musician, id);
        }

        public MusicianEntity DeleteMusician(int id)
        {
            return _musicianRepository.Delete(id);
        }

        public MusicianEntity GetMusician(int id)
        {
            return _musicianRepository.Get(id);
        }

        public IEnumerable<MusicianEntity> GetAllMusicians()
        {
            return _musicianRepository.GetAll();
        }
    }
}
