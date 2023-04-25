using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Science_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        public void numOfTrials_TextChanged(object sender, EventArgs e)
        {
            string trials = numOfTrials.Text;
        }

        public void numOfSucessfulTrials_TextChanged(object sender, EventArgs e)
        {
            string sucessfulTrials = numOfSucessfulTrials.Text;
        }

        public void nullHypothesis_TextChanged(object sender, EventArgs e)
        {
            string x = nullHypothesis.Text;
            decimal currentProbability = Convert.ToDecimal(x);
        }

        public void significenceLevel_Scroll(object sender, EventArgs e)
        {
            int sigLevel = significenceLevel.Value;
        }
    }
}
