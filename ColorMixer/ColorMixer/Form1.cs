using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void convertButton_Click(object sender, EventArgs e)
        {
            double userInputDistance;
            if (double.TryParse(distanceTextBox.Text, out userInputDistance))
            {
                userInputDistance = double.Parse(distanceTextBox.Text);
                int fromListBoxIndex = fromListBox.SelectedIndex;
                int toListBoxIndex = toListBox.SelectedIndex;

                if (fromListBoxIndex ==0 && toListBoxIndex ==0)
                {
                        double inchesToInchesDistance = userInputDistance;
                        outputLabel.Text = inchesToInchesDistance.ToString();
                }
                else if (fromListBoxIndex ==0 && toListBoxIndex ==1)
                {
                    outputLabel.Text = (userInputDistance / 12).ToString();
                }
                else if (fromListBoxIndex == 0 && toListBoxIndex == 2)
                {
                    outputLabel.Text = (userInputDistance / 36).ToString();
                }
                else if (fromListBoxIndex == 1 && toListBoxIndex == 0)
                {
                    outputLabel.Text = (userInputDistance * 12).ToString();
                }
                else if (fromListBoxIndex == 1 && toListBoxIndex == 1)
                {
                    outputLabel.Text = userInputDistance.ToString();
                }
                else if (fromListBoxIndex == 1 && toListBoxIndex == 2)
                {
                    outputLabel.Text = (userInputDistance / 3).ToString();
                }
                else if (fromListBoxIndex == 2 && toListBoxIndex == 0)
                {
                    outputLabel.Text = (userInputDistance * 36 ).ToString();
                }
                else if (fromListBoxIndex == 2 && toListBoxIndex == 1)
                {
                    outputLabel.Text = (userInputDistance * 3).ToString();
                }
                else if (fromListBoxIndex == 2 && toListBoxIndex == 2)
                {
                    outputLabel.Text = userInputDistance.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please input a number.");
            }
}

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }


