
namespace HeadsOrTails
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.showHeads = new System.Windows.Forms.Button();
            this.showTails = new System.Windows.Forms.Button();
            this.resetCoin = new System.Windows.Forms.Button();
            this.flipCoin = new System.Windows.Forms.Button();
            this.labelHeads = new System.Windows.Forms.Label();
            this.labelTails = new System.Windows.Forms.Label();
            this.counterHeads = new System.Windows.Forms.Label();
            this.counterTails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // picCoin
            // 
            this.picCoin.Image = global::HeadsOrTails.Properties.Resources.fiftyCents;
            this.picCoin.Location = new System.Drawing.Point(49, 106);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(200, 200);
            this.picCoin.TabIndex = 0;
            this.picCoin.TabStop = false;
            // 
            // showHeads
            // 
            this.showHeads.Location = new System.Drawing.Point(297, 106);
            this.showHeads.Name = "showHeads";
            this.showHeads.Size = new System.Drawing.Size(89, 23);
            this.showHeads.TabIndex = 1;
            this.showHeads.Text = "Show Heads";
            this.showHeads.UseVisualStyleBackColor = true;
            this.showHeads.Click += new System.EventHandler(this.showHeads_Click);
            // 
            // showTails
            // 
            this.showTails.Location = new System.Drawing.Point(297, 156);
            this.showTails.Name = "showTails";
            this.showTails.Size = new System.Drawing.Size(89, 23);
            this.showTails.TabIndex = 2;
            this.showTails.Text = "Show Tails";
            this.showTails.UseVisualStyleBackColor = true;
            this.showTails.Click += new System.EventHandler(this.showTails_Click);
            // 
            // resetCoin
            // 
            this.resetCoin.Location = new System.Drawing.Point(297, 207);
            this.resetCoin.Name = "resetCoin";
            this.resetCoin.Size = new System.Drawing.Size(89, 23);
            this.resetCoin.TabIndex = 3;
            this.resetCoin.Text = "Reset";
            this.resetCoin.UseVisualStyleBackColor = true;
            this.resetCoin.Click += new System.EventHandler(this.resetCoin_Click);
            // 
            // flipCoin
            // 
            this.flipCoin.Location = new System.Drawing.Point(297, 282);
            this.flipCoin.Name = "flipCoin";
            this.flipCoin.Size = new System.Drawing.Size(89, 58);
            this.flipCoin.TabIndex = 4;
            this.flipCoin.Text = "FLIP!";
            this.flipCoin.UseVisualStyleBackColor = true;
            this.flipCoin.Click += new System.EventHandler(this.flipCoin_Click);
            // 
            // labelHeads
            // 
            this.labelHeads.AutoSize = true;
            this.labelHeads.Location = new System.Drawing.Point(85, 349);
            this.labelHeads.Name = "labelHeads";
            this.labelHeads.Size = new System.Drawing.Size(40, 15);
            this.labelHeads.TabIndex = 5;
            this.labelHeads.Text = "Heads";
            // 
            // labelTails
            // 
            this.labelTails.AutoSize = true;
            this.labelTails.Location = new System.Drawing.Point(179, 349);
            this.labelTails.Name = "labelTails";
            this.labelTails.Size = new System.Drawing.Size(29, 15);
            this.labelTails.TabIndex = 6;
            this.labelTails.Text = "Tails";
            // 
            // counterHeads
            // 
            this.counterHeads.AutoSize = true;
            this.counterHeads.Location = new System.Drawing.Point(85, 375);
            this.counterHeads.Name = "counterHeads";
            this.counterHeads.Size = new System.Drawing.Size(13, 15);
            this.counterHeads.TabIndex = 7;
            this.counterHeads.Text = "0";
            // 
            // counterTails
            // 
            this.counterTails.AutoSize = true;
            this.counterTails.Location = new System.Drawing.Point(179, 375);
            this.counterTails.Name = "counterTails";
            this.counterTails.Size = new System.Drawing.Size(13, 15);
            this.counterTails.TabIndex = 8;
            this.counterTails.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.counterTails);
            this.Controls.Add(this.counterHeads);
            this.Controls.Add(this.labelTails);
            this.Controls.Add(this.labelHeads);
            this.Controls.Add(this.flipCoin);
            this.Controls.Add(this.resetCoin);
            this.Controls.Add(this.showTails);
            this.Controls.Add(this.showHeads);
            this.Controls.Add(this.picCoin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.Button showHeads;
        private System.Windows.Forms.Button showTails;
        private System.Windows.Forms.Button resetCoin;
        private System.Windows.Forms.Button flipCoin;
        private System.Windows.Forms.Label labelHeads;
        private System.Windows.Forms.Label labelTails;
        private System.Windows.Forms.Label counterHeads;
        private System.Windows.Forms.Label counterTails;
    }
}

