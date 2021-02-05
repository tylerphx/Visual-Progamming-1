using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1Prep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        const double TIP = .10, TAX = .15, croCost = 2.5, coffeeCost = 5.50;
            double totalCroCost = 0, totalCoffeeCost = 0, subtotal = 0, finalizedTotal = 0;
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearAll();
            
        }
        private void clearAll()
        {
            try
            {
                croissantTextBox.Text = " ";
                coffeeTextBox.Text = " ";
                tipOutputLabel.Text = " ";
                taxOutputLabel.Text = " ";
                totalOutputLabel.Text = " ";
                croissantTextBox.Focus();
            }
            catch
            {
                MessageBox.Show("Error clearing the data.");
            }
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
                MessageBox.Show("Error exiting application.");
            }
        }
        private void processDataButton_Click(object sender, EventArgs e)
        {
            processData(); 
            outputData();
        }
        private void processData()
        {
            try
            {
                totalCroCost = int.Parse(croissantTextBox.Text) * croCost;
                totalCoffeeCost = +int.Parse(coffeeTextBox.Text) * coffeeCost;
                subtotal = totalCroCost + totalCoffeeCost;
                MessageBox.Show("Subtotal is $" + subtotal);
                finalizedTotal = (subtotal * TAX) + (subtotal * TIP) + subtotal;
            }
            catch
            {
                MessageBox.Show("Error processing the data");
            }
        }
            private void outputData()
            {
                try
                {
                taxOutputLabel.Text = (subtotal * TAX).ToString("c");
                tipOutputLabel.Text = (subtotal * TIP).ToString("c");
                totalOutputLabel.Text = finalizedTotal.ToString("c");
            }
                catch
                {

                }
            }
        }
    }


