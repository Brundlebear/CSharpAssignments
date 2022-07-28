using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissorsKBrundage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int playerCnt = 0;
        int oppCnt = 0;
        int drawCnt = 0;

        private void rock_Click(object sender, EventArgs e)
        {
            // Set and show the player choice
            lblPlayerChoice.Visible = true;
            picPlayerChoice.Visible = true;
            picPlayerChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Rock;
            // Generate a random number 1,2,3 and use that to assign the opponent choice
            Random random = new Random();
            int oppNum = random.Next(1, 4);

            if (oppNum == 1) 
            {
                picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Rock;
                lblWinner.Text = "DRAW";
                drawCnt++;
                lblDrawCnt.Text = drawCnt.ToString();
            } if (oppNum == 2)
            {
                picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Paper;
                lblWinner.Text = "OPPONENT WINS";
                oppCnt++;
                lblOppCnt.Text = oppCnt.ToString();
                
            } if (oppNum == 3)
            {
                picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Scissors;
                lblWinner.Text = "PLAYER WINS";
                playerCnt++;
                lblPlayerCnt.Text = playerCnt.ToString();
                
            }
            lblOppChoice.Visible = true;
            picOppChoice.Visible = true;
            lblWinner.Visible = true;


        }

        private void paper_Click(object sender, EventArgs e)
        {
            // Set and show the player choice
            lblPlayerChoice.Visible = true;
            picPlayerChoice.Visible = true;
            picPlayerChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Paper;
            // Generate a random number 1,2,3 and use that to assign the opponent choice
            Random random = new Random();
            int oppNum = random.Next(1, 4);

            if (oppNum == 1)
            {
                picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Rock;
                lblWinner.Text = "PLAYER WINS";
                playerCnt++;
                lblPlayerCnt.Text = playerCnt.ToString();
            }
            if (oppNum == 2)
            {
                picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Paper;
                lblWinner.Text = "DRAW";
                drawCnt++;
                lblDrawCnt.Text = drawCnt.ToString();

            }
            if (oppNum == 3)
            {
                picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Scissors;
                lblWinner.Text = "OPPONENT WINS";
                oppCnt++;
                lblOppCnt.Text = oppCnt.ToString();

            }
            lblOppChoice.Visible = true;
            picOppChoice.Visible = true;
            lblWinner.Visible = true;
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            // Set and show the player choice
            lblPlayerChoice.Visible = true;
            picPlayerChoice.Visible = true;
            picPlayerChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Scissors;
            // Generate a random number 1,2,3 and use that to assign the opponent choice
            Random random = new Random();
            int oppNum = random.Next(1, 4);

            if (oppNum == 1)
            {
                picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Rock;
                lblWinner.Text = "OPPONENT WINS";
                oppCnt++;
                lblOppCnt.Text = oppCnt.ToString();
            }
            if (oppNum == 2)
            {
                picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Paper;
                lblWinner.Text = "PLAYER WINS";
                playerCnt++;
                lblPlayerCnt.Text = playerCnt.ToString();

            }
            if (oppNum == 3)
            {
                picOppChoice.Image = global::RockPaperScissorsKBrundage.Properties.Resources.Scissors;
                lblWinner.Text = "DRAW";
                drawCnt++;
                lblDrawCnt.Text = drawCnt.ToString();


            }
            lblOppChoice.Visible = true;
            picOppChoice.Visible = true;
            lblWinner.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOppChoice.Visible = false;
            picOppChoice.Visible = false;
            lblWinner.Visible = false;
            drawCnt = 0;
            oppCnt = 0;
            playerCnt = 0;
            lblPlayerCnt.Text = playerCnt.ToString();
            lblOppCnt.Text = oppCnt.ToString();
            lblDrawCnt.Text = drawCnt.ToString();

        }
    }
}
