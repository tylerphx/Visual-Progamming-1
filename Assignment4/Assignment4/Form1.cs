using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string studentName = " ", letterGrade = " ";
        double gradeScore1, gradeScore2, gradeScore3, averageScore;
        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                exitApp();
            }
            catch (Exception)
            {
            }
            
        }
        private void exitApp()
        {
            Application.Exit();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                process();
            }
            catch (Exception)
            {
            }
        }
        private void process()
        {
            try
            {
                StreamReader inputFileOne;
                inputFileOne = File.OpenText("students1.txt");
                while (!inputFileOne.EndOfStream)
                {
                    studentName = inputFileOne.ReadLine();
                    gradeScore1 = double.Parse(inputFileOne.ReadLine());
                    gradeScore2 = double.Parse(inputFileOne.ReadLine());
                    gradeScore3 = double.Parse(inputFileOne.ReadLine());
                    averageScore = (gradeScore1 + gradeScore2 + gradeScore3) / 3;
                    if (averageScore <= 59)
                    {
                        letterGrade = "F";
                    }
                    else if (averageScore <= 69)
                    {
                        letterGrade = "D";
                    }
                    else if (averageScore <= 79)
                    {
                        letterGrade = "C";
                    }
                    else if (averageScore <= 89)
                    {
                        letterGrade = "B";
                    }
                    else
                    {
                        letterGrade = "A";
                    }
                    //Calls the output method which adds the items to the textbox. 
                    output();
                }
            }
            catch
            {
            }
        }
        private void output()
        {
            try
            {
                gradeListBox.Items.Add(studentName + "\t " + averageScore.ToString("n2") + "\t" + letterGrade);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
 }


