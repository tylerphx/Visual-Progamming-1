using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void milesDroveLabel_Click(object sender, EventArgs e)
        {

        }

        private void gallonsUsedLabel_Click(object sender, EventArgs e)
        {

        }

        private void mpgLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double milesDrove; double gallonsUsed; double mpg;
          
            
            if (double.TryParse(milesDrivenTextBox.Text, out milesDrove))
            {
                if (double.TryParse(gallonsUsedTextBox.Text, out gallonsUsed))
                {
                    milesDrove = double.Parse(milesDrivenTextBox.Text);
                    gallonsUsed = double.Parse(gallonsUsedTextBox.Text);
                    mpg = milesDrove / gallonsUsed;
                    outputLabel.Text = mpg.ToString();
                }
                else
                {
                    MessageBox.Show("Error in the type of data input for gallons used. Please type a number.");
                }
            }
            else
            {
                MessageBox.Show("Error for miles driven");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {
     


        }

        private void milesDrivenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gallonsUsedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
