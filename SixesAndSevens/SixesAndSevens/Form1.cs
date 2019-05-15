using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SixesAndSevens
{
    public partial class SixesAndSevens : Form
    {
        // Instance variables
        private int iGoalScore = 50; // The Game Goal Score to reach
        private int[] iActivePlayers = { 1, 2 };
        int iDie1, iDie2, iDieResult, iRunningScore;
        bool p1Turn = true;
        bool p2Turn = false;
        int p1RoundsWon = 0;
        int p2RoundsWon = 0;
        int p1Cumulative, p2Cumulative;




        public SixesAndSevens()
        {
            InitializeComponent();
            btnRollDice.Visible = false;
            btnPassTurn.Visible = false;
            Graphics graPaper = picBxDie1.CreateGraphics();
            Graphics graPaper2 = picBxDie2.CreateGraphics();

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            
            
            Random rRollDice = new Random();

            iDie1 = rRollDice.Next(1, 7);
            txtBxDie1.Text = Convert.ToString(iDie1);

            iDie2 = rRollDice.Next(1, 7);
            txtBxDie2.Text = Convert.ToString(iDie2);

            iDieResult = iDie1 + iDie2;
            
            if (iDie1 == 1)
            {
                Graphics graPaper = picBxDie1.CreateGraphics();
                graPaper.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper.DrawEllipse(penBlue, 35, 35, 15, 15);
            }
            if (iDie1 == 2)
            {
                Graphics graPaper = picBxDie1.CreateGraphics();
                graPaper.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper.DrawEllipse(penBlue, 60, 10, 15, 15);
                graPaper.DrawEllipse(penBlue, 10, 60, 15, 15);
            }
            if (iDie1 == 3)
            {
                Graphics graPaper = picBxDie1.CreateGraphics();
                graPaper.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper.DrawEllipse(penBlue, 10, 10, 15, 15);
                graPaper.DrawEllipse(penBlue, 35, 35, 15, 15);
                graPaper.DrawEllipse(penBlue, 60, 60, 15, 15);
            }
            if (iDie1 == 4)
            {
                Graphics graPaper = picBxDie1.CreateGraphics();
                graPaper.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper.DrawEllipse(penBlue, 10, 10, 15, 15);
                graPaper.DrawEllipse(penBlue, 60, 10, 15, 15);
                graPaper.DrawEllipse(penBlue, 60, 60, 15, 15);
                graPaper.DrawEllipse(penBlue, 10, 60, 15, 15);
            }
            if (iDie1 == 5)
            {
                Graphics graPaper = picBxDie1.CreateGraphics();
                graPaper.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper.DrawEllipse(penBlue, 10, 10, 15, 15);
                graPaper.DrawEllipse(penBlue, 60, 10, 15, 15);
                graPaper.DrawEllipse(penBlue, 60, 60, 15, 15);
                graPaper.DrawEllipse(penBlue, 10, 60, 15, 15);
                graPaper.DrawEllipse(penBlue, 35, 35, 15, 15);
            }
            if (iDie1 == 6)
            {
                Graphics graPaper = picBxDie1.CreateGraphics();
                graPaper.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper.DrawEllipse(penBlue, 10, 10, 15, 15);
                graPaper.DrawEllipse(penBlue, 60, 10, 15, 15);
                graPaper.DrawEllipse(penBlue, 60, 60, 15, 15);
                graPaper.DrawEllipse(penBlue, 10, 60, 15, 15);
                graPaper.DrawEllipse(penBlue, 10, 35, 15, 15);
                graPaper.DrawEllipse(penBlue, 60, 35, 15, 15);

            }

            if (iDie2 == 1)
            {
                Graphics graPaper2 = picBxDie2.CreateGraphics();
                graPaper2.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper2.DrawEllipse(penBlue, 35, 35, 15, 15);
            }
            if (iDie2 == 2)
            {
                Graphics graPaper2 = picBxDie2.CreateGraphics();
                graPaper2.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper2.DrawEllipse(penBlue, 60, 10, 15, 15);
                graPaper2.DrawEllipse(penBlue, 10, 60, 15, 15);
            }
            if (iDie2 == 3)
            {
                Graphics graPaper2 = picBxDie2.CreateGraphics();
                graPaper2.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper2.DrawEllipse(penBlue, 10, 10, 15, 15);
                graPaper2.DrawEllipse(penBlue, 35, 35, 15, 15);
                graPaper2.DrawEllipse(penBlue, 60, 60, 15, 15);
            }
            if (iDie2 == 4)
            {
                Graphics graPaper2 = picBxDie2.CreateGraphics();
                graPaper2.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper2.DrawEllipse(penBlue, 10, 10, 15, 15);
                graPaper2.DrawEllipse(penBlue, 60, 10, 15, 15);
                graPaper2.DrawEllipse(penBlue, 60, 60, 15, 15);
                graPaper2.DrawEllipse(penBlue, 10, 60, 15, 15);
            }
            if (iDie2 == 5)
            {
                Graphics graPaper2 = picBxDie2.CreateGraphics();
                graPaper2.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper2.DrawEllipse(penBlue, 10, 10, 15, 15);
                graPaper2.DrawEllipse(penBlue, 60, 10, 15, 15);
                graPaper2.DrawEllipse(penBlue, 60, 60, 15, 15);
                graPaper2.DrawEllipse(penBlue, 10, 60, 15, 15);
                graPaper2.DrawEllipse(penBlue, 35, 35, 15, 15);
            }
            if (iDie2 == 6)
            {
                Graphics graPaper2 = picBxDie2.CreateGraphics();
                graPaper2.Clear(Color.White);
                Pen penBlue = new Pen(Color.Black, 3);
                graPaper2.DrawEllipse(penBlue, 10, 10, 15, 15);
                graPaper2.DrawEllipse(penBlue, 60, 10, 15, 15);
                graPaper2.DrawEllipse(penBlue, 60, 60, 15, 15);
                graPaper2.DrawEllipse(penBlue, 10, 60, 15, 15);
                graPaper2.DrawEllipse(penBlue, 10, 35, 15, 15);
                graPaper2.DrawEllipse(penBlue, 60, 35, 15, 15);

            }








            if (iDie1 == 6)
            {
                if (iDie2 == 1)
                {
                    if (p1Turn == true)
                    {
                        p1Cumulative = 0;
                        txtBxPlayer1.Text = Convert.ToString(p1Cumulative);
                    }
                    else if (p2Turn == true)
                    {
                        p2Cumulative = 0;
                        txtBxPlayer2.Text = Convert.ToString(p2Cumulative);
                    }
                        MessageBox.Show("You lose your Running Score and your Cumulative Score, Pass the turn!", "Sorry, you got a Silly Seven!");
                }

                iRunningScore = 0;
                lblRunningScore.Text = Convert.ToString(iRunningScore);

                if (p1Turn == true)
                {
                    MessageBox.Show("Player 2's Turn");
                    p1Turn = false;
                    p2Turn = true;
                    lblPlayer1.BackColor = SystemColors.Control;
                    lblPlayer2.BackColor = Color.Red;
                }
                else if (p2Turn == true)
                {
                    MessageBox.Show("Player 1's Turn");
                    p2Turn = false;
                    p1Turn = true;
                    lblPlayer1.BackColor = Color.Red;
                    lblPlayer2.BackColor = SystemColors.Control;

                }
            }

            else if (iDie2 == 6)
            {
                if (iDie1 == 1)
                {
                    if (p1Turn == true)
                    {
                        p1Cumulative = 0;
                        txtBxPlayer1.Text = Convert.ToString(p1Cumulative);
                    }
                    else if (p2Turn == true)
                    {
                        p2Cumulative = 0;
                        txtBxPlayer2.Text = Convert.ToString(p2Cumulative);
                    }

                    MessageBox.Show("You lose your Running Score and your Cumulative Score, Pass the turn!", "Sorry, you got a Silly Seven!");
                    
                }

                iRunningScore = 0;
                lblRunningScore.Text = Convert.ToString(iRunningScore);

                if (p1Turn == true)
                {
                    MessageBox.Show("Player 2's Turn");
                    p1Turn = false;
                    p2Turn = true;
                    lblPlayer1.BackColor = SystemColors.Control;
                    lblPlayer2.BackColor = Color.Red;
                }
                else if (p2Turn == true)
                {
                    MessageBox.Show("Player 1's Turn");
                    p2Turn = false;
                    p1Turn = true;
                    lblPlayer1.BackColor = Color.Red;
                    lblPlayer2.BackColor = SystemColors.Control;
                }
                
            }
            else
            {
                iRunningScore = iRunningScore + iDieResult;
                lblRunningScore.Text = Convert.ToString(iRunningScore);

                if (p1Turn == true)
                {
                    p1Cumulative = p1Cumulative + iDieResult;
                    txtBxPlayer1.Text = Convert.ToString(p1Cumulative);
                    
                }
                else if (p2Turn == true)
                {
                    p2Cumulative = p2Cumulative + iDieResult;
                    txtBxPlayer2.Text = Convert.ToString(p2Cumulative);
                    
                }
                if (p1Cumulative >= iGoalScore)
                {
                    MessageBox.Show("PLAYER 1 WINS!!!");

                    string message = "Do you want to Restart?";
                    string title = "Restart";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        p1Cumulative = 0;
                        p2Cumulative = 0;
                        iRunningScore = 0;
                        txtBxPlayer1.Text = Convert.ToString(p1Cumulative);
                        txtBxPlayer2.Text = Convert.ToString(p2Cumulative);
                        p1RoundsWon = p1RoundsWon + 1;
                        lblP1Rounds.Text = Convert.ToString(p1RoundsWon);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                if (p2Cumulative >= iGoalScore)
                {
                    MessageBox.Show("PLAYER 2 WINS!!!");

                    string message = "Do you want to Restart?";
                    string title = "Restart";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        p1Cumulative = 0;
                        p2Cumulative = 0;
                        iRunningScore = 0;
                        txtBxPlayer1.Text = Convert.ToString(p1Cumulative);
                        txtBxPlayer2.Text = Convert.ToString(p2Cumulative);
                        p2RoundsWon = p2RoundsWon + 1;
                        lblP2Rounds.Text = Convert.ToString(p1RoundsWon);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }



            //This is the spot where the Cumulative score adds the Running score every button click.











        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPassTurn_Click(object sender, EventArgs e)
        {
            if (lblPlayer1.BackColor == Color.Red && p1Turn == true)
            {
                iRunningScore = 0;
                lblRunningScore.Text = Convert.ToString(iRunningScore);
                lblPlayer1.BackColor = SystemColors.Control;
                lblPlayer2.BackColor = Color.Red;
                p1Turn = false;
                p2Turn = true;
            }
            else if (lblPlayer2.BackColor == Color.Red && p2Turn == true)
            {
                iRunningScore = 0;
                lblRunningScore.Text = Convert.ToString(iRunningScore);
                lblPlayer1.BackColor = Color.Red;
                lblPlayer2.BackColor = SystemColors.Control;
                p2Turn = false;
                p1Turn = true;
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnRollDice.Visible = true;
            btnPassTurn.Visible = true;
            btnStartGame.Visible = false;
            lblDie1.Visible = true;
            lblDie2.Visible = true;
            lblRunningScoreHead.Visible = true;
            lblRunningScore.Visible = true;
            txtBxPlayer1.Visible = true;
            txtBxPlayer2.Visible = true;
            txtBxDie1.Visible = true;
            txtBxDie2.Visible = true;
            lblRunningScore.Visible = true;
            picBxDie1.Visible = true;
            picBxDie2.Visible = true;
            lblPlayer1.BackColor = new System.Drawing.Color();
            lblPlayer1.BackColor = Color.Red;
            lblPlayer1.Visible = true;
            lblPlayer2.Visible = true;
            lblCumulativeScores.Visible = true;
            lblRoundsWonP1.Visible = true;
            lblRoundsWonP2.Visible = true;
            lblP1Rounds.Visible = true;
            lblP2Rounds.Visible = true;

        }
    }
}
