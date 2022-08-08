using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AstronomyHelperKBrundage
{
    public partial class PlanetForm : Form
    {

        String[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };
        String[] distfromsun = { "0.387 AU", "0.7223 AU", "1 AU", "1.5237 AU", "5.2028 AU", "9.5388 AU", "19.18 AU", "30.0611 AU", "39.44 AU" };
        String[] planetmass = { "3.31 x 10^23 kg", "4.87 x 10^24 kg", "5.967 x 10^24 kg", ".6424 x 10^24 kg", "1.899 x 10^27 kg", "5.69 x 10^26 kg", "8.69 x 10^25 kg", "1.03 x 10^26 kg", "1.2 x 10^22 kg" };
        String[] planettempo = { "-173 C to 430 C", "472 C", "-50 C to 50 C", "-140 C to 20 C", "-110 C", "-180 C", "-220 C", "-216 C", "-230 C" };
        String[] planettype = { "Terrestrial", "Terrestrial", "Terrestrial", "Terrestrial", "Jovian", "Jovian", "Jovian", "Jovian", "Low density" };

        public PlanetForm()
        {
            InitializeComponent();
        }

        public void populateForm(int choice)
        {
            infoName.Text = planets[choice];
            infoDistance.Text = distfromsun[choice] ;
            infoMass.Text = planetmass[choice] ;
            infoTemp.Text = planettempo[choice];
            infoType.Text = planettype[choice] ;
        }

    }
}
