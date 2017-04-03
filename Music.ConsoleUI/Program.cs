using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Entities;
using Music.DataAccess;
using Music.Service.Interfaces;
using Music.BusinessLogic.Models;
using Music.BusinessLogic;

namespace Music.ConsoleUI
{
    class Program
    {
        //static ServiceProvider serviceProvider = new ServiceProvider();

        //static IBandEntityService bandService = serviceProvider.GetBandService();
        //static IMusicianEntityService musicianService = serviceProvider.GetMusicianService();
        //static IAlbumEntityService albumService = serviceProvider.GetAlbumService();
        //static ISongEntityService songService = serviceProvider.GetSongService();

        static void Main(string[] args)
        {

            var translator = new EntityTranslator();

            List<IArtist> artists = AddTestArtists();

            ServiceProvider serviceProvider =  translator.ModelToEntity(artists);
            IBandEntityService bandService = serviceProvider.GetBandService();
            IMusicianEntityService musicianService = serviceProvider.GetMusicianService();
            IAlbumEntityService albumService = serviceProvider.GetAlbumService();
            ISongEntityService songService = serviceProvider.GetSongService();

            var numberOfMusicians = musicianService.GetAllMusicians().Count();
            var numberOfAlbums = albumService.GetAllAlbums().Count();
            var numberOfSongs = songService.GetAllSongs().Count();
            Console.WriteLine(numberOfMusicians);
            Console.WriteLine(numberOfAlbums);
            Console.WriteLine(numberOfSongs);

            artists = translator.EntityToModel().ToList();

            Console.WriteLine("----------------------------------");
            Console.WriteLine(artists.First().Albums.First().Songs.First().Title);
            ArtistsInfo(artists);

        }

        private static void NewBand(List<IArtist>artists)
        {
            Console.Write("\nEnter band name: ");
            string name = Console.ReadLine();
        }
        private static List<IArtist> AddTestArtists()
        {
            IArtist james = new Musician() { Name = "James Hetfield" };
            james.Albums.Add(new Album() { artist = james, PublicationDate = DateTime.Now, Title = "james album" });
            james.Albums.First().Songs.Add(new Song() { Title = "james album song 1", Album = james.Albums.First() });
            IArtist lars = new Musician() { Name = "Lars Ulrich" };
            IArtist kirk = new Musician() { Name = "Kirk Hammett" };
            IArtist robert = new Musician() { Name = "Robert Trujillo" };
            Band metallica = new Band()
            {
                Name = "Metallica",
                Musicians = {(Musician)james, (Musician)lars, (Musician)kirk, (Musician)robert},
                Albums =
                {
                    new Album()
                    {
                        Title = "Ride the Lightning",
                        PublicationDate = DateTime.Now,
                        Songs =
                        {
                            new Song() { Title = "Fight Fire With Fire" },
                            new Song() { Title = "Ride the Lighting" },
                            new Song() { Title = "From Whom the Bell Tolls" }
                        }
                    },
                    new Album()
                    {
                        Title = "Test album 2",
                        PublicationDate = DateTime.Now,
                        Songs =
                        {
                            new Song() { Title = "2Test Song 1" },
                            new Song() { Title = "2Test Song 2" },
                            new Song() { Title = "2Test song 3" }
                        }
                    },
                    new Album()
                    {
                        Title = "Test album 3",
                        PublicationDate = DateTime.Now,
                        Songs =
                        {
                            new Song() { Title = "3Test Song 1" },
                            new Song() { Title = "3Test Song 2" },
                            new Song() { Title = "3Test song 3" }
                        }
                    }
                }
            };

            foreach (var musician in ((Band)metallica).Musicians)
            {
                musician.Bands.Add((Band)metallica);
            }

            foreach (var album in metallica.Albums)
            {
                album.artist = metallica;
                album.Songs.ForEach(s => s.Album = album);
            }


            IArtist testMusician1 = new Musician() { Name = "testMusician 1" };
            testMusician1.Albums.Add(new Album() { artist = testMusician1, PublicationDate = DateTime.Now, Title = "TestMusician1 album" });
            testMusician1.Albums.First().Songs.Add(new Song() { Title = "testMusician1 album song 1", Album = testMusician1.Albums.First() });
            IArtist testMusician2 = new Musician() { Name = "testMusician2" };
            IArtist testMusician3 = new Musician() { Name = "testMusician3" };
            IArtist testMusician4 = new Musician() { Name = "testMusician4" };
            Band testBand2 = new Band()
            {
                Name = "TestBand2",
                Musicians = {(Musician)testMusician1, (Musician)testMusician2, (Musician)testMusician3, (Musician)testMusician4},
                Albums =
                {
                    new Album()
                    {
                        Title = "TestBand2 Test album 4",
                        PublicationDate = DateTime.Now,
                        Songs =
                        {
                            new Song() { Title = "TestBand2 Test album 4 testSong 1" },
                            new Song() { Title = "TestBand2 Test album 4 testSong 2" },
                            new Song() { Title = "TestBand2 Test album 4 testSong 3" }
                        }
                    },
                    new Album()
                    {
                        Title = "TestBand2 Test album 5",
                        PublicationDate = DateTime.Now,
                        Songs =
                        {
                            new Song() { Title = "TestBand2 Test album 5 Test Song 1" },
                            new Song() { Title = "TestBand2 Test album 5 Test Song 2" },
                            new Song() { Title = "TestBand2 Test album 5 Test song 3" }
                        }
                    },
                    new Album()
                    {
                        Title = "TestBand2 Test album 6",
                        PublicationDate = DateTime.Now,
                        Songs =
                        {
                            new Song() { Title = "TestBand2 Test album 6 Test Song 1" },
                            new Song() { Title = "TestBand2 Test album 6 Test Song 2" },
                            new Song() { Title = "TestBand2 Test album 6 Test song 3" }
                        }
                    }
                }
            };

            foreach (var musician in ((Band)testBand2).Musicians)
            {
                musician.Bands.Add((Band)testBand2);
            }

            foreach (var album in testBand2.Albums)
            {
                album.artist = testBand2;
                album.Songs.ForEach(s => s.Album = album);
            }
            return new List<IArtist>() { metallica, james, lars, kirk, robert, testBand2, testMusician1, testMusician2, testMusician3, testMusician4 };;
        }
        private static void ArtistsInfo(IEnumerable<IArtist> artists)
        {
            Console.Write("\nLongest name: ");
            Console.Write(artists.OrderByDescending(a => a.Name.Length).First().Name);
            Console.Write("\nFirst released album has: ");
            Console.Write(artists.SelectMany(a => a.Albums).OrderBy(a => a.PublicationDate.Ticks).First().artist.Name);
            Console.Write("\nLast released album has: ");
            Console.Write(artists.SelectMany(a => a.Albums).OrderByDescending(a => a.PublicationDate.Ticks).First().artist.Name);
            Console.Write("\nArtist with most recorded albums: ");
            Console.Write(artists.OrderByDescending(a => a.Albums.Count).First().Name);
            Console.WriteLine();
        }
    }
}
