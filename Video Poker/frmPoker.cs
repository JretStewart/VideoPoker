using Azara_Video_Poker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
    Authors: Aaron Azar, Jarret Stewart
    Date Last Updated: 5/10/2016
    Purpose: Created for C# Final
    Discription: Video Poker game designed for C# final project. Game detects player hands, and adds credits based on winnings.
                 The player is able to save their current game and load it to play at a later time.
*/

namespace Azara_Video_Poker
{
    public partial class    frmPoker : Form
    {
        //Variables
        Poker pokerGame = new Poker();
        Hand poker = new Hand();
        Card cardSpotOne, cardSpotTwo, cardSpotThree, cardSpotFour, cardSpotFive;
        frmWinnings view = new frmWinnings();
        frmTest test = new frmTest();
        int nBet = 1;
        int nCredits = 500;
        int nIndex = 0;
        bool isDeal = false;
        bool isHold1 = false;
        bool isHold2 = false;
        bool isHold3 = false;
        bool isHold4 = false;
        bool isHold5 = false;
        
        string strName { get; set; }

        public frmPoker()
        {
            InitializeComponent();
            hideHold();
        }//End frmPoker()

        private void frmPoker_Load(object sender, EventArgs e)
        {
            lblAmount.Text = nCredits.ToString();
            
        }//End frmPoker_Load AA

        public bool isBal()
        {
            if (nBet > nCredits)
            {
                DialogResult result;
                result = MessageBox.Show("You do not have enough credits. Rebuy?", "Bad Luck!",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    gameReset();
                    nCredits = 500;
                    nBet = 1;
                    lblAmount.Text = nCredits.ToString();
                    lblBet.Text = nBet.ToString();
                    return true;
                }
                else
                {
                    gameReset();
                    return false;
                }
               
            }
            else
            {
                gameReset();
                return false;
            }
        }//end isBal() JS
        /// <summary>
        /// Max out bet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnMax_Click(object sender, EventArgs e)
        {
            nBet = 5;
            lblBet.Text = nBet.ToString();
            if (nBet > nCredits)
            {
                isBal();
            }
            else
            {
                view.lblBetRef = lblBet;
                view.DisplayWinnings();

                pokerGame = new Poker();
                gameReset();
                bttnAdd.Visible = false;
                bttnMinus.Visible = false;
                bttnMax.Visible = false;
                lblWinningHand.Visible = false;
                pbCard1.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotOne = pokerGame.deckCard[nIndex];
                nIndex++;
                pbCard2.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotTwo = pokerGame.deckCard[nIndex];
                nIndex++;
                pbCard3.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotThree = pokerGame.deckCard[nIndex];
                nIndex++;
                pbCard4.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotFour = pokerGame.deckCard[nIndex];
                nIndex++;
                pbCard5.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotFive = pokerGame.deckCard[nIndex];
                nIndex++;
                bttnDeal.Text = "DRAW";
                nCredits -= nBet;
                lblAmount.Text = nCredits.ToString();
                isDeal = true;
                resetHold();
            }
            

        }//End bttnMax_Click AA && JS

        /// <summary>
        /// Sets button to increase label by 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            nBet++;
            if (nBet <= 5)
            {
                lblBet.Text = nBet.ToString();
            }
            else if (nBet > 5)
            {
                nBet = 5;
                lblBet.Text = nBet.ToString();
                DialogResult overbet;
                overbet = MessageBox.Show("Cannot bet more than 5 credits", "Max Bet", MessageBoxButtons.OK);

            }
            view.lblBetRef = lblBet;
            view.DisplayWinnings();

        }//End bttnAdd_Click JS

        /// <summary>
        /// Sets button to decrease label by 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnMinus_Click(object sender, EventArgs e)
        {
            nBet--;
            if (nBet >= 1 )
            {
                lblBet.Text = nBet.ToString();
            }
            else if (nBet < 1)
            {
                nBet = 1;
                lblBet.Text = nBet.ToString();
            }
            view.lblBetRef = lblBet;
            view.DisplayWinnings();


        }//End bttnMinus_Click JS

        public void hideHold()
        {
            if (isHold1)
            {
                bttnHold1.Visible = true;
            }
            else
            {
                bttnHold1.Visible = false;
            }
            if (isHold2)
            {
                bttnHold2.Visible = true;
            }
            else
            {
                bttnHold2.Visible = false;
            }
            if (isHold3)
            {
                bttnHold3.Visible = true;
            }
            else
            {
                bttnHold3.Visible = false;
            }
            if (isHold4)
            {
                bttnHold4.Visible = true;
            }
            else
            {
                bttnHold4.Visible = false;
            }
            if (isHold5)
            {
                bttnHold5.Visible = true;
            }
            else
            {
                bttnHold5.Visible = false;
            }

        }//End hideHold() JS

        public void resetHold()
        {
            bttnHold1.Visible = true;
            bttnHold2.Visible = true;
            bttnHold3.Visible = true;
            bttnHold4.Visible = true;
            bttnHold5.Visible = true;
        }//End resetHold JS

        /// <summary>
        /// Deals 5 cards for gameplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnDeal_Click(object sender, EventArgs e)
        {
            //Determines if first or second hand
            if (isDeal)
            {
                checkHold();
                poker.setHand(cardSpotOne, cardSpotTwo, cardSpotThree, cardSpotFour, cardSpotFive, nBet);
                lblWinningHand.Text = poker.checkHand();
                lblWinningHand.Visible = true;
                nCredits += poker.setWinnings();
                lblAmount.Text = nCredits.ToString();
                bttnDeal.Text = "DEAL";
                isDeal = false;
                bttnMinus.Visible = true;
                bttnAdd.Visible = true;
                bttnMax.Visible = true;
                hideHold();
            }
            else
            {
                if (nBet > nCredits)
                {
                    isBal();
                }
                else
                {
                    pokerGame = new Poker();
                    nIndex = 0;
                    holdReset();
                    bttnAdd.Visible = false;
                    bttnMinus.Visible = false;
                    bttnMax.Visible = false;
                    lblWinningHand.Visible = false;
                    pbCard1.Image = pokerGame.deckCard[nIndex].CardImage;
                    cardSpotOne = pokerGame.deckCard[nIndex];
                    nIndex++;
                    pbCard2.Image = pokerGame.deckCard[nIndex].CardImage;
                    cardSpotTwo = pokerGame.deckCard[nIndex];
                    nIndex++;
                    pbCard3.Image = pokerGame.deckCard[nIndex].CardImage;
                    cardSpotThree = pokerGame.deckCard[nIndex];
                    nIndex++;
                    pbCard4.Image = pokerGame.deckCard[nIndex].CardImage;
                    cardSpotFour = pokerGame.deckCard[nIndex];
                    nIndex++;
                    pbCard5.Image = pokerGame.deckCard[nIndex].CardImage;
                    cardSpotFive = pokerGame.deckCard[nIndex];
                    nIndex++;
                    bttnDeal.Text = "DRAW";
                    nCredits -= nBet;
                    lblAmount.Text = nCredits.ToString();

                    isDeal = true;
                    resetHold();
                }

            }
        }//End bttnDeal_Click AA && JS

        /// <summary>
        /// Resets Hold buttons and bools
        /// </summary>
        private void gameReset()
        {
            nIndex = 0;
            pbCard1.Image = Resources._150px_Card_back_Power_Core;
            pbCard2.Image = Resources._150px_Card_back_Power_Core;
            pbCard3.Image = Resources._150px_Card_back_Power_Core;
            pbCard4.Image = Resources._150px_Card_back_Power_Core;
            pbCard5.Image = Resources._150px_Card_back_Power_Core;
            holdReset();
            bttnDeal.Text = "DEAL";
            isDeal = false;
            bttnAdd.Visible = true;
            bttnMinus.Visible = true;
            bttnMax.Visible = true;
            lblWinningHand.Text = "";
        }//End gameReset AA && JS

        /// <summary>
        /// Resets hold buttons to false
        /// </summary>
        private void holdReset()
        {
            bttnHold1.BackColor = Color.Transparent;
            bttnHold2.BackColor = Color.Transparent;
            bttnHold3.BackColor = Color.Transparent;
            bttnHold4.BackColor = Color.Transparent;
            bttnHold5.BackColor = Color.Transparent;
            isHold1 = false;
            isHold2 = false;
            isHold3 = false;
            isHold4 = false;
            isHold5 = false;
        }//End holdReset AA

        /// <summary>
        /// Checks to see what cards are held and replaces those that aren't
        /// </summary>
        private void checkHold()
        {
            if (!isHold1)
            {
                pbCard1.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotOne = pokerGame.deckCard[nIndex];
                nIndex++;
            }
            if (!isHold2)
            {
                pbCard2.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotTwo = pokerGame.deckCard[nIndex];
                nIndex++;
            }
            if (!isHold3)
            {
                pbCard3.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotThree = pokerGame.deckCard[nIndex];
                nIndex++;
            }
            if (!isHold4)
            {
                pbCard4.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotFour = pokerGame.deckCard[nIndex];
                nIndex++;
            }
            if (!isHold5)
            {
                pbCard5.Image = pokerGame.deckCard[nIndex].CardImage;
                cardSpotFive = pokerGame.deckCard[nIndex];
                nIndex++;
            }
        }//End checkHold AA

        /// <summary>
        /// alternates hold button from clicked to standard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnHold1_Click(object sender, EventArgs e)
        {
            if (isHold1)
            {
                bttnHold1.BackColor = Color.Transparent;
                isHold1 = false;
            }
            else
            {
                bttnHold1.BackColor = Color.RoyalBlue;
                isHold1 = true;
            }
        }//End bttnHold1_Click AA && JS

        private void bttnHold2_Click(object sender, EventArgs e)
        {
            if (isHold2)
            {
                bttnHold2.BackColor = Color.Transparent;
                isHold2 = false;
            }
            else
            {

                bttnHold2.BackColor = Color.RoyalBlue;
                isHold2 = true;
            }
        }//End bttnHold2_Click AA && JS

        private void bttnHold3_Click(object sender, EventArgs e)
        {
            if (isHold3)
            {
                bttnHold3.BackColor = Color.Transparent;
                isHold3 = false;
            }
            else
            {
                bttnHold3.BackColor = Color.RoyalBlue;
                isHold3 = true;
            }
        }//End bttnHold3_Click AA && JS

        private void bttnHold4_Click(object sender, EventArgs e)
        {
            if (isHold4)
            {
                bttnHold4.BackColor = Color.Transparent;
                isHold4 = false;
            }
            else
            {
                bttnHold4.BackColor = Color.RoyalBlue;
                isHold4 = true;
            }
        }//End bttnHold4_Click AA && JS

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.lblBetRef = lblBet;
            view.BackColor = Color.Yellow;
            view.Show();
        }// end options JS

        /// <summary>
        /// Updates Players name using ShowDialog method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void lblName_Click(object sender, EventArgs e)
        {
            string strNewName = ShowDialog("Enter Name: ", "Name Change");
            if(strNewName != strName && strNewName != "")
            {
                strName = strNewName;
                lblName.Text = strName;                
            }
            else if (strNewName == "" && strName != null)
            {
                lblName.Text = strName;
            }
            else
            {
                lblName.Text = "Player";
            }
        }//end lblName AA && JS

        /// <summary>
        /// Creates a dialog box for the player to enter their name.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <returns></returns>
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }//End ShowDialog AA && JS

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are You Sure?", "Exit Game?", MessageBoxButtons.YesNo);
           
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }//End exitGame JS

        private void fullScreenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }//End Fullscreen JS

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }//End Normal View JS

        private void pbCard5_Click(object sender, EventArgs e)
        {
            if (isHold5)
            {
                bttnHold5.BackColor = Color.Transparent;
                isHold5 = false;
            }
            else
            {
                bttnHold5.BackColor = Color.RoyalBlue;
                isHold5 = true;
            }
        }//End Click5 JS && AA

        private void pbCard4_Click(object sender, EventArgs e)
        {
            if (isHold4)
            {
                bttnHold4.BackColor = Color.Transparent;
                isHold4 = false;
            }
            else
            {
                bttnHold4.BackColor = Color.RoyalBlue;
                isHold4 = true;
            }
        }//End Click4 JS && AA

        private void pbCard3_Click(object sender, EventArgs e)
        {
            if (isHold3)
            {
                bttnHold3.BackColor = Color.Transparent;
                isHold3 = false;
            }
            else
            {
                bttnHold3.BackColor = Color.RoyalBlue;
                isHold3 = true;
            }
        }//End Click3 JS && AA

        private void pbCard2_Click_1(object sender, EventArgs e)
        {
            if (isHold2)
            {
                bttnHold2.BackColor = Color.Transparent;
                isHold2 = false;
            }
            else
            {
                bttnHold2.BackColor = Color.RoyalBlue;
                isHold2 = true;
            }
        }//End Click2 JS && AA

        private void pbCard1_Click_1(object sender, EventArgs e)
        {
            if (isHold1)
            {
                bttnHold1.BackColor = Color.Transparent;
                isHold1 = false;
            }
            else
            {
                bttnHold1.BackColor = Color.RoyalBlue;
                isHold1 = true;
            }
        }//End Click1 JS && AA

        private void button1_Click(object sender, EventArgs e)
        {
            test.BackColor = Color.Yellow;
            test.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test.BackColor = Color.Blue;
            this.BackColor = Color.Green;
        }

        private void bttnHold5_Click(object sender, EventArgs e)
        {
            if (isHold5)
            {
                bttnHold5.BackColor = Color.Transparent;
                isHold5 = false;
            }
            else
            {
                bttnHold5.BackColor = Color.RoyalBlue;
                isHold5 = true;
            }
        }//End bttnHold5_Click AA && JS

        /// <summary>
        /// resets game on New Game click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameReset();
            hideHold();
            nCredits = 500;
            nBet = 1;
            lblAmount.Text = nCredits.ToString();
            lblBet.Text = nBet.ToString();
        }//End newGameToolStripMenuItem_Click JS

        /// <summary>
        /// saves game on Save Game click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create creditsave from the lbl data
            CreditAmount creditSave = new CreditAmount(lblAmount.Text);

            FileSave saveGame = new FileSave();

            bool isSaved = saveGame.SaveGame(creditSave);

            saveGame.SaveGame(creditSave);

            if (isSaved)
            {
                MessageBox.Show("Game Saved.","Save Game");
            }
            else
            {
                MessageBox.Show("Could Not Save Game. Please Close 'CreditSave.csv'.", "Error");
            }
        }//End saveGameToolStripMenuItem_Click JS

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGame load = new LoadGame();
            gameReset();
            lblAmount.Text = load.loadGame();
            nCredits = Convert.ToInt32(load.loadGame());
            nBet = 1;
            lblBet.Text = nBet.ToString();
            hideHold();
        }   
    }//End class
}//End namespace
