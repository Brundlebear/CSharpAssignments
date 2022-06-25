
namespace CurrencyConverter
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
            this.flag1 = new System.Windows.Forms.PictureBox();
            this.flag2 = new System.Windows.Forms.PictureBox();
            this.dollarsTextBox = new System.Windows.Forms.TextBox();
            this.convertedTextBox = new System.Windows.Forms.TextBox();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.poundsButton = new System.Windows.Forms.Button();
            this.canadianButton = new System.Windows.Forms.Button();
            this.marksButton = new System.Windows.Forms.Button();
            this.yenButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag2)).BeginInit();
            this.SuspendLayout();
            // 
            // flag1
            // 
            this.flag1.Image = global::CurrencyConverter.Properties.Resources.US;
            this.flag1.Location = new System.Drawing.Point(12, 30);
            this.flag1.Name = "flag1";
            this.flag1.Size = new System.Drawing.Size(199, 156);
            this.flag1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flag1.TabIndex = 0;
            this.flag1.TabStop = false;
            // 
            // flag2
            // 
            this.flag2.Image = global::CurrencyConverter.Properties.Resources.US;
            this.flag2.Location = new System.Drawing.Point(12, 192);
            this.flag2.Name = "flag2";
            this.flag2.Size = new System.Drawing.Size(199, 156);
            this.flag2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flag2.TabIndex = 1;
            this.flag2.TabStop = false;
            // 
            // dollarsTextBox
            // 
            this.dollarsTextBox.Location = new System.Drawing.Point(349, 93);
            this.dollarsTextBox.Name = "dollarsTextBox";
            this.dollarsTextBox.Size = new System.Drawing.Size(100, 23);
            this.dollarsTextBox.TabIndex = 2;
            this.dollarsTextBox.Text = "0";
            this.dollarsTextBox.TextChanged += new System.EventHandler(this.dollarsTextBox_TextChanged);
            // 
            // convertedTextBox
            // 
            this.convertedTextBox.Enabled = false;
            this.convertedTextBox.Location = new System.Drawing.Point(349, 256);
            this.convertedTextBox.Name = "convertedTextBox";
            this.convertedTextBox.Size = new System.Drawing.Size(100, 23);
            this.convertedTextBox.TabIndex = 3;
            this.convertedTextBox.Text = "0";
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Location = new System.Drawing.Point(273, 96);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(43, 15);
            this.dollarLabel.TabIndex = 4;
            this.dollarLabel.Text = "Dollars";
            // 
            // convertedLabel
            // 
            this.convertedLabel.AutoSize = true;
            this.convertedLabel.Location = new System.Drawing.Point(273, 259);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(43, 15);
            this.convertedLabel.TabIndex = 5;
            this.convertedLabel.Text = "Dollars";
            // 
            // poundsButton
            // 
            this.poundsButton.Enabled = false;
            this.poundsButton.Location = new System.Drawing.Point(118, 408);
            this.poundsButton.Name = "poundsButton";
            this.poundsButton.Size = new System.Drawing.Size(75, 23);
            this.poundsButton.TabIndex = 6;
            this.poundsButton.Text = "Pounds";
            this.poundsButton.UseVisualStyleBackColor = true;
            this.poundsButton.Click += new System.EventHandler(this.poundsButton_Click);
            // 
            // canadianButton
            // 
            this.canadianButton.Enabled = false;
            this.canadianButton.Location = new System.Drawing.Point(199, 408);
            this.canadianButton.Name = "canadianButton";
            this.canadianButton.Size = new System.Drawing.Size(75, 23);
            this.canadianButton.TabIndex = 7;
            this.canadianButton.Text = "Canadian";
            this.canadianButton.UseVisualStyleBackColor = true;
            this.canadianButton.Click += new System.EventHandler(this.canadianButton_Click);
            // 
            // marksButton
            // 
            this.marksButton.Enabled = false;
            this.marksButton.Location = new System.Drawing.Point(280, 408);
            this.marksButton.Name = "marksButton";
            this.marksButton.Size = new System.Drawing.Size(75, 23);
            this.marksButton.TabIndex = 8;
            this.marksButton.Text = "Marks";
            this.marksButton.UseVisualStyleBackColor = true;
            this.marksButton.Click += new System.EventHandler(this.marksButton_Click);
            // 
            // yenButton
            // 
            this.yenButton.Enabled = false;
            this.yenButton.Location = new System.Drawing.Point(160, 437);
            this.yenButton.Name = "yenButton";
            this.yenButton.Size = new System.Drawing.Size(75, 23);
            this.yenButton.TabIndex = 9;
            this.yenButton.Text = "Yen";
            this.yenButton.UseVisualStyleBackColor = true;
            this.yenButton.Click += new System.EventHandler(this.yenButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(241, 437);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 479);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.yenButton);
            this.Controls.Add(this.marksButton);
            this.Controls.Add(this.canadianButton);
            this.Controls.Add(this.poundsButton);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.convertedTextBox);
            this.Controls.Add(this.dollarsTextBox);
            this.Controls.Add(this.flag2);
            this.Controls.Add(this.flag1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.flag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flag1;
        private System.Windows.Forms.PictureBox flag2;
        private System.Windows.Forms.TextBox dollarsTextBox;
        private System.Windows.Forms.TextBox convertedTextBox;
        private System.Windows.Forms.Label dollarLabel;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.Button poundsButton;
        private System.Windows.Forms.Button canadianButton;
        private System.Windows.Forms.Button marksButton;
        private System.Windows.Forms.Button yenButton;
        private System.Windows.Forms.Button resetButton;
    }
}

