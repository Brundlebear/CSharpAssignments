using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {

        double dollarValue = 0;
        double exchangeRate = 1;
        double convertedValue = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void dollarsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (dollarsTextBox.Text.Length > 0) 
            {
                dollarValue = Convert.ToDouble(dollarsTextBox.Text);
            }
            else
            {
                dollarValue = 0;
            }

            if (dollarValue > 0)
            {
                poundsButton.Enabled = true;
                canadianButton.Enabled = true;
                marksButton.Enabled = true;
                yenButton.Enabled = true;
            }
            else
            {
                poundsButton.Enabled = false;
                canadianButton.Enabled = false;
                marksButton.Enabled = false;
                yenButton.Enabled = false;
            }

        }
        private void poundsButton_Click(object sender, EventArgs e)
        {
            exchangeRate = 0.63;
            convertedValue = dollarValue * exchangeRate;
            convertedLabel.Text = "Pounds";
            convertedTextBox.Text = Convert.ToString(convertedValue);
            flag2.Image = Properties.Resources.UK;
        }

        private void canadianButton_Click(object sender, EventArgs e)
        {
            exchangeRate = 1.29;
            convertedValue = dollarValue * exchangeRate;
            convertedLabel.Text = "CAD";
            convertedTextBox.Text = Convert.ToString(convertedValue);
            flag2.Image = Properties.Resources.Canada;
        }

        private void marksButton_Click(object sender, EventArgs e)
        {
            exchangeRate = 1.82;
            convertedValue = dollarValue * exchangeRate;
            convertedLabel.Text = "Marks";
            convertedTextBox.Text = Convert.ToString(convertedValue);
            flag2.Image = Properties.Resources.Marks;
        }

        private void yenButton_Click(object sender, EventArgs e)
        {
            exchangeRate = 120.85;
            convertedValue = dollarValue * exchangeRate;
            convertedLabel.Text = "Yen";
            convertedTextBox.Text = Convert.ToString(convertedValue);
            flag2.Image = Properties.Resources.Japan;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            exchangeRate = 1;
            dollarsTextBox.Text = "0";
            dollarValue = Convert.ToDouble(dollarsTextBox.Text);
            convertedValue = dollarValue * exchangeRate;
            convertedLabel.Text = "Dollars";
            convertedTextBox.Text = Convert.ToString(convertedValue);
            flag2.Image = Properties.Resources.US;
            poundsButton.Enabled = false;
            canadianButton.Enabled = false;
            marksButton.Enabled = false;
            yenButton.Enabled = false;
        }
    }
}
