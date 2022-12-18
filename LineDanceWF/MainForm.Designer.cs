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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1124, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DanceSearch
            // 
            this.DanceSearch.Location = new System.Drawing.Point(29, 240);
            this.DanceSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DanceSearch.Name = "DanceSearch";
            this.DanceSearch.Size = new System.Drawing.Size(199, 23);
            this.DanceSearch.TabIndex = 1;
            this.DanceSearch.TextChanged += new System.EventHandler(this.DanceSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dances";
            // 
            // danceListBox
            // 
            this.danceListBox.FormattingEnabled = true;
            this.danceListBox.ItemHeight = 15;
            this.danceListBox.Location = new System.Drawing.Point(29, 265);
            this.danceListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.danceListBox.Name = "danceListBox";
            this.danceListBox.Size = new System.Drawing.Size(248, 364);
            this.danceListBox.TabIndex = 3;
            // 
            // SongLabel
            // 
            this.SongLabel.AutoSize = true;
            this.SongLabel.Location = new System.Drawing.Point(432, 211);
            this.SongLabel.Name = "SongLabel";
            this.SongLabel.Size = new System.Drawing.Size(39, 15);
            this.SongLabel.TabIndex = 4;
            this.SongLabel.Text = "Songs";
            // 
            // songListbox
            // 
            this.songListbox.FormattingEnabled = true;
            this.songListbox.ItemHeight = 15;
            this.songListbox.Location = new System.Drawing.Point(432, 265);
            this.songListbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.songListbox.Name = "songListbox";
            this.songListbox.Size = new System.Drawing.Size(248, 364);
            this.songListbox.TabIndex = 6;
            // 
            // SongSearch
            // 
            this.SongSearch.Location = new System.Drawing.Point(432, 240);
            this.SongSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SongSearch.Name = "SongSearch";
            this.SongSearch.Size = new System.Drawing.Size(199, 23);
            this.SongSearch.TabIndex = 5;
            this.SongSearch.TextChanged += new System.EventHandler(this.SongSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(769, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButtonPlayClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(769, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnButtonStopClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 526);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.songListbox);
            this.Controls.Add(this.SongSearch);
            this.Controls.Add(this.SongLabel);
            this.Controls.Add(this.danceListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DanceSearch);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Linedance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}