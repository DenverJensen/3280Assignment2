using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public partial class Game
    {


        #region Attributes
        /// <summary>
        /// The total number of games played. 
        /// </summary>
        public int gamesPlayed;
        /// <summary>
        /// The total number of games Won.  
        /// </summary>
        public int gamesWon;
        /// <summary>
        /// The total number of games Lost.
        /// </summary>
        public int gamesLost;
        /// <summary>
        /// The Random dice roll.
        /// </summary>
        public Random random;
        /// <summary>
        /// The stats for dice 1;
        /// </summary>
        public Die die1;
        /// <summary>
        /// The stats for dice 2;
        /// </summary>
        public Die die2;
        /// <summary>
        /// The stats for dice 3;
        /// </summary>
        public Die die3;
        /// <summary>
        /// The stats for dice 4;
        /// </summary>
        public Die die4;
        /// <summary>
        /// The stats for dice 5;
        /// </summary>
        public Die die5;
        /// <summary>
        /// The stats for dice 6;
        /// </summary>
        public Die die6;
        #endregion
        #region Constructor
        /// <summary>
        /// Constructs a new Game object, setting everything to zero and making new dice with new stats.
        /// </summary>
        public Game()
        {
            //new instances of all items
            gamesPlayed = gamesWon = gamesLost = 0;
            random = new Random();
            die1 = new Die(Die.Face.one);
            die2 = new Die(Die.Face.two);
            die3 = new Die(Die.Face.three);
            die4 = new Die(Die.Face.four);
            die5 = new Die(Die.Face.five);
            die6 = new Die(Die.Face.six);

        }
        #endregion
        #region methods
        /// <summary>
        /// increments the games won/lost fields and all stats for specific die
        /// </summary>
        /// <param name="guess">user input guess from gameboard</param>
        /// <returns></returns>
        public int playRound(int guess)
        {
            int roll = random.Next(1, 7);
            gamesPlayed++;
            if (roll == guess)
            {
                gamesWon++;
            }
            else
            {
                gamesLost++;
            }
            //update frequency and roll %
            switch (roll)
            {
                case 1:
                    refreshPercent();
                    die1.freq++;
                    break;
                case 2:
                    refreshPercent();
                    die2.freq++;
                    break;
                case 3:
                    refreshPercent();
                    die3.freq++;
                    break;
                case 4:
                    refreshPercent();
                    die4.freq++;
                    break;
                case 5:
                    refreshPercent();
                    die5.freq++;
                    break;
                case 6:
                    refreshPercent();
                    die6.freq++;
                    break;
                default:
                    break;
            }
            //Incrementing the guess
            switch (guess)
            {
                case 1:
                    die1.numGuessed++;
                    break;
                case 2:
                    die2.numGuessed++;
                    break;
                case 3:
                    die3.numGuessed++;
                    break;
                case 4:
                    die4.numGuessed++;
                    break;
                case 5:
                    die5.numGuessed++;
                    break;
                case 6:
                    die6.numGuessed++;
                    break;
                default:
                    break;
            }
            refreshPercent();
            return roll;
        }
        /// <summary>
        /// Method used for refreshing all of the die percentages each roll.
        /// </summary>
        private void refreshPercent()
        {
            die1.perc = ((double)die1.freq / (double)gamesPlayed);
            die2.perc = ((double)die2.freq / (double)gamesPlayed);
            die3.perc = ((double)die3.freq / (double)gamesPlayed);
            die4.perc = ((double)die4.freq / (double)gamesPlayed);
            die5.perc = ((double)die5.freq / (double)gamesPlayed);
            die6.perc = ((double)die6.freq / (double)gamesPlayed);
        }
        #endregion
    }
}
