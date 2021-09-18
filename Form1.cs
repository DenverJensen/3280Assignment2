using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace Assignment2
{
    /// <summary>
    /// Game board form for Die Guess game. Assignment 2
    /// 
    /// 
    /// created by Denver Jensen 09/12/2021
    /// </summary>
    public partial class Main : Form
    {
        #region Attributes
        /// <summary>
        /// Game object to roll dice and refresh stats
        /// </summary>
        public Game game;
        #endregion

        #region methods
        /// <summary>
        /// Main method for game operation
        /// </summary>
        public Main()
        {
            InitializeComponent();

            //create new game instance
            game = new Game();
        }


        /// <summary>
        /// validate user input is number 1-6 for dice roll. If not valid, show error label.
        /// If no errors, roll dice and update stats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoll_Click(object sender, EventArgs e)
        {
            int temp; //The current number in the guess
            if (!Int32.TryParse(txtEnterGuess.Text, out temp))
            {
                lblError.Visible = true;
            }
            else if (temp > 6 || temp < 1)
            {
                lblError.Visible = true;
            }
            else
            {
                //roll dice
                //this should be used to create relative reference, but not sure how to use it
                //MyImage.Source = new BitmapImage(new Uri(@"Images/die1.gif", UriKind.Relative));

                lblError.Visible = false;
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                for (int i = 1; i <= 6; i++)
                {
                    //shuffle thru die images to simulate roll 
                    pbImage.Image = Image.FromFile(@"images/die" + i.ToString() + ".gif");

                    //pbImage.Image = Image.FromFile("C:/Users/jense/OneDrive/Desktop/C#/Assignments/Assignment2/images/die" + i.ToString() + ".gif");
                    pbImage.Refresh();
                    Thread.Sleep(150);

                }
                //play round using guess if no errors
                int roll = game.playRound(Int32.Parse(txtEnterGuess.Text));
                pbImage.Image = Image.FromFile(@"images/die" + roll.ToString() + ".gif");

                //pbImage.Image = Image.FromFile("C:/Users/jense/OneDrive/Desktop/C#/Assignments/Assignment2/images/die" + roll.ToString() + ".gif");
                //refresh stats
                refreshStats();
            }

        }

        /// <summary>
        /// refresh stats for all dice
        /// </summary>
        private void refreshStats()
        {
            //refresh stats data
            rtbResults.Text = "";
            rtbResults.Text += "FACE | FREQUENCY | PERCENT | # OF TIMES GUESSED\n"; //headers
            putFormatLine((int)game.die1.face, game.die1.freq, game.die1.perc, game.die1.numGuessed);
            putFormatLine((int)game.die2.face, game.die2.freq, game.die2.perc, game.die2.numGuessed);
            putFormatLine((int)game.die3.face, game.die3.freq, game.die3.perc, game.die3.numGuessed);
            putFormatLine((int)game.die4.face, game.die4.freq, game.die4.perc, game.die4.numGuessed);
            putFormatLine((int)game.die5.face, game.die5.freq, game.die5.perc, game.die5.numGuessed);
            putFormatLine((int)game.die6.face, game.die6.freq, game.die6.perc, game.die6.numGuessed);
            //Updating the stats in the groupBox
            lblTimesPlayedResult.Text = game.gamesPlayed.ToString("N0");
            lblTimesWonResult.Text = game.gamesWon.ToString("N0");
            lblTimesLostResult.Text = game.gamesLost.ToString("N0");
            //Refreshing the whole window to update the stats.
            Refresh();
        }
        /// <summary>
        /// method to format a newline to the results textbox
        /// </summary>
        /// <param name="face">face of the dice</param>
        /// <param name="numRolled">number of times rolled</param>
        /// <param name="Rolled">the percentage of times rolled</param>
        /// <param name="guessed">number of times guessed</param>
        public void putFormatLine(int face, int numRolled, double Rolled, int guessed)
        {
            rtbResults.Text += String.Format("{0,-7} |          {1,-12} |      {2,-12:P2}| {3,15}\n", face, numRolled, Rolled, guessed);
        }

        /// <summary>
        /// method for resetting the main results textbox, guess textbox and refresh the stats on the gameboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            game = new Game();
            rtbResults.Text = "";
            txtEnterGuess.Text = null;
            refreshStats();
        }
        #endregion
    }
}
