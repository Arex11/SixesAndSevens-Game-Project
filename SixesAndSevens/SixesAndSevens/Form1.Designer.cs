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
            this.lstBxPlayer1 = new System.Windows.Forms.ListBox();
            this.lstBxPlayer2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDie2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(30, 301);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(143, 69);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnPassTurn
            // 
            this.btnPassTurn.Location = new System.Drawing.Point(180, 300);
            this.btnPassTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPassTurn.Name = "btnPassTurn";
            this.btnPassTurn.Size = new System.Drawing.Size(144, 70);
            this.btnPassTurn.TabIndex = 1;
            this.btnPassTurn.Text = "Pass Turn";
            this.btnPassTurn.UseVisualStyleBackColor = true;
            this.btnPassTurn.Click += new System.EventHandler(this.btnPassTurn_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(575, 25);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer1.TabIndex = 4;
            this.lblPlayer1.Text = "Player 1";
            this.lblPlayer1.Visible = false;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(755, 25);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(65, 20);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "Player 2";
            this.lblPlayer2.Visible = false;
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(69, 25);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(46, 20);
            this.lblDie1.TabIndex = 6;
            this.lblDie1.Text = "Die 1";
            this.lblDie1.Visible = false;
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(230, 25);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(46, 20);
            this.lblDie2.TabIndex = 7;
            this.lblDie2.Text = "Die 2";
            this.lblDie2.Visible = false;
            // 
            // lblRunningScoreHead
            // 
            this.lblRunningScoreHead.AutoSize = true;
            this.lblRunningScoreHead.Location = new System.Drawing.Point(396, 79);
            this.lblRunningScoreHead.Name = "lblRunningScoreHead";
            this.lblRunningScoreHead.Size = new System.Drawing.Size(119, 20);
            this.lblRunningScoreHead.TabIndex = 8;
            this.lblRunningScoreHead.Text = "Running Score:";
            this.lblRunningScoreHead.Visible = false;
            // 
            // txtBxDie1
            // 
            this.txtBxDie1.Location = new System.Drawing.Point(30, 84);
            this.txtBxDie1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxDie1.Multiline = true;
            this.txtBxDie1.Name = "txtBxDie1";
            this.txtBxDie1.Size = new System.Drawing.Size(130, 36);
            this.txtBxDie1.TabIndex = 9;
            this.txtBxDie1.Visible = false;
            // 
            // txtBxDie2
            // 
            this.txtBxDie2.Location = new System.Drawing.Point(194, 84);
            this.txtBxDie2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBxDie2.Multiline = true;
            this.txtBxDie2.Name = "txtBxDie2";
            this.txtBxDie2.Size = new System.Drawing.Size(129, 36);
            this.txtBxDie2.TabIndex = 10;
            this.txtBxDie2.Visible = false;
            // 
            // lblCumulativeScores
            // 
            this.lblCumulativeScores.AutoSize = true;
            this.lblCumulativeScores.Location = new System.Drawing.Point(649, 45);
            this.lblCumulativeScores.Name = "lblCumulativeScores";
            this.lblCumulativeScores.Size = new System.Drawing.Size(141, 20);
            this.lblCumulativeScores.TabIndex = 12;
            this.lblCumulativeScores.Text = "Cumulative Scores";
            this.lblCumulativeScores.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(30, 386);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 38);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(343, 148);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(218, 109);
            this.btnStartGame.TabIndex = 15;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // picBxDie1
            // 
            this.picBxDie1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBxDie1.Location = new System.Drawing.Point(30, 128);
            this.picBxDie1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBxDie1.Name = "picBxDie1";
            this.picBxDie1.Size = new System.Drawing.Size(130, 138);
            this.picBxDie1.TabIndex = 16;
            this.picBxDie1.TabStop = false;
            this.picBxDie1.Visible = false;
            // 
            // picBxDie2
            // 
            this.picBxDie2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBxDie2.Location = new System.Drawing.Point(194, 128);
            this.picBxDie2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBxDie2.Name = "picBxDie2";
            this.picBxDie2.Size = new System.Drawing.Size(130, 138);
            this.picBxDie2.TabIndex = 17;
            this.picBxDie2.TabStop = false;
            this.picBxDie2.Visible = false;
            // 
            // lblRoundsWonP1
            // 
            this.lblRoundsWonP1.AutoSize = true;
            this.lblRoundsWonP1.Location = new System.Drawing.Point(575, 350);
            this.lblRoundsWonP1.Name = "lblRoundsWonP1";
            this.lblRoundsWonP1.Size = new System.Drawing.Size(106, 20);
            this.lblRoundsWonP1.TabIndex = 18;
            this.lblRoundsWonP1.Text = "Rounds Won:";
            this.lblRoundsWonP1.Visible = false;
            // 
            // lblP1Rounds
            // 
            this.lblP1Rounds.AutoSize = true;
            this.lblP1Rounds.Location = new System.Drawing.Point(627, 384);
            this.lblP1Rounds.Name = "lblP1Rounds";
            this.lblP1Rounds.Size = new System.Drawing.Size(18, 20);
            this.lblP1Rounds.TabIndex = 19;
            this.lblP1Rounds.Text = "0";
            this.lblP1Rounds.Visible = false;
            // 
            // lblRoundsWonP2
            // 
            this.lblRoundsWonP2.AutoSize = true;
            this.lblRoundsWonP2.Location = new System.Drawing.Point(747, 350);
            this.lblRoundsWonP2.Name = "lblRoundsWonP2";
            this.lblRoundsWonP2.Size = new System.Drawing.Size(106, 20);
            this.lblRoundsWonP2.TabIndex = 20;
            this.lblRoundsWonP2.Text = "Rounds Won:";
            this.lblRoundsWonP2.Visible = false;
            // 
            // lblP2Rounds
            // 
            this.lblP2Rounds.AutoSize = true;
            this.lblP2Rounds.Location = new System.Drawing.Point(793, 384);
            this.lblP2Rounds.Name = "lblP2Rounds";
            this.lblP2Rounds.Size = new System.Drawing.Size(18, 20);
            this.lblP2Rounds.TabIndex = 21;
            this.lblP2Rounds.Text = "0";
            this.lblP2Rounds.Visible = false;
            // 
            // lblRunningScore
            // 
            this.lblRunningScore.AutoSize = true;
            this.lblRunningScore.Location = new System.Drawing.Point(446, 111);
            this.lblRunningScore.Name = "lblRunningScore";
            this.lblRunningScore.Size = new System.Drawing.Size(18, 20);
            this.lblRunningScore.TabIndex = 22;
            this.lblRunningScore.Text = "0";
            this.lblRunningScore.Visible = false;
            // 
            // lstBxPlayer1
            // 
            this.lstBxPlayer1.FormattingEnabled = true;
            this.lstBxPlayer1.ItemHeight = 20;
            this.lstBxPlayer1.Location = new System.Drawing.Point(579, 79);
            this.lstBxPlayer1.Name = "lstBxPlayer1";
            this.lstBxPlayer1.Size = new System.Drawing.Size(112, 244);
            this.lstBxPlayer1.TabIndex = 23;
            // 
            // lstBxPlayer2
            // 
            this.lstBxPlayer2.FormattingEnabled = true;
            this.lstBxPlayer2.ItemHeight = 20;
            this.lstBxPlayer2.Location = new System.Drawing.Point(751, 79);
            this.lstBxPlayer2.Name = "lstBxPlayer2";
            this.lstBxPlayer2.Size = new System.Drawing.Size(107, 244);
            this.lstBxPlayer2.TabIndex = 24;
            // 
            // SixesAndSevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 438);
            this.Controls.Add(this.lstBxPlayer2);
            this.Controls.Add(this.lstBxPlayer1);
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
        private System.Windows.Forms.ListBox lstBxPlayer1;
        private System.Windows.Forms.ListBox lstBxPlayer2;
    }
}

