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

        public SixesAndSevens()
        {
            InitializeComponent();
            btnRollDice.Visible = false;
            btnPassTurn.Visible = false;
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int iDie1, iDie2, iDieResult;

            Random rRollDice = new Random();

            iDie1 = rRollDice.Next(1, 6);
            txtBxDie1.Text = Convert.ToString(iDie1);

            iDie2 = rRollDice.Next(1, 6);
            txtBxDie2.Text = Convert.ToString(iDie2);

            iDieResult = iDie1 + iDie2;
            
            if (iDie1 == 6)
            {
                if (iDie1 == 1)
                {
                    txtBxRunningScore.Text = Convert.ToString(iDieResult);
                    MessageBox.Show("You lose your Running Score and your Culmative Score, Pass the turn!", "Sorry, you got a Silly Seven!");
                }
            }

            else if (iDie2 == 6)
            {
                if (iDie2 == 1)
                {
                    txtBxRunningScore.Text = Convert.ToString(iDieResult);
                    MessageBox.Show("You lose your Running Score and your Culmative Score, Pass the turn!", "Sorry, you got a Silly Seven!");
                }
            }
            else
            {
                txtBxRunningScore.Text = Convert.ToString(iDieResult);
            }
        }
                
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPassTurn_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnRollDice.Visible = true;
            btnPassTurn.Visible = true;
            btnStartGame.Visible = false;

            lblPlayer1.BackColor = new System.Drawing.Color();
            lblPlayer1.BackColor = Color.Red;


        }
    }
}
