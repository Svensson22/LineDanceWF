using LineDanceWF.Data;
using LineDanceWF.Services;
using System.Security.Cryptography.X509Certificates;

namespace LineDanceWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LDContext dbtest = new LDContext();
            //db.Database.EnsureDeleted();
            dbtest.Database.EnsureCreated();
            LDRepo lDRepo = new LDRepo(dbtest);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Song> songs = new List<Song>();
            string searchText = DanceSearch.Text;
           
        }
    }
}