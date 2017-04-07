namespace FormsUI
{
    partial class NewBand
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
            this.bandNameLabel = new System.Windows.Forms.Label();
            this.bandNameTextBox = new System.Windows.Forms.TextBox();
            this.bandAddLabel = new System.Windows.Forms.Button();
            this.assignedMusiciansListBox = new System.Windows.Forms.ListBox();
            this.allMusiciansListBox = new System.Windows.Forms.ListBox();
            this.assignedMusiciansLabel = new System.Windows.Forms.Label();
            this.allMusiciansLabel = new System.Windows.Forms.Label();
            this.assignMusicianButton = new System.Windows.Forms.Button();
            this.removeFromAssignedMusiciansButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bandNameLabel
            // 
            this.bandNameLabel.AutoSize = true;
            this.bandNameLabel.Location = new System.Drawing.Point(12, 32);
            this.bandNameLabel.Name = "bandNameLabel";
            this.bandNameLabel.Size = new System.Drawing.Size(49, 17);
            this.bandNameLabel.TabIndex = 1;
            this.bandNameLabel.Text = "Name:";
            // 
            // bandNameTextBox
            // 
            this.bandNameTextBox.Location = new System.Drawing.Point(67, 29);
            this.bandNameTextBox.Name = "bandNameTextBox";
            this.bandNameTextBox.Size = new System.Drawing.Size(227, 23);
            this.bandNameTextBox.TabIndex = 10;
            // 
            // bandAddLabel
            // 
            this.bandAddLabel.Location = new System.Drawing.Point(196, 300);
            this.bandAddLabel.Name = "bandAddLabel";
            this.bandAddLabel.Size = new System.Drawing.Size(157, 23);
            this.bandAddLabel.TabIndex = 11;
            this.bandAddLabel.Text = "Add Band";
            this.bandAddLabel.UseVisualStyleBackColor = true;
            this.bandAddLabel.Click += new System.EventHandler(this.bandAddLabel_Click);
            // 
            // assignedMusiciansListBox
            // 
            this.assignedMusiciansListBox.FormattingEnabled = true;
            this.assignedMusiciansListBox.ItemHeight = 16;
            this.assignedMusiciansListBox.Location = new System.Drawing.Point(302, 84);
            this.assignedMusiciansListBox.Name = "assignedMusiciansListBox";
            this.assignedMusiciansListBox.Size = new System.Drawing.Size(230, 196);
            this.assignedMusiciansListBox.TabIndex = 16;
            // 
            // allMusiciansListBox
            // 
            this.allMusiciansListBox.FormattingEnabled = true;
            this.allMusiciansListBox.ItemHeight = 16;
            this.allMusiciansListBox.Location = new System.Drawing.Point(15, 84);
            this.allMusiciansListBox.Name = "allMusiciansListBox";
            this.allMusiciansListBox.Size = new System.Drawing.Size(230, 196);
            this.allMusiciansListBox.TabIndex = 15;
            // 
            // assignedMusiciansLabel
            // 
            this.assignedMusiciansLabel.AutoSize = true;
            this.assignedMusiciansLabel.Location = new System.Drawing.Point(299, 64);
            this.assignedMusiciansLabel.Name = "assignedMusiciansLabel";
            this.assignedMusiciansLabel.Size = new System.Drawing.Size(132, 17);
            this.assignedMusiciansLabel.TabIndex = 14;
            this.assignedMusiciansLabel.Text = "Assigned Musicians";
            // 
            // allMusiciansLabel
            // 
            this.allMusiciansLabel.AutoSize = true;
            this.allMusiciansLabel.Location = new System.Drawing.Point(12, 64);
            this.allMusiciansLabel.Name = "allMusiciansLabel";
            this.allMusiciansLabel.Size = new System.Drawing.Size(89, 17);
            this.allMusiciansLabel.TabIndex = 13;
            this.allMusiciansLabel.Text = "All Musicians";
            // 
            // assignMusicianButton
            // 
            this.assignMusicianButton.Location = new System.Drawing.Point(251, 118);
            this.assignMusicianButton.Name = "assignMusicianButton";
            this.assignMusicianButton.Size = new System.Drawing.Size(45, 47);
            this.assignMusicianButton.TabIndex = 12;
            this.assignMusicianButton.Text = "Add >";
            this.assignMusicianButton.UseVisualStyleBackColor = true;
            this.assignMusicianButton.Click += new System.EventHandler(this.assignMusicianButton_Click);
            // 
            // removeFromAssignedMusiciansButton
            // 
            this.removeFromAssignedMusiciansButton.Location = new System.Drawing.Point(251, 183);
            this.removeFromAssignedMusiciansButton.Name = "removeFromAssignedMusiciansButton";
            this.removeFromAssignedMusiciansButton.Size = new System.Drawing.Size(45, 47);
            this.removeFromAssignedMusiciansButton.TabIndex = 17;
            this.removeFromAssignedMusiciansButton.Text = "Rem <";
            this.removeFromAssignedMusiciansButton.UseVisualStyleBackColor = true;
            this.removeFromAssignedMusiciansButton.Click += new System.EventHandler(this.removeFromAssignedMusiciansButton_Click);
            // 
            // NewBand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 334);
            this.Controls.Add(this.removeFromAssignedMusiciansButton);
            this.Controls.Add(this.assignedMusiciansListBox);
            this.Controls.Add(this.allMusiciansListBox);
            this.Controls.Add(this.assignedMusiciansLabel);
            this.Controls.Add(this.allMusiciansLabel);
            this.Controls.Add(this.assignMusicianButton);
            this.Controls.Add(this.bandAddLabel);
            this.Controls.Add(this.bandNameTextBox);
            this.Controls.Add(this.bandNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewBand";
            this.Text = "NewBand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bandNameLabel;
        private System.Windows.Forms.TextBox bandNameTextBox;
        private System.Windows.Forms.Button bandAddLabel;
        private System.Windows.Forms.ListBox assignedMusiciansListBox;
        private System.Windows.Forms.ListBox allMusiciansListBox;
        private System.Windows.Forms.Label assignedMusiciansLabel;
        private System.Windows.Forms.Label allMusiciansLabel;
        private System.Windows.Forms.Button assignMusicianButton;
        private System.Windows.Forms.Button removeFromAssignedMusiciansButton;
    }
}