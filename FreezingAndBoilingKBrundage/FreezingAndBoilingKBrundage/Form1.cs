using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FreezingAndBoilingKBrundage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTempUpdate_Click(object sender, EventArgs e)
        {
            int currentTemp;
            if (int.TryParse(inputTemp.Text, out currentTemp)) 
            {
                //int currentTemp = System.Convert.ToInt32(inputTemp.Text);
                string waterState;
                string ethylState;
                string oxygenState;
                string mercuryState;

                //Define Emoji based on temperature
                if (currentTemp <= 32)
                {
                    tempIndicator.Text = "🥶";
                    tempIndicator.ForeColor = Color.Blue;
                } else if (currentTemp < 95)
                {
                    tempIndicator.Text = "😎";
                    tempIndicator.ForeColor = Color.Yellow;
                }
                else
                {
                    tempIndicator.Text = "🥵";
                    tempIndicator.ForeColor = Color.OrangeRed;
                }

                //Define state of matter for Ethyl Alcohol
                if (currentTemp <= -173)
                {
                    ethylState = "solid";
                    imageAlcohol.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.solid;
                }
                else if (currentTemp < 172)
                {
                    ethylState = "liquid";
                    imageAlcohol.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.liquid;
                }
                else
                {
                    ethylState = "gas";
                    imageAlcohol.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.gas;
                }
                //Update Ethyl Alcohol Description
                descEthylAlcohol.Text = "At " + currentTemp + " degrees, Ethyl Alcohol is a " + ethylState + "!";



                //Define state of matter for Mercury
                if (currentTemp <= -38)
                {
                    mercuryState = "solid";
                    imageMercury.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.solid;
                }
                else if (currentTemp < 676)
                {
                    mercuryState = "liquid";
                    imageMercury.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.liquid;
                }
                else
                {
                    mercuryState = "gas";
                    imageMercury.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.gas;
                }
                //Update Mercury Description
                descMercury.Text = "At " + currentTemp + " degrees, Mercury is a " + mercuryState + "!";

                //Define state of matter for Oxygen
                if (currentTemp <= -362)
                {
                    oxygenState = "solid";
                    imageOxygen.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.solid;
                }
                else if (currentTemp < -306)
                {
                    oxygenState = "liquid";
                    imageOxygen.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.liquid;
                }
                else
                {
                    oxygenState = "gas";
                    imageOxygen.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.gas;
                }
                //Update Oxygen Description
                descOxygen.Text = "At " + currentTemp + " degrees, Oxygen is a " + oxygenState + "!";

                //Define state of matter for Water
                if (currentTemp <= 32)
                {
                    waterState = "solid";
                    imageWater.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.solid;
                }
                else if (currentTemp < 212)
                {
                    waterState = "liquid";
                    imageWater.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.liquid;
                }
                else
                {
                    waterState = "gas";
                    imageWater.Image = global::FreezingAndBoilingKBrundage.Properties.Resources.gas;
                }
                //Update Water Description
                descWater.Text = "At " + currentTemp + " degrees, Water is a " + waterState + "!";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputTemp.Text = "90";
            btnTempUpdate_Click(sender, e);

        }
    } 
}
