
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
            this.lblTimesWon = new System.Windows.Forms.Label();
            this.lblTimesLost = new System.Windows.Forms.Label();
            this.lblTimesPlayedResult = new System.Windows.Forms.Label();
            this.lblTimesWonResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupGameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimesPlayed
            // 
            this.lblTimesPlayed.AutoSize = true;
            this.lblTimesPlayed.Location = new System.Drawing.Point(13, 22);
            this.lblTimesPlayed.Name = "lblTimesPlayed";
            this.lblTimesPlayed.Size = new System.Drawing.Size(125, 13);
            this.lblTimesPlayed.TabIndex = 0;
            this.lblTimesPlayed.Text = "Number of Times Played:";
            this.lblTimesPlayed.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupGameInfo
            // 
            this.groupGameInfo.Controls.Add(this.label1);
            this.groupGameInfo.Controls.Add(this.lblTimesWonResult);
            this.groupGameInfo.Controls.Add(this.lblTimesPlayedResult);
            this.groupGameInfo.Controls.Add(this.lblTimesPlayed);
            this.groupGameInfo.Controls.Add(this.lblTimesLost);
            this.groupGameInfo.Controls.Add(this.lblTimesWon);
            this.groupGameInfo.Location = new System.Drawing.Point(40, 33);
            this.groupGameInfo.Name = "groupGameInfo";
            this.groupGameInfo.Size = new System.Drawing.Size(226, 111);
            this.groupGameInfo.TabIndex = 1;
            this.groupGameInfo.TabStop = false;
            this.groupGameInfo.Text = "Game Info";
            this.groupGameInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTimesWon
            // 
            this.lblTimesWon.AutoSize = true;
            this.lblTimesWon.Location = new System.Drawing.Point(13, 51);
            this.lblTimesWon.Name = "lblTimesWon";
            this.lblTimesWon.Size = new System.Drawing.Size(116, 13);
            this.lblTimesWon.TabIndex = 1;
            this.lblTimesWon.Text = "Number of Times Won:";
            // 
            // lblTimesLost
            // 
            this.lblTimesLost.AutoSize = true;
            this.lblTimesLost.Location = new System.Drawing.Point(13, 82);
            this.lblTimesLost.Name = "lblTimesLost";
            this.lblTimesLost.Size = new System.Drawing.Size(113, 13);
            this.lblTimesLost.TabIndex = 2;
            this.lblTimesLost.Text = "Number of Times Lost:";
            // 
            // lblTimesPlayedResult
            // 
            this.lblTimesPlayedResult.AutoSize = true;
            this.lblTimesPlayedResult.Location = new System.Drawing.Point(166, 22);
            this.lblTimesPlayedResult.Name = "lblTimesPlayedResult";
            this.lblTimesPlayedResult.Size = new System.Drawing.Size(13, 13);
            this.lblTimesPlayedResult.TabIndex = 3;
            this.lblTimesPlayedResult.Text = "0";
            // 
            // lblTimesWonResult
            // 
            this.lblTimesWonResult.AutoSize = true;
            this.lblTimesWonResult.Location = new System.Drawing.Point(166, 51);
            this.lblTimesWonResult.Name = "lblTimesWonResult";
            this.lblTimesWonResult.Size = new System.Drawing.Size(13, 13);
            this.lblTimesWonResult.TabIndex = 4;
            this.lblTimesWonResult.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 334);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(613, 159);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 505);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupGameInfo);
            this.Name = "Main";
            this.Text = "Die Guess Game";
            this.groupGameInfo.ResumeLayout(false);
            this.groupGameInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTimesPlayed;
        private System.Windows.Forms.GroupBox groupGameInfo;
        private System.Windows.Forms.Label lblTimesWon;
        private System.Windows.Forms.Label lblTimesPlayedResult;
        private System.Windows.Forms.Label lblTimesLost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimesWonResult;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

