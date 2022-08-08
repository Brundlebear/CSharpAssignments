
namespace AstronomyHelperKBrundage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.planetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercuryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.earthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jupiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uranusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neptuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planetsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // planetsToolStripMenuItem
            // 
            this.planetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mercuryToolStripMenuItem,
            this.venusToolStripMenuItem,
            this.earthToolStripMenuItem,
            this.marsToolStripMenuItem,
            this.jupiterToolStripMenuItem,
            this.saturnToolStripMenuItem,
            this.uranusToolStripMenuItem,
            this.neptuneToolStripMenuItem,
            this.plutoToolStripMenuItem});
            this.planetsToolStripMenuItem.Name = "planetsToolStripMenuItem";
            this.planetsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.planetsToolStripMenuItem.Text = "Planets";
            // 
            // mercuryToolStripMenuItem
            // 
            this.mercuryToolStripMenuItem.Name = "mercuryToolStripMenuItem";
            this.mercuryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mercuryToolStripMenuItem.Text = "Mercury";
            this.mercuryToolStripMenuItem.Click += new System.EventHandler(this.mercuryToolStripMenuItem_Click);
            // 
            // venusToolStripMenuItem
            // 
            this.venusToolStripMenuItem.Name = "venusToolStripMenuItem";
            this.venusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.venusToolStripMenuItem.Text = "Venus";
            this.venusToolStripMenuItem.Click += new System.EventHandler(this.venusToolStripMenuItem_Click);
            // 
            // earthToolStripMenuItem
            // 
            this.earthToolStripMenuItem.Name = "earthToolStripMenuItem";
            this.earthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.earthToolStripMenuItem.Text = "Earth";
            this.earthToolStripMenuItem.Click += new System.EventHandler(this.earthToolStripMenuItem_Click);
            // 
            // marsToolStripMenuItem
            // 
            this.marsToolStripMenuItem.Name = "marsToolStripMenuItem";
            this.marsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marsToolStripMenuItem.Text = "Mars";
            this.marsToolStripMenuItem.Click += new System.EventHandler(this.marsToolStripMenuItem_Click);
            // 
            // jupiterToolStripMenuItem
            // 
            this.jupiterToolStripMenuItem.Name = "jupiterToolStripMenuItem";
            this.jupiterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jupiterToolStripMenuItem.Text = "Jupiter";
            this.jupiterToolStripMenuItem.Click += new System.EventHandler(this.jupiterToolStripMenuItem_Click);
            // 
            // saturnToolStripMenuItem
            // 
            this.saturnToolStripMenuItem.Name = "saturnToolStripMenuItem";
            this.saturnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saturnToolStripMenuItem.Text = "Saturn";
            this.saturnToolStripMenuItem.Click += new System.EventHandler(this.saturnToolStripMenuItem_Click);
            // 
            // uranusToolStripMenuItem
            // 
            this.uranusToolStripMenuItem.Name = "uranusToolStripMenuItem";
            this.uranusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uranusToolStripMenuItem.Text = "Uranus";
            this.uranusToolStripMenuItem.Click += new System.EventHandler(this.uranusToolStripMenuItem_Click);
            // 
            // neptuneToolStripMenuItem
            // 
            this.neptuneToolStripMenuItem.Name = "neptuneToolStripMenuItem";
            this.neptuneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neptuneToolStripMenuItem.Text = "Neptune";
            this.neptuneToolStripMenuItem.Click += new System.EventHandler(this.neptuneToolStripMenuItem_Click);
            // 
            // plutoToolStripMenuItem
            // 
            this.plutoToolStripMenuItem.Name = "plutoToolStripMenuItem";
            this.plutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plutoToolStripMenuItem.Text = "Pluto";
            this.plutoToolStripMenuItem.Click += new System.EventHandler(this.plutoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AstronomyHelperKBrundage.Properties.Resources.TheSolarSystem;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 508);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Astronomy Facts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem planetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercuryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem earthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jupiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uranusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neptuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plutoToolStripMenuItem;
    }
}

