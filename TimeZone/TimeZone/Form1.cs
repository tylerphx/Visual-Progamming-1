﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZone
{
    public partial class Form1 : Form
    {
        private string timezoneDenver;

        public Form1()
        {
            InitializeComponent();
        }

        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string city;
            if (cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
                switch (city)
                {
                    case "Denver":
                        timeZoneLabel.Text = "Mountain";
                        break;
                    case "Honolulu":
                        timeZoneLabel.Text = "XD";
                            break;
                    
                }
            }


        }

        private void okButton_Click(object sender, EventArgs e)
        {
            
                
        }
    }
}
