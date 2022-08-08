
namespace AstronomyHelperKBrundage
{
    partial class PlanetForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.infoType = new System.Windows.Forms.Label();
            this.infoTemp = new System.Windows.Forms.Label();
            this.infoMass = new System.Windows.Forms.Label();
            this.infoDistance = new System.Windows.Forms.Label();
            this.infoName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(88, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(29, 51);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(97, 13);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Distance from Sun:";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(91, 78);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(35, 13);
            this.lblMass.TabIndex = 2;
            this.lblMass.Text = "Mass:";
            this.lblMass.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(56, 106);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(70, 13);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Temperature:";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(59, 135);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(67, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Planet Type:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // infoType
            // 
            this.infoType.AutoSize = true;
            this.infoType.Location = new System.Drawing.Point(129, 135);
            this.infoType.Name = "infoType";
            this.infoType.Size = new System.Drawing.Size(27, 13);
            this.infoType.TabIndex = 9;
            this.infoType.Text = " info";
            // 
            // infoTemp
            // 
            this.infoTemp.AutoSize = true;
            this.infoTemp.Location = new System.Drawing.Point(129, 106);
            this.infoTemp.Name = "infoTemp";
            this.infoTemp.Size = new System.Drawing.Size(27, 13);
            this.infoTemp.TabIndex = 8;
            this.infoTemp.Text = " info";
            // 
            // infoMass
            // 
            this.infoMass.AutoSize = true;
            this.infoMass.Location = new System.Drawing.Point(129, 78);
            this.infoMass.Name = "infoMass";
            this.infoMass.Size = new System.Drawing.Size(27, 13);
            this.infoMass.TabIndex = 7;
            this.infoMass.Text = " info";
            // 
            // infoDistance
            // 
            this.infoDistance.AutoSize = true;
            this.infoDistance.Location = new System.Drawing.Point(129, 51);
            this.infoDistance.Name = "infoDistance";
            this.infoDistance.Size = new System.Drawing.Size(27, 13);
            this.infoDistance.TabIndex = 6;
            this.infoDistance.Text = " info";
            // 
            // infoName
            // 
            this.infoName.AutoSize = true;
            this.infoName.Location = new System.Drawing.Point(129, 24);
            this.infoName.Name = "infoName";
            this.infoName.Size = new System.Drawing.Size(27, 13);
            this.infoName.TabIndex = 5;
            this.infoName.Text = " info";
            // 
            // PlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 187);
            this.Controls.Add(this.infoType);
            this.Controls.Add(this.infoTemp);
            this.Controls.Add(this.infoMass);
            this.Controls.Add(this.infoDistance);
            this.Controls.Add(this.infoName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblMass);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblName);
            this.Name = "PlanetForm";
            this.Text = "Planet Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label infoType;
        private System.Windows.Forms.Label infoTemp;
        private System.Windows.Forms.Label infoMass;
        private System.Windows.Forms.Label infoDistance;
        private System.Windows.Forms.Label infoName;
    }
}