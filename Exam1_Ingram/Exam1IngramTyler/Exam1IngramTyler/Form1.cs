using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1IngramTyler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //initalizing my variables and constants
        int totalTouchdowns, totalPointKicks, totalFieldGoals, touchdowns, pointKicks, fieldGoals, totalPointsScored;
        const int TOUCHDOWN = 6, EXTRA_POINT_KICK = 1, FIELD_GOAL = 3;
        private void clearButton_Click(object sender, EventArgs e)
        {
            //when clicked, calls the method that clears fields and creates a message
            clearFields();
            //when clicked, calls the method that clears variables (not constants though)
            clearVariables();
        }
        private void clickHereButton_Click(object sender, EventArgs e)
        {
            //when clicked, calls the method that makes the passPictureBox visible when clicked 
            summonPassPicture();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //when clicked, calls the method that closes the application
            closeApplication();
        }
        private void clearPassingPlayPicture_Click(object sender, EventArgs e)
        {
            //when clicked, calls the method that hides the PassPictureBox
            hidePassPicture();
        }
        private void computeButton_Click(object sender, EventArgs e)
        {
            //when clicked, calls the methods that gather, process, and output the data collected from the user
            Userinput();
            processData();
            outputData();
        }
        private void Userinput()
        {
            try
            {
                //gathers the user input from each of the 3 textboxes and stores it for processing
                touchdowns = int.Parse(totalTouchdownsTextBox.Text);
                pointKicks = int.Parse(totalPointKicksTextBox.Text);
                fieldGoals = int.Parse(totalFieldGoalsTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error gathering user input");
            }
        }
        private void processData()
        {
            try
            {
                //processing the user input from the three textboxes, multiplying them accordingly to get the total points scored
                totalTouchdowns = touchdowns * TOUCHDOWN;
                totalPointKicks = pointKicks * EXTRA_POINT_KICK;
                totalFieldGoals = fieldGoals * FIELD_GOAL;
                totalPointsScored = totalTouchdowns + totalPointKicks + totalFieldGoals;
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
                //outputs the total points scored to the label
                totalPointsOutputLabel.Text = totalPointsScored.ToString();
            }
            catch
            {
                MessageBox.Show("Error outputing the data");
            }
        }
        private void clearFields()
        {
            try
            {
                //Clears the fields, sends a message, and sets focus on the first textbox
                MessageBox.Show("Clearing the scoreboard.");
                totalTouchdownsTextBox.Text = " ";
                totalPointKicksTextBox.Text = " ";
                totalFieldGoalsTextBox.Text = " ";
                totalPointsOutputLabel.Text = " ";
                totalTouchdownsTextBox.Focus();
            }
            catch
            {
                MessageBox.Show("Error clearing fields");
            }
        }
        private void clearVariables()
        {
            try
            {
                //clears the variables by setting them to 0, am not clearing constants, however, as they should not be cleared.
                totalTouchdowns = 0; totalPointKicks = 0; totalFieldGoals = 0; touchdowns = 0; pointKicks = 0; fieldGoals = 0; totalPointsScored = 0;
            }
            catch
            {
                MessageBox.Show("Error clearing the variables.");
            }
        }
        private void summonPassPicture()
        {
            try
            {
                //makes the passPicture visible 
                passPictureBox.Visible = true;
            }
            catch
            {
                MessageBox.Show("Error summoning the picture.");
            }
        }
        private void hidePassPicture()
        {
            try
            {
                //makes the passPicture invisible
                passPictureBox.Visible = false;
            }
            catch
            {
                MessageBox.Show("Error hiding the picture.");
            }
        }
        private void closeApplication()
        {
            try
            {
                //closes the application
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Error closing the application.");
            }
        }
    }
}
