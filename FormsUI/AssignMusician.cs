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
    public partial class AssignMusician : Form
    {
        IArtist _artist;
        ObservableCollection<IArtist> _artists;
        public AssignMusician(ObservableCollection<IArtist> artists, IArtist selectedArtist)
        {
            InitializeComponent();

            _artist = selectedArtist;
            _artists = artists;

            Band band = _artist as Band;
            var unassignedMusicians = _artists.Where(a => a is Musician && !band.Musicians.Contains(a));
            foreach (var musician in unassignedMusicians)
            {
                allMusiciansListBox.Items.Add(musician);
            };
            var assignedMusicians = band.Musicians;
            foreach (var musician in assignedMusicians)
            {
                assignedMusiciansListBox.Items.Add(musician);
            };
        }

        private void DoneWithAssignmentButton_Click(object sender, EventArgs e)
        {
            Band band = _artist as Band;
            foreach (var item in assignedMusiciansListBox.Items)
            {
                Musician musician = item as Musician;
                if (!musician.Bands.Contains(band))
                    musician.Bands.Add(band);
                if (!band.Musicians.Contains(musician))
                    band.Musicians.Add(musician);
            }
            foreach (var item in allMusiciansListBox.Items)
            {
                Musician musician = item as Musician;
                if (musician.Bands.Contains(band))
                    musician.Bands.Remove(band);
                if (band.Musicians.Contains(musician))
                    band.Musicians.Remove(musician);
            }
            this.Close();

        }

        private void assignMusicianButton_Click(object sender, EventArgs e)
        {
            if (allMusiciansListBox.SelectedItem != null)
            {
                assignedMusiciansListBox.Items.Add(allMusiciansListBox.SelectedItem);
                allMusiciansListBox.Items.Remove(allMusiciansListBox.SelectedItem);
            }
        }

        private void removeFromAssignedMusiciansButton_Click(object sender, EventArgs e)
        {
            if (assignedMusiciansListBox.SelectedItem != null)
            {
                allMusiciansListBox.Items.Add(assignedMusiciansListBox.SelectedItem);
                assignedMusiciansListBox.Items.Remove(assignedMusiciansListBox.SelectedItem);
            }
        }
    }
}
