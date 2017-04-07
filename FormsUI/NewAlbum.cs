using Music.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class NewAlbum : Form
    {
        IArtist _artist;
        Album _album;
        public NewAlbum(IArtist artist)
        {
            InitializeComponent();
            _artist = artist;
        }

        private void publishAlbumButton_Click(object sender, EventArgs e)
        {
            _album = new Album()
            {
                artist = _artist,
                PublicationDate = albumPublicationDateTimePicker.Value,
                Title = albumNameTextBox.Text
            };

            int songDuration;
            int.TryParse(songDurationTextBox.Text, out songDuration);
            Song song = new Song()
            {
                Title = songNameTextBox.Text,
                Album = _album,
                Duration = songDuration
            };

            foreach (var item in songsListBox.Items)
            {
                Song songItem = item as Song;
                _album.Songs.Add(songItem);
                songItem.Album = _album;
            }

            _artist.Albums.Add(_album);

            this.Close();
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            int songDuration;
            int.TryParse(songDurationTextBox.Text, out songDuration);
            Song song = new Song()
            {
                Title = songNameTextBox.Text,
                Album = _album,
                Duration = songDuration
            };

            songsListBox.Items.Add(song);
        }

        private void NewAlbum_Load(object sender, EventArgs e)
        {

        }
    }
}
