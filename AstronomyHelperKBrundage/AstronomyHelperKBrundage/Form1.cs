using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AstronomyHelperKBrundage
{
    public partial class Form1 : Form
    {

        PlanetForm popup = new PlanetForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void mercuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup.populateForm(0);
            popup.Show();
            popup.Focus();
        }

        private void venusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup.populateForm(1);
            popup.Show();
            popup.Focus();
        }

        private void earthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup.populateForm(2);
            popup.Show();
            popup.Focus();
        }

        private void marsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup.populateForm(3);
            popup.Show();
            popup.Focus();
        }

        private void jupiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup.populateForm(4);
            popup.Show();
            popup.Focus();
        }

        private void saturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup.populateForm(5);
            popup.Show();
            popup.Focus();
        }

        private void uranusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup.populateForm(6);
            popup.Show();
            popup.Focus();
        }

        private void neptuneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup.populateForm(7);
            popup.Show();
            popup.Focus();
        }

        private void plutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            popup.populateForm(8);
            popup.Show();
            popup.Focus();
        }
    }
}
