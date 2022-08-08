
namespace WarGameKBrundage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblOppValue = new System.Windows.Forms.Label();
            this.lblPlayerValue = new System.Windows.Forms.Label();
            this.lblOppName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.picOppCard = new System.Windows.Forms.PictureBox();
            this.picPlayerCard = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblTieCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOppCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(89, 434);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 70);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(351, 434);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(152, 70);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "A Spin On The Classic Card Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 317);
            this.label2.MinimumSize = new System.Drawing.Size(343, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ready to Play?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WarGameKBrundage.Properties.Resources.warcards;
            this.pictureBox1.InitialImage = global::WarGameKBrundage.Properties.Resources.warcards;
            this.pictureBox1.Location = new System.Drawing.Point(130, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(258, 315);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 13;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Visible = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lblOppValue
            // 
            this.lblOppValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppValue.Location = new System.Drawing.Point(351, 314);
            this.lblOppValue.Name = "lblOppValue";
            this.lblOppValue.Size = new System.Drawing.Size(185, 20);
            this.lblOppValue.TabIndex = 12;
            this.lblOppValue.Text = "Opponent Score:";
            this.lblOppValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOppValue.Visible = false;
            // 
            // lblPlayerValue
            // 
            this.lblPlayerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerValue.Location = new System.Drawing.Point(56, 314);
            this.lblPlayerValue.Name = "lblPlayerValue";
            this.lblPlayerValue.Size = new System.Drawing.Size(185, 20);
            this.lblPlayerValue.TabIndex = 11;
            this.lblPlayerValue.Text = "Player Score: ";
            this.lblPlayerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerValue.Visible = false;
            // 
            // lblOppName
            // 
            this.lblOppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppName.Location = new System.Drawing.Point(351, 5);
            this.lblOppName.Name = "lblOppName";
            this.lblOppName.Size = new System.Drawing.Size(185, 28);
            this.lblOppName.TabIndex = 10;
            this.lblOppName.Text = "Opponent Card";
            this.lblOppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOppName.Visible = false;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(56, 5);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(185, 28);
            this.lblPlayerName.TabIndex = 9;
            this.lblPlayerName.Text = "Player Card";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerName.Visible = false;
            // 
            // picOppCard
            // 
            this.picOppCard.Image = ((System.Drawing.Image)(resources.GetObject("picOppCard.Image")));
            this.picOppCard.Location = new System.Drawing.Point(351, 28);
            this.picOppCard.Name = "picOppCard";
            this.picOppCard.Size = new System.Drawing.Size(185, 263);
            this.picOppCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOppCard.TabIndex = 8;
            this.picOppCard.TabStop = false;
            this.picOppCard.Visible = false;
            // 
            // picPlayerCard
            // 
            this.picPlayerCard.Image = ((System.Drawing.Image)(resources.GetObject("picPlayerCard.Image")));
            this.picPlayerCard.Location = new System.Drawing.Point(56, 28);
            this.picPlayerCard.Name = "picPlayerCard";
            this.picPlayerCard.Size = new System.Drawing.Size(185, 263);
            this.picPlayerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard.TabIndex = 7;
            this.picPlayerCard.TabStop = false;
            this.picPlayerCard.Visible = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(2, 362);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(588, 72);
            this.lblGameOver.TabIndex = 14;
            this.lblGameOver.Text = "game over message";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // lblTieCount
            // 
            this.lblTieCount.Location = new System.Drawing.Point(5, 349);
            this.lblTieCount.Name = "lblTieCount";
            this.lblTieCount.Size = new System.Drawing.Size(585, 23);
            this.lblTieCount.TabIndex = 15;
            this.lblTieCount.Text = "Ties: ";
            this.lblTieCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieCount.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 525);
            this.Controls.Add(this.lblTieCount);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.lblOppValue);
            this.Controls.Add(this.lblPlayerValue);
            this.Controls.Add(this.lblOppName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.picOppCard);
            this.Controls.Add(this.picPlayerCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOppCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lblOppValue;
        private System.Windows.Forms.Label lblPlayerValue;
        private System.Windows.Forms.Label lblOppName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.PictureBox picOppCard;
        private System.Windows.Forms.PictureBox picPlayerCard;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblTieCount;
    }
}

