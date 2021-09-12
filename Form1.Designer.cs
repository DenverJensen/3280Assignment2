
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
            this.lblTimesLostResult = new System.Windows.Forms.Label();
            this.lblTimesWonResult = new System.Windows.Forms.Label();
            this.lblTimesPlayedResult = new System.Windows.Forms.Label();
            this.lblTimesLost = new System.Windows.Forms.Label();
            this.lblTimesWon = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.lblEnterGuess = new System.Windows.Forms.Label();
            this.txtEnterGuess = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.groupGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
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
            // 
            // groupGameInfo
            // 
            this.groupGameInfo.Controls.Add(this.lblTimesLostResult);
            this.groupGameInfo.Controls.Add(this.lblTimesWonResult);
            this.groupGameInfo.Controls.Add(this.lblTimesPlayedResult);
            this.groupGameInfo.Controls.Add(this.lblTimesPlayed);
            this.groupGameInfo.Controls.Add(this.lblTimesLost);
            this.groupGameInfo.Controls.Add(this.lblTimesWon);
            this.groupGameInfo.Location = new System.Drawing.Point(40, 33);
            this.groupGameInfo.Name = "groupGameInfo";
            this.groupGameInfo.Size = new System.Drawing.Size(238, 111);
            this.groupGameInfo.TabIndex = 1;
            this.groupGameInfo.TabStop = false;
            this.groupGameInfo.Text = "Game Info";
            // 
            // lblTimesLostResult
            // 
            this.lblTimesLostResult.AutoSize = true;
            this.lblTimesLostResult.Location = new System.Drawing.Point(166, 82);
            this.lblTimesLostResult.Name = "lblTimesLostResult";
            this.lblTimesLostResult.Size = new System.Drawing.Size(13, 13);
            this.lblTimesLostResult.TabIndex = 5;
            this.lblTimesLostResult.Text = "0";
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
            // lblTimesPlayedResult
            // 
            this.lblTimesPlayedResult.AutoSize = true;
            this.lblTimesPlayedResult.Location = new System.Drawing.Point(166, 22);
            this.lblTimesPlayedResult.Name = "lblTimesPlayedResult";
            this.lblTimesPlayedResult.Size = new System.Drawing.Size(13, 13);
            this.lblTimesPlayedResult.TabIndex = 3;
            this.lblTimesPlayedResult.Text = "0";
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
            // lblTimesWon
            // 
            this.lblTimesWon.AutoSize = true;
            this.lblTimesWon.Location = new System.Drawing.Point(13, 51);
            this.lblTimesWon.Name = "lblTimesWon";
            this.lblTimesWon.Size = new System.Drawing.Size(116, 13);
            this.lblTimesWon.TabIndex = 1;
            this.lblTimesWon.Text = "Number of Times Won:";
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(13, 271);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(464, 159);
            this.rtbResults.TabIndex = 2;
            this.rtbResults.Text = "Enter a guess to begin...";
            // 
            // lblEnterGuess
            // 
            this.lblEnterGuess.AutoSize = true;
            this.lblEnterGuess.Location = new System.Drawing.Point(53, 166);
            this.lblEnterGuess.Name = "lblEnterGuess";
            this.lblEnterGuess.Size = new System.Drawing.Size(113, 13);
            this.lblEnterGuess.TabIndex = 3;
            this.lblEnterGuess.Text = "Enter your guess (1-6):";
            this.lblEnterGuess.Click += new System.EventHandler(this.lblEnterGuess_Click);
            // 
            // txtEnterGuess
            // 
            this.txtEnterGuess.Location = new System.Drawing.Point(194, 163);
            this.txtEnterGuess.Name = "txtEnterGuess";
            this.txtEnterGuess.Size = new System.Drawing.Size(58, 20);
            this.txtEnterGuess.TabIndex = 4;
            this.txtEnterGuess.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(126, 208);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(301, 208);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(301, 33);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(138, 115);
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(258, 166);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(162, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Please enter a valid number (1-6)";
            this.lblError.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 451);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtEnterGuess);
            this.Controls.Add(this.lblEnterGuess);
            this.Controls.Add(this.rtbResults);
            this.Controls.Add(this.groupGameInfo);
            this.Name = "Main";
            this.Text = "Die Guess Game";
            this.groupGameInfo.ResumeLayout(false);
            this.groupGameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimesPlayed;
        private System.Windows.Forms.GroupBox groupGameInfo;
        private System.Windows.Forms.Label lblTimesWon;
        private System.Windows.Forms.Label lblTimesPlayedResult;
        private System.Windows.Forms.Label lblTimesLost;
        private System.Windows.Forms.Label lblTimesLostResult;
        private System.Windows.Forms.Label lblTimesWonResult;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Label lblEnterGuess;
        private System.Windows.Forms.TextBox txtEnterGuess;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblError;
    }
}

