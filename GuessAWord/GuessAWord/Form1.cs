using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GuessAWord
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        static string[] words = { "apricot", "elephant", "tigress", "fortunate", "impossible", "historical", "colorful", "science" };
        string wordAnswer;
        string wordGuess;
        string displayText;
        char letter;
        bool letterInWord = false;

        public Form1()
        {
            InitializeComponent();
            wordAnswer = words[rnd.Next(8)];
            for (int i = 0; i < wordAnswer.Length; ++i)
            {
                displayText += "_ ";
            }
            wordDisplay.Text = displayText;

        }



        private void btnSubmitLetter_Click(object sender, EventArgs e)
        {
            letterInWord = false;
            lblGuessed.Visible = true;
            letter = Convert.ToChar(letterInput.Text.Substring(0, 1));
            for (int pos = 0; pos < wordAnswer.Length; ++pos)        //Set up a loop to look at each character in wordAnswer
            {
                char tempChar = Convert.ToChar(wordAnswer.Substring(pos, 1));
                if (tempChar == letter)
                {
                    letterInWord = true;
                    char[] tempCharArray = displayText.ToCharArray();
                    tempCharArray[(pos*2)] = letter;
                    displayText = new string(tempCharArray);
                    wordDisplay.Text = displayText;
                }
            } 
            if (letterInWord == false)
            {
                lblIncorrectLetters.Text += letter + ",";
            }
        }

        private void btnSubmitWord_Click(object sender, EventArgs e)
        {
            wordGuess = wordInput.Text;
            if (wordGuess == wordAnswer)
            {
                lblWinner.Visible = true;
                lblWrong.Visible = false;
                wordDisplay.Text = wordGuess;
            }
            else 
            {
                lblWrong.Visible = true;
                lblWinner.Visible = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            wordAnswer = words[rnd.Next(8)];
            displayText = "";
            for (int i = 0; i < wordAnswer.Length; ++i)
            {
                displayText += " _";
            }
            wordDisplay.Text = displayText;
            lblWinner.Visible = false;
            lblWrong.Visible = false;
            lblGuessed.Visible = false;
            lblIncorrectLetters.Text = "";

        }
    }
}
