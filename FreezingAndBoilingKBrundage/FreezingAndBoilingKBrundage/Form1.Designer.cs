
namespace FreezingAndBoilingKBrundage
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
            this.descWater = new System.Windows.Forms.Label();
            this.descOxygen = new System.Windows.Forms.Label();
            this.descMercury = new System.Windows.Forms.Label();
            this.descEthylAlcohol = new System.Windows.Forms.Label();
            this.imageWater = new System.Windows.Forms.PictureBox();
            this.imageOxygen = new System.Windows.Forms.PictureBox();
            this.imageMercury = new System.Windows.Forms.PictureBox();
            this.imageAlcohol = new System.Windows.Forms.PictureBox();
            this.lblTempUnit = new System.Windows.Forms.Label();
            this.inputTemp = new System.Windows.Forms.TextBox();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblOxygen = new System.Windows.Forms.Label();
            this.lblMercury = new System.Windows.Forms.Label();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.lblDirections = new System.Windows.Forms.Label();
            this.btnTempUpdate = new System.Windows.Forms.Button();
            this.tempIndicator = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMercury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlcohol)).BeginInit();
            this.SuspendLayout();
            // 
            // descWater
            // 
            this.descWater.AutoSize = true;
            this.descWater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.descWater.Location = new System.Drawing.Point(75, 481);
            this.descWater.Name = "descWater";
            this.descWater.Size = new System.Drawing.Size(157, 13);
            this.descWater.TabIndex = 30;
            this.descWater.Text = "At 90 degrees, Water is a liquid!";
            // 
            // descOxygen
            // 
            this.descOxygen.AutoSize = true;
            this.descOxygen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.descOxygen.Location = new System.Drawing.Point(75, 377);
            this.descOxygen.Name = "descOxygen";
            this.descOxygen.Size = new System.Drawing.Size(157, 13);
            this.descOxygen.TabIndex = 29;
            this.descOxygen.Text = "At 90 degrees, Oxygen is a gas!";
            // 
            // descMercury
            // 
            this.descMercury.AutoSize = true;
            this.descMercury.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.descMercury.Location = new System.Drawing.Point(75, 274);
            this.descMercury.Name = "descMercury";
            this.descMercury.Size = new System.Drawing.Size(166, 13);
            this.descMercury.TabIndex = 28;
            this.descMercury.Text = "At 90 degrees, Mercury is a liquid!";
            // 
            // descEthylAlcohol
            // 
            this.descEthylAlcohol.AutoSize = true;
            this.descEthylAlcohol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.descEthylAlcohol.Location = new System.Drawing.Point(75, 170);
            this.descEthylAlcohol.Name = "descEthylAlcohol";
            this.descEthylAlcohol.Size = new System.Drawing.Size(189, 13);
            this.descEthylAlcohol.TabIndex = 27;
            this.descEthylAlcohol.Text = "At 90 degrees, Ethyl Alcohol is a liquid!";
            // 
            // imageWater
            // 
            this.imageWater.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.liquid;
            this.imageWater.Location = new System.Drawing.Point(16, 436);
            this.imageWater.Name = "imageWater";
            this.imageWater.Size = new System.Drawing.Size(47, 43);
            this.imageWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageWater.TabIndex = 26;
            this.imageWater.TabStop = false;
            // 
            // imageOxygen
            // 
            this.imageOxygen.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.gas;
            this.imageOxygen.Location = new System.Drawing.Point(16, 334);
            this.imageOxygen.Name = "imageOxygen";
            this.imageOxygen.Size = new System.Drawing.Size(47, 43);
            this.imageOxygen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageOxygen.TabIndex = 25;
            this.imageOxygen.TabStop = false;
            // 
            // imageMercury
            // 
            this.imageMercury.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.liquid;
            this.imageMercury.Location = new System.Drawing.Point(16, 230);
            this.imageMercury.Name = "imageMercury";
            this.imageMercury.Size = new System.Drawing.Size(47, 43);
            this.imageMercury.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageMercury.TabIndex = 24;
            this.imageMercury.TabStop = false;
            // 
            // imageAlcohol
            // 
            this.imageAlcohol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageAlcohol.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.liquid;
            this.imageAlcohol.Location = new System.Drawing.Point(16, 126);
            this.imageAlcohol.Name = "imageAlcohol";
            this.imageAlcohol.Size = new System.Drawing.Size(47, 43);
            this.imageAlcohol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlcohol.TabIndex = 23;
            this.imageAlcohol.TabStop = false;
            // 
            // lblTempUnit
            // 
            this.lblTempUnit.AutoSize = true;
            this.lblTempUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblTempUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lblTempUnit.Location = new System.Drawing.Point(484, 14);
            this.lblTempUnit.Name = "lblTempUnit";
            this.lblTempUnit.Size = new System.Drawing.Size(42, 31);
            this.lblTempUnit.TabIndex = 22;
            this.lblTempUnit.Text = "°F";
            // 
            // inputTemp
            // 
            this.inputTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 44F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.inputTemp.Location = new System.Drawing.Point(364, 21);
            this.inputTemp.MinimumSize = new System.Drawing.Size(69, 69);
            this.inputTemp.Name = "inputTemp";
            this.inputTemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputTemp.Size = new System.Drawing.Size(114, 74);
            this.inputTemp.TabIndex = 21;
            this.inputTemp.Text = "90";
            this.inputTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.lblWater.Location = new System.Drawing.Point(69, 452);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(36, 13);
            this.lblWater.TabIndex = 20;
            this.lblWater.Text = "Water";
            // 
            // lblOxygen
            // 
            this.lblOxygen.AutoSize = true;
            this.lblOxygen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.lblOxygen.Location = new System.Drawing.Point(69, 348);
            this.lblOxygen.Name = "lblOxygen";
            this.lblOxygen.Size = new System.Drawing.Size(43, 13);
            this.lblOxygen.TabIndex = 19;
            this.lblOxygen.Text = "Oxygen";
            // 
            // lblMercury
            // 
            this.lblMercury.AutoSize = true;
            this.lblMercury.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.lblMercury.Location = new System.Drawing.Point(69, 244);
            this.lblMercury.Name = "lblMercury";
            this.lblMercury.Size = new System.Drawing.Size(45, 13);
            this.lblMercury.TabIndex = 18;
            this.lblMercury.Text = "Mercury";
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.AutoSize = true;
            this.lblAlcohol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(74)))));
            this.lblAlcohol.Location = new System.Drawing.Point(69, 142);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(68, 13);
            this.lblAlcohol.TabIndex = 17;
            this.lblAlcohol.Text = "Ethyl Alcohol";
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lblDirections.Location = new System.Drawing.Point(12, 21);
            this.lblDirections.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(328, 72);
            this.lblDirections.TabIndex = 16;
            this.lblDirections.Text = "Please enter a temperature to see the state of some common substances at that tem" +
    "perature";
            // 
            // btnTempUpdate
            // 
            this.btnTempUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(3)))));
            this.btnTempUpdate.Location = new System.Drawing.Point(364, 101);
            this.btnTempUpdate.Name = "btnTempUpdate";
            this.btnTempUpdate.Size = new System.Drawing.Size(114, 39);
            this.btnTempUpdate.TabIndex = 31;
            this.btnTempUpdate.Text = "UPDATE";
            this.btnTempUpdate.UseVisualStyleBackColor = false;
            this.btnTempUpdate.Click += new System.EventHandler(this.btnTempUpdate_Click);
            // 
            // tempIndicator
            // 
            this.tempIndicator.AutoSize = true;
            this.tempIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempIndicator.ForeColor = System.Drawing.Color.Yellow;
            this.tempIndicator.Location = new System.Drawing.Point(313, 244);
            this.tempIndicator.MaximumSize = new System.Drawing.Size(220, 0);
            this.tempIndicator.Name = "tempIndicator";
            this.tempIndicator.Size = new System.Drawing.Size(220, 153);
            this.tempIndicator.TabIndex = 32;
            this.tempIndicator.Text = "😎";
            this.tempIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnClear.Location = new System.Drawing.Point(364, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 39);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "RESET";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(545, 591);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tempIndicator);
            this.Controls.Add(this.btnTempUpdate);
            this.Controls.Add(this.descWater);
            this.Controls.Add(this.descOxygen);
            this.Controls.Add(this.descMercury);
            this.Controls.Add(this.descEthylAlcohol);
            this.Controls.Add(this.imageWater);
            this.Controls.Add(this.imageOxygen);
            this.Controls.Add(this.imageMercury);
            this.Controls.Add(this.imageAlcohol);
            this.Controls.Add(this.lblTempUnit);
            this.Controls.Add(this.inputTemp);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.lblOxygen);
            this.Controls.Add(this.lblMercury);
            this.Controls.Add(this.lblAlcohol);
            this.Controls.Add(this.lblDirections);
            this.Name = "Form1";
            this.Text = "Freezing and Boiling Points";
            ((System.ComponentModel.ISupportInitialize)(this.imageWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageMercury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlcohol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descWater;
        private System.Windows.Forms.Label descOxygen;
        private System.Windows.Forms.Label descMercury;
        private System.Windows.Forms.Label descEthylAlcohol;
        private System.Windows.Forms.PictureBox imageWater;
        private System.Windows.Forms.PictureBox imageOxygen;
        private System.Windows.Forms.PictureBox imageMercury;
        private System.Windows.Forms.PictureBox imageAlcohol;
        private System.Windows.Forms.Label lblTempUnit;
        private System.Windows.Forms.TextBox inputTemp;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblOxygen;
        private System.Windows.Forms.Label lblMercury;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.Button btnTempUpdate;
        private System.Windows.Forms.Label tempIndicator;
        private System.Windows.Forms.Button btnClear;
    }
}

