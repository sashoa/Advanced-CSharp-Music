using Music.BusinessLogic;
using Music.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class Music : Form
    {
        private static ObservableCollection<IArtist> artists = new ObservableCollection<IArtist>(AddTestArtists());
        private static List<IArtist> AddTestArtists()
        {
            IArtist james = new Musician() { Name = "James Hetfield" };
            //james.Albums.Add(new Album() { artist = james, PublicationDate = DateTime.Now, Title = "james album" });
            //james.Albums.First().Songs.Add(new Song() { Title = "james album song 1", Album = james.Albums.First() });
            IArtist lars = new Musician() { Name = "Lars Ulrich" };
            IArtist kirk = new Musician() { Name = "Kirk Hammett" };
            IArtist robert = new Musician() { Name = "Robert Trujillo" };
            Band metallica = new Band()
            {
                Name = "Metallica",
                Musicians = { (Musician)james, (Musician)lars, (Musician)kirk, (Musician)robert },
                Albums =
                {
                    new Album()
                    {
                        Title = "Ride the Lightning",
                        PublicationDate = DateTime.Now,
                        Songs =
                        {
                            new Song() { Title = "Fight Fire With Fire", Duration = 285 },
                            new Song() { Title = "Ride the Lighting", Duration = 399 },
                            new Song() { Title = "From Whom the Bell Tolls", Duration = 311 }
                        }
                    },
                    new Album()
                    {
                        Title = "Hardwired... to Self-Destruct",
                        PublicationDate = DateTime.Now,
                        Songs =
                        {
                            new Song() { Title = "HardWired", Duration = 189 },
                            new Song() { Title = "Atlas Rise", Duration = 388 },
                            new Song() { Title = "Now That We're Dead", Duration = 419 }
                        }
                    },
                    new Album()
                    {
                        Title = "And Justice for All",
                        PublicationDate = DateTime.Now,
                        Songs =
                        {
                            new Song() { Title = "Blackened", Duration = 403 },
                            new Song() { Title = "And Justice for All", Duration = 586 },
                            new Song() { Title = "3Test song 3", Duration = 385 }
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


            IArtist demisRoussos = new Musician()
            {
                Name = "Demis Roussos",
                Albums =
                {
                    new Album()
                    {
                        Title = "Forever and Ever",
                        PublicationDate = new DateTime(1973),
                        Songs =
                        {
                            new Song()
                            {
                                Title = "Forever and Ever",
                                Duration = 223
                            },
                            new Song()
                            {
                                Title = "My Friend the Wind",
                                Duration = 240
                            },
                            new Song()
                            {
                                Title = "My Reason",
                                Duration = 242
                            }
                        }
                    },
                    new Album()
                    {
                        Title = "Reflection",
                        PublicationDate = new DateTime(1984),
                        Songs =
                        {
                            new Song()
                            {
                                Title = "As Time Goes By",
                                Duration = 282
                            },
                            new Song()
                            {
                                Title = "I Almost Lost My Mind",
                                Duration = 524
                            },
                            new Song()
                            {
                                Title = "Love Me Tender",
                                Duration = 253
                            }
                        }
                    }
                }
            };

            foreach (var album in demisRoussos.Albums)
            {
                album.artist = demisRoussos;
                album.Songs.ForEach(s => s.Album = album);
            }

            IArtist vangelis = new Musician()
            {
                Name = "Vangelis",
                Albums =
                {
                    new Album()
                    {
                        Title = "Rosetta",
                        PublicationDate = new DateTime(2016, 9, 23),
                        Songs =
                        {
                            new Song()
                            {
                                Title = "Starstuff",
                                Duration = 315
                            },
                            new Song()
                            {
                                Title = "Infinitude",
                                Duration = 270
                            },
                            new Song()
                            {
                                Title = "Exo Genesis",
                                Duration = 213
                            }
                        }
                    },
                    new Album()
                    {
                        Title = "Conquest of Paradise",
                        PublicationDate = new DateTime(1992, 2, 14),
                        Songs =
                        {
                            new Song()
                            {
                                Title = "Conquest of Paradise",
                                Duration = 288
                            },
                            new Song()
                            {
                                Title = "Monastery of La Rabida",
                                Duration = 219
                            },
                            new Song()
                            {
                                Title = "Light and Shadow",
                                Duration = 227
                            }
                        }
                    }
                }
            };

            foreach (var album in vangelis.Albums)
            {
                album.artist = vangelis;
                album.Songs.ForEach(s => s.Album = album);
            }

            return new List<IArtist>() { metallica, demisRoussos, vangelis, james, lars, kirk, robert };
        }
        private void DispayArtistInfo(IArtist artist)
        {
            artistTypeLabel.Text = "";
            artistIdLabel.Text = "";
            artistNameLabel.Text = "";
            numOfAlbumsLabel.Text = $"";
            numOfSongsLabel.Text = $"";
            memberOfBandsOrNumOfMusiciansLabel.Text = "";
            artistTypeLabel.Text = artist.GetType().Name.ToUpper();
            artistIdLabel.Text = $"Id: {artist.Id}";
            artistNameLabel.Text = $"Name: {artist.Name}";
            numOfAlbumsLabel.Text = $"Number Of Albums: {artist.Albums.Count}";
            numOfSongsLabel.Text = $"Number Of Total Songs: {artist.Albums.SelectMany(a => a.Songs).Count()}";
            memberOfBandsOrNumOfMusiciansLabel.Text = artist is Band ? $"Number of Musicians: {((Band)artist).Musicians.Count}" :
                                                                       $"Member of {((Musician)artist).Bands.Count} Bands";

        }
        private void DisplayArtists()
        {
            artistsList.Items.Clear();
            foreach (var artist in artists)
            {
                artistsList.Items.Add(artist);
            }
        }
        private void DisplayCollectionInfo()
        {
            var allAlbums = artists.SelectMany(a => a.Albums);
            var allSongs = allAlbums.SelectMany(a => a.Songs);
            var albumsCount = allAlbums.Count();
            var songsCount = allSongs.Count();
            var artistWithLongestName = artists.OrderByDescending(a => a.Name.Length).FirstOrDefault();

            IArtist artistWithFirstRecordedAlbum = null;
            IArtist artistWithLastRecordedAlbum = null;
            if (albumsCount > 0)
            {
                artistWithFirstRecordedAlbum = allAlbums.OrderByDescending(a => a.PublicationDate).FirstOrDefault().artist;
                artistWithLastRecordedAlbum = allAlbums.OrderBy(a => a.PublicationDate).FirstOrDefault().artist;
            }
            var artistWithMostRecordedAlbums = artists.OrderByDescending(a => a.Albums.Count).First();
            IArtist artistWithLongestSong = null;
            if (albumsCount > 0 && songsCount > 0)
                artistWithLongestSong = allSongs.OrderByDescending(s => s.Duration).FirstOrDefault().Album.artist;
            var artistWithMostSongs = artists.OrderByDescending(a => a.Albums.SelectMany(al => al.Songs).Count()).FirstOrDefault();
            var artistWithLongestTotalSongDuration = artists.OrderByDescending(a => a.Albums.SelectMany(al => al.Songs).Aggregate(0, (c, s) => c + s.Duration)).FirstOrDefault();
            var artistWithAverageTotalSongDuration = artists.OrderByDescending(a => a.Albums.SelectMany(al => al.Songs).Aggregate(0, (c, s) => c + s.Duration)).FirstOrDefault();
            double averageDuratonOfSong = 0;
            if (songsCount > 0)
                averageDuratonOfSong = allSongs.Average(s => s.Duration);
            double averageDurationOfAlbum = 0;
            if (albumsCount > 0)
                averageDurationOfAlbum = allAlbums.Average(a => a.Songs.Aggregate(0, (c, s) => c + s.Duration));
            longestArtistNameLabel.Text = artistWithLongestName != null ?
                                          $"The longest artist name has {artistWithLongestName} With {artistWithLongestName.Name.Length } Characters" : "";
            firstRecordedAlbumLabel.Text = artistWithFirstRecordedAlbum != null ?
                                           $"{artistWithFirstRecordedAlbum.Name} is the artist with the first recorded album" : "";
            lastRecordedAlbumLabel.Text = artistWithLastRecordedAlbum != null ? 
                                          $"{artistWithLastRecordedAlbum.Name} is the artist with the last recorded album" : "";
            mostRecordedAlbumsLabel.Text = artistWithMostRecordedAlbums != null ?
                                           $"{artistWithMostRecordedAlbums} is the artist with the most recorded albums" : "";
            longestSongLabel.Text = artistWithLongestSong != null ?
                                    $"{artistWithLongestSong} is the artist with the longest song" : "";
            mostSongsLabel.Text = artistWithMostSongs != null ?
                                  $"{artistWithMostSongs} is the artist with most songs" : "";
            longestTotalSongDuration.Text = $"{artistWithLongestTotalSongDuration} is the artist with the longest total song duration";
            averageSongDurationLabel.Text = $"Average song duration is {averageDuratonOfSong:F2}";
            averageAlbumDurationLabel.Text = $"Average album duration is {averageDurationOfAlbum:F2}";

        }
        public Music()
        {
            InitializeComponent();

            artists.CollectionChanged += UpdateArtistsList;
            artists.CollectionChanged += UpdateCollectionInfo;
            if (artists.Count > 0)
            {
                DisplayArtists();
                DisplayCollectionInfo();
            }
            addAlbumButton.Hide();
            addMusicianButton.Hide();
            assignToBandButton.Hide();

            //richTextBox1.Text = Persistance.Export(artists);
        }

        private void UpdateCollectionInfo(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            DisplayCollectionInfo();
        }

        private void UpdateArtistsList(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            DisplayArtists();
        }

        private void artistsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IArtist selectedArtist = artistsList.SelectedItem as IArtist;
            DispayArtistInfo(selectedArtist);
            if (selectedArtist is Band)
            {
                addAlbumButton.Show();
                addMusicianButton.Show();
                assignToBandButton.Hide();
            }
            if (selectedArtist is Musician)
            {
                addAlbumButton.Show();
                assignToBandButton.Show();
                addMusicianButton.Hide();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newBandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBand newBand = new NewBand(artists);
            newBand.Show();
        }

        private void addMusicianButton_Click(object sender, EventArgs e)
        {
            if (artistsList.SelectedItem != null)
            {
                IArtist artist = artistsList.SelectedItem as IArtist;
                artist = artists.Single(a => a is Band && a.Id == artist.Id);
                AssignMusician assignMusician = new AssignMusician(artists, artist);
                assignMusician.Show();
            }
        }

        private void newMusicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMusician newMusician = new NewMusician(artists);
            newMusician.Show();
        }

        private void addAlbumButton_Click(object sender, EventArgs e)
        {
            if (artistsList.SelectedItem != null)
            {
                IArtist artist = artistsList.SelectedItem as IArtist;
                artist = artists.Single(a => a.Id == artist.Id && a.Name == artist.Name );
                NewAlbum newAlbum = new NewAlbum(artist);
                newAlbum.Show();
            }
        }

        private void assignToBand_Click(object sender, EventArgs e)
        {
            if (artistsList.SelectedItem != null)
            {
                IArtist artist = artistsList.SelectedItem as IArtist;
                artist = artists.Single(a => a is Musician && a.Id == artist.Id);
                AssignToBand assignToBand = new AssignToBand(artists, artist);
                assignToBand.Show();
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "MusicCollectionData";
            dialog.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, Persistance.Export(artists));
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = "MusicCollectionData";
            dialog.Filter = "Json Files (.Json)|*.Json;";
            if (dialog.ShowDialog() == DialogResult.OK) // Test result.
            {
                string file = dialog.FileName;
                try
                {
                    
                    string data = File.ReadAllText(file);
                    artists = Persistance.Import(data);
                    DisplayArtists();
                    DisplayCollectionInfo();
                }
                catch (IOException ioex)
                {
                    MessageBox.Show(ioex.Message);
                }
            }
        }

    }
}
