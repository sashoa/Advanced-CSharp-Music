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
using Music.BusinessLogic.Models;

namespace FormsUI
{
    public partial class NewBand : Form
    {
        ObservableCollection<IArtist> _artists;
        public NewBand(ObservableCollection<IArtist> artists)
        {
            InitializeComponent();
            _artists = artists;

            var musicians = _artists.Where(a => a is Musician);

            foreach (var musician in musicians)
            {
                allMusiciansListBox.Items.Add(musician);
            }
        }

        private void bandMusiciansLabel_Click(object sender, EventArgs e)
        {

        }

        private void bandAddLabel_Click(object sender, EventArgs e)
        {
            Band band = new Band() { Name = bandNameTextBox.Text };
            foreach (var item in assignedMusiciansListBox.Items)
            {
                Musician musician = item as Musician;
                band.Musicians.Add(musician);
                musician.Bands.Add(band);
            }
            _artists.Add(band);
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
