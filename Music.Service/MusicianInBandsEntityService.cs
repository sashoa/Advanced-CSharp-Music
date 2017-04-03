using Music.DataAccess;
using Music.Entities;
using Music.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Service
{
    public class MusicianInBandsEntityService : IMusicianInBandsEntityService
    {
        private IRepository<BandEntity> _bandRepository;
        private IRepository<MusicianEntity> _musicianRepository;
        private IRepository<AlbumEntity> _albumRepository;
        private IRepository<SongEntity> _songRepository;
        private IRepository<MusicianInBandsEntity> _musicianInBandsRepository;

        public MusicianInBandsEntityService(IRepository<BandEntity> bandRepository,
                            IRepository<MusicianEntity> musicianRepository,
                            IRepository<AlbumEntity> albumRepository,
                            IRepository<MusicianInBandsEntity> musicianInBandsRepository,
                            IRepository<SongEntity> songRepository)
        {
            _bandRepository = bandRepository;
            _musicianRepository = musicianRepository;
            _albumRepository = albumRepository;
            _songRepository = songRepository;
            _musicianInBandsRepository = musicianInBandsRepository;
        }

        public MusicianInBandsEntity Save(MusicianInBandsEntity musicianInBands, int? id = null)
        {
            return _musicianInBandsRepository.Save(musicianInBands, id);
        }

        public MusicianInBandsEntity Delete(int id)
        {
            return _musicianInBandsRepository.Delete(id);
        }

        public MusicianInBandsEntity Get(int id)
        {
            return _musicianInBandsRepository.Get(id);
        }

        public IEnumerable<MusicianInBandsEntity> GetAll()
        {
            return _musicianInBandsRepository.GetAll();
        }
    }
}
