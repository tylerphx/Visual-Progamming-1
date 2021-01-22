using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   
        private void spanishButton_Click(object sender, EventArgs e)
        {
            translationOutputLabel.Text = "Buenos Dias";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            translationOutputLabel.Text = "Buongiorno";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translationOutputLabel.Text = "Guten Morgen";
        }

        private void translationOutputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
