namespace SixesAndSevens
{
    partial class SixesAndSevens
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnPassTurn = new System.Windows.Forms.Button();
            this.txtBxPlayer1 = new System.Windows.Forms.TextBox();
            this.txtBxPlayer2 = new System.Windows.Forms.TextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.lblRunningScore = new System.Windows.Forms.Label();
            this.txtBxDie1 = new System.Windows.Forms.TextBox();
            this.txtBxDie2 = new System.Windows.Forms.TextBox();
            this.txtBxRunningScore = new System.Windows.Forms.TextBox();
            this.lblCumulativeScores = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(30, 196);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(218, 109);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnPassTurn
            // 
            this.btnPassTurn.Location = new System.Drawing.Point(293, 196);
            this.btnPassTurn.Name = "btnPassTurn";
            this.btnPassTurn.Size = new System.Drawing.Size(216, 109);
            this.btnPassTurn.TabIndex = 1;
            this.btnPassTurn.Text = "Pass Turn";
            this.btnPassTurn.UseVisualStyleBackColor = true;
            this.btnPassTurn.Click += new System.EventHandler(this.btnPassTurn_Click);
            // 
            // txtBxPlayer1
            // 
            this.txtBxPlayer1.Location = new System.Drawing.Point(556, 75);
            this.txtBxPlayer1.Multiline = true;
            this.txtBxPlayer1.Name = "txtBxPlayer1";
            this.txtBxPlayer1.Size = new System.Drawing.Size(100, 339);
            this.txtBxPlayer1.TabIndex = 2;
            // 
            // txtBxPlayer2
            // 
            this.txtBxPlayer2.Location = new System.Drawing.Point(737, 75);
            this.txtBxPlayer2.Multiline = true;
            this.txtBxPlayer2.Name = "txtBxPlayer2";
            this.txtBxPlayer2.Size = new System.Drawing.Size(100, 339);
            this.txtBxPlayer2.TabIndex = 3;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(575, 25);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(755, 25);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Player 2";
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(69, 25);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(46, 20);
            this.lblDie1.TabIndex = 6;
            this.lblDie1.Text = "Die 1";
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(230, 25);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(46, 20);
            this.lblDie2.TabIndex = 7;
            this.lblDie2.Text = "Die 2";
            // 
            // lblRunningScore
            // 
            this.lblRunningScore.AutoSize = true;
            this.lblRunningScore.Location = new System.Drawing.Point(377, 25);
            this.lblRunningScore.Name = "lblRunningScore";
            this.lblRunningScore.Size = new System.Drawing.Size(115, 20);
            this.lblRunningScore.TabIndex = 8;
            this.lblRunningScore.Text = "Running Score";
            // 
            // txtBxDie1
            // 
            this.txtBxDie1.Location = new System.Drawing.Point(30, 75);
            this.txtBxDie1.Multiline = true;
            this.txtBxDie1.Name = "txtBxDie1";
            this.txtBxDie1.Size = new System.Drawing.Size(130, 36);
            this.txtBxDie1.TabIndex = 9;
            // 
            // txtBxDie2
            // 
            this.txtBxDie2.Location = new System.Drawing.Point(194, 75);
            this.txtBxDie2.Multiline = true;
            this.txtBxDie2.Name = "txtBxDie2";
            this.txtBxDie2.Size = new System.Drawing.Size(129, 36);
            this.txtBxDie2.TabIndex = 10;
            // 
            // txtBxRunningScore
            // 
            this.txtBxRunningScore.Location = new System.Drawing.Point(381, 75);
            this.txtBxRunningScore.Multiline = true;
            this.txtBxRunningScore.Name = "txtBxRunningScore";
            this.txtBxRunningScore.Size = new System.Drawing.Size(128, 36);
            this.txtBxRunningScore.TabIndex = 11;
            // 
            // lblCumulativeScores
            // 
            this.lblCumulativeScores.AutoSize = true;
            this.lblCumulativeScores.Location = new System.Drawing.Point(627, 45);
            this.lblCumulativeScores.Name = "lblCumulativeScores";
            this.lblCumulativeScores.Size = new System.Drawing.Size(141, 20);
            this.lblCumulativeScores.TabIndex = 12;
            this.lblCumulativeScores.Text = "Cumulative Scores";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(30, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 38);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(154, 147);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(218, 109);
            this.btnStartGame.TabIndex = 15;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // SixesAndSevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 438);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCumulativeScores);
            this.Controls.Add(this.txtBxRunningScore);
            this.Controls.Add(this.txtBxDie2);
            this.Controls.Add(this.txtBxDie1);
            this.Controls.Add(this.lblRunningScore);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtBxPlayer2);
            this.Controls.Add(this.txtBxPlayer1);
            this.Controls.Add(this.btnPassTurn);
            this.Controls.Add(this.btnRollDice);
            this.Name = "SixesAndSevens";
            this.Text = "SixesAndSevens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnPassTurn;
        private System.Windows.Forms.TextBox txtBxPlayer1;
        private System.Windows.Forms.TextBox txtBxPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.Label lblRunningScore;
        private System.Windows.Forms.TextBox txtBxDie1;
        private System.Windows.Forms.TextBox txtBxDie2;
        private System.Windows.Forms.TextBox txtBxRunningScore;
        private System.Windows.Forms.Label lblCumulativeScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartGame;
    }
}

