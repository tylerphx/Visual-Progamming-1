using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesPriceCalculator3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)

        {
            try
            {
                //divide by 100 before doing any calculations 
                decimal discount;
                discount = decimal.Parse(discountPercentageTextBox.Text) / 100;

                //now that you put the decimal in the right spot, do the calculations
                decimal originalPrice = decimal.Parse(originalPriceTextBox.Text);
                decimal discountPrice = originalPrice - (discount * originalPrice);
                salesPriceLabel.Text = discountPrice.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void discountPercentageTextBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void originalPricePromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void discPercentagePromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void salesPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
