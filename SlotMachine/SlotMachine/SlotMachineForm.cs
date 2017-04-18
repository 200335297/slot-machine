using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Gowtham Talluri
//ID: 200335297
//AppName: SlotMachine
//Description: Play the slot game

namespace SlotMachine
{
    public partial class SlotMachineForm : Form
    {
        private int playerMoney = 1000;
        private int winnings = 0;
        private int jackpot = 5000;
        private float turn = 0.0f;
        private int playerBet = 0;
        private float winNumber = 0.0f;
        private float lossNumber = 0.0f;
        private string[] spinResult;
        private string fruits = "";
        private float winRatio = 0.0f;
        private float lossRatio = 0.0f;
        private int grapes = 0;
        private int bananas = 0;
        private int oranges = 0;
        private int cherries = 0;
        private int bars = 0;
        private int bells = 0;
        private int sevens = 0;
        private int blanks = 0;

        private Random random = new Random();

        public SlotMachineForm()
        {
            InitializeComponent();
        }

        /* Utility function to show Player Stats */
        private void showPlayerStats()
        {
            winRatio = winNumber / turn;
            lossRatio = lossNumber / turn;
            string stats = "";
            stats += ("Jackpot: " + jackpot + "\n");
            stats += ("Player Money: " + playerMoney + "\n");
            stats += ("Turn: " + turn + "\n");
            stats += ("Wins: " + winNumber + "\n");
            stats += ("Losses: " + lossNumber + "\n");
            stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
            stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");
            MessageBox.Show(stats, "Player Stats");
        }

        /* Utility function to reset all fruit tallies*/
        private void resetFruitTally()
        {
            grapes = 0;
            bananas = 0;
            oranges = 0;
            cherries = 0;
            bars = 0;
            bells = 0;
            sevens = 0;
            blanks = 0;
        }

        /* Utility function to reset the player stats */
        private void resetAll()
        {
            playerMoney = 1000;
            winnings = 0;
            jackpot = 5000;
            turn = 0;
            playerBet = 10;
            winNumber = 0;
            lossNumber = 0;
            winRatio = 0.0f;
            bettextbox.Text = playerBet.ToString();
            credittextbox.Text = playerMoney.ToString();
            winnerpaidtextbox.Text = "Amount";
            headtextbox.Text = " ";
        }

        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;
            if (jackPotTry == jackPotWin)
            {
                winnerpaidtextbox.Text = "JACKPOT!!";
                headtextbox.Text = "5000";
              MessageBox.Show("You Won the $" + jackpot + " Jackpot!!","Jackpot!!");
                playerMoney += jackpot;
                jackpot = 5000;
            }
        }

        /* Utility function to show a win message and increase player money */
        private void showWinMessage()
        {
            playerMoney += winnings;
            winnerpaidtextbox.Text = "$" + winnings;
            //MessageBox.Show("You Won: $" + winnings, "Winner!");
            resetFruitTally();
            checkJackPot();
        }

        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            playerMoney -= playerBet;
            winnerpaidtextbox.Text = "Lost";
           // MessageBox.Show("You Lost!", "Loss!");
            resetFruitTally();
        }

        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;
            
        }

        /* When this function is called it determines the betLine results.
    e.g. Bar - Orange - Banana */
        private string[] Reels()
        {
            string[] betLine = { " ", " ", " " };
            int[] outCome = { 0, 0, 0 };

            for (var spin = 0; spin < 3; spin++)
            {
                outCome[spin] = this.random.Next(65) + 1;

               if (checkRange(outCome[spin], 1, 27)) {  // 41.5% probability
                    betLine[spin] = "blank";
                    blanks++;
                    setReelPicture(spin, SlotMachine.Properties.Resources.blank);
                }
                else if (checkRange(outCome[spin], 28, 37)){ // 15.4% probability
                    betLine[spin] = "Grapes";
                    grapes++;
                    setReelPicture(spin, SlotMachine.Properties.Resources.grapes);
                }
                else if (checkRange(outCome[spin], 38, 46)){ // 13.8% probability
                    betLine[spin] = "Banana";
                    bananas++;
                    setReelPicture(spin, SlotMachine.Properties.Resources.banana);
                }
                else if (checkRange(outCome[spin], 47, 54)){ // 12.3% probability
                    betLine[spin] = "Orange";
                    oranges++;
                    setReelPicture(spin, SlotMachine.Properties.Resources.orange);
                }
                else if (checkRange(outCome[spin], 55, 59)){ //  7.7% probability
                    betLine[spin] = "Cherry";
                    cherries++;
                    setReelPicture(spin, SlotMachine.Properties.Resources.cherry);
                }
                else if (checkRange(outCome[spin], 60, 62)){ //  4.6% probability
                    betLine[spin] = "Bar";
                    bars++;
                    setReelPicture(spin, SlotMachine.Properties.Resources.bar);
                }
                else if (checkRange(outCome[spin], 63, 64)){ //  3.1% probability
                    betLine[spin] = "Bell";
                    bells++;
                    setReelPicture(spin, SlotMachine.Properties.Resources.bell);
                }
                else if (checkRange(outCome[spin], 65, 65)){ //  1.5% probability
                    betLine[spin] = "Seven";
                    sevens++;
                    setReelPicture(spin, SlotMachine.Properties.Resources.seven);
                }

               

            }
            return betLine;
        }
        /// <summary>
        /// to set the image
        /// </summary>
        /// <param name="spin"></param>
        /// <param name="resultImage"></param>
        public void setReelPicture(int spin, Image resultImage)
        {
            if (spin == 0)
            {
                pictureBox10.Image = resultImage;
            }
            else if (spin == 1)
            {
                pictureBox9.Image = resultImage;
            }
            else
            {
                pictureBox6.Image = resultImage;
            }
        }

        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (blanks == 0)
            {
                if (grapes == 3)
                {
                    winnings = playerBet * 10;
                }
                else if (bananas == 3)
                {
                    winnings = playerBet * 20;
                }
                else if (oranges == 3)
                {
                    winnings = playerBet * 30;
                }
                else if (cherries == 3)
                {
                    winnings = playerBet * 40;
                }
                else if (bars == 3)
                {
                    winnings = playerBet * 50;
                }
                else if (bells == 3)
                {
                    winnings = playerBet * 75;
                }
                else if (sevens == 3)
                {
                    winnings = playerBet * 100;
                }
                else if (grapes == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (bananas == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (oranges == 2)
                {
                    winnings = playerBet * 3;
                }
                else if (cherries == 2)
                {
                    winnings = playerBet * 4;
                }
                else if (bars == 2)
                {
                    winnings = playerBet * 5;
                }
                else if (bells == 2)
                {
                    winnings = playerBet * 10;
                }
                else if (sevens == 2)
                {
                    winnings = playerBet * 20;
                }
                else if (sevens == 1)
                {
                    winnings = playerBet * 5;
                }
                else
                {
                    winnings = playerBet * 1;
                }
                winNumber++;
                showWinMessage();
            }
            else
            {
                lossNumber++;
                showLossMessage();
            }

        }

        private void SpinPictureBox_Click(object sender, EventArgs e)
        {
            headtextbox.Text = " ";



            if (playerMoney == 0)
            {
                if (MessageBox.Show("You ran out of Money! \nDo you want to play again?","Out of Money!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetAll();
                    showPlayerStats();
                }
            }
            else if (playerBet > playerMoney)
            {
                MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
            }
            else if (playerBet < 0)
            {
                MessageBox.Show("All bets must be a positive $ amount.", "Incorrect Bet");
            }
            else if (playerBet <= playerMoney)
            {
                spinResult = Reels();
                credittextbox.Text = playerMoney.ToString();
                determineWinnings();
                credittextbox.Text = playerMoney.ToString();
                turn++;
                //showPlayerStats();
                if (playerMoney <= 0)
                {
                    if (MessageBox.Show("You ran out of Money! \nDo you want to play again?", "Out of Money!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        resetAll();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount");
            }
        }

        /// <summary>
        /// bet button textbox click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void betboxclick(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            if (playerMoney < Convert.ToInt32(box.Tag.ToString()))
            {
                MessageBox.Show("You don't have enough money to place that bet!", "Insufficient Funds");
            }
            else
            {
                bettextbox.Text = box.Tag.ToString();
                playerBet = Convert.ToInt32(box.Tag.ToString());
            }
        }
        /// <summary>
        /// on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slotformload(object sender, EventArgs e)
        {
            credittextbox.Text = playerMoney.ToString();
            bettextbox.Text = "10";
            playerBet = 10; // default bet amount

        }
        /// <summary>
        /// reset button handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetbuttonclick(object sender, EventArgs e)
        {
            this.resetAll();
        }
        /// <summary>
        /// event handler for exit the code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exitapplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
