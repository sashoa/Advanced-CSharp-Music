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
    public class BandEntityService : IBandEntityService
    {
        private IRepository<BandEntity> _bandRepository;
        private IRepository<MusicianEntity> _musicianRepository;
        private IRepository<AlbumEntity> _albumRepository;
        private IRepository<SongEntity> _songRepository;

        public BandEntityService(IRepository<BandEntity> bandRepository,
                            IRepository<MusicianEntity> musicianRepository,
                            IRepository<AlbumEntity> albumRepository,
                            IRepository<SongEntity> songRepository)
        {
            _bandRepository = bandRepository;
            _musicianRepository = musicianRepository;
            _albumRepository = albumRepository;
            _songRepository = songRepository;
        }

        public BandEntity SaveBand(BandEntity band, int? id = null)
        {
            return _bandRepository.Save(band, id);
        }

        public BandEntity DeleteBand(int id)
        {
            return _bandRepository.Delete(id);
        }

        public BandEntity GetBand(int id)
        {
            return _bandRepository.Get(id);
        }

        public IEnumerable<BandEntity> GetAllBands()
        {
            return _bandRepository.GetAll();
        }
    }
}
