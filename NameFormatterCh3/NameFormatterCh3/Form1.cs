using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameFormatterCh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void dexterTranslatedButton_Click(object sender, EventArgs e)
        {
            dexterTranslatedLabel.Text = "right";
        }

        private void mediumTranslatedButton_Click(object sender, EventArgs e)
        {
            mediumTranslatedLabel.Text = "center";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sinisterTranslatedButton_Click(object sender, EventArgs e)
        {
            sinisterTranslatedLabel.Text = "left";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
