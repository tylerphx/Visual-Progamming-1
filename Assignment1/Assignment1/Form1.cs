using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            //Accidentally created this click method. Useless code.
        }
        private void totalOutputLabel_Click(object sender, EventArgs e)
        {
            //Accidentally created this click method. Useless code.
        }
        private void exitButton_Click(object sender, EventArgs e)
        { 
            closeProgram();
        }
        private void closeProgram()
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Error closing the program.");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearLabels();
        }
        private void clearLabels()
        {
            try
            {
                classATextBox.Text = " ";
                classATextBox.Focus();
                classBTextBox.Text = " ";
                classCTextBox.Text = " ";
                classARevenueOutputLabel.Text = " ";
                classBRevenueOutputLabel.Text = " ";
                classCRevenueOutputLabel.Text = " ";
                totalOutputLabel.Text = " ";
            }
            catch
            {
                MessageBox.Show("Error clearing the labels.");
            }
        }
        private void calculateRevenueButton_Click(object sender, EventArgs e)
        {
            calculateRevenue();
        }
        private void calculateRevenue()
        {
            try
            {
                const int CLASS_A_TICKET = 15;
                const int CLASS_B_TICKET = 12;
                const int CLASS_C_TICKET = 9;
                int class_A_Revenue = int.Parse(classATextBox.Text) * CLASS_A_TICKET;
                classARevenueOutputLabel.Text = class_A_Revenue.ToString("c");
                int class_B_Revenue = int.Parse(classBTextBox.Text) * CLASS_B_TICKET;
                classBRevenueOutputLabel.Text = class_B_Revenue.ToString("c");
                int class_C_Revenue = int.Parse(classCTextBox.Text) * CLASS_C_TICKET;
                classCRevenueOutputLabel.Text = class_C_Revenue.ToString("c");
                int total = class_A_Revenue + class_B_Revenue + class_C_Revenue;
                totalOutputLabel.Text = total.ToString("c");
            }
            catch
            {
                MessageBox.Show("Error calculating the revenue, possibly due to invalid input data");
            }
        }

    }
}
