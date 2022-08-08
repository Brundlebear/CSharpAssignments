using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WarGameKBrundage
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        int playerScore = 0;
        int oppScore = 0;
        int tieCount = 0;
        int[] deck = new int[52];
        int[] chosenCards = new int[52];
        // This next line is ugly and I'm sure there's a better way to do this but I was getting too deep and losing sight of the project trying to figure it out
        Image[] cardGraphic = {WarGameKBrundage.Properties.Resources.AceofClubs, WarGameKBrundage.Properties.Resources.AceofHearts, WarGameKBrundage.Properties.Resources.AceofDiamonds, WarGameKBrundage.Properties.Resources.AceofSpades, WarGameKBrundage.Properties.Resources.TwoofClubs, WarGameKBrundage.Properties.Resources.TwoofHearts, WarGameKBrundage.Properties.Resources.TwoofDiamonds, WarGameKBrundage.Properties.Resources.TwoofSpades, WarGameKBrundage.Properties.Resources.ThreeofClubs, WarGameKBrundage.Properties.Resources.ThreeofHearts, WarGameKBrundage.Properties.Resources.ThreeofDiamonds, WarGameKBrundage.Properties.Resources.ThreeofSpades, WarGameKBrundage.Properties.Resources.FourofClubs, WarGameKBrundage.Properties.Resources.FourofHearts, WarGameKBrundage.Properties.Resources.FourofDiamonds, WarGameKBrundage.Properties.Resources.FourofSpades, WarGameKBrundage.Properties.Resources.FiveofClubs, WarGameKBrundage.Properties.Resources.FiveofHearts, WarGameKBrundage.Properties.Resources.FiveofDiamonds, WarGameKBrundage.Properties.Resources.FiveofSpades, WarGameKBrundage.Properties.Resources.SixofClubs, WarGameKBrundage.Properties.Resources.SixofHearts, WarGameKBrundage.Properties.Resources.SixofDiamonds, WarGameKBrundage.Properties.Resources.SixofSpades, WarGameKBrundage.Properties.Resources.SevenofClubs, WarGameKBrundage.Properties.Resources.SevenofHearts, WarGameKBrundage.Properties.Resources.SevenofDiamonds, WarGameKBrundage.Properties.Resources.SevenofSpades, WarGameKBrundage.Properties.Resources.EightofClubs, WarGameKBrundage.Properties.Resources.EightofHearts, WarGameKBrundage.Properties.Resources.EightofDiamonds, WarGameKBrundage.Properties.Resources.EightofSpades, WarGameKBrundage.Properties.Resources.NineofClubs, WarGameKBrundage.Properties.Resources.NineofHearts, WarGameKBrundage.Properties.Resources.NineofDiamonds, WarGameKBrundage.Properties.Resources.NineofSpades, WarGameKBrundage.Properties.Resources.TenofClubs, WarGameKBrundage.Properties.Resources.TenofHearts, WarGameKBrundage.Properties.Resources.TenofDiamonds, WarGameKBrundage.Properties.Resources.TenofSpades, WarGameKBrundage.Properties.Resources.JackofClubs, WarGameKBrundage.Properties.Resources.JackofHearts, WarGameKBrundage.Properties.Resources.JackofDiamonds, WarGameKBrundage.Properties.Resources.JackofSpades, WarGameKBrundage.Properties.Resources.QueenofClubs, WarGameKBrundage.Properties.Resources.QueenofHearts, WarGameKBrundage.Properties.Resources.QueenofDiamonds, WarGameKBrundage.Properties.Resources.QueenofSpades, WarGameKBrundage.Properties.Resources.KingofClubs, WarGameKBrundage.Properties.Resources.KingofHearts, WarGameKBrundage.Properties.Resources.KingofDiamonds, WarGameKBrundage.Properties.Resources.KingofSpades };

        private void FillDeck()
        {

            picOppCard.Image = WarGameKBrundage.Properties.Resources.card;
            picPlayerCard.Image = WarGameKBrundage.Properties.Resources.card;
            lblPlayerValue.Visible = false;
            lblOppValue.Visible = false;
            lblTieCount.Visible = false;

            for (int i = 0; i < 52; i++)
            {
                deck[i] = (i+1);
                chosenCards[i] = 0;
            }
            playerScore = 0;
            oppScore = 0;
            tieCount = 0;
            lblGameOver.Visible = false;
        }

        private bool deckEmpty()
        {
            for (int i = 0; i < 52; i++)
            {
                if (chosenCards[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private int selectCard()
        {
            int card = rnd.Next(1, 53);
            if (chosenCards[card - 1] != card)
            {
                chosenCards[card - 1] = card;
                return deck[card - 1];
            }
            else
            {
                return selectCard();
            }
        }

        private void determineScoring(int player, int opp)
        {
            
            int pValue = (player-1) / 4;
            int oValue = (opp-1) / 4;
            if (pValue > oValue)
            {
                playerScore++;
            }
            else if (pValue < oValue)
            {
                oppScore++;
            }
            else if (pValue == oValue)
                tieCount++;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            lblOppName.Visible = true;
            lblPlayerName.Visible = true;
            picOppCard.Visible = true;
            picPlayerCard.Visible = true;
            btnDeal.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            pictureBox1.Visible = false;
            FillDeck();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            int playerCard = selectCard();
            {
                picPlayerCard.Image = cardGraphic[playerCard - 1];
            }
            int oppCard = selectCard();
            picOppCard.Image = cardGraphic[oppCard-1];

            determineScoring(playerCard, oppCard);
            lblPlayerValue.Text = "Player Score: " + playerScore;
            lblOppValue.Text = "Opponent Score: " + oppScore;
            lblTieCount.Text = "Ties: " + tieCount;
            btnStart.Text = "Restart";

            if (tieCount > 0)
            {
                lblTieCount.Visible = true;
            }
            lblOppValue.Visible = true;
            lblPlayerValue.Visible = true;
            if (deckEmpty())
            {
                btnDeal.Visible = false;
                if (playerScore > oppScore)
                { 
                    lblGameOver.Text = "Player Won More Hands, " + playerScore + " in all!"; 
                } else if (playerScore < oppScore)
                {
                    lblGameOver.Text = "Opponent Won More Hands, " + oppScore + " in all!";
                } else
                {
                    lblGameOver.Text = "Player and Opponent Tied!";
                }
                lblGameOver.Visible = true;
            }

        }
    }
}
