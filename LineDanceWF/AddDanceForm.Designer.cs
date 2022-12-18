namespace LineDanceWF
{
    partial class AddDanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AddDanceDanceNameInput = new System.Windows.Forms.TextBox();
            this.DanceNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDanceSongSearchInput = new System.Windows.Forms.TextBox();
            this.AdddanceSongSearchResultList = new System.Windows.Forms.ListBox();
            this.AddDanceAddOriginalSongBtn = new System.Windows.Forms.Button();
            this.AddDanceAddAlternativeSongBtn = new System.Windows.Forms.Button();
            this.AddDanceSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddDanceOriginalSongLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddDanceAlternativeSongListbox = new System.Windows.Forms.ListBox();
            this.AddDanceCancelBtn = new System.Windows.Forms.Button();
            this.AddDanceRemoveAlternative = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddDanceDanceNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Dance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddDanceDanceNameInput
            // 
            this.AddDanceDanceNameInput.Location = new System.Drawing.Point(225, 77);
            this.AddDanceDanceNameInput.Name = "AddDanceDanceNameInput";
            this.AddDanceDanceNameInput.Size = new System.Drawing.Size(241, 27);
            this.AddDanceDanceNameInput.TabIndex = 1;
            this.AddDanceDanceNameInput.TextChanged += new System.EventHandler(this.AddDanceDanceNameInput_TextChanged);
            // 
            // DanceNameLabel
            // 
            this.DanceNameLabel.AutoSize = true;
            this.DanceNameLabel.Location = new System.Drawing.Point(225, 53);
            this.DanceNameLabel.Name = "DanceNameLabel";
            this.DanceNameLabel.Size = new System.Drawing.Size(92, 20);
            this.DanceNameLabel.TabIndex = 2;
            this.DanceNameLabel.Text = "Dance name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search for songs";
            // 
            // AddDanceSongSearchInput
            // 
            this.AddDanceSongSearchInput.Location = new System.Drawing.Point(225, 141);
            this.AddDanceSongSearchInput.Name = "AddDanceSongSearchInput";
            this.AddDanceSongSearchInput.Size = new System.Drawing.Size(241, 27);
            this.AddDanceSongSearchInput.TabIndex = 4;
            this.AddDanceSongSearchInput.TextChanged += new System.EventHandler(this.AddDanceSongSearchInput_TextChanged);
            // 
            // AdddanceSongSearchResultList
            // 
            this.AdddanceSongSearchResultList.FormattingEnabled = true;
            this.AdddanceSongSearchResultList.ItemHeight = 20;
            this.AdddanceSongSearchResultList.Location = new System.Drawing.Point(225, 173);
            this.AdddanceSongSearchResultList.Name = "AdddanceSongSearchResultList";
            this.AdddanceSongSearchResultList.Size = new System.Drawing.Size(241, 84);
            this.AdddanceSongSearchResultList.TabIndex = 5;
            // 
            // AddDanceAddOriginalSongBtn
            // 
            this.AddDanceAddOriginalSongBtn.Location = new System.Drawing.Point(225, 275);
            this.AddDanceAddOriginalSongBtn.Name = "AddDanceAddOriginalSongBtn";
            this.AddDanceAddOriginalSongBtn.Size = new System.Drawing.Size(241, 39);
            this.AddDanceAddOriginalSongBtn.TabIndex = 6;
            this.AddDanceAddOriginalSongBtn.Text = "Add as original";
            this.AddDanceAddOriginalSongBtn.UseVisualStyleBackColor = true;
            this.AddDanceAddOriginalSongBtn.Click += new System.EventHandler(this.AddDanceAddOriginalSongBtn_Click);
            // 
            // AddDanceAddAlternativeSongBtn
            // 
            this.AddDanceAddAlternativeSongBtn.Location = new System.Drawing.Point(225, 315);
            this.AddDanceAddAlternativeSongBtn.Name = "AddDanceAddAlternativeSongBtn";
            this.AddDanceAddAlternativeSongBtn.Size = new System.Drawing.Size(241, 39);
            this.AddDanceAddAlternativeSongBtn.TabIndex = 7;
            this.AddDanceAddAlternativeSongBtn.Text = "Add as alternative";
            this.AddDanceAddAlternativeSongBtn.UseVisualStyleBackColor = true;
            this.AddDanceAddAlternativeSongBtn.Click += new System.EventHandler(this.AddDanceAddAlternativeSongBtn_Click);
            // 
            // AddDanceSave
            // 
            this.AddDanceSave.Location = new System.Drawing.Point(226, 387);
            this.AddDanceSave.Name = "AddDanceSave";
            this.AddDanceSave.Size = new System.Drawing.Size(117, 36);
            this.AddDanceSave.TabIndex = 8;
            this.AddDanceSave.Text = "Save";
            this.AddDanceSave.UseVisualStyleBackColor = true;
            this.AddDanceSave.Click += new System.EventHandler(this.AddDanceSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Original song";
            // 
            // AddDanceOriginalSongLabel
            // 
            this.AddDanceOriginalSongLabel.AutoSize = true;
            this.AddDanceOriginalSongLabel.Location = new System.Drawing.Point(573, 81);
            this.AddDanceOriginalSongLabel.Name = "AddDanceOriginalSongLabel";
            this.AddDanceOriginalSongLabel.Size = new System.Drawing.Size(105, 20);
            this.AddDanceOriginalSongLabel.TabIndex = 10;
            this.AddDanceOriginalSongLabel.Text = "Not yet added";
            this.AddDanceOriginalSongLabel.Click += new System.EventHandler(this.AddDanceOriginalSongLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alternative list";
            // 
            // AddDanceAlternativeSongListbox
            // 
            this.AddDanceAlternativeSongListbox.FormattingEnabled = true;
            this.AddDanceAlternativeSongListbox.ItemHeight = 20;
            this.AddDanceAlternativeSongListbox.Location = new System.Drawing.Point(545, 141);
            this.AddDanceAlternativeSongListbox.Name = "AddDanceAlternativeSongListbox";
            this.AddDanceAlternativeSongListbox.Size = new System.Drawing.Size(239, 164);
            this.AddDanceAlternativeSongListbox.TabIndex = 12;
            this.AddDanceAlternativeSongListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddDanceCancelBtn
            // 
            this.AddDanceCancelBtn.Location = new System.Drawing.Point(349, 387);
            this.AddDanceCancelBtn.Name = "AddDanceCancelBtn";
            this.AddDanceCancelBtn.Size = new System.Drawing.Size(117, 36);
            this.AddDanceCancelBtn.TabIndex = 13;
            this.AddDanceCancelBtn.Text = "Cancel";
            this.AddDanceCancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddDanceRemoveAlternative
            // 
            this.AddDanceRemoveAlternative.Location = new System.Drawing.Point(544, 315);
            this.AddDanceRemoveAlternative.Name = "AddDanceRemoveAlternative";
            this.AddDanceRemoveAlternative.Size = new System.Drawing.Size(241, 39);
            this.AddDanceRemoveAlternative.TabIndex = 14;
            this.AddDanceRemoveAlternative.Text = "Remove selected";
            this.AddDanceRemoveAlternative.UseVisualStyleBackColor = true;
            this.AddDanceRemoveAlternative.Click += new System.EventHandler(this.AddDanceRemoveAlternative_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dance Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddDanceDanceNameLabel
            // 
            this.AddDanceDanceNameLabel.AutoSize = true;
            this.AddDanceDanceNameLabel.Location = new System.Drawing.Point(573, 41);
            this.AddDanceDanceNameLabel.Name = "AddDanceDanceNameLabel";
            this.AddDanceDanceNameLabel.Size = new System.Drawing.Size(105, 20);
            this.AddDanceDanceNameLabel.TabIndex = 16;
            this.AddDanceDanceNameLabel.Text = "Not yet added";
            // 
            // AddDanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.AddDanceDanceNameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddDanceRemoveAlternative);
            this.Controls.Add(this.AddDanceCancelBtn);
            this.Controls.Add(this.AddDanceAlternativeSongListbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddDanceOriginalSongLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddDanceSave);
            this.Controls.Add(this.AddDanceAddAlternativeSongBtn);
            this.Controls.Add(this.AddDanceAddOriginalSongBtn);
            this.Controls.Add(this.AdddanceSongSearchResultList);
            this.Controls.Add(this.AddDanceSongSearchInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DanceNameLabel);
            this.Controls.Add(this.AddDanceDanceNameInput);
            this.Controls.Add(this.label1);
            this.Name = "AddDanceForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox AddDanceDanceNameInput;
        private Label DanceNameLabel;
        private Label label2;
        private TextBox AddDanceSongSearchInput;
        private ListBox AdddanceSongSearchResultList;
        private Button AddDanceAddOriginalSongBtn;
        private Button AddDanceAddAlternativeSongBtn;
        private Button AddDanceSave;
        private Label label3;
        private Label AddDanceOriginalSongLabel;
        private Label label4;
        private ListBox AddDanceAlternativeSongListbox;
        private Button AddDanceCancelBtn;
        private Button AddDanceRemoveAlternative;
        private Label label5;
        private Label AddDanceDanceNameLabel;
    }
}