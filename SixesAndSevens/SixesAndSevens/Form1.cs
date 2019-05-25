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

    #region Instance Variables
    public partial class SixesAndSevens : Form
    {
       
        // The Game Goal Score to reach
        int iGoalScore = 0;
        
        //Setting the variables to handle the numbers for both Dice, the result of both Dice and the Running Score
        int iDie1, iDie2, iDieResult, iRunningScore;

        //Boolean to handle the player's turn variables
        bool p1Turn = true;
        bool p2Turn = false;

        //Variables to keep track of how many rounds Player 1 and Player 2 have won
        int p1RoundsWon = 0;
        int p2RoundsWon = 0;

        //Variables to keep track of each players Cumulative Scores
        int p1Cumulative, p2Cumulative;

        #endregion

        #region Sixes and Sevens Game Initialization
        public SixesAndSevens()
        {
            //Roll Dice and Pass Turn buttons a set to not be visible when the application opens
            InitializeComponent();
            btnRollDice.Visible = false;
            btnPassTurn.Visible = false;
            lstBxPlayer1.Visible = false;
            lstBxPlayer2.Visible = false;
            while (chBoxComputer.Checked)
            {
                lblPlayerName2.Visible = false;
            }

        }
        #endregion

        #region Computer's Turn Drawing Graphics
        private void computerFillEllipse()
        {
            //Graphics events are established to be called when each die is rolled to show the die face as a graphic
            Graphics graPaper = picBxDie1.CreateGraphics();
            Graphics graPaper2 = picBxDie2.CreateGraphics();

            //Random event to generate a random number when the RollDice button is clicked

            Random rRollDice = new Random();

            iDie1 = rRollDice.Next(1, 7);
            txtBxDie1.Text = Convert.ToString(iDie1);

            iDie2 = rRollDice.Next(1, 7);
            txtBxDie2.Text = Convert.ToString(iDie2);

            //The two Dice rolled are added together to get the total result
            iDieResult = iDie1 + iDie2;


            //Using graphics to create and replicate the look of actual dice for more ease of use for the user interactivity

            //Creating a new brush for FillEllipse function to call
            SolidBrush brshBlack = new SolidBrush(Color.Black);

            //IF Statements to create the FilleEllipse circles depending on the iDie1 roll number
            if (iDie1 == 1)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 35, 35, 15, 15);
            }
            if (iDie1 == 2)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 60, 15, 15);
            }
            if (iDie1 == 3)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 35, 35, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 60, 15, 15);
            }
            if (iDie1 == 4)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 60, 15, 15);
            }
            if (iDie1 == 5)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 35, 35, 15, 15);
            }
            if (iDie1 == 6)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 35, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 35, 15, 15);
            }


            //IF Statements to create the FilleEllipse circles depending on the iDie2 roll number
            if (iDie2 == 1)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 35, 35, 15, 15);
            }
            if (iDie2 == 2)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 60, 15, 15);
            }
            if (iDie2 == 3)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 35, 35, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 60, 15, 15);
            }
            if (iDie2 == 4)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 60, 15, 15);
            }
            if (iDie2 == 5)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 35, 35, 15, 15);
            }
            if (iDie2 == 6)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 35, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 35, 15, 15);
            }
        }
        #endregion

        #region Roll Dice Button with Die Face Graphics
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            //Graphics events are established to be called when each die is rolled to show the die face as a graphic
            Graphics graPaper = picBxDie1.CreateGraphics();
            Graphics graPaper2 = picBxDie2.CreateGraphics();

            //Random event to generate a random number when the RollDice button is clicked

            Random rRollDice = new Random();

            iDie1 = rRollDice.Next(1, 7);
            txtBxDie1.Text = Convert.ToString(iDie1);

            iDie2 = rRollDice.Next(1, 7);
            txtBxDie2.Text = Convert.ToString(iDie2);

            //The two Dice rolled are added together to get the total result
            iDieResult = iDie1 + iDie2;

            
            //Using graphics to create and replicate the look of actual dice for more ease of use for the user interactivity

            //Creating a new brush for FillEllipse function to call
            SolidBrush brshBlack = new SolidBrush(Color.Black);

            //IF Statements to create the FilleEllipse circles depending on the iDie1 roll number
            if (iDie1 == 1)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 35, 35, 15, 15);
            }
            if (iDie1 == 2)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 60, 15, 15);
            }
            if (iDie1 == 3)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 35, 35, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 60, 15, 15);
            }
            if (iDie1 == 4)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 60, 15, 15);
            }
            if (iDie1 == 5)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 35, 35, 15, 15);
            }
            if (iDie1 == 6)
            {
                graPaper.Clear(Color.White);
                graPaper.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 60, 15, 15);
                graPaper.FillEllipse(brshBlack, 10, 35, 15, 15);
                graPaper.FillEllipse(brshBlack, 60, 35, 15, 15);
            }


            //IF Statements to create the FilleEllipse circles depending on the iDie2 roll number
            if (iDie2 == 1)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 35, 35, 15, 15);
            }
            if (iDie2 == 2)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 60, 15, 15);
            }
            if (iDie2 == 3)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 35, 35, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 60, 15, 15);
            }
            if (iDie2 == 4)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 60, 15, 15);
            }
            if (iDie2 == 5)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 35, 35, 15, 15);
            }
            if (iDie2 == 6)
            {
                graPaper2.Clear(Color.White);
                graPaper2.FillEllipse(brshBlack, 10, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 10, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 60, 15, 15);
                graPaper2.FillEllipse(brshBlack, 10, 35, 15, 15);
                graPaper2.FillEllipse(brshBlack, 60, 35, 15, 15);
            }
            #endregion

            #region Silly Seven Check
            //IF Statements to check if player1 has rolled the "Silly Seven" being a combination of either die containing the number 6 or 1 adding to 7
            //Checking if Die 1 has rolled a 6 or a 1 and setting the Cumulative Score to 0
            if (iDie1 == 6)
            {
                if (iDie2 == 1)
                {
                    if (p1Turn == true)
                    {
                        p1Cumulative = 0;
                        lstBxPlayer1.Items.Add(Convert.ToString(p1Cumulative));
                    }
                    else if (p2Turn == true)
                    {
                        
                        p2Cumulative = 0;
                        lstBxPlayer2.Items.Add(Convert.ToString(p2Cumulative));
                    }
                    //Displays a message box stating that the scores have been lost and to pass the turn
                    MessageBox.Show("You lose your Running Score and your Cumulative Score, Pass the turn!", "Sorry, you got a Silly Seven!");
                }

                if (p1Turn == true)
                {
                    MessageBox.Show(lblPlayer2.Text + "'s Turn");
                    p1Turn = false;
                    p2Turn = true;
                    
                    lblPlayer1.BackColor = SystemColors.Control;
                    lblPlayer2.BackColor = Color.Red;

                    if (chBoxComputer.Checked)
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(2000);
                        btnRollDice.PerformClick();
                        computerFillEllipse();

                        Application.DoEvents();
                        System.Threading.Thread.Sleep(2000);
                        btnRollDice.PerformClick();
                        computerFillEllipse();

                        lblPlayer1.BackColor = Color.Red;
                        lblPlayer2.BackColor = SystemColors.Control;
                        p2Turn = false;
                        p1Turn = true;
                    }
                }
                else if (p2Turn == true)
                {
                    MessageBox.Show(lblPlayer1.Text + "'s Turn");
                    p2Turn = false;
                    p1Turn = true;
                    lblPlayer1.BackColor = Color.Red;
                    lblPlayer2.BackColor = SystemColors.Control;
                }
                

                //This will set the Running Score to 0 and pass the turn to player2.
                iRunningScore = 0;
                lblRunningScore.Text = Convert.ToString(iRunningScore);
            }

            //Checking if Die 1 has rolled a 6 or a 1 and setting the Cumulative Score to 0
            else if (iDie2 == 6)
            {
                if (iDie1 == 1)
                {
                    if (p1Turn == true)
                    {
                        p1Cumulative = 0;
                        lstBxPlayer1.Items.Add(Convert.ToString(p1Cumulative));
                    }
                    else if (p2Turn == true)
                    {
                        p2Cumulative = 0;
                        lstBxPlayer2.Items.Add(Convert.ToString(p2Cumulative));
                    }
                    //Displays a message box stating that the scores have been lost and to pass the turn
                    MessageBox.Show("You lose your Running Score and your Cumulative Score, Pass the turn!", "Sorry, you got a Silly Seven!");
                    
                }

                if (p1Turn == true)
                {
                    MessageBox.Show(lblPlayer2.Text + "'s Turn");
                    p1Turn = false;
                    p2Turn = true;
                    lblPlayer1.BackColor = SystemColors.Control;
                    lblPlayer2.BackColor = Color.Red;

                    if (chBoxComputer.Checked)
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(2000);
                        btnRollDice.PerformClick();
                        computerFillEllipse();

                        Application.DoEvents();
                        System.Threading.Thread.Sleep(2000);
                        btnRollDice.PerformClick();
                        computerFillEllipse();

                        lblPlayer1.BackColor = Color.Red;
                        lblPlayer2.BackColor = SystemColors.Control;
                        p2Turn = false;
                        p1Turn = true;
                    }
                }
                else if (p2Turn == true)
                {
                    MessageBox.Show(lblPlayer1.Text + "'s Turn");
                    p2Turn = false;
                    p1Turn = true;
                    lblPlayer1.BackColor = Color.Red;
                    lblPlayer2.BackColor = SystemColors.Control;
                }
                

                //This will set the Running Score to 0 and pass the turn to player1.
                iRunningScore = 0;
                lblRunningScore.Text = Convert.ToString(iRunningScore);
            }
            else
            {
                //This will set the Running Score to the current result of the combined Die roll and check to see what player has reached the GoalScore and declares the winner.
                iRunningScore = iRunningScore + iDieResult;
                lblRunningScore.Text = Convert.ToString(iRunningScore);

                //IF Statement checking what player's turn it is and adding their current Die Result to their Cumulative Score
                if (p1Turn == true)
                {
                    p1Cumulative = p1Cumulative + iDieResult;
                    lstBxPlayer1.Items.Add(p1Cumulative);
                }
                else if (p2Turn == true)
                {
                    p2Cumulative = p2Cumulative + iDieResult;
                    lstBxPlayer2.Items.Add(p2Cumulative);
                }


                #region Goal Score Winner Check
                //IF Statement checking if the current player's Cumulative Score has reached the Goal Score and displays a message box saying that Player1 has won the game.
                if (p1Cumulative >= iGoalScore)
                {
                    MessageBox.Show(lblPlayer1.Text + " WINS!!!");

                    //This will display a Yes or No option for Player1 to select if they want to restart the game or not.
                    //If they select Yes, it will set all fields to 0
                    string message = "Do you want to Restart?";
                    string title = "Restart";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        lstBxPlayer1.Items.Clear();
                        lstBxPlayer2.Items.Clear();
                        p1Cumulative = 0;
                        p2Cumulative = 0;
                        iRunningScore = 0;
                        lstBxPlayer1.Text = Convert.ToString(p1Cumulative);
                        lstBxPlayer2.Text = Convert.ToString(p2Cumulative);

                        //A For Loop to add 1 round each time the player wins
                        p1RoundsWon = p1RoundsWon + 1;
                        for (int i = 1; i <= p1RoundsWon; i++)
                        {
                            lblP1Rounds.Text = Convert.ToString(p1RoundsWon);
                        }
                    }
                    else
                    //The game will close if No is selected
                    {
                        this.Close();
                    }
                }

                //IF Statement checking if the current player's Cumulative Score has reached the Goal Score and displays a message box saying that Player2 has won the game.
                if (p2Cumulative >= iGoalScore)
                {
                    MessageBox.Show(lblPlayer2.Text + " WINS!!!");

                    //This will display a Yes or No option for Player2 to select if they want to restart the game or not.
                    //If they select Yes, it will set all fields to 0
                    string message = "Do you want to Restart?";
                    string title = "Restart";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        lstBxPlayer1.Items.Clear();
                        lstBxPlayer2.Items.Clear();
                        p1Cumulative = 0;
                        p2Cumulative = 0;
                        iRunningScore = 0;
                        lstBxPlayer1.Text = Convert.ToString(p1Cumulative);
                        lstBxPlayer2.Text = Convert.ToString(p2Cumulative);

                        //A For Loop to add 1 round each time the player wins
                        p2RoundsWon = p2RoundsWon + 1;
                        for (int i = 1; i <= p2RoundsWon; i++)
                        {
                            lblP2Rounds.Text = Convert.ToString(p2RoundsWon);
                        }
                    }
                    else
                    //The game will close if No is selected
                    {
                        this.Close();
                    }
                    #endregion


                }
            }
            #endregion


            //This is the spot where the Cumulative score adds the Running score every button click.


        }
        #region Exit Button
        //Exit button clears all fileds and closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Pass Turn Button
        //When the Pass Turn button is pressed, an IF Statement is run to check what Player's turn it is and then sets the Running Score to 0 and passes the turn to the next player
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

                if (chBoxComputer.Checked)
                {
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(2000);
                    btnRollDice.PerformClick();
                    computerFillEllipse();

                    Application.DoEvents();
                    System.Threading.Thread.Sleep(2000);
                    btnRollDice.PerformClick();
                    computerFillEllipse();

                    lblPlayer1.BackColor = Color.Red;
                    lblPlayer2.BackColor = SystemColors.Control;
                    p2Turn = false;
                    p1Turn = true;
                }
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
        #endregion

        #region Start Game Button
        //When the Start Game button is clicked, all other labels, text boxes and buttons are set to visible and the Start Game button is set to invisible 
        //and also sets the Player 1 label to have a background colour of Red to signify it is Turn 1
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    iGoalScore = Convert.ToInt32(txtBoxScoreLimit.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Please Enter a number");
            //}

            if (txtBoxScoreLimit.Text != "")
            {
                iGoalScore = Convert.ToInt32(txtBoxScoreLimit.Text);
            }
            else
            {
                MessageBox.Show("Please Enter Score Limit");
            }
            
            if ((txtBoxP1Name.Text != "") && (txtBoxP2Name.Text != "") && chBoxComputer.Checked != true)
            {
                txtBoxScoreLimit.Visible = false;

                lblPlayer1.Text = txtBoxP1Name.Text;
                lblPlayer2.Text = txtBoxP2Name.Text;
                txtBoxP1Name.Visible = false;
                txtBoxP2Name.Visible = false;
                lblPlayerName1.Visible = false;
                lblPlayerName2.Visible = false;
                btnRollDice.Visible = true;
                btnPassTurn.Visible = true;
                btnStartGame.Visible = false;
                lblDie1.Visible = true;
                lblDie2.Visible = true;
                lblRunningScoreHead.Visible = true;
                lblRunningScore.Visible = true;
                lstBxPlayer1.Visible = true;
                lstBxPlayer2.Visible = true;
                txtBxDie1.Visible = true;
                txtBxDie2.Visible = true;
                lblRunningScore.Visible = true;
                picBxDie1.Visible = true;
                picBxDie2.Visible = true;
                lblPlayer1.BackColor = new Color();
                lblPlayer1.BackColor = Color.Red;
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblCumulativeScores.Visible = true;
                lblRoundsWonP1.Visible = true;
                lblRoundsWonP2.Visible = true;
                lblP1Rounds.Visible = true;
                lblP2Rounds.Visible = true;
                lblScoreLimitDisp.Visible = true;
                lblScoreLimitDisp.Text = txtBoxScoreLimit.Text;
            }
            else if (txtBoxP1Name.Text != null && chBoxComputer.Checked)
            {
                lblPlayer2.Text = "Computer";
                txtBoxScoreLimit.Visible = false;
                chBoxComputer.Visible = false;
                lblPlayer1.Text = txtBoxP1Name.Text;
                txtBoxP1Name.Visible = false;
                txtBoxP2Name.Visible = false;
                lblPlayerName1.Visible = false;
                lblPlayerName2.Visible = false;
                btnRollDice.Visible = true;
                btnPassTurn.Visible = true;
                btnStartGame.Visible = false;
                lblDie1.Visible = true;
                lblDie2.Visible = true;
                lblRunningScoreHead.Visible = true;
                lblRunningScore.Visible = true;
                lstBxPlayer1.Visible = true;
                lstBxPlayer2.Visible = true;
                txtBxDie1.Visible = true;
                txtBxDie2.Visible = true;
                lblRunningScore.Visible = true;
                picBxDie1.Visible = true;
                picBxDie2.Visible = true;
                lblPlayer1.BackColor = new Color();
                lblPlayer1.BackColor = Color.Red;
                lblPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblCumulativeScores.Visible = true;
                lblRoundsWonP1.Visible = true;
                lblRoundsWonP2.Visible = true;
                lblP1Rounds.Visible = true;
                lblP2Rounds.Visible = true;
                lblScoreLimitDisp.Visible = true;
                lblScoreLimitDisp.Text = txtBoxScoreLimit.Text;
            }
            else 
            {
                MessageBox.Show("Please Enter Player Names");
            }
        }
        #endregion
    }
}
