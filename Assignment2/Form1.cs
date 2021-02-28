using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int PACKAGE_A_HOURS = 10, PACKAGE_B_HOURS = 20, PACKAGE_A_ADDITIONAL_HOURS = 2, PACKAGE_B_ADDITIONAL_HOURS = 1;
        const double NONPROFIT_DISCOUNT = .80, PACKAGE_A_MONTHLY_FEE = 9.95, PACKAGE_B_MONTHLY_FEE = 14.95, PACKAGE_C_MONTHLY_FEE = 19.95;
        double hoursUsed, totalCost;
        private void exitButton_Click(object sender, EventArgs e)
        {
            closeApplication();
        }

        private void closeApplication()
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Error closing the application.");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
                clearFields();
        }
        private void clearFields()
        {
            try
            {
                totalAmountDueLabel.Text = " "; hoursUsedLabel.Text = " ";
                hoursUsed = 0; totalCost = 0;
                hoursUsedLabel.Focus();
            }
            catch
            {
                MessageBox.Show("Error clearing the fields and values");
            }
        }
        private void userInputValidation()
        {
            {   //Note that this method is not using the try catch method because it is not needed. Instead it uses a tryParse method. 
                //This if statement checks to see if the user input is a number
                if (double.TryParse(hoursUsedLabel.Text, out hoursUsed))
                {
                    hoursUsed = double.Parse(hoursUsedLabel.Text);
                    //This if statement checks to see if the user input is within the possible range of hours in a month, 
                    //If above, it asks them to please input a valid number of hours, sets focus to the textbox, and clears all fields.
                    if (hoursUsed > 744)
                    {
                        MessageBox.Show("Try again. Please input a valid number of hours.");
                        clearFields();
                    }

                }
                //If the user input is not a number, the program tells them input a number next time, sets focus to the textbox, and clears all fields. 
                else
                {
                    MessageBox.Show("Try again. Please enter a number.");
                    clearFields();
                }
            }

        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
                userInputValidation();
                calculateTotalDue();
        }
        private void calculateTotalDue()
        {
            try
            {
                if (packageARadioButton.Checked)
                {
                    if (nonprofitCheckBox.Checked)
                    {
                        if (hoursUsed > 10) 
                            //If radio button A is selected, nonprofit checkbox is selected, and the hours is greater than 10,  it calculates the total amount due and sends it to the output label.
                        {
                            totalCost = ((hoursUsed - 10) * PACKAGE_A_ADDITIONAL_HOURS + PACKAGE_A_MONTHLY_FEE) * NONPROFIT_DISCOUNT;
                            totalAmountDueLabel.Text = totalCost.ToString("c");
                        }
                            //If the radio button is selected, and the nonprofit box, but the hours used is less than or equal to 10, it just uses 
                            //the discount and the subscription fee to calculate the total and then sends that to the output lablel.
                        else
                        {
                            totalCost = PACKAGE_A_MONTHLY_FEE * NONPROFIT_DISCOUNT;
                            totalAmountDueLabel.Text = totalCost.ToString("c");
                        }
                    }
                    //If the nonprofit box is not checked, and the hours used is greater than 10, it calculates the total due and sends it to the output label. 
                    else if (hoursUsed > 10)
                    {
                        totalCost = (hoursUsed - 10) * PACKAGE_A_ADDITIONAL_HOURS + PACKAGE_A_MONTHLY_FEE;
                        totalAmountDueLabel.Text = totalCost.ToString("c");
                    }
                    //If the nonprofit box is not checked, and the hours used is less than or equal to 10, it calculates the total due and sends it to the output label. 
                    else if (hoursUsed < 10)
                    {
                        totalCost = PACKAGE_A_MONTHLY_FEE;
                        totalAmountDueLabel.Text = totalCost.ToString("c");
                    }
                }
                //This is almost identical to the code above, except this code is for when you select subscription service B.
               else if (packageBRadioButton.Checked)
                {
                    if (nonprofitCheckBox.Checked)
                    { 
                        if (hoursUsed > 20)
                        {
                            totalCost = ((hoursUsed - 20) * PACKAGE_B_ADDITIONAL_HOURS + PACKAGE_B_MONTHLY_FEE) * NONPROFIT_DISCOUNT;
                            totalAmountDueLabel.Text = totalCost.ToString("c");
                        }
                        else
                        {
                            totalCost = PACKAGE_B_MONTHLY_FEE * NONPROFIT_DISCOUNT;
                            totalAmountDueLabel.Text = totalCost.ToString("c");
                        }
                    }
                    else if (hoursUsed > 20)
                    {
                        totalCost = (hoursUsed - 20) * PACKAGE_B_ADDITIONAL_HOURS + PACKAGE_B_MONTHLY_FEE;
                        totalAmountDueLabel.Text = totalCost.ToString("c");
                    }
                    else if (hoursUsed < 20)
                    {
                        totalCost = PACKAGE_B_MONTHLY_FEE;
                        totalAmountDueLabel.Text = totalCost.ToString("c");
                    }
                }
               //This is for subscription C, and there is no premium for extra hours, since they get unlimited hours with this service. 
                else if (packageCRadioButton.Checked)
                {
                    if (nonprofitCheckBox.Checked)
                    {
                        totalCost = PACKAGE_C_MONTHLY_FEE * NONPROFIT_DISCOUNT;
                        totalAmountDueLabel.Text = totalCost.ToString("c");
                    }
                    else
                    {
                        totalCost = PACKAGE_C_MONTHLY_FEE;
                        totalAmountDueLabel.Text = totalCost.ToString("c");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error calculating the data.");
            }
        }
    }
}