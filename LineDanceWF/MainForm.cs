using LineDanceWF.Data;
using LineDanceWF.Services;
using System.Security.Cryptography.X509Certificates;
using NAudio;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;

namespace LineDanceWF
{
    public partial class MainForm : Form
    {
        private LDRepo _repo;
        private List<Song> songlist;
        private List<Dance> dancelist;

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;


        public MainForm()

        {
            _repo = new LDRepo(new LDContext());
            InitializeComponent();

            var x = _repo.DemoMetod();
            
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(x.FilePath);
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DanceSearch_TextChanged(object sender, EventArgs e)
        {
            dancelist = new List<Dance>();
            string searchText = SongSearch.Text;
            danceListBox.Items.Clear();
            if (searchText.Length != 0)
            {
                dancelist = _repo.FindTop20dances(searchText);

                foreach (Dance dance in dancelist)
                {
                    danceListBox.Items.Add(dance.Name);
                }
            }
        }
        private void SongSearch_TextChanged(object sender, EventArgs e)
        {
            songlist = new List<Song>();
            string searchText = SongSearch.Text;
            songListbox.Items.Clear();
            if (searchText.Length != 0)
            {
                songlist = _repo.FindTop20songs(searchText);

                foreach (Song song in songlist)
                {
                    songListbox.Items.Add(song.Name);
                }
            }
        }

        //private void songListBox_SelectionChanged(object sender, EventArgs e)
        //{
        //    var test = e.ToString();
        //    MessageBox.Show($"Selected {test}.");
        //}


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}