namespace FormsUI
{
    partial class AssignMusician
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
            this.removeFromAssignedMusiciansButton = new System.Windows.Forms.Button();
            this.assignedMusiciansListBox = new System.Windows.Forms.ListBox();
            this.allMusiciansListBox = new System.Windows.Forms.ListBox();
            this.assignedMusiciansLabel = new System.Windows.Forms.Label();
            this.allMusiciansLabel = new System.Windows.Forms.Label();
            this.assignMusicianButton = new System.Windows.Forms.Button();
            this.DoneWithAssignmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeFromAssignedMusiciansButton
            // 
            this.removeFromAssignedMusiciansButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromAssignedMusiciansButton.Location = new System.Drawing.Point(248, 134);
            this.removeFromAssignedMusiciansButton.Name = "removeFromAssignedMusiciansButton";
            this.removeFromAssignedMusiciansButton.Size = new System.Drawing.Size(45, 47);
            this.removeFromAssignedMusiciansButton.TabIndex = 23;
            this.removeFromAssignedMusiciansButton.Text = "Rem <";
            this.removeFromAssignedMusiciansButton.UseVisualStyleBackColor = true;
            this.removeFromAssignedMusiciansButton.Click += new System.EventHandler(this.removeFromAssignedMusiciansButton_Click);
            // 
            // assignedMusiciansListBox
            // 
            this.assignedMusiciansListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedMusiciansListBox.FormattingEnabled = true;
            this.assignedMusiciansListBox.ItemHeight = 16;
            this.assignedMusiciansListBox.Location = new System.Drawing.Point(299, 35);
            this.assignedMusiciansListBox.Name = "assignedMusiciansListBox";
            this.assignedMusiciansListBox.Size = new System.Drawing.Size(230, 196);
            this.assignedMusiciansListBox.TabIndex = 22;
            // 
            // allMusiciansListBox
            // 
            this.allMusiciansListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allMusiciansListBox.FormattingEnabled = true;
            this.allMusiciansListBox.ItemHeight = 16;
            this.allMusiciansListBox.Location = new System.Drawing.Point(12, 35);
            this.allMusiciansListBox.Name = "allMusiciansListBox";
            this.allMusiciansListBox.Size = new System.Drawing.Size(230, 196);
            this.allMusiciansListBox.TabIndex = 21;
            // 
            // assignedMusiciansLabel
            // 
            this.assignedMusiciansLabel.AutoSize = true;
            this.assignedMusiciansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedMusiciansLabel.Location = new System.Drawing.Point(296, 15);
            this.assignedMusiciansLabel.Name = "assignedMusiciansLabel";
            this.assignedMusiciansLabel.Size = new System.Drawing.Size(132, 17);
            this.assignedMusiciansLabel.TabIndex = 20;
            this.assignedMusiciansLabel.Text = "Assigned Musicians";
            // 
            // allMusiciansLabel
            // 
            this.allMusiciansLabel.AutoSize = true;
            this.allMusiciansLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allMusiciansLabel.Location = new System.Drawing.Point(9, 15);
            this.allMusiciansLabel.Name = "allMusiciansLabel";
            this.allMusiciansLabel.Size = new System.Drawing.Size(89, 17);
            this.allMusiciansLabel.TabIndex = 19;
            this.allMusiciansLabel.Text = "All Musicians";
            // 
            // assignMusicianButton
            // 
            this.assignMusicianButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignMusicianButton.Location = new System.Drawing.Point(248, 69);
            this.assignMusicianButton.Name = "assignMusicianButton";
            this.assignMusicianButton.Size = new System.Drawing.Size(45, 47);
            this.assignMusicianButton.TabIndex = 18;
            this.assignMusicianButton.Text = "Add >";
            this.assignMusicianButton.UseVisualStyleBackColor = true;
            this.assignMusicianButton.Click += new System.EventHandler(this.assignMusicianButton_Click);
            // 
            // DoneWithAssignmentButton
            // 
            this.DoneWithAssignmentButton.Location = new System.Drawing.Point(218, 241);
            this.DoneWithAssignmentButton.Name = "DoneWithAssignmentButton";
            this.DoneWithAssignmentButton.Size = new System.Drawing.Size(112, 23);
            this.DoneWithAssignmentButton.TabIndex = 24;
            this.DoneWithAssignmentButton.Text = "Done";
            this.DoneWithAssignmentButton.UseVisualStyleBackColor = true;
            this.DoneWithAssignmentButton.Click += new System.EventHandler(this.DoneWithAssignmentButton_Click);
            // 
            // AssignMusician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 276);
            this.Controls.Add(this.DoneWithAssignmentButton);
            this.Controls.Add(this.removeFromAssignedMusiciansButton);
            this.Controls.Add(this.assignedMusiciansListBox);
            this.Controls.Add(this.allMusiciansListBox);
            this.Controls.Add(this.assignedMusiciansLabel);
            this.Controls.Add(this.allMusiciansLabel);
            this.Controls.Add(this.assignMusicianButton);
            this.Name = "AssignMusician";
            this.Text = "AssignMusician";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeFromAssignedMusiciansButton;
        private System.Windows.Forms.ListBox assignedMusiciansListBox;
        private System.Windows.Forms.ListBox allMusiciansListBox;
        private System.Windows.Forms.Label assignedMusiciansLabel;
        private System.Windows.Forms.Label allMusiciansLabel;
        private System.Windows.Forms.Button assignMusicianButton;
        private System.Windows.Forms.Button DoneWithAssignmentButton;
    }
}