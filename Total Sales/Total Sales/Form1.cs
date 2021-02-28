using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog.ShowDialog();
            StreamReader inputFile;
            openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFileDialog.FileName);
                MessageBox.Show("NOICE");
            }
            else
            {
                MessageBox.Show("you clicked cancel! ");
            }
        }

        //calculates the total of all the number values in a pre-existing file
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Sales.txt");
                while (!inputFile.EndOfStream)
                {
                    double stringTotal = double.Parse(inputFile.ReadLine());
                    double total = 0;
                    total = stringTotal + total; 
                    if (inputFile.EndOfStream)
                    {
                        totalLabel.Text = total.ToString("c");
                    }
                }
            }
            catch
            {
                //
            }
        }
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
        }
    }
}
