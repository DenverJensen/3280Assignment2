
namespace Assignment2
{
    partial class Main
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
            this.lblTimesPlayed = new System.Windows.Forms.Label();
            this.groupGameInfo = new System.Windows.Forms.GroupBox();
            this.txtTimesPlayed = new System.Windows.Forms.TextBox();
            this.lblTimesWon = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupGameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimesPlayed
            // 
            this.lblTimesPlayed.AutoSize = true;
            this.lblTimesPlayed.Location = new System.Drawing.Point(38, 30);
            this.lblTimesPlayed.Name = "lblTimesPlayed";
            this.lblTimesPlayed.Size = new System.Drawing.Size(120, 13);
            this.lblTimesPlayed.TabIndex = 0;
            this.lblTimesPlayed.Text = "Number of times played:";
            this.lblTimesPlayed.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupGameInfo
            // 
            this.groupGameInfo.Controls.Add(this.textBox1);
            this.groupGameInfo.Controls.Add(this.lblTimesWon);
            this.groupGameInfo.Controls.Add(this.txtTimesPlayed);
            this.groupGameInfo.Location = new System.Drawing.Point(25, 13);
            this.groupGameInfo.Name = "groupGameInfo";
            this.groupGameInfo.Size = new System.Drawing.Size(226, 111);
            this.groupGameInfo.TabIndex = 1;
            this.groupGameInfo.TabStop = false;
            this.groupGameInfo.Text = "Game Info";
            this.groupGameInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTimesPlayed
            // 
            this.txtTimesPlayed.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimesPlayed.Location = new System.Drawing.Point(151, 14);
            this.txtTimesPlayed.Name = "txtTimesPlayed";
            this.txtTimesPlayed.Size = new System.Drawing.Size(53, 20);
            this.txtTimesPlayed.TabIndex = 0;
            // 
            // lblTimesWon
            // 
            this.lblTimesWon.AutoSize = true;
            this.lblTimesWon.Location = new System.Drawing.Point(13, 47);
            this.lblTimesWon.Name = "lblTimesWon";
            this.lblTimesWon.Size = new System.Drawing.Size(109, 13);
            this.lblTimesWon.TabIndex = 1;
            this.lblTimesWon.Text = "Number of times won:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 505);
            this.Controls.Add(this.lblTimesPlayed);
            this.Controls.Add(this.groupGameInfo);
            this.Name = "Main";
            this.Text = "Die Guess Game";
            this.groupGameInfo.ResumeLayout(false);
            this.groupGameInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimesPlayed;
        private System.Windows.Forms.GroupBox groupGameInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTimesWon;
        private System.Windows.Forms.TextBox txtTimesPlayed;
    }
}

