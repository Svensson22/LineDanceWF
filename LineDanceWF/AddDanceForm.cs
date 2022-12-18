using LineDanceWF.Data;
using LineDanceWF.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineDanceWF
{
    public partial class AddDanceForm : Form
    {
        private LDRepo _repo;
        private List<Song> songlist;
        private Dance dance = new Dance();
        
        public AddDanceForm()
        {
            _repo = new LDRepo(new LDContext());
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddDanceDanceNameInput_TextChanged(object sender, EventArgs e)
        {
            AddDanceDanceNameLabel.Text = AddDanceDanceNameInput.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddDanceSongSearchInput_TextChanged(object sender, EventArgs e)
        {
            songlist = new List<Song>();
            string searchText = AddDanceSongSearchInput.Text;
            AdddanceSongSearchResultList.Items.Clear();
            if (searchText.Length != 0)
            {
                songlist = _repo.FindTop20songs(searchText);

                foreach (Song song in songlist)
                {
                    AdddanceSongSearchResultList.Items.Add(song.Name);
                }
            }

        }

        private void AddDanceAddOriginalSongBtn_Click(object sender, EventArgs e)
        {
            if(AdddanceSongSearchResultList.SelectedIndex == -1)
            {
                MessageBox.Show("No selected item to add");
            }
            else
            {
                Song song = songlist[AdddanceSongSearchResultList.SelectedIndex];
                dance.OriginalSong = song;
                dance.OriginalSongID = song.SongId;
                AddDanceOriginalSongLabel.Text = song.Name;
                if (dance.Alternatives.Where(x => x.FileHash.Equals(song.FileHash)).Any() == true)
                {
                    dance.Alternatives.Remove(song);
                    AddDanceUpdateAlternativeSongList(dance.Alternatives.ToList());
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddDanceOriginalSongLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddDanceAddAlternativeSongBtn_Click(object sender, EventArgs e)
        {
            if (AdddanceSongSearchResultList.SelectedIndex == -1)
            {
                MessageBox.Show("No selected item to add");
            }
            else
            {
                Song song = songlist[AdddanceSongSearchResultList.SelectedIndex];
                if(song.Equals(dance.OriginalSong) == true)
                {
                    MessageBox.Show($"{song.Name} is already picked as original song");
                }
                else if(dance.Alternatives.Where(x => x.FileHash.Equals(song.FileHash)).Any() == true)
                {
                    MessageBox.Show($"{song.Name} already exists as an alternative song");
                }
                else
                {
                    dance.Alternatives.Add(song);
                    AddDanceUpdateAlternativeSongList(dance.Alternatives.ToList());

                }
            }
        }
        private void AddDanceUpdateAlternativeSongList(List<Song> songs)
        {
            AddDanceAlternativeSongListbox.Items.Clear();
            foreach (Song song in songs)
            {
                AddDanceAlternativeSongListbox.Items.Add(song.Name);
            }
        }

        private void AddDanceRemoveAlternative_Click(object sender, EventArgs e)
        {
            if (AddDanceAlternativeSongListbox.SelectedIndex == -1)
            {
                MessageBox.Show("No selected item to remove");
            }
            else
            {
                Song song = dance.Alternatives[AddDanceAlternativeSongListbox.SelectedIndex];
                dance.Alternatives.Remove(song);
                AddDanceUpdateAlternativeSongList(dance.Alternatives.ToList());
            }
        }

        private void AddDanceSave_Click(object sender, EventArgs e)
        {
            dance.Name= AddDanceDanceNameLabel.Text;
            _repo.AddDance(dance);
        }
    }
}
