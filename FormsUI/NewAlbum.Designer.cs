namespace FormsUI
{
    partial class NewAlbum
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
            this.albumNameLabel = new System.Windows.Forms.Label();
            this.albumNameTextBox = new System.Windows.Forms.TextBox();
            this.songNameTextBox = new System.Windows.Forms.TextBox();
            this.addSongsLabel = new System.Windows.Forms.Label();
            this.addSongButton = new System.Windows.Forms.Button();
            this.publishAlbumButton = new System.Windows.Forms.Button();
            this.songsListBox = new System.Windows.Forms.ListBox();
            this.songsLabel = new System.Windows.Forms.Label();
            this.dateOfPupblicationLabel = new System.Windows.Forms.Label();
            this.albumPublicationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.songName = new System.Windows.Forms.Label();
            this.songDurationLabel = new System.Windows.Forms.Label();
            this.songDurationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // albumNameLabel
            // 
            this.albumNameLabel.AutoSize = true;
            this.albumNameLabel.Location = new System.Drawing.Point(92, 19);
            this.albumNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumNameLabel.Name = "albumNameLabel";
            this.albumNameLabel.Size = new System.Drawing.Size(92, 17);
            this.albumNameLabel.TabIndex = 0;
            this.albumNameLabel.Text = "Album Name:";
            // 
            // albumNameTextBox
            // 
            this.albumNameTextBox.Location = new System.Drawing.Point(192, 16);
            this.albumNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumNameTextBox.Name = "albumNameTextBox";
            this.albumNameTextBox.Size = new System.Drawing.Size(287, 23);
            this.albumNameTextBox.TabIndex = 1;
            // 
            // songNameTextBox
            // 
            this.songNameTextBox.Location = new System.Drawing.Point(384, 118);
            this.songNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.songNameTextBox.Name = "songNameTextBox";
            this.songNameTextBox.Size = new System.Drawing.Size(178, 23);
            this.songNameTextBox.TabIndex = 2;
            // 
            // addSongsLabel
            // 
            this.addSongsLabel.AutoSize = true;
            this.addSongsLabel.Location = new System.Drawing.Point(294, 92);
            this.addSongsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addSongsLabel.Name = "addSongsLabel";
            this.addSongsLabel.Size = new System.Drawing.Size(81, 17);
            this.addSongsLabel.TabIndex = 3;
            this.addSongsLabel.Text = "Add Songs:";
            // 
            // addSongButton
            // 
            this.addSongButton.Location = new System.Drawing.Point(297, 186);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(83, 26);
            this.addSongButton.TabIndex = 0;
            this.addSongButton.Text = "Add Song";
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // publishAlbumButton
            // 
            this.publishAlbumButton.Location = new System.Drawing.Point(233, 325);
            this.publishAlbumButton.Name = "publishAlbumButton";
            this.publishAlbumButton.Size = new System.Drawing.Size(144, 23);
            this.publishAlbumButton.TabIndex = 5;
            this.publishAlbumButton.Text = "Publish Album";
            this.publishAlbumButton.UseVisualStyleBackColor = true;
            this.publishAlbumButton.Click += new System.EventHandler(this.publishAlbumButton_Click);
            // 
            // songsListBox
            // 
            this.songsListBox.FormattingEnabled = true;
            this.songsListBox.ItemHeight = 16;
            this.songsListBox.Location = new System.Drawing.Point(12, 106);
            this.songsListBox.Name = "songsListBox";
            this.songsListBox.Size = new System.Drawing.Size(255, 196);
            this.songsListBox.TabIndex = 6;
            // 
            // songsLabel
            // 
            this.songsLabel.AutoSize = true;
            this.songsLabel.Location = new System.Drawing.Point(9, 86);
            this.songsLabel.Name = "songsLabel";
            this.songsLabel.Size = new System.Drawing.Size(52, 17);
            this.songsLabel.TabIndex = 7;
            this.songsLabel.Text = "Songs:";
            // 
            // dateOfPupblicationLabel
            // 
            this.dateOfPupblicationLabel.AutoSize = true;
            this.dateOfPupblicationLabel.Location = new System.Drawing.Point(92, 47);
            this.dateOfPupblicationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateOfPupblicationLabel.Name = "dateOfPupblicationLabel";
            this.dateOfPupblicationLabel.Size = new System.Drawing.Size(134, 17);
            this.dateOfPupblicationLabel.TabIndex = 8;
            this.dateOfPupblicationLabel.Text = "Date Of Publication:";
            // 
            // albumPublicationDateTimePicker
            // 
            this.albumPublicationDateTimePicker.Location = new System.Drawing.Point(233, 43);
            this.albumPublicationDateTimePicker.Name = "albumPublicationDateTimePicker";
            this.albumPublicationDateTimePicker.Size = new System.Drawing.Size(246, 23);
            this.albumPublicationDateTimePicker.TabIndex = 9;
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Location = new System.Drawing.Point(294, 121);
            this.songName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(86, 17);
            this.songName.TabIndex = 10;
            this.songName.Text = "Song Name:";
            // 
            // songDurationLabel
            // 
            this.songDurationLabel.AutoSize = true;
            this.songDurationLabel.Location = new System.Drawing.Point(294, 152);
            this.songDurationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songDurationLabel.Name = "songDurationLabel";
            this.songDurationLabel.Size = new System.Drawing.Size(103, 17);
            this.songDurationLabel.TabIndex = 12;
            this.songDurationLabel.Text = "Song Duration:";
            // 
            // songDurationTextBox
            // 
            this.songDurationTextBox.Location = new System.Drawing.Point(400, 149);
            this.songDurationTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.songDurationTextBox.Name = "songDurationTextBox";
            this.songDurationTextBox.Size = new System.Drawing.Size(162, 23);
            this.songDurationTextBox.TabIndex = 11;
            // 
            // NewAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 360);
            this.Controls.Add(this.songDurationLabel);
            this.Controls.Add(this.songDurationTextBox);
            this.Controls.Add(this.songName);
            this.Controls.Add(this.albumPublicationDateTimePicker);
            this.Controls.Add(this.dateOfPupblicationLabel);
            this.Controls.Add(this.songsLabel);
            this.Controls.Add(this.songsListBox);
            this.Controls.Add(this.publishAlbumButton);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.addSongsLabel);
            this.Controls.Add(this.songNameTextBox);
            this.Controls.Add(this.albumNameTextBox);
            this.Controls.Add(this.albumNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewAlbum";
            this.Text = "NewAlbum";
            this.Load += new System.EventHandler(this.NewAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label albumNameLabel;
        private System.Windows.Forms.TextBox albumNameTextBox;
        private System.Windows.Forms.TextBox songNameTextBox;
        private System.Windows.Forms.Label addSongsLabel;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Button publishAlbumButton;
        private System.Windows.Forms.ListBox songsListBox;
        private System.Windows.Forms.Label songsLabel;
        private System.Windows.Forms.Label dateOfPupblicationLabel;
        private System.Windows.Forms.DateTimePicker albumPublicationDateTimePicker;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label songDurationLabel;
        private System.Windows.Forms.TextBox songDurationTextBox;
    }
}