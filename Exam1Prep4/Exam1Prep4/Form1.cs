using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1Prep4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double COST_OF_CROSSAINT = 3.50, COST_OF_COFFEE = 5.50, TIP_PERCENT = .10, VAT_PERCENT = .15;
        int croissantsEaten, coffeeDrank;
        double subTotal, vatTotal, tipTotal, grandTotal;

        private void exitButton_Click(object sender, EventArgs e)
        {
            closeApplication();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void processButton_Click(object sender, EventArgs e)
        {
            input();
            process();
            output();


        }
        private void input()
        {
            try
            {
                croissantsEaten = int.Parse(crossaintTextBox.Text);
                coffeeDrank = int.Parse(coffeeDrankTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error inputing the data");
            }

        }
        private void process()
        {
            try
            {
                subTotal = (croissantsEaten * COST_OF_CROSSAINT) + (coffeeDrank * COST_OF_COFFEE);
                tipTotal = (subTotal * TIP_PERCENT);
                vatTotal = (subTotal * VAT_PERCENT);
                grandTotal = subTotal + tipTotal + vatTotal; 
            }
            catch
            {
                MessageBox.Show("Error processing the data");
            }
        }
        private void output()
        {
            try
            {
                MessageBox.Show("Subtotal: ", subTotal.ToString("c"));
                tipLabelOutput.Text = tipTotal.ToString("c");
                vatLabelOutput.Text = vatTotal.ToString("c");
                TotalLabelOutput.Text = grandTotal.ToString("c");
            }
            catch
            {
                MessageBox.Show("Error outputing the data");
            }
        }
        private void closeApplication()
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Error closing the application");
            }
        }
        private void clearFields()
        {
            try
            {
                crossaintTextBox.Text = " ";
                coffeeDrankTextBox.Text = " ";
                tipLabelOutput.Text = " ";
                TotalLabelOutput.Text = " ";
                vatLabelOutput.Text = " ";
                crossaintTextBox.Focus();
            }
            catch
            {
                MessageBox.Show("Error clearing the application");
            }
        }
    }
}
