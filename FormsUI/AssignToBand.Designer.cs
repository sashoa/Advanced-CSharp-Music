namespace FormsUI
{
    partial class AssignToBand
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
            this.DoneWithAssignmentButton = new System.Windows.Forms.Button();
            this.removeFromAssignedBandsButton = new System.Windows.Forms.Button();
            this.assignedBandsListBox = new System.Windows.Forms.ListBox();
            this.allBandsListBox = new System.Windows.Forms.ListBox();
            this.assignedBandsLabel = new System.Windows.Forms.Label();
            this.allBandsLabel = new System.Windows.Forms.Label();
            this.assignBandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoneWithAssignmentButton
            // 
            this.DoneWithAssignmentButton.Location = new System.Drawing.Point(218, 243);
            this.DoneWithAssignmentButton.Name = "DoneWithAssignmentButton";
            this.DoneWithAssignmentButton.Size = new System.Drawing.Size(112, 29);
            this.DoneWithAssignmentButton.TabIndex = 31;
            this.DoneWithAssignmentButton.Text = "Done";
            this.DoneWithAssignmentButton.UseVisualStyleBackColor = true;
            this.DoneWithAssignmentButton.Click += new System.EventHandler(this.DoneWithAssignmentButton_Click);
            // 
            // removeFromAssignedBandsButton
            // 
            this.removeFromAssignedBandsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromAssignedBandsButton.Location = new System.Drawing.Point(248, 136);
            this.removeFromAssignedBandsButton.Name = "removeFromAssignedBandsButton";
            this.removeFromAssignedBandsButton.Size = new System.Drawing.Size(45, 47);
            this.removeFromAssignedBandsButton.TabIndex = 30;
            this.removeFromAssignedBandsButton.Text = "Rem <";
            this.removeFromAssignedBandsButton.UseVisualStyleBackColor = true;
            this.removeFromAssignedBandsButton.Click += new System.EventHandler(this.removeFromAssignedBandsButton_Click);
            // 
            // assignedBandsListBox
            // 
            this.assignedBandsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedBandsListBox.FormattingEnabled = true;
            this.assignedBandsListBox.ItemHeight = 16;
            this.assignedBandsListBox.Location = new System.Drawing.Point(299, 37);
            this.assignedBandsListBox.Name = "assignedBandsListBox";
            this.assignedBandsListBox.Size = new System.Drawing.Size(230, 196);
            this.assignedBandsListBox.TabIndex = 29;
            // 
            // allBandsListBox
            // 
            this.allBandsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBandsListBox.FormattingEnabled = true;
            this.allBandsListBox.ItemHeight = 16;
            this.allBandsListBox.Location = new System.Drawing.Point(12, 37);
            this.allBandsListBox.Name = "allBandsListBox";
            this.allBandsListBox.Size = new System.Drawing.Size(230, 196);
            this.allBandsListBox.TabIndex = 28;
            // 
            // assignedBandsLabel
            // 
            this.assignedBandsLabel.AutoSize = true;
            this.assignedBandsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedBandsLabel.Location = new System.Drawing.Point(296, 17);
            this.assignedBandsLabel.Name = "assignedBandsLabel";
            this.assignedBandsLabel.Size = new System.Drawing.Size(110, 17);
            this.assignedBandsLabel.TabIndex = 27;
            this.assignedBandsLabel.Text = "Assigned Bands";
            // 
            // allBandsLabel
            // 
            this.allBandsLabel.AutoSize = true;
            this.allBandsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBandsLabel.Location = new System.Drawing.Point(9, 17);
            this.allBandsLabel.Name = "allBandsLabel";
            this.allBandsLabel.Size = new System.Drawing.Size(67, 17);
            this.allBandsLabel.TabIndex = 26;
            this.allBandsLabel.Text = "All Bands";
            // 
            // assignBandButton
            // 
            this.assignBandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignBandButton.Location = new System.Drawing.Point(248, 71);
            this.assignBandButton.Name = "assignBandButton";
            this.assignBandButton.Size = new System.Drawing.Size(45, 47);
            this.assignBandButton.TabIndex = 25;
            this.assignBandButton.Text = "Add >";
            this.assignBandButton.UseVisualStyleBackColor = true;
            this.assignBandButton.Click += new System.EventHandler(this.assignBandButton_Click);
            // 
            // AssignToBand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 284);
            this.Controls.Add(this.DoneWithAssignmentButton);
            this.Controls.Add(this.removeFromAssignedBandsButton);
            this.Controls.Add(this.assignedBandsListBox);
            this.Controls.Add(this.allBandsListBox);
            this.Controls.Add(this.assignedBandsLabel);
            this.Controls.Add(this.allBandsLabel);
            this.Controls.Add(this.assignBandButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignToBand";
            this.Text = "AssignToBand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneWithAssignmentButton;
        private System.Windows.Forms.Button removeFromAssignedBandsButton;
        private System.Windows.Forms.ListBox assignedBandsListBox;
        private System.Windows.Forms.ListBox allBandsListBox;
        private System.Windows.Forms.Label assignedBandsLabel;
        private System.Windows.Forms.Label allBandsLabel;
        private System.Windows.Forms.Button assignBandButton;
    }
}