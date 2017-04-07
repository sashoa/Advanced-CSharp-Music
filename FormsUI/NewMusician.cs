using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using Music.BusinessLogic.Models;

namespace FormsUI
{
    public partial class NewMusician : Form
    {
        ObservableCollection<IArtist> _artists;
        public NewMusician(ObservableCollection<IArtist> artists)
        {
            InitializeComponent();
            _artists = artists;

            var bands = _artists.Where(a => a is Band);

            foreach (var band in bands)
            {
                allBandsListBox.Items.Add(band);
            }
        }

        private void addMusicianButton_Click(object sender, EventArgs e)
        {
            Musician musician = new Musician() { Name = musicianNameTextBox.Text};
            foreach (var item in assignedBandsListBox.Items)
            {
                Band band = item as Band;
                musician.Bands.Add(band);
                band.Musicians.Add(musician);
            }
            _artists.Add(musician);

            this.Hide();
        }

        private void NewMusician_Load(object sender, EventArgs e)
        {
        }

        private void assignBandButton_Click(object sender, EventArgs e)
        {
            assignedBandsListBox.Items.Add(allBandsListBox.SelectedItem);
            allBandsListBox.Items.Remove(allBandsListBox.SelectedItem);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    assignedBandsListBox.Items.Add(allBandsListBox.SelectedItem);
        //    allBandsListBox.Items.Remove(allBandsListBox.SelectedItem);
        //}

        private void removeFromAssignedBandsButton_Click(object sender, EventArgs e)
        {
            allBandsListBox.Items.Add(assignedBandsListBox.SelectedItem);
            assignedBandsListBox.Items.Remove(assignedBandsListBox.SelectedItem);
        }
    }
}
