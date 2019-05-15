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
            this.lblRunningScoreHead = new System.Windows.Forms.Label();
            this.txtBxDie1 = new System.Windows.Forms.TextBox();
            this.txtBxDie2 = new System.Windows.Forms.TextBox();
            this.lblCumulativeScores = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.picBxDie1 = new System.Windows.Forms.PictureBox();
            this.picBxDie2 = new System.Windows.Forms.PictureBox();
            this.lblRoundsWonP1 = new System.Windows.Forms.Label();
            this.lblP1Rounds = new System.Windows.Forms.Label();
            this.lblRoundsWonP2 = new System.Windows.Forms.Label();
            this.lblP2Rounds = new System.Windows.Forms.Label();
            this.lblRunningScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(27, 241);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(127, 55);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnPassTurn
            // 
            this.btnPassTurn.Location = new System.Drawing.Point(160, 240);
            this.btnPassTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPassTurn.Name = "btnPassTurn";
            this.btnPassTurn.Size = new System.Drawing.Size(128, 56);
            this.btnPassTurn.TabIndex = 1;
            this.btnPassTurn.Text = "Pass Turn";
            this.btnPassTurn.UseVisualStyleBackColor = true;
            this.btnPassTurn.Click += new System.EventHandler(this.btnPassTurn_Click);
            // 
            // txtBxPlayer1
            // 
            this.txtBxPlayer1.Location = new System.Drawing.Point(494, 60);
            this.txtBxPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxPlayer1.Multiline = true;
            this.txtBxPlayer1.Name = "txtBxPlayer1";
            this.txtBxPlayer1.Size = new System.Drawing.Size(89, 159);
            this.txtBxPlayer1.TabIndex = 2;
            this.txtBxPlayer1.Visible = false;
            // 
            // txtBxPlayer2
            // 
            this.txtBxPlayer2.Location = new System.Drawing.Point(655, 60);
            this.txtBxPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxPlayer2.Multiline = true;
            this.txtBxPlayer2.Name = "txtBxPlayer2";
            this.txtBxPlayer2.Size = new System.Drawing.Size(89, 159);
            this.txtBxPlayer2.TabIndex = 3;
            this.txtBxPlayer2.Visible = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(511, 20);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(60, 17);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Player 1";
            this.lblPlayer1.Visible = false;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(671, 20);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(60, 17);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Player 2";
            this.lblPlayer2.Visible = false;
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(61, 20);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(41, 17);
            this.lblDie1.TabIndex = 6;
            this.lblDie1.Text = "Die 1";
            this.lblDie1.Visible = false;
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(204, 20);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(41, 17);
            this.lblDie2.TabIndex = 7;
            this.lblDie2.Text = "Die 2";
            this.lblDie2.Visible = false;
            // 
            // lblRunningScoreHead
            // 
            this.lblRunningScoreHead.AutoSize = true;
            this.lblRunningScoreHead.Location = new System.Drawing.Point(352, 63);
            this.lblRunningScoreHead.Name = "lblRunningScoreHead";
            this.lblRunningScoreHead.Size = new System.Drawing.Size(106, 17);
            this.lblRunningScoreHead.TabIndex = 8;
            this.lblRunningScoreHead.Text = "Running Score:";
            this.lblRunningScoreHead.Visible = false;
            // 
            // txtBxDie1
            // 
            this.txtBxDie1.Location = new System.Drawing.Point(27, 60);
            this.txtBxDie1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxDie1.Multiline = true;
            this.txtBxDie1.Name = "txtBxDie1";
            this.txtBxDie1.Size = new System.Drawing.Size(116, 30);
            this.txtBxDie1.TabIndex = 9;
            this.txtBxDie1.Visible = false;
            // 
            // txtBxDie2
            // 
            this.txtBxDie2.Location = new System.Drawing.Point(172, 60);
            this.txtBxDie2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxDie2.Multiline = true;
            this.txtBxDie2.Name = "txtBxDie2";
            this.txtBxDie2.Size = new System.Drawing.Size(115, 30);
            this.txtBxDie2.TabIndex = 10;
            this.txtBxDie2.Visible = false;
            // 
            // lblCumulativeScores
            // 
            this.lblCumulativeScores.AutoSize = true;
            this.lblCumulativeScores.Location = new System.Drawing.Point(557, 36);
            this.lblCumulativeScores.Name = "lblCumulativeScores";
            this.lblCumulativeScores.Size = new System.Drawing.Size(125, 17);
            this.lblCumulativeScores.TabIndex = 12;
            this.lblCumulativeScores.Text = "Cumulative Scores";
            this.lblCumulativeScores.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(27, 309);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 30);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(294, 118);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(194, 87);
            this.btnStartGame.TabIndex = 15;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // picBxDie1
            // 
            this.picBxDie1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBxDie1.Location = new System.Drawing.Point(27, 95);
            this.picBxDie1.Name = "picBxDie1";
            this.picBxDie1.Size = new System.Drawing.Size(116, 110);
            this.picBxDie1.TabIndex = 16;
            this.picBxDie1.TabStop = false;
            this.picBxDie1.Visible = false;
            // 
            // picBxDie2
            // 
            this.picBxDie2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBxDie2.Location = new System.Drawing.Point(172, 95);
            this.picBxDie2.Name = "picBxDie2";
            this.picBxDie2.Size = new System.Drawing.Size(116, 110);
            this.picBxDie2.TabIndex = 17;
            this.picBxDie2.TabStop = false;
            this.picBxDie2.Visible = false;
            // 
            // lblRoundsWonP1
            // 
            this.lblRoundsWonP1.AutoSize = true;
            this.lblRoundsWonP1.Location = new System.Drawing.Point(494, 264);
            this.lblRoundsWonP1.Name = "lblRoundsWonP1";
            this.lblRoundsWonP1.Size = new System.Drawing.Size(94, 17);
            this.lblRoundsWonP1.TabIndex = 18;
            this.lblRoundsWonP1.Text = "Rounds Won:";
            this.lblRoundsWonP1.Visible = false;
            // 
            // lblP1Rounds
            // 
            this.lblP1Rounds.AutoSize = true;
            this.lblP1Rounds.Location = new System.Drawing.Point(529, 291);
            this.lblP1Rounds.Name = "lblP1Rounds";
            this.lblP1Rounds.Size = new System.Drawing.Size(16, 17);
            this.lblP1Rounds.TabIndex = 19;
            this.lblP1Rounds.Text = "0";
            this.lblP1Rounds.Visible = false;
            // 
            // lblRoundsWonP2
            // 
            this.lblRoundsWonP2.AutoSize = true;
            this.lblRoundsWonP2.Location = new System.Drawing.Point(652, 264);
            this.lblRoundsWonP2.Name = "lblRoundsWonP2";
            this.lblRoundsWonP2.Size = new System.Drawing.Size(90, 17);
            this.lblRoundsWonP2.TabIndex = 20;
            this.lblRoundsWonP2.Text = "Rounds Won";
            this.lblRoundsWonP2.Visible = false;
            // 
            // lblP2Rounds
            // 
            this.lblP2Rounds.AutoSize = true;
            this.lblP2Rounds.Location = new System.Drawing.Point(692, 291);
            this.lblP2Rounds.Name = "lblP2Rounds";
            this.lblP2Rounds.Size = new System.Drawing.Size(16, 17);
            this.lblP2Rounds.TabIndex = 21;
            this.lblP2Rounds.Text = "0";
            this.lblP2Rounds.Visible = false;
            // 
            // lblRunningScore
            // 
            this.lblRunningScore.AutoSize = true;
            this.lblRunningScore.Location = new System.Drawing.Point(396, 95);
            this.lblRunningScore.Name = "lblRunningScore";
            this.lblRunningScore.Size = new System.Drawing.Size(16, 17);
            this.lblRunningScore.TabIndex = 22;
            this.lblRunningScore.Text = "0";
            this.lblRunningScore.Visible = false;
            // 
            // SixesAndSevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 350);
            this.Controls.Add(this.lblRunningScore);
            this.Controls.Add(this.lblP2Rounds);
            this.Controls.Add(this.lblRoundsWonP2);
            this.Controls.Add(this.lblP1Rounds);
            this.Controls.Add(this.lblRoundsWonP1);
            this.Controls.Add(this.picBxDie2);
            this.Controls.Add(this.picBxDie1);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCumulativeScores);
            this.Controls.Add(this.txtBxDie2);
            this.Controls.Add(this.txtBxDie1);
            this.Controls.Add(this.lblRunningScoreHead);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.lblDie1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtBxPlayer2);
            this.Controls.Add(this.txtBxPlayer1);
            this.Controls.Add(this.btnPassTurn);
            this.Controls.Add(this.btnRollDice);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SixesAndSevens";
            this.Text = "SixesAndSevens";
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie2)).EndInit();
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
        private System.Windows.Forms.Label lblRunningScoreHead;
        private System.Windows.Forms.TextBox txtBxDie1;
        private System.Windows.Forms.TextBox txtBxDie2;
        private System.Windows.Forms.Label lblCumulativeScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox picBxDie1;
        private System.Windows.Forms.PictureBox picBxDie2;
        private System.Windows.Forms.Label lblRoundsWonP1;
        private System.Windows.Forms.Label lblP1Rounds;
        private System.Windows.Forms.Label lblRoundsWonP2;
        private System.Windows.Forms.Label lblP2Rounds;
        private System.Windows.Forms.Label lblRunningScore;
    }
}

