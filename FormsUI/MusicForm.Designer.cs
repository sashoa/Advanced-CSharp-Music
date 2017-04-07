namespace FormsUI
{
    partial class Music
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
            this.artistsList = new System.Windows.Forms.ListBox();
            this.artistInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.assignToBandButton = new System.Windows.Forms.Button();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.addMusicianButton = new System.Windows.Forms.Button();
            this.artistTypeLabel = new System.Windows.Forms.Label();
            this.memberOfBandsOrNumOfMusiciansLabel = new System.Windows.Forms.Label();
            this.numOfSongsLabel = new System.Windows.Forms.Label();
            this.numOfAlbumsLabel = new System.Windows.Forms.Label();
            this.artistIdLabel = new System.Windows.Forms.Label();
            this.artistNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMusicianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollectionInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.averageAlbumDurationLabel = new System.Windows.Forms.Label();
            this.averageSongDurationLabel = new System.Windows.Forms.Label();
            this.longestTotalSongDuration = new System.Windows.Forms.Label();
            this.mostSongsLabel = new System.Windows.Forms.Label();
            this.mostRecordedAlbumsLabel = new System.Windows.Forms.Label();
            this.lastRecordedAlbumLabel = new System.Windows.Forms.Label();
            this.firstRecordedAlbumLabel = new System.Windows.Forms.Label();
            this.longestArtistNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.longestSongLabel = new System.Windows.Forms.Label();
            this.artistInfoGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.CollectionInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // artistsList
            // 
            this.artistsList.FormattingEnabled = true;
            this.artistsList.ItemHeight = 16;
            this.artistsList.Location = new System.Drawing.Point(13, 58);
            this.artistsList.Margin = new System.Windows.Forms.Padding(4);
            this.artistsList.Name = "artistsList";
            this.artistsList.Size = new System.Drawing.Size(265, 452);
            this.artistsList.TabIndex = 0;
            this.artistsList.SelectedIndexChanged += new System.EventHandler(this.artistsList_SelectedIndexChanged);
            // 
            // artistInfoGroupBox
            // 
            this.artistInfoGroupBox.Controls.Add(this.assignToBandButton);
            this.artistInfoGroupBox.Controls.Add(this.addAlbumButton);
            this.artistInfoGroupBox.Controls.Add(this.addMusicianButton);
            this.artistInfoGroupBox.Controls.Add(this.artistTypeLabel);
            this.artistInfoGroupBox.Controls.Add(this.memberOfBandsOrNumOfMusiciansLabel);
            this.artistInfoGroupBox.Controls.Add(this.numOfSongsLabel);
            this.artistInfoGroupBox.Controls.Add(this.numOfAlbumsLabel);
            this.artistInfoGroupBox.Controls.Add(this.artistIdLabel);
            this.artistInfoGroupBox.Controls.Add(this.artistNameLabel);
            this.artistInfoGroupBox.Location = new System.Drawing.Point(297, 58);
            this.artistInfoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.artistInfoGroupBox.Name = "artistInfoGroupBox";
            this.artistInfoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.artistInfoGroupBox.Size = new System.Drawing.Size(266, 173);
            this.artistInfoGroupBox.TabIndex = 1;
            this.artistInfoGroupBox.TabStop = false;
            this.artistInfoGroupBox.Text = "Artist";
            // 
            // assignToBandButton
            // 
            this.assignToBandButton.Location = new System.Drawing.Point(130, 140);
            this.assignToBandButton.Name = "assignToBandButton";
            this.assignToBandButton.Size = new System.Drawing.Size(124, 26);
            this.assignToBandButton.TabIndex = 8;
            this.assignToBandButton.Text = "Assign";
            this.assignToBandButton.UseVisualStyleBackColor = true;
            this.assignToBandButton.Click += new System.EventHandler(this.assignToBand_Click);
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Location = new System.Drawing.Point(11, 140);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(113, 26);
            this.addAlbumButton.TabIndex = 7;
            this.addAlbumButton.Text = "Add Album";
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);
            // 
            // addMusicianButton
            // 
            this.addMusicianButton.Location = new System.Drawing.Point(130, 140);
            this.addMusicianButton.Name = "addMusicianButton";
            this.addMusicianButton.Size = new System.Drawing.Size(124, 26);
            this.addMusicianButton.TabIndex = 6;
            this.addMusicianButton.Text = "Assign";
            this.addMusicianButton.UseVisualStyleBackColor = true;
            this.addMusicianButton.Click += new System.EventHandler(this.addMusicianButton_Click);
            // 
            // artistTypeLabel
            // 
            this.artistTypeLabel.AutoSize = true;
            this.artistTypeLabel.Location = new System.Drawing.Point(7, 22);
            this.artistTypeLabel.Name = "artistTypeLabel";
            this.artistTypeLabel.Size = new System.Drawing.Size(0, 17);
            this.artistTypeLabel.TabIndex = 5;
            // 
            // memberOfBandsOrNumOfMusiciansLabel
            // 
            this.memberOfBandsOrNumOfMusiciansLabel.AutoSize = true;
            this.memberOfBandsOrNumOfMusiciansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberOfBandsOrNumOfMusiciansLabel.Location = new System.Drawing.Point(8, 107);
            this.memberOfBandsOrNumOfMusiciansLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberOfBandsOrNumOfMusiciansLabel.Name = "memberOfBandsOrNumOfMusiciansLabel";
            this.memberOfBandsOrNumOfMusiciansLabel.Size = new System.Drawing.Size(0, 17);
            this.memberOfBandsOrNumOfMusiciansLabel.TabIndex = 4;
            // 
            // numOfSongsLabel
            // 
            this.numOfSongsLabel.AutoSize = true;
            this.numOfSongsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfSongsLabel.Location = new System.Drawing.Point(8, 90);
            this.numOfSongsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numOfSongsLabel.Name = "numOfSongsLabel";
            this.numOfSongsLabel.Size = new System.Drawing.Size(0, 17);
            this.numOfSongsLabel.TabIndex = 3;
            // 
            // numOfAlbumsLabel
            // 
            this.numOfAlbumsLabel.AutoSize = true;
            this.numOfAlbumsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfAlbumsLabel.Location = new System.Drawing.Point(8, 73);
            this.numOfAlbumsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numOfAlbumsLabel.Name = "numOfAlbumsLabel";
            this.numOfAlbumsLabel.Size = new System.Drawing.Size(0, 17);
            this.numOfAlbumsLabel.TabIndex = 2;
            this.numOfAlbumsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // artistIdLabel
            // 
            this.artistIdLabel.AutoSize = true;
            this.artistIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistIdLabel.Location = new System.Drawing.Point(8, 39);
            this.artistIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistIdLabel.Name = "artistIdLabel";
            this.artistIdLabel.Size = new System.Drawing.Size(0, 17);
            this.artistIdLabel.TabIndex = 1;
            // 
            // artistNameLabel
            // 
            this.artistNameLabel.AutoSize = true;
            this.artistNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistNameLabel.Location = new System.Drawing.Point(8, 56);
            this.artistNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistNameLabel.Name = "artistNameLabel";
            this.artistNameLabel.Size = new System.Drawing.Size(0, 17);
            this.artistNameLabel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBandToolStripMenuItem,
            this.newMusicianToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newBandToolStripMenuItem
            // 
            this.newBandToolStripMenuItem.Name = "newBandToolStripMenuItem";
            this.newBandToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newBandToolStripMenuItem.Text = "New Band";
            this.newBandToolStripMenuItem.Click += new System.EventHandler(this.newBandToolStripMenuItem_Click);
            // 
            // newMusicianToolStripMenuItem
            // 
            this.newMusicianToolStripMenuItem.Name = "newMusicianToolStripMenuItem";
            this.newMusicianToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newMusicianToolStripMenuItem.Text = "New Musician";
            this.newMusicianToolStripMenuItem.Click += new System.EventHandler(this.newMusicianToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // CollectionInfoGroupBox
            // 
            this.CollectionInfoGroupBox.Controls.Add(this.longestSongLabel);
            this.CollectionInfoGroupBox.Controls.Add(this.averageAlbumDurationLabel);
            this.CollectionInfoGroupBox.Controls.Add(this.averageSongDurationLabel);
            this.CollectionInfoGroupBox.Controls.Add(this.longestTotalSongDuration);
            this.CollectionInfoGroupBox.Controls.Add(this.mostSongsLabel);
            this.CollectionInfoGroupBox.Controls.Add(this.mostRecordedAlbumsLabel);
            this.CollectionInfoGroupBox.Controls.Add(this.lastRecordedAlbumLabel);
            this.CollectionInfoGroupBox.Controls.Add(this.firstRecordedAlbumLabel);
            this.CollectionInfoGroupBox.Controls.Add(this.longestArtistNameLabel);
            this.CollectionInfoGroupBox.Location = new System.Drawing.Point(297, 261);
            this.CollectionInfoGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CollectionInfoGroupBox.Name = "CollectionInfoGroupBox";
            this.CollectionInfoGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.CollectionInfoGroupBox.Size = new System.Drawing.Size(459, 249);
            this.CollectionInfoGroupBox.TabIndex = 3;
            this.CollectionInfoGroupBox.TabStop = false;
            this.CollectionInfoGroupBox.Text = "Collection Info";
            // 
            // averageAlbumDurationLabel
            // 
            this.averageAlbumDurationLabel.AutoSize = true;
            this.averageAlbumDurationLabel.Location = new System.Drawing.Point(7, 154);
            this.averageAlbumDurationLabel.Name = "averageAlbumDurationLabel";
            this.averageAlbumDurationLabel.Size = new System.Drawing.Size(46, 17);
            this.averageAlbumDurationLabel.TabIndex = 11;
            this.averageAlbumDurationLabel.Text = "label3";
            // 
            // averageSongDurationLabel
            // 
            this.averageSongDurationLabel.AutoSize = true;
            this.averageSongDurationLabel.Location = new System.Drawing.Point(6, 137);
            this.averageSongDurationLabel.Name = "averageSongDurationLabel";
            this.averageSongDurationLabel.Size = new System.Drawing.Size(46, 17);
            this.averageSongDurationLabel.TabIndex = 10;
            this.averageSongDurationLabel.Text = "label2";
            // 
            // longestTotalSongDuration
            // 
            this.longestTotalSongDuration.AutoSize = true;
            this.longestTotalSongDuration.Location = new System.Drawing.Point(6, 120);
            this.longestTotalSongDuration.Name = "longestTotalSongDuration";
            this.longestTotalSongDuration.Size = new System.Drawing.Size(46, 17);
            this.longestTotalSongDuration.TabIndex = 7;
            this.longestTotalSongDuration.Text = "label9";
            // 
            // mostSongsLabel
            // 
            this.mostSongsLabel.AutoSize = true;
            this.mostSongsLabel.Location = new System.Drawing.Point(6, 103);
            this.mostSongsLabel.Name = "mostSongsLabel";
            this.mostSongsLabel.Size = new System.Drawing.Size(46, 17);
            this.mostSongsLabel.TabIndex = 5;
            this.mostSongsLabel.Text = "label7";
            // 
            // mostRecordedAlbumsLabel
            // 
            this.mostRecordedAlbumsLabel.AutoSize = true;
            this.mostRecordedAlbumsLabel.Location = new System.Drawing.Point(7, 71);
            this.mostRecordedAlbumsLabel.Name = "mostRecordedAlbumsLabel";
            this.mostRecordedAlbumsLabel.Size = new System.Drawing.Size(46, 17);
            this.mostRecordedAlbumsLabel.TabIndex = 3;
            this.mostRecordedAlbumsLabel.Text = "label5";
            // 
            // lastRecordedAlbumLabel
            // 
            this.lastRecordedAlbumLabel.AutoSize = true;
            this.lastRecordedAlbumLabel.Location = new System.Drawing.Point(7, 54);
            this.lastRecordedAlbumLabel.Name = "lastRecordedAlbumLabel";
            this.lastRecordedAlbumLabel.Size = new System.Drawing.Size(46, 17);
            this.lastRecordedAlbumLabel.TabIndex = 2;
            this.lastRecordedAlbumLabel.Text = "label4";
            // 
            // firstRecordedAlbumLabel
            // 
            this.firstRecordedAlbumLabel.AutoSize = true;
            this.firstRecordedAlbumLabel.Location = new System.Drawing.Point(7, 37);
            this.firstRecordedAlbumLabel.Name = "firstRecordedAlbumLabel";
            this.firstRecordedAlbumLabel.Size = new System.Drawing.Size(46, 17);
            this.firstRecordedAlbumLabel.TabIndex = 1;
            this.firstRecordedAlbumLabel.Text = "label3";
            // 
            // longestArtistNameLabel
            // 
            this.longestArtistNameLabel.AutoSize = true;
            this.longestArtistNameLabel.Location = new System.Drawing.Point(7, 20);
            this.longestArtistNameLabel.Name = "longestArtistNameLabel";
            this.longestArtistNameLabel.Size = new System.Drawing.Size(46, 17);
            this.longestArtistNameLabel.TabIndex = 0;
            this.longestArtistNameLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Artists Type:";
            // 
            // longestSongLabel
            // 
            this.longestSongLabel.AutoSize = true;
            this.longestSongLabel.Location = new System.Drawing.Point(7, 88);
            this.longestSongLabel.Name = "longestSongLabel";
            this.longestSongLabel.Size = new System.Drawing.Size(46, 17);
            this.longestSongLabel.TabIndex = 13;
            this.longestSongLabel.Text = "label5";
            // 
            // Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CollectionInfoGroupBox);
            this.Controls.Add(this.artistInfoGroupBox);
            this.Controls.Add(this.artistsList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Music";
            this.Text = "Music Collection";
            this.artistInfoGroupBox.ResumeLayout(false);
            this.artistInfoGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CollectionInfoGroupBox.ResumeLayout(false);
            this.CollectionInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox artistsList;
        private System.Windows.Forms.GroupBox artistInfoGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMusicianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.GroupBox CollectionInfoGroupBox;
        private System.Windows.Forms.Label numOfAlbumsLabel;
        private System.Windows.Forms.Label artistIdLabel;
        private System.Windows.Forms.Label artistNameLabel;
        private System.Windows.Forms.Label memberOfBandsOrNumOfMusiciansLabel;
        private System.Windows.Forms.Label numOfSongsLabel;
        private System.Windows.Forms.Label artistTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label longestTotalSongDuration;
        private System.Windows.Forms.Label mostSongsLabel;
        private System.Windows.Forms.Label mostRecordedAlbumsLabel;
        private System.Windows.Forms.Label lastRecordedAlbumLabel;
        private System.Windows.Forms.Label firstRecordedAlbumLabel;
        private System.Windows.Forms.Label longestArtistNameLabel;
        private System.Windows.Forms.Label averageAlbumDurationLabel;
        private System.Windows.Forms.Label averageSongDurationLabel;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Button addMusicianButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button assignToBandButton;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.Label longestSongLabel;
    }
}

