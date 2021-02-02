using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_5ChangeCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private decimal total;
        const decimal FIVE_CENTS_VALUE = .05m;
        const decimal TEN_CENTS_VALUE = .10m;
        const decimal TWENTYFIVE_CENTS_VALUE = .25m;
        const decimal FIFTY_CENTS_VALUE = .50m; 

        private void totalLabel_Click(object sender, EventArgs e)
        {
            
        }
        
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTYFIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");

        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
