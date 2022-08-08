
namespace GuessAWord
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
            this.btnSubmitLetter = new System.Windows.Forms.Button();
            this.btnSubmitWord = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.letterInput = new System.Windows.Forms.TextBox();
            this.wordInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblIncorrectLetters = new System.Windows.Forms.Label();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.wordDisplay = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitLetter
            // 
            this.btnSubmitLetter.Location = new System.Drawing.Point(40, 366);
            this.btnSubmitLetter.Name = "btnSubmitLetter";
            this.btnSubmitLetter.Size = new System.Drawing.Size(178, 48);
            this.btnSubmitLetter.TabIndex = 0;
            this.btnSubmitLetter.Text = "Submit Letter";
            this.btnSubmitLetter.UseVisualStyleBackColor = true;
            this.btnSubmitLetter.Click += new System.EventHandler(this.btnSubmitLetter_Click);
            // 
            // btnSubmitWord
            // 
            this.btnSubmitWord.Location = new System.Drawing.Point(257, 366);
            this.btnSubmitWord.Name = "btnSubmitWord";
            this.btnSubmitWord.Size = new System.Drawing.Size(178, 48);
            this.btnSubmitWord.TabIndex = 1;
            this.btnSubmitWord.Text = "Submit Word";
            this.btnSubmitWord.UseVisualStyleBackColor = true;
            this.btnSubmitWord.Click += new System.EventHandler(this.btnSubmitWord_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(540, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 48);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // letterInput
            // 
            this.letterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterInput.Location = new System.Drawing.Point(82, 33);
            this.letterInput.MaximumSize = new System.Drawing.Size(50, 50);
            this.letterInput.MinimumSize = new System.Drawing.Size(4, 50);
            this.letterInput.Name = "letterInput";
            this.letterInput.Size = new System.Drawing.Size(50, 44);
            this.letterInput.TabIndex = 3;
            // 
            // wordInput
            // 
            this.wordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordInput.Location = new System.Drawing.Point(235, 33);
            this.wordInput.MinimumSize = new System.Drawing.Size(4, 50);
            this.wordInput.Name = "wordInput";
            this.wordInput.Size = new System.Drawing.Size(178, 44);
            this.wordInput.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.letterInput);
            this.groupBox1.Controls.Add(this.wordInput);
            this.groupBox1.Location = new System.Drawing.Point(22, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 191);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblIncorrectLetters);
            this.groupBox2.Controls.Add(this.lblGuessed);
            this.groupBox2.Controls.Add(this.lblInstructions);
            this.groupBox2.Controls.Add(this.wordDisplay);
            this.groupBox2.Location = new System.Drawing.Point(22, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 229);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lblIncorrectLetters
            // 
            this.lblIncorrectLetters.AutoSize = true;
            this.lblIncorrectLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectLetters.Location = new System.Drawing.Point(66, 151);
            this.lblIncorrectLetters.MinimumSize = new System.Drawing.Size(300, 50);
            this.lblIncorrectLetters.Name = "lblIncorrectLetters";
            this.lblIncorrectLetters.Size = new System.Drawing.Size(300, 50);
            this.lblIncorrectLetters.TabIndex = 3;
            this.lblIncorrectLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessed.Location = new System.Drawing.Point(66, 119);
            this.lblGuessed.MinimumSize = new System.Drawing.Size(300, 50);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(300, 50);
            this.lblGuessed.TabIndex = 2;
            this.lblGuessed.Text = "Incorrect Letters:";
            this.lblGuessed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGuessed.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(46, 16);
            this.lblInstructions.MinimumSize = new System.Drawing.Size(300, 50);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(342, 50);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Guess the word below!";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordDisplay
            // 
            this.wordDisplay.AutoSize = true;
            this.wordDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordDisplay.Location = new System.Drawing.Point(12, 64);
            this.wordDisplay.MinimumSize = new System.Drawing.Size(411, 55);
            this.wordDisplay.Name = "wordDisplay";
            this.wordDisplay.Size = new System.Drawing.Size(411, 55);
            this.wordDisplay.TabIndex = 0;
            this.wordDisplay.Text = "1 2 3 4 5 6 7 8 9 0";
            this.wordDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(463, 171);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(332, 73);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "Great Job!";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinner.Visible = false;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.Location = new System.Drawing.Point(463, 171);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(324, 73);
            this.lblWrong.TabIndex = 8;
            this.lblWrong.Text = "Try Again!";
            this.lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrong.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmitWord);
            this.Controls.Add(this.btnSubmitLetter);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Word Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitLetter;
        private System.Windows.Forms.Button btnSubmitWord;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox letterInput;
        private System.Windows.Forms.TextBox wordInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label wordDisplay;
        private System.Windows.Forms.Label lblIncorrectLetters;
        private System.Windows.Forms.Label lblGuessed;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblWrong;
    }
}

