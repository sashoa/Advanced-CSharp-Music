using Music.DataAccess;
using Music.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Service.Interfaces;
using Music.Service;

namespace Music.BusinessLogic
{
    public class ServiceProvider
    {
        // Default Repositories
        public IRepository<BandEntity> BandRepository { get; set; } = new Repository<BandEntity>(new List<BandEntity>());
        public IRepository<MusicianEntity> MusicianRepository { get; set; } = new Repository<MusicianEntity>(new List<MusicianEntity>());
        public IRepository<AlbumEntity> AlbumRepository { get; set; } = new Repository<AlbumEntity>(new List<AlbumEntity>());
        public IRepository<SongEntity> SongRepository { get; set; } = new Repository<SongEntity>(new List<SongEntity>());
        public IRepository<MusicianInBandsEntity> MusicianInBandsRepository { get; set; } = new Repository<MusicianInBandsEntity>(new List<MusicianInBandsEntity>());


        public IBandEntityService GetBandService()
        {
            return new BandEntityService(BandRepository, MusicianRepository, AlbumRepository, SongRepository);
        }
        public IMusicianEntityService GetMusicianService()
        {
            return new MusicianEntityService(BandRepository, MusicianRepository, AlbumRepository, SongRepository);
        }
        public IAlbumEntityService GetAlbumService()
        {
            return new AlbumEntityService(BandRepository, MusicianRepository, AlbumRepository, SongRepository);
        }
        public ISongEntityService GetSongService()
        {
            return new SongEntityService(BandRepository, MusicianRepository, AlbumRepository, SongRepository);
        }
        public IMusicianInBandsEntityService GetMusicianInBandsService()
        {
            return new MusicianInBandsEntityService(BandRepository, MusicianRepository, AlbumRepository, MusicianInBandsRepository, SongRepository);
        }
        public IJsonEntityService GetJsonService()
        {
            return new JsonEntityService(BandRepository, MusicianRepository, AlbumRepository, MusicianInBandsRepository, SongRepository);
        }

    }
}
