using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
JS
*/
namespace Azara_Video_Poker
{
    public partial class frmWinnings : Form
    {
        public Label lblBetRef { get; set; }

        string[] strWinningHands = { "Royal Flush", "Straight Flush", "Four of a Kind", "Full House", "Flush", "Straight", "Three of a Kind", "Two Pair", "Pair" };
        int[] nWinnings1Coin = { 800, 50, 25, 8, 6, 4, 3, 2, 1 };
        int[] nWinnings2Coin = { 1600, 100, 50, 16, 12, 8, 6, 4, 2 };
        int[] nWinnings3Coin = { 2400, 150, 75, 24, 18, 12, 9, 6, 3 };
        int[] nWinnings4Coin = { 3200, 200, 100, 32, 24, 16, 12, 8, 4 };
        int[] nWinnings5Coin = { 4000, 250, 125, 40, 30, 20, 15, 10, 5 };

        public frmWinnings()
        {
            InitializeComponent();
        }

        public void frmWinnings_Load(object sender, EventArgs e)
        {
            DisplayWinnings();
        }

        public void DisplayWinnings()
        {
            PictureBox back = new PictureBox();
            back.Location = new Point(0, 0);
            back.BackColor = Color.Blue;
            back.Name = "pbBack";
            back.Size = new Size(675, 250);
            this.Controls.Add(back);
            back.Visible = true;
            back.BringToFront();

            for (int i = 0; i < strWinningHands.Length; i++)
            {
                Label label = new Label();
                label.BackColor = Color.Blue;
                label.ForeColor = Color.Yellow;
                label.AutoSize = true;
                label.Name = "lblHand" + i;
                label.Top = 15 + (25 * i);
                label.Left = 10;
                label.Text = strWinningHands[i].ToString();
                this.Controls.Add(label);
                label.Visible = true;
                label.BringToFront();

            }//End for loop WinningHand
            if (lblBetRef.Text == "1")
            {
                for (int i = 0; i < nWinnings1Coin.Length; i++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Red;
                    label.ForeColor = Color.Yellow;
                    label.AutoSize = true;
                    label.Name = "lblWinning1Coin" + i;
                    label.Top = 15 + (25 * i);
                    label.Left = 200;
                    label.Text = nWinnings1Coin[i].ToString();
                    this.Controls.Add(label);
                    label.Visible = true;
                    label.BringToFront();
                }
            }
            else
            {
                for (int i = 0; i < nWinnings1Coin.Length; i++)
                {
                Label label = new Label();
                label.BackColor = Color.Blue;
                label.ForeColor = Color.Yellow;
                label.AutoSize = true;
                label.Name = "lblWinning1Coin" + i;
                label.Top = 15 + (25 * i);
                label.Left = 200;
                label.Text = nWinnings1Coin[i].ToString();
                this.Controls.Add(label);
                label.Visible = true;
                label.BringToFront();

            }
                   

            }//End for loop Winning1Coin
            if (lblBetRef.Text == "2")
            {
                for (int i = 0; i < nWinnings2Coin.Length; i++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Red;
                    label.ForeColor = Color.Yellow;
                    label.AutoSize = true;
                    label.Name = "lblWinning2Coin" + i;
                    label.Top = 15 + (25 * i);
                    label.Left = 300;
                    label.Text = nWinnings2Coin[i].ToString();
                    this.Controls.Add(label);
                    label.Visible = true;
                    label.BringToFront();
                }
            }
            else
            {
                for (int i = 0; i < nWinnings2Coin.Length; i++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Blue;
                    label.ForeColor = Color.Yellow;
                    label.AutoSize = true;
                    label.Name = "lblWinning2Coin" + i;
                    label.Top = 15 + (25 * i);
                    label.Left = 300;
                    label.Text = nWinnings2Coin[i].ToString();
                    this.Controls.Add(label);
                    label.Visible = true;
                    label.BringToFront();
                }
            }//End for loop Winnin2Coin
            if (lblBetRef.Text == "3")
            {
                for (int i = 0; i < nWinnings3Coin.Length; i++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Red;
                    label.ForeColor = Color.Yellow;
                    label.AutoSize = true;
                    label.Name = "lblWinning3Coin" + i;
                    label.Top = 15 + (25 * i);
                    label.Left = 400;
                    label.Text = nWinnings3Coin[i].ToString();
                    this.Controls.Add(label);
                    label.Visible = true;
                    label.BringToFront();
                }
            }
            else
            {
                for (int i = 0; i < nWinnings3Coin.Length; i++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Blue;
                    label.ForeColor = Color.Yellow;
                    label.AutoSize = true;
                    label.Name = "lblWinning3Coin" + i;
                    label.Top = 15 + (25 * i);
                    label.Left = 400;
                    label.Text = nWinnings3Coin[i].ToString();
                    this.Controls.Add(label);
                    label.Visible = true;
                    label.BringToFront();
                }
            }//End for loop Winning3Coin
            if (lblBetRef.Text == "4")
            {
                for (int i = 0; i < nWinnings4Coin.Length; i++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Red;
                    label.ForeColor = Color.Yellow;
                    label.AutoSize = true;
                    label.Name = "lblWinning4Coin" + i;
                    label.Top = 15 + (25 * i);
                    label.Left = 500;
                    label.Text = nWinnings4Coin[i].ToString();
                    this.Controls.Add(label);
                    label.Visible = true;
                    label.BringToFront();
                }
            }
            else
            {
                for (int i = 0; i < nWinnings4Coin.Length; i++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Blue;
                    label.ForeColor = Color.Yellow;
                    label.AutoSize = true;
                    label.Name = "lblWinning4Coin" + i;
                    label.Top = 15 + (25 * i);
                    label.Left = 500;
                    label.Text = nWinnings4Coin[i].ToString();
                    this.Controls.Add(label);
                    label.Visible = true;
                    label.BringToFront();
                }
            }//End for loop Winning4Coin
            if (lblBetRef.Text == "5")
            {
                for (int i = 0; i < nWinnings5Coin.Length; i++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Red;
                    label.ForeColor = Color.Yellow;
                    label.AutoSize = true;
                    label.Name = "lblWinning5Coin" + i;
                    label.Top = 15 + (25 * i);
                    label.Left = 600;
                    label.Text = nWinnings5Coin[i].ToString();
                    this.Controls.Add(label);
                    label.Visible = true;
                    label.BringToFront();
                }
            }
            else
            {
                for (int i = 0; i < nWinnings5Coin.Length; i++)
                {
                    Label label = new Label();
                    label.BackColor = Color.Blue;
                    label.ForeColor = Color.Yellow;
                    label.AutoSize = true;
                    label.Name = "lblWinning5Coin" + i;
                    label.Top = 15 + (25 * i);
                    label.Left = 600;
                    label.Text = nWinnings5Coin[i].ToString();
                    this.Controls.Add(label);
                    label.Visible = true;
                    label.BringToFront();
                }

            }//End for loop Winning5Coin
        }
    }
}
