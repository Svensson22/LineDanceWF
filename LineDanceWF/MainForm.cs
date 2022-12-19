using LineDanceWF.Data;
using LineDanceWF.Services;
using LineDanceWF.SoundTouch;
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

        //private WaveOutEvent waveOut;
        private IWavePlayer wavePlayer;
        private AudioFileReader reader;
        private VarispeedSampleProvider speedControl;


        public MainForm()

        {
            _repo = new LDRepo(new LDContext());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tempoLabel.Text = $"{tempoBar.Value / 100f}x";
            label2.Text = $"{tempoBar.Minimum / 100f}x";
            label3.Text = $"{tempoBar.Maximum / 100f}x";

            loadMessage.Text = "";
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

            // Kolla om en låt redan spelas
            if (wavePlayer is not null)
            {
                wavePlayer.Stop();
                LoadFile(song.FilePath);
            }

            // Audio stream för speed control
            if (wavePlayer is null)
            {
                wavePlayer = new WaveOutEvent();
                wavePlayer.Volume = volumeSlider1.Volume;
                wavePlayer.PlaybackStopped += OnPlaybackStopped;
            }

            if (speedControl is null)
            {
                LoadFile(song.FilePath);
                if (speedControl is null) return;
            }

            speedControl.PlaybackRate = tempoBar.Value / 100f;
            tempoLabel.Text = $"{tempoBar.Value / 100f}x";
            wavePlayer.Init(speedControl);
            wavePlayer.Play();
        }

        private void LoadFile(string file)
        {
            reader?.Dispose();
            speedControl?.Dispose();
            reader = null;
            speedControl = null;

            reader = new AudioFileReader(file);

            speedControl = new VarispeedSampleProvider(reader, 200, new SoundTouchProfile(true, true));
        }

        private void OnButtonStopClicked(object sender, EventArgs e)
        {
            wavePlayer?.Stop();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            if (args.Exception != null)
            {
                MessageBox.Show(args.Exception.Message, "Playback Stopped Unexpectedly");
            }
        }

        private void AddDanceBtn_Click(object sender, EventArgs e)
        {
            AddDanceForm addDanceForm = new AddDanceForm();
            addDanceForm.ShowDialog();
        }

        private void danceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            songlist = new List<Song>();
            Dance dance = new Dance();
            dance = dancelist[danceListBox.SelectedIndex];
            songlist.Add(dance.OriginalSong);
            songListbox.Items.Clear();
            foreach (Song song in dance.Alternatives)
            {
                songlist.Add(song);
            }
            foreach (Song song in songlist)
            {
                songListbox.Items.Add(song.Name);
            }
        }

        private void OnVolumeChanged(object sender, EventArgs e)
        {
            if (wavePlayer is not null)
                wavePlayer.Volume = volumeSlider1.Volume;
        }

        private void OnTempoChanged(object sender, EventArgs e)
        {
            if (speedControl is not null)
                speedControl.PlaybackRate = tempoBar.Value / 100f;

            tempoLabel.Text = $"{tempoBar.Value / 100f}x";
        }
    }
}