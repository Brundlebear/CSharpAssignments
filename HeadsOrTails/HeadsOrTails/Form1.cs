using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadsOrTails
{

    public partial class Form1 : Form
    {

        int headsCounter = 0;
        int tailsCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void showHeads_Click(object sender, EventArgs e)
        {
            picCoin.Image = Properties.Resources.imageHeads;
            headsCounter++;
            this.counterHeads.Text = headsCounter.ToString();
        }

        private void showTails_Click(object sender, EventArgs e)
        {
            picCoin.Image = Properties.Resources.imageTails;
            tailsCounter++;
            this.counterTails.Text = tailsCounter.ToString();
        }

        private void resetCoin_Click(object sender, EventArgs e)
        {
            picCoin.Image = Properties.Resources.fiftyCents;
            headsCounter = 0;
            tailsCounter = 0;
            this.counterHeads.Text = headsCounter.ToString();
            this.counterTails.Text = tailsCounter.ToString();
        }

        private void flipCoin_Click(object sender, EventArgs e)
        {


            Random rnd = new Random();
            int RandomNum = rnd.Next(0, 2);
            if(RandomNum == 0)
            {
                picCoin.Image = Properties.Resources.imageHeads;
                headsCounter++;
                this.counterHeads.Text = headsCounter.ToString();

            }
            else
            {
                picCoin.Image = Properties.Resources.imageTails;
                tailsCounter++;
                this.counterTails.Text = tailsCounter.ToString();
            }
        }
    }
}
