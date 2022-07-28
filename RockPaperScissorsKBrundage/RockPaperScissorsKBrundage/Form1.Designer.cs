
namespace RockPaperScissorsKBrundage
{
    partial class Form1
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
            this.btnRock = new System.Windows.Forms.PictureBox();
            this.btnPaper = new System.Windows.Forms.PictureBox();
            this.btnScissors = new System.Windows.Forms.PictureBox();
            this.lblHeadline1 = new System.Windows.Forms.Label();
            this.lblHeadline2 = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblOppWins = new System.Windows.Forms.Label();
            this.lblPlayerCnt = new System.Windows.Forms.Label();
            this.lblOppCnt = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.picPlayerChoice = new System.Windows.Forms.PictureBox();
            this.picOppChoice = new System.Windows.Forms.PictureBox();
            this.lblOppChoice = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDrawCnt = new System.Windows.Forms.Label();
            this.lblDraws = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOppChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRock.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Rock;
            this.btnRock.Location = new System.Drawing.Point(93, 144);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(150, 150);
            this.btnRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRock.TabIndex = 0;
            this.btnRock.TabStop = false;
            this.btnRock.Click += new System.EventHandler(this.rock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPaper.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Paper;
            this.btnPaper.Location = new System.Drawing.Point(341, 144);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(150, 150);
            this.btnPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPaper.TabIndex = 1;
            this.btnPaper.TabStop = false;
            this.btnPaper.Click += new System.EventHandler(this.paper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnScissors.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Scissors;
            this.btnScissors.Location = new System.Drawing.Point(588, 144);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(150, 150);
            this.btnScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnScissors.TabIndex = 2;
            this.btnScissors.TabStop = false;
            this.btnScissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // lblHeadline1
            // 
            this.lblHeadline1.AutoSize = true;
            this.lblHeadline1.Font = new System.Drawing.Font("Rockwell Extra Bold", 31F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline1.Location = new System.Drawing.Point(46, 28);
            this.lblHeadline1.Name = "lblHeadline1";
            this.lblHeadline1.Size = new System.Drawing.Size(742, 50);
            this.lblHeadline1.TabIndex = 3;
            this.lblHeadline1.Text = "LET\'S GET READY TO RUMBLE";
            // 
            // lblHeadline2
            // 
            this.lblHeadline2.AutoSize = true;
            this.lblHeadline2.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadline2.Location = new System.Drawing.Point(243, 95);
            this.lblHeadline2.Name = "lblHeadline2";
            this.lblHeadline2.Size = new System.Drawing.Size(344, 32);
            this.lblHeadline2.TabIndex = 4;
            this.lblHeadline2.Text = "Choose your fighter:";
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.Location = new System.Drawing.Point(2, 426);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(131, 32);
            this.lblPlayerWins.TabIndex = 5;
            this.lblPlayerWins.Text = "Player:";
            // 
            // lblOppWins
            // 
            this.lblOppWins.AutoSize = true;
            this.lblOppWins.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppWins.Location = new System.Drawing.Point(2, 458);
            this.lblOppWins.Name = "lblOppWins";
            this.lblOppWins.Size = new System.Drawing.Size(188, 32);
            this.lblOppWins.TabIndex = 6;
            this.lblOppWins.Text = "Opponent:";
            // 
            // lblPlayerCnt
            // 
            this.lblPlayerCnt.AutoSize = true;
            this.lblPlayerCnt.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCnt.Location = new System.Drawing.Point(127, 426);
            this.lblPlayerCnt.Name = "lblPlayerCnt";
            this.lblPlayerCnt.Size = new System.Drawing.Size(34, 32);
            this.lblPlayerCnt.TabIndex = 7;
            this.lblPlayerCnt.Text = "0";
            // 
            // lblOppCnt
            // 
            this.lblOppCnt.AutoSize = true;
            this.lblOppCnt.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppCnt.Location = new System.Drawing.Point(185, 458);
            this.lblOppCnt.Name = "lblOppCnt";
            this.lblOppCnt.Size = new System.Drawing.Size(34, 32);
            this.lblOppCnt.TabIndex = 8;
            this.lblOppCnt.Text = "0";
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChoice.Location = new System.Drawing.Point(56, 308);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(237, 32);
            this.lblPlayerChoice.TabIndex = 9;
            this.lblPlayerChoice.Text = "Player Chose:";
            this.lblPlayerChoice.Visible = false;
            // 
            // picPlayerChoice
            // 
            this.picPlayerChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPlayerChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayerChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Rock;
            this.picPlayerChoice.Location = new System.Drawing.Point(299, 308);
            this.picPlayerChoice.Name = "picPlayerChoice";
            this.picPlayerChoice.Size = new System.Drawing.Size(40, 40);
            this.picPlayerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerChoice.TabIndex = 10;
            this.picPlayerChoice.TabStop = false;
            this.picPlayerChoice.Visible = false;
            // 
            // picOppChoice
            // 
            this.picOppChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picOppChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Rock;
            this.picOppChoice.Location = new System.Drawing.Point(699, 308);
            this.picOppChoice.Name = "picOppChoice";
            this.picOppChoice.Size = new System.Drawing.Size(40, 40);
            this.picOppChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOppChoice.TabIndex = 12;
            this.picOppChoice.TabStop = false;
            this.picOppChoice.Visible = false;
            // 
            // lblOppChoice
            // 
            this.lblOppChoice.AutoSize = true;
            this.lblOppChoice.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppChoice.Location = new System.Drawing.Point(399, 308);
            this.lblOppChoice.Name = "lblOppChoice";
            this.lblOppChoice.Size = new System.Drawing.Size(294, 32);
            this.lblOppChoice.TabIndex = 11;
            this.lblOppChoice.Text = "Opponent Chose:";
            this.lblOppChoice.Visible = false;
            // 
            // lblWinner
            // 
            this.lblWinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Rockwell Extra Bold", 31F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(332, 368);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(173, 50);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "DRAW";
            this.lblWinner.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(3)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.button1.Location = new System.Drawing.Point(630, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 68);
            this.button1.TabIndex = 14;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDrawCnt
            // 
            this.lblDrawCnt.AutoSize = true;
            this.lblDrawCnt.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawCnt.Location = new System.Drawing.Point(127, 394);
            this.lblDrawCnt.Name = "lblDrawCnt";
            this.lblDrawCnt.Size = new System.Drawing.Size(34, 32);
            this.lblDrawCnt.TabIndex = 16;
            this.lblDrawCnt.Text = "0";
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraws.Location = new System.Drawing.Point(2, 394);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(130, 32);
            this.lblDraws.TabIndex = 15;
            this.lblDraws.Text = "Draws:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.lblDrawCnt);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.picOppChoice);
            this.Controls.Add(this.lblOppChoice);
            this.Controls.Add(this.picPlayerChoice);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.lblOppCnt);
            this.Controls.Add(this.lblPlayerCnt);
            this.Controls.Add(this.lblOppWins);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblHeadline2);
            this.Controls.Add(this.lblHeadline1);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.btnRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOppChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnRock;
        private System.Windows.Forms.PictureBox btnPaper;
        private System.Windows.Forms.PictureBox btnScissors;
        private System.Windows.Forms.Label lblHeadline1;
        private System.Windows.Forms.Label lblHeadline2;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblOppWins;
        private System.Windows.Forms.Label lblPlayerCnt;
        private System.Windows.Forms.Label lblOppCnt;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.PictureBox picPlayerChoice;
        private System.Windows.Forms.PictureBox picOppChoice;
        private System.Windows.Forms.Label lblOppChoice;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDrawCnt;
        private System.Windows.Forms.Label lblDraws;
    }
}

