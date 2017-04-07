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
    public partial class AssignToBand : Form
    {
        ObservableCollection<IArtist> _artists;
        IArtist _artist;
        public AssignToBand(ObservableCollection<IArtist> artists, IArtist selectedArtist)
        {
            InitializeComponent();

            _artist = selectedArtist;
            _artists = artists;


            Musician musician = _artist as Musician;
            var unassignedBands = _artists.Where(a => a is Band && !musician.Bands.Contains(a));
            foreach (var band in unassignedBands)
            {
                allBandsListBox.Items.Add(band);
            }

            var assignedBands = ((Musician)_artist).Bands;
            foreach (var band in assignedBands)
            {
                assignedBandsListBox.Items.Add(band);
            }
        }

        private void DoneWithAssignmentButton_Click(object sender, EventArgs e)
        {
            Musician musician = _artist as Musician;
            foreach (var item in assignedBandsListBox.Items)
            {
                Band band = item as Band;
                if (!musician.Bands.Contains(band))
                    musician.Bands.Add(band);
                if (!band.Musicians.Contains(musician))
                    band.Musicians.Add(musician);
            }

            foreach (var item in allBandsListBox.Items)
            {
                Band band = item as Band;
                if (band.Musicians.Contains(musician))
                    band.Musicians.Remove(musician);
                if (musician.Bands.Contains(band))
                    musician.Bands.Remove(band);
            }
            this.Close();
        }

        private void assignBandButton_Click(object sender, EventArgs e)
        {
            if (allBandsListBox.SelectedItem != null)
            {
                assignedBandsListBox.Items.Add(allBandsListBox.SelectedItem);
                allBandsListBox.Items.Remove(allBandsListBox.SelectedItem);
            }
        }

        private void removeFromAssignedBandsButton_Click(object sender, EventArgs e)
        {
            if (assignedBandsListBox.SelectedItem != null)
            {
                allBandsListBox.Items.Add(assignedBandsListBox.SelectedItem);
                assignedBandsListBox.Items.Remove(assignedBandsListBox.SelectedItem);
            }

        }
    }
}
