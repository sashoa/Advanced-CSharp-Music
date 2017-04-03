using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Entities;
using Music.Service.Interfaces;
using Music.DataAccess;

namespace Music.Service
{
    public class AlbumEntityService : IAlbumEntityService
    {
        private IRepository<BandEntity> _bandRepository;
        private IRepository<MusicianEntity> _musicianRepository;
        private IRepository<AlbumEntity> _albumRepository;
        private IRepository<SongEntity> _songRepository;

        public AlbumEntityService(IRepository<BandEntity> bandRepository,
                            IRepository<MusicianEntity> musicianRepository,
                            IRepository<AlbumEntity> albumRepository,
                            IRepository<SongEntity> songRepository)
        {
            _bandRepository = bandRepository;
            _musicianRepository = musicianRepository;
            _albumRepository = albumRepository;
            _songRepository = songRepository;
        }

        public AlbumEntity DeleteAlbum(int id)
        {
            return _albumRepository.Delete(id);
        }

        public AlbumEntity GetAlbum(int id)
        {
            return _albumRepository.Get(id);
        }

        public IEnumerable<AlbumEntity> GetAllAlbums()
        {
            return _albumRepository.GetAll();
        }

        public AlbumEntity SaveAlbum(AlbumEntity album, int? id = null)
        {
            return _albumRepository.Save(album, id);
        }
    }
}
