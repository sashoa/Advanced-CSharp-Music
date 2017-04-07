namespace FormsUI
{
    partial class NewMusician
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
            this.addMusicianButton = new System.Windows.Forms.Button();
            this.musicianNameLabel = new System.Windows.Forms.Label();
            this.musicianNameTextBox = new System.Windows.Forms.TextBox();
            this.assignBandButton = new System.Windows.Forms.Button();
            this.allBandsLabel = new System.Windows.Forms.Label();
            this.assignedBandsLabel = new System.Windows.Forms.Label();
            this.allBandsListBox = new System.Windows.Forms.ListBox();
            this.assignedBandsListBox = new System.Windows.Forms.ListBox();
            this.removeFromAssignedBandsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMusicianButton
            // 
            this.addMusicianButton.Location = new System.Drawing.Point(185, 263);
            this.addMusicianButton.Margin = new System.Windows.Forms.Padding(4);
            this.addMusicianButton.Name = "addMusicianButton";
            this.addMusicianButton.Size = new System.Drawing.Size(175, 28);
            this.addMusicianButton.TabIndex = 0;
            this.addMusicianButton.Text = "Add Musician";
            this.addMusicianButton.UseVisualStyleBackColor = true;
            this.addMusicianButton.Click += new System.EventHandler(this.addMusicianButton_Click);
            // 
            // musicianNameLabel
            // 
            this.musicianNameLabel.AutoSize = true;
            this.musicianNameLabel.Location = new System.Drawing.Point(13, 9);
            this.musicianNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.musicianNameLabel.Name = "musicianNameLabel";
            this.musicianNameLabel.Size = new System.Drawing.Size(108, 17);
            this.musicianNameLabel.TabIndex = 1;
            this.musicianNameLabel.Text = "Musician Name:";
            // 
            // musicianNameTextBox
            // 
            this.musicianNameTextBox.Location = new System.Drawing.Point(129, 6);
            this.musicianNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.musicianNameTextBox.Name = "musicianNameTextBox";
            this.musicianNameTextBox.Size = new System.Drawing.Size(168, 23);
            this.musicianNameTextBox.TabIndex = 2;
            // 
            // assignBandButton
            // 
            this.assignBandButton.Location = new System.Drawing.Point(252, 90);
            this.assignBandButton.Name = "assignBandButton";
            this.assignBandButton.Size = new System.Drawing.Size(45, 47);
            this.assignBandButton.TabIndex = 0;
            this.assignBandButton.Text = "Add >";
            this.assignBandButton.UseVisualStyleBackColor = true;
            this.assignBandButton.Click += new System.EventHandler(this.assignBandButton_Click);
            // 
            // allBandsLabel
            // 
            this.allBandsLabel.AutoSize = true;
            this.allBandsLabel.Location = new System.Drawing.Point(13, 40);
            this.allBandsLabel.Name = "allBandsLabel";
            this.allBandsLabel.Size = new System.Drawing.Size(67, 17);
            this.allBandsLabel.TabIndex = 5;
            this.allBandsLabel.Text = "All Bands";
            // 
            // assignedBandsLabel
            // 
            this.assignedBandsLabel.AutoSize = true;
            this.assignedBandsLabel.Location = new System.Drawing.Point(300, 40);
            this.assignedBandsLabel.Name = "assignedBandsLabel";
            this.assignedBandsLabel.Size = new System.Drawing.Size(110, 17);
            this.assignedBandsLabel.TabIndex = 6;
            this.assignedBandsLabel.Text = "Assigned Bands";
            // 
            // allBandsListBox
            // 
            this.allBandsListBox.FormattingEnabled = true;
            this.allBandsListBox.ItemHeight = 16;
            this.allBandsListBox.Location = new System.Drawing.Point(16, 60);
            this.allBandsListBox.Name = "allBandsListBox";
            this.allBandsListBox.Size = new System.Drawing.Size(230, 196);
            this.allBandsListBox.TabIndex = 7;
            // 
            // assignedBandsListBox
            // 
            this.assignedBandsListBox.FormattingEnabled = true;
            this.assignedBandsListBox.ItemHeight = 16;
            this.assignedBandsListBox.Location = new System.Drawing.Point(303, 60);
            this.assignedBandsListBox.Name = "assignedBandsListBox";
            this.assignedBandsListBox.Size = new System.Drawing.Size(230, 196);
            this.assignedBandsListBox.TabIndex = 8;
            // 
            // removeFromAssignedBandsButton
            // 
            this.removeFromAssignedBandsButton.Location = new System.Drawing.Point(252, 163);
            this.removeFromAssignedBandsButton.Name = "removeFromAssignedBandsButton";
            this.removeFromAssignedBandsButton.Size = new System.Drawing.Size(45, 47);
            this.removeFromAssignedBandsButton.TabIndex = 10;
            this.removeFromAssignedBandsButton.Text = "Rem <";
            this.removeFromAssignedBandsButton.UseVisualStyleBackColor = true;
            this.removeFromAssignedBandsButton.Click += new System.EventHandler(this.removeFromAssignedBandsButton_Click);
            // 
            // NewMusician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 304);
            this.Controls.Add(this.removeFromAssignedBandsButton);
            this.Controls.Add(this.assignedBandsListBox);
            this.Controls.Add(this.allBandsListBox);
            this.Controls.Add(this.assignedBandsLabel);
            this.Controls.Add(this.allBandsLabel);
            this.Controls.Add(this.assignBandButton);
            this.Controls.Add(this.musicianNameTextBox);
            this.Controls.Add(this.musicianNameLabel);
            this.Controls.Add(this.addMusicianButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewMusician";
            this.Text = "NewMusician";
            this.Load += new System.EventHandler(this.NewMusician_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMusicianButton;
        private System.Windows.Forms.Label musicianNameLabel;
        private System.Windows.Forms.TextBox musicianNameTextBox;
        private System.Windows.Forms.Button assignBandButton;
        private System.Windows.Forms.Label allBandsLabel;
        private System.Windows.Forms.Label assignedBandsLabel;
        private System.Windows.Forms.ListBox allBandsListBox;
        private System.Windows.Forms.ListBox assignedBandsListBox;
        private System.Windows.Forms.Button removeFromAssignedBandsButton;
    }
}