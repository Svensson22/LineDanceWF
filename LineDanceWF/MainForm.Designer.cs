using LineDanceWF.Services;

namespace LineDanceWF
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnLoad(EventArgs e)
        {
            LDContext db = new LDContext();
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            LDRepo lDRepo = new LDRepo(db);
            //Delete later just testing to see were it stops
            //pick a folder were you have music to check if it adds
            //Atm issues with conection to database
            //lDRepo.AddSongsFromFolder();
            base.OnLoad(e);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DanceSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.danceListBox = new System.Windows.Forms.ListBox();
            this.SongLabel = new System.Windows.Forms.Label();
            this.songListbox = new System.Windows.Forms.ListBox();
            this.SongSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddDanceBtn = new System.Windows.Forms.Button();
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.tempoBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tempoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2564, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DanceSearch
            // 
            this.DanceSearch.Location = new System.Drawing.Point(54, 286);
            this.DanceSearch.Margin = new System.Windows.Forms.Padding(5);
            this.DanceSearch.Name = "DanceSearch";
            this.DanceSearch.Size = new System.Drawing.Size(366, 39);
            this.DanceSearch.TabIndex = 1;
            this.DanceSearch.TextChanged += new System.EventHandler(this.DanceSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dances";
            // 
            // danceListBox
            // 
            this.danceListBox.FormattingEnabled = true;
            this.danceListBox.ItemHeight = 32;
            this.danceListBox.Location = new System.Drawing.Point(54, 339);
            this.danceListBox.Margin = new System.Windows.Forms.Padding(5);
            this.danceListBox.Name = "danceListBox";
            this.danceListBox.Size = new System.Drawing.Size(457, 772);
            this.danceListBox.TabIndex = 3;
            this.danceListBox.SelectedIndexChanged += new System.EventHandler(this.danceListBox_SelectedIndexChanged);
            // 
            // SongLabel
            // 
            this.SongLabel.AutoSize = true;
            this.SongLabel.Location = new System.Drawing.Point(803, 224);
            this.SongLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SongLabel.Name = "SongLabel";
            this.SongLabel.Size = new System.Drawing.Size(79, 32);
            this.SongLabel.TabIndex = 4;
            this.SongLabel.Text = "Songs";
            // 
            // songListbox
            // 
            this.songListbox.FormattingEnabled = true;
            this.songListbox.ItemHeight = 32;
            this.songListbox.Location = new System.Drawing.Point(803, 339);
            this.songListbox.Margin = new System.Windows.Forms.Padding(5);
            this.songListbox.Name = "songListbox";
            this.songListbox.Size = new System.Drawing.Size(457, 772);
            this.songListbox.TabIndex = 6;
            // 
            // SongSearch
            // 
            this.SongSearch.Location = new System.Drawing.Point(803, 286);
            this.SongSearch.Margin = new System.Windows.Forms.Padding(5);
            this.SongSearch.Name = "SongSearch";
            this.SongSearch.Size = new System.Drawing.Size(366, 39);
            this.SongSearch.TabIndex = 5;
            this.SongSearch.TextChanged += new System.EventHandler(this.SongSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1428, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButtonPlayClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1428, 313);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnButtonStopClicked);
            // 
            // AddDanceBtn
            // 
            this.AddDanceBtn.Location = new System.Drawing.Point(57, 1123);
            this.AddDanceBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AddDanceBtn.Name = "AddDanceBtn";
            this.AddDanceBtn.Size = new System.Drawing.Size(457, 61);
            this.AddDanceBtn.TabIndex = 9;
            this.AddDanceBtn.Text = "Add new dance";
            this.AddDanceBtn.UseVisualStyleBackColor = true;
            this.AddDanceBtn.Click += new System.EventHandler(this.AddDanceBtn_Click);
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(1409, 224);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(192, 32);
            this.volumeSlider1.TabIndex = 10;
            this.volumeSlider1.VolumeChanged += new System.EventHandler(this.OnVolumeChanged);
            // 
            // tempoBar
            // 
            this.tempoBar.Location = new System.Drawing.Point(1393, 415);
            this.tempoBar.Maximum = 110;
            this.tempoBar.Minimum = 90;
            this.tempoBar.Name = "tempoBar";
            this.tempoBar.Size = new System.Drawing.Size(208, 90);
            this.tempoBar.TabIndex = 11;
            this.tempoBar.Value = 100;
            this.tempoBar.Scroll += new System.EventHandler(this.OnTempoChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1401, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "0.9x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1555, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "1.1x";
            // 
            // tempoLabel
            // 
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.Location = new System.Drawing.Point(1609, 417);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(0, 32);
            this.tempoLabel.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(2564, 1399);
            this.Controls.Add(this.tempoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempoBar);
            this.Controls.Add(this.volumeSlider1);
            this.Controls.Add(this.AddDanceBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.songListbox);
            this.Controls.Add(this.SongSearch);
            this.Controls.Add(this.SongLabel);
            this.Controls.Add(this.danceListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DanceSearch);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Linedance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private PictureBox pictureBox1;
        private TextBox DanceSearch;
        private Label label1;
        private ListBox danceListBox;
        private Label SongLabel;
        private ListBox songListbox;
        private TextBox SongSearch;
        private Button button1;
        private Button button2;
        private Button AddDanceBtn;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private TrackBar tempoBar;
        private Label label2;
        private Label label3;
        private Label tempoLabel;
    }
}