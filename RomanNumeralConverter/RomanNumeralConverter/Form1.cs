using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanNumeralConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {

            int userInput;

            if (int.TryParse(textBox1.Text, out userInput))
            {
                userInput = int.Parse(textBox1.Text);
                if (userInput == 1)
                {
                    outputLabel.Text = "I";
                }
                if (userInput > 10)
                {
                    MessageBox.Show("Error, that number is greater than 10.");
                }
                    //too lazy to code case 4 to 10.
            }
            else
            {
                MessageBox.Show("Error, that is not even a number!");
            }
        }
         


            
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
