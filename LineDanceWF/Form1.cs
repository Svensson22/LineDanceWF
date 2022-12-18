using LineDanceWF.Data;
using LineDanceWF.Services;
using System.Security.Cryptography.X509Certificates;

namespace LineDanceWF
{
    public partial class Form1 : Form
    {
        private LDRepo _repo;
        public Form1()
        {
            _repo = new LDRepo(new LDContext());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Song> songs = new List<Song>();
            string searchText = DanceSearch.Text;
            
           
        }
    }
}