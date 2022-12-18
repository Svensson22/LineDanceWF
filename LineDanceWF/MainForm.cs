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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DanceSearch_TextChanged(object sender, EventArgs e)
        {
            dancelist = new List<Dance>();
            string searchText = DanceSearch.Text;
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

        private void OnButtonPlayClicked(object sender, EventArgs e)
        {
            var song = _repo.GetSongByName(songListbox.Text);

            if (song is null)
                return;

            if (outputDevice is null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }

            if (audioFile is null)
            {
                audioFile = new AudioFileReader(song.FilePath);
                outputDevice.Init(audioFile);
            }

            outputDevice.Play();
        }

        private void OnButtonStopClicked(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

        private void AddDanceBtn_Click(object sender, EventArgs e)
        {
           AddDanceForm addDanceForm= new AddDanceForm();
            addDanceForm.ShowDialog();
        }

        private void danceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            songlist=new List<Song>();
            Dance dance=new Dance();
            dance = dancelist[danceListBox.SelectedIndex];
            songlist.Add(dance.OriginalSong);
            songListbox.Items.Clear();
            foreach(Song song in dance.Alternatives)
            {
                songlist.Add(song);
            }
            foreach(Song song in songlist)
            {
                songListbox.Items.Add(song.Name);
            }
        }
    }
}