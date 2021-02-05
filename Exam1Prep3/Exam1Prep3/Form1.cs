using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1Prep3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double VAT = .10, TIP = .15, CROISSANTCOST = 3.50, COFFEECOST = 5.50; 
        int croissantEaten = 0, coffeeDrank = 0;
        double subtotal = 0, tipTotal = 0, vatTotal = 0, grandTotal = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Useless code
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //Useless code
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exitApplication();
        }
        private void exitApplication()
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Error exiting application");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearApplication();
        }
        private void clearApplication()
        {
            try
            {
                croissantOutputTextBox.Text = " ";
                coffeeOutputTextBox.Text = " ";
                tipOutputLabel.Text = " ";
                vatOutputLabel.Text = " ";
                grandTotalOutputLabel.Text = " ";
                croissantOutputTextBox.Focus();
            }
            catch
            {
                MessageBox.Show("Error clearing application");
            }
        }

        private void processDataButton_Click(object sender, EventArgs e)
        {
            labelTestText.Visible = true;
            inputData();
            processData();
            outputData();
        }
        private void inputData()
        {
            try
            {
                croissantEaten = int.Parse(croissantOutputTextBox.Text);
                coffeeDrank = int.Parse(coffeeOutputTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error inputing data");
            }
        }
        private void processData()
        {
            try
            {
                subtotal = (croissantEaten * CROISSANTCOST) + (coffeeDrank * COFFEECOST);
                tipTotal = subtotal * TIP;
                vatTotal = subtotal * VAT;
                grandTotal = subtotal + tipTotal + vatTotal; 
            }
            catch
            {
                MessageBox.Show("Error processing data");
            }
        }
        private void outputData()
        {
            try
            {
                MessageBox.Show("Subtotal is $" + subtotal);
                tipOutputLabel.Text = tipTotal.ToString("C");
                vatOutputLabel.Text = vatTotal.ToString("C");
                grandTotalOutputLabel.Text = grandTotal.ToString("C");
            }
            catch
            {
                MessageBox.Show("Error sending data to labels");
            }
        }
    }

}
