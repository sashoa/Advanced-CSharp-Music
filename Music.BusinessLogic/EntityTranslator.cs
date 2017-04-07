using Music.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.BusinessLogic.Models;
using Music.Entities;

namespace Music.BusinessLogic
{
    public class EntityTranslator
    {
        static ServiceProvider serviceProvider;

        static IBandEntityService bandService; 
        static IMusicianEntityService musicianService; 
        static IAlbumEntityService albumService;
        static ISongEntityService songService;
        static IMusicianInBandsEntityService musicianInBandsService;

        public EntityTranslator(ServiceProvider sp)
        {
            serviceProvider = sp;
            bandService = sp.GetBandService();
            musicianService = sp.GetMusicianService();
            albumService = sp.GetAlbumService();
            musicianInBandsService = sp.GetMusicianInBandsService();
            songService = sp.GetSongService();
        }

        public ServiceProvider ModelToEntity(IEnumerable<IArtist> artists)
        {
            var bands = artists.Where(a => a is Band).Select(a => (Band)a);
            var musicians = artists.Where(a => a is Musician).Select(a => (Musician)a);
            var albums = artists.SelectMany(a => a.Albums);
            var songs = albums.SelectMany(a => a.Songs);
            var musiciansInBands = musicians.Select(m => new { mId = m.Id, bIds = m.Bands.Select(b => b.Id) });

            foreach (var band in bands)
            {
                BandEntity bandEntity = new BandEntity(band.Name);
                bandService.SaveBand(bandEntity, band.Id);
            }
            foreach (var musicansInBand in musiciansInBands)
            {
                foreach (var id in musicansInBand.bIds)
                {
                    MusicianInBandsEntity musicianInBand = new MusicianInBandsEntity() { MusicianId = musicansInBand.mId, BandId = id };
                    musicianInBandsService.Save(musicianInBand, null);
                }
            }
            foreach (var musician in musicians)
            {
                MusicianEntity musicianEntity = new MusicianEntity(musician.Name, musician.Id);
                musicianService.SaveMusician(musicianEntity, musician.Id);
            }
            foreach (var album in albums)
            {
                int? bandId = null, musicianId = null;
                if (album.artist is Band)
                {
                    bandId = album.artist.Id;
                }
                if (album.artist is Musician)
                {
                    musicianId = album.artist.Id;
                }
                AlbumEntity albumEntity = new AlbumEntity(album.Title, album.PublicationDate, bandId, musicianId);
                albumService.SaveAlbum(albumEntity, album.Id);
            }

            foreach (var song in songs)
            {
                SongEntity songEntity = new SongEntity(song.Title, song.Duration, song.Album.Id);
                songService.SaveSong(songEntity, song.Id);
            }
            return serviceProvider;
        }

        public IEnumerable<IArtist> EntityToModel()
        {
            List<IArtist> artists = new List<IArtist>();

            var allBands = bandService.GetAllBands();
            var allMusicians = musicianService.GetAllMusicians();
            var allMusicianInBands = musicianInBandsService.GetAll();
            var allAlbums = albumService.GetAllAlbums();
            var allSongs = songService.GetAllSongs();

            //Band.NextId = allBands.Max(b => b.Id);
            //Musician.NextId = allMusicians.Max(m => m.Id);
            //Album.NextId = allAlbums.Max(a => a.Id);
            //Song.NextId = allSongs.Max(s => s.Id);

            // Translate Bands
            foreach (var bandEntity in allBands)
            {
                Band band = new Band()
                {
                    Id = bandEntity.Id,
                    Name = bandEntity.Name,
                };
                artists.Add(band);
            }
            // Translate Musicians
            foreach (var musicianEntity in allMusicians)
            {
                Musician musician = new Musician()
                {
                    Id = musicianEntity.Id,
                    Name = musicianEntity.Name,
                };
                artists.Add(musician);
            }

            // Assign Musicians to Bands
            var bands = artists.Where(a => a is Band);
            foreach (var band in bands)
            {
                foreach (var musicianInBand in allMusicianInBands)
                {
                    var temp = artists.SingleOrDefault(a => a is Musician &&
                                       (a.Id == musicianInBand.MusicianId && band.Id == musicianInBand.BandId));
                    if (temp != null)
                        ((Band)band).Musicians.Add(temp as Musician);
                }
            }

            // Assign Bands to Musicians
            var musicians = artists.Where(a => a is Musician);
            foreach (var musician in musicians)
            {
                foreach (var musicianInBand in allMusicianInBands)
                {
                    var temp = artists.FirstOrDefault(a => a is Band &&
                                                   (a.Id == musicianInBand.BandId && musician.Id == musicianInBand.MusicianId));
                    if (temp != null)
                        ((Musician)musician).Bands.Add( temp as Band);
                }
            }

            // Translate Albums
            foreach (var albumEntity in allAlbums)
            {
                IArtist artist = null;
                if (albumEntity.BandId != null)
                    artist = artists.Single(a => a.Id == albumEntity.BandId && a is Band);
                else if (albumEntity.MusicianId != null)
                    artist = artists.Single(a => a.Id == albumEntity.MusicianId && a is Musician);
                                                          
                Album album = new Album()
                {
                    Id = albumEntity.Id,
                    PublicationDate = albumEntity.PublicationDate,
                    Title = albumEntity.Title,
                    artist = artist
                };

                artist.Albums.Add(album);
            }

            // Translate Songs and assign to Albums
            foreach (var songEntity in allSongs)
            {
                var album = artists.SelectMany(a => a.Albums).Single(a => a.Id == songEntity.AlbumId);
                Song song = new Song()
                {
                    Id = songEntity.Id,
                    Title = songEntity.Title,
                    Album = album
                };
                album.Songs.Add(song);
            }

            // Assign Songs to Albums
            //var albums = artists.SelectMany(a => a.Albums);
            //foreach (var album in albums)
            //{

            //}


            return artists;
        }
    }
}
