using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Music.Service.Interfaces;
using Music.Entities;
using Music.DataAccess;
using System.Diagnostics;

namespace Music.Service
{
    public class JsonEntityService : IJsonEntityService
    {
        private IRepository<BandEntity> _bandRepository;
        private IRepository<MusicianEntity> _musicianRepository;
        private IRepository<AlbumEntity> _albumRepository;
        private IRepository<SongEntity> _songRepository;
        private IRepository<MusicianInBandsEntity> _musicianInBandsRepository;

        public JsonEntityService(IRepository<BandEntity> bandRepository,
                            IRepository<MusicianEntity> musicianRepository,
                            IRepository<AlbumEntity> albumRepository,
                            IRepository<MusicianInBandsEntity> musicianInBandsRepository,
                            IRepository<SongEntity> songRepository)
        {
            _bandRepository = bandRepository;
            _musicianRepository = musicianRepository;
            _albumRepository = albumRepository;
            _musicianInBandsRepository = musicianInBandsRepository;
            _songRepository = songRepository;
        }
        public string GetJson()
        {
            object objects = new
            {
                Bands = _bandRepository.GetAll(),
                Musicians = _musicianRepository.GetAll(),
                Albums = _albumRepository.GetAll(),
                MusicianInBands = _musicianInBandsRepository.GetAll(),
                Songs = _songRepository.GetAll()
            };
            return JsonConvert.SerializeObject(objects);
        }
    }
}
