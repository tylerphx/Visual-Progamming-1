using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
    {
            InitializeComponent();
    }
        //Written by Tyler Ingram in 2020
        //Adds the items to listboxes when the program is run
        //Not using constants for efficiency  
        double wshopcost = 0, lodge = 0, subtotal = 0, grandtotal =0;
        string hostCity, workshop; 
    private void addWorkShopButton_Click(object sender, EventArgs e)
    {
            Process();
    }
    private void Process()
        {
            //Calculates the total for the handling stress workshop and for any locations they choose
            //and this is added to the costs textbox. Does this for every workshop.
                    if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 0)
                    {
                        wshopcost = 595;
                        lodge = 3 * 95;
                    }
                    else if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 1)
                    {
                        wshopcost = 595;
                        lodge = 125 * 3;
                    }
                    else if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 2)
                    {
                        wshopcost = 595;
                        lodge = 110 * 3;
                    }
                    else if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 3)
                    {
                        wshopcost = 595;
                        lodge = 100 * 3;
                    }
                    else if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 4)
                    {
                        wshopcost = 595;
                        lodge = 92 * 3;
                    }
                    else if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 5)
                    {
                        wshopcost = 595;
                        lodge = 90 * 3;
                    }
                    //Calculates the total for the time management workshop and for any locations they choose, 
                    //and this is added to the costs textbox 
                    else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 0)
                    {
                        wshopcost = 695;
                        lodge = 95 * 3;
                    }
                    else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 1)
                    {
                        wshopcost = 695;
                        lodge = 125 * 3;
                    }
                    else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 2)
                    {
                        wshopcost = 695;
                        lodge = 110 * 3;
                    }
                    else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 3)
                    {
                        wshopcost = 695;
                        lodge = 125 * 3;
                    }
                    else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 4)
                    {
                        wshopcost = 695;
                        lodge = 92 * 3;
                    }
                    else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 5)
                    {
                        wshopcost = 695;
                        lodge = 90 * 3;
                       
                    }
                    //Calculates the total for the supervision skills workshop and for any locations they choose, 
                    //and this is added to the costs textbox 
                    else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 0)
                    {
                        wshopcost = 995;
                        lodge = 95 * 3;
                        
                    }
                    else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 1)
                    {
                        wshopcost = 995;
                        lodge = 125 * 3;
                        
                    }
                    else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 2)
                    {
                        wshopcost = 995;
                        lodge = 110 * 3;
                        
                    }
                    else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 3)
                    {
                        wshopcost = 995;
                        lodge = 100 * 3;
                        
                    }
                    else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 4)
                    {
                        wshopcost = 995;
                        lodge = 92 * 3;
                       
                    }
                    else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 5)
                    {
                        wshopcost = 995;
                        lodge = 90 * 3;
                        
                    }
                    //Calculates the total for the Negotation workshop and for any locations they choose, 
                    //and this is added to the  costs textbox 
                    else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 0)
                    {
                        wshopcost = 1295;
                        lodge = 95 * 5;
                    }
                    else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 1)
                    {
                        wshopcost = 1295;
                        lodge = 125 * 5;
                       
                    }
                    else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 2)
                    {
                        wshopcost = 1295;
                        lodge = 110 * 5;
                        
                    }
                    else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 3)
                    {
                        wshopcost = 1295;
                        lodge = 100 * 5;
                    }
                    else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 4)
                    {
                        wshopcost = 1295;
                        lodge = 92 * 5;
                       
                    }
                    else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 5)
                    {
                        wshopcost = 1295;
                        lodge = 90 * 5;
                       
                    }
                    //Calculates the total for the How to Interview workshop and for any locations they choose, 
                    //and this is added to the list of costs textbox 
                    else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 0)
                    {
                        wshopcost = 395;
                        lodge = 95 * 1;
                        
                    }
                    else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 1)
                    {
                        wshopcost = 395;
                        lodge = 125 * 1;
                        
                    }
                    else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 2)
                    {
                        wshopcost = 395;
                        lodge = 110 * 1;
                       
                    }
                    else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 3)
                    {
                        wshopcost = 395;
                        lodge = 100 * 1;
                        
                    }
                    else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 4)
                    {
                        wshopcost = 395;
                        lodge = 92 * 1;
                        
                    }
                    else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 5)
                    {
                        wshopcost = 395;
                        lodge = 90 * 1;
                       
                    }
            hostCity = locationListBox.SelectedItem.ToString();
            workshop = workShopListBox.SelectedItem.ToString();
            subtotal = wshopcost + lodge;
            grandtotal = grandtotal + subtotal;
            costListBox.Items.Add(workshop + "\t" + hostCity + "\t" + subtotal.ToString("C"));     
    }
    private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            OutputGrandTotal();
        }
    private void OutputGrandTotal()
        {
            outputLabel.Text = grandtotal.ToString("c");
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetApplication();
            ClearFields();
        }
        private void ResetApplication()
        {
            locationListBox.ClearSelected();
            workShopListBox.ClearSelected();
        }
        private void ClearFields()
        {
            outputLabel.Text = "";
            wshopcost = 0; lodge = 0; subtotal = 0; grandtotal = 0; 
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }
        private void ExitApplication()
        {
            Application.Exit();
        }
    }
}
