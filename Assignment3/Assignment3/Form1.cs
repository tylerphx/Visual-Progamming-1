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
        private void Form1_Load(object sender, EventArgs e)
        {
            //Adds the items to the list when the program is run
            workShopListBox.Items.Add("Handling Stress");
            workShopListBox.Items.Add("Time Management");
            workShopListBox.Items.Add("Supervision Skills");
            workShopListBox.Items.Add("Negotiation");
            workShopListBox.Items.Add("How to Interview");
            locationListBox.Items.Add("Austin");
            locationListBox.Items.Add("Chicago");
            locationListBox.Items.Add("Dallas");
            locationListBox.Items.Add("Orlando");
            locationListBox.Items.Add("Phoenix");
            locationListBox.Items.Add("Raleigh");
        }
        const int //declaring all the constants
            HANDLING_STRESS_REGISTRATION_FEE = 595, HANDLING_STRESS_DAYS = 3,
            TIME_MANAGEMENT_REGISTRATION_FEE = 695, TIME_MANAGEMENT_DAYS = 3,
            SUPERVISION_SKILLS_REGISTRATION_FEE = 995, SUPERVISION_SKILLS_DAYS = 3,
            NEGOTATION_REGISTRATION_FEE = 1295, NEGOTATION_DAYS = 3,
            HOW_TO_INTERVIEW_REGISTRATION_FEE = 395, HOW_TO_INTERVIEW_DAYS = 1,
            AUSTIN_LODGING_DAILY_FEE = 95, CHICAGO_LODGING_DAILY_FEE = 125, DALLAS_LODGING_DAILY_FEE = 110, ORLANDO_LODGING_DAILY_FEE = 100, 
            PHOENIX_LODGING_DAILY_FEE = 92, RALEIGH_LODGING_DAILY_FEE = 90;
        private void addWorkShopButton_Click(object sender, EventArgs e)
        {
            CostsListBoxTotal();
        }
        private void CostsListBoxTotal()
        {
            //Calculates the total for the handling stress workshop and for any locations they choose, 
            //and this is added to the costs textbox 
            //Note that it will show two charges in the list box, one for the registration and one for the lodging. 
            //I wanted it to be this way so the customer understands the payment in detail. 
            {
                if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 0)
                {
                    costListBox.Items.Add(HANDLING_STRESS_REGISTRATION_FEE);
                    int handlingStressLodgingTotal = AUSTIN_LODGING_DAILY_FEE * HANDLING_STRESS_DAYS;
                    costListBox.Items.Add(handlingStressLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 1)
                {
                    costListBox.Items.Add(HANDLING_STRESS_REGISTRATION_FEE);
                    int handlingStressLodgingTotal = CHICAGO_LODGING_DAILY_FEE * HANDLING_STRESS_DAYS;
                    costListBox.Items.Add(handlingStressLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 2)
                {
                    costListBox.Items.Add(HANDLING_STRESS_REGISTRATION_FEE);
                    int handlingStressLodgingTotal = DALLAS_LODGING_DAILY_FEE * HANDLING_STRESS_DAYS;
                    costListBox.Items.Add(handlingStressLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 3)
                {
                    costListBox.Items.Add(HANDLING_STRESS_REGISTRATION_FEE);
                    int handlingStressLodgingTotal = ORLANDO_LODGING_DAILY_FEE * HANDLING_STRESS_DAYS;
                    costListBox.Items.Add(handlingStressLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 4)
                {
                    costListBox.Items.Add(HANDLING_STRESS_REGISTRATION_FEE);
                    int handlingStressLodgingTotal = PHOENIX_LODGING_DAILY_FEE * HANDLING_STRESS_DAYS;
                    costListBox.Items.Add(handlingStressLodgingTotal);
                }
                else  if (workShopListBox.SelectedIndex == 0 && locationListBox.SelectedIndex == 5)
                {
                    costListBox.Items.Add(HANDLING_STRESS_REGISTRATION_FEE);
                    int handlingStressLodgingTotal = RALEIGH_LODGING_DAILY_FEE * HANDLING_STRESS_DAYS;
                    costListBox.Items.Add(handlingStressLodgingTotal);
                }
                //Calculates the total for the time management workshop and for any locations they choose, 
                //and this is added to the costs textbox 
                else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 0)
                {
                    costListBox.Items.Add(TIME_MANAGEMENT_REGISTRATION_FEE);
                    int timeManagementLodgingTotal = AUSTIN_LODGING_DAILY_FEE * TIME_MANAGEMENT_DAYS;
                    costListBox.Items.Add(timeManagementLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 1)
                {
                    costListBox.Items.Add(TIME_MANAGEMENT_REGISTRATION_FEE);
                    int timeManagementLodgingTotal = CHICAGO_LODGING_DAILY_FEE * TIME_MANAGEMENT_DAYS;
                    costListBox.Items.Add(timeManagementLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 2)
                {
                    costListBox.Items.Add(TIME_MANAGEMENT_REGISTRATION_FEE);
                    int timeManagementLodgingTotal = DALLAS_LODGING_DAILY_FEE * TIME_MANAGEMENT_DAYS;
                    costListBox.Items.Add(timeManagementLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 3)
                {
                    costListBox.Items.Add(TIME_MANAGEMENT_REGISTRATION_FEE);
                    int timeManagementLodgingTotal = ORLANDO_LODGING_DAILY_FEE * TIME_MANAGEMENT_DAYS;
                    costListBox.Items.Add(timeManagementLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 4)
                {
                    costListBox.Items.Add(TIME_MANAGEMENT_REGISTRATION_FEE);
                    int timeManagementLodgingTotal = PHOENIX_LODGING_DAILY_FEE * TIME_MANAGEMENT_DAYS;
                    costListBox.Items.Add(timeManagementLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 1 && locationListBox.SelectedIndex == 5)
                {
                    costListBox.Items.Add(TIME_MANAGEMENT_REGISTRATION_FEE);
                    int timeManagementLodgingTotal = RALEIGH_LODGING_DAILY_FEE * TIME_MANAGEMENT_DAYS;
                    costListBox.Items.Add(timeManagementLodgingTotal);
                }
                //Calculates the total for the supervision skills workshop and for any locations they choose, 
                //and this is added to the costs textbox 
                else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 0)
                {
                    costListBox.Items.Add(SUPERVISION_SKILLS_REGISTRATION_FEE);
                    int supervisionSkillsLodgingTotal = AUSTIN_LODGING_DAILY_FEE * SUPERVISION_SKILLS_DAYS;
                    costListBox.Items.Add(supervisionSkillsLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 1)
                {
                    costListBox.Items.Add(SUPERVISION_SKILLS_REGISTRATION_FEE);
                    int supervisionSkillsLodgingTotal = CHICAGO_LODGING_DAILY_FEE * SUPERVISION_SKILLS_DAYS;
                    costListBox.Items.Add(supervisionSkillsLodgingTotal);
                } 
                else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 2)
                {
                    costListBox.Items.Add(SUPERVISION_SKILLS_REGISTRATION_FEE);
                    int supervisionSkillsLodgingTotal = DALLAS_LODGING_DAILY_FEE * SUPERVISION_SKILLS_DAYS;
                    costListBox.Items.Add(supervisionSkillsLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 3)
                {
                    costListBox.Items.Add(SUPERVISION_SKILLS_REGISTRATION_FEE);
                    int supervisionSkillsLodgingTotal = ORLANDO_LODGING_DAILY_FEE * SUPERVISION_SKILLS_DAYS;
                    costListBox.Items.Add(supervisionSkillsLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 4)
                {
                    costListBox.Items.Add(SUPERVISION_SKILLS_REGISTRATION_FEE);
                    int supervisionSkillsLodgingTotal = PHOENIX_LODGING_DAILY_FEE * SUPERVISION_SKILLS_DAYS;
                    costListBox.Items.Add(supervisionSkillsLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 2 && locationListBox.SelectedIndex == 5)
                {
                    costListBox.Items.Add(SUPERVISION_SKILLS_REGISTRATION_FEE);
                    int supervisionSkillsLodgingTotal = RALEIGH_LODGING_DAILY_FEE * SUPERVISION_SKILLS_DAYS;
                    costListBox.Items.Add(supervisionSkillsLodgingTotal);
                }
                //Calculates the total for the Negotation workshop and for any locations they choose, 
                //and this is added to the  costs textbox 
                else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 0)
                {
                    costListBox.Items.Add(NEGOTATION_REGISTRATION_FEE);
                    int negotiationLodgingTotal = AUSTIN_LODGING_DAILY_FEE * NEGOTATION_DAYS;
                    costListBox.Items.Add(negotiationLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 1)
                {
                    costListBox.Items.Add(NEGOTATION_REGISTRATION_FEE);
                    int negotiationLodgingTotal = CHICAGO_LODGING_DAILY_FEE * NEGOTATION_DAYS;
                    costListBox.Items.Add(negotiationLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 2)
                {
                    costListBox.Items.Add(NEGOTATION_REGISTRATION_FEE);
                    int negotiationLodgingTotal = DALLAS_LODGING_DAILY_FEE * NEGOTATION_DAYS;
                    costListBox.Items.Add(negotiationLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 3)
                {
                    costListBox.Items.Add(NEGOTATION_REGISTRATION_FEE);
                    int negotiationLodgingTotal = ORLANDO_LODGING_DAILY_FEE * NEGOTATION_DAYS;
                    costListBox.Items.Add(negotiationLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 4)
                {
                    costListBox.Items.Add(NEGOTATION_REGISTRATION_FEE);
                    int negotiationLodgingTotal = PHOENIX_LODGING_DAILY_FEE * NEGOTATION_DAYS;
                    costListBox.Items.Add(negotiationLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 3 && locationListBox.SelectedIndex == 5)
                {
                    costListBox.Items.Add(NEGOTATION_REGISTRATION_FEE);
                    int negotiationLodgingTotal = RALEIGH_LODGING_DAILY_FEE * NEGOTATION_DAYS;
                    costListBox.Items.Add(negotiationLodgingTotal);
                }
                //Calculates the total for the How to Interview workshop and for any locations they choose, 
                //and this is added to the list of costs textbox 
                else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 0)
                {
                    costListBox.Items.Add(HOW_TO_INTERVIEW_REGISTRATION_FEE);
                    int howToInterviewLodgingTotal = AUSTIN_LODGING_DAILY_FEE * HOW_TO_INTERVIEW_DAYS;
                    costListBox.Items.Add(howToInterviewLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 1)
                {
                    costListBox.Items.Add(HOW_TO_INTERVIEW_REGISTRATION_FEE);
                    int howToInterviewLodgingTotal = CHICAGO_LODGING_DAILY_FEE * HOW_TO_INTERVIEW_DAYS;
                    costListBox.Items.Add(howToInterviewLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 2)
                {
                    costListBox.Items.Add(HOW_TO_INTERVIEW_REGISTRATION_FEE);
                    int howToInterviewLodgingTotal = DALLAS_LODGING_DAILY_FEE * HOW_TO_INTERVIEW_DAYS;
                    costListBox.Items.Add(howToInterviewLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 3)
                {
                    costListBox.Items.Add(HOW_TO_INTERVIEW_REGISTRATION_FEE);
                    int howToInterviewLodgingTotal = ORLANDO_LODGING_DAILY_FEE * HOW_TO_INTERVIEW_DAYS;
                    costListBox.Items.Add(howToInterviewLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 4)
                {
                    costListBox.Items.Add(HOW_TO_INTERVIEW_REGISTRATION_FEE);
                    int howToInterviewLodgingTotal = PHOENIX_LODGING_DAILY_FEE * HOW_TO_INTERVIEW_DAYS;
                    costListBox.Items.Add(howToInterviewLodgingTotal);
                }
                else if (workShopListBox.SelectedIndex == 4 && locationListBox.SelectedIndex == 5)
                {
                    costListBox.Items.Add(HOW_TO_INTERVIEW_REGISTRATION_FEE);
                    int howToInterviewLodgingTotal = RALEIGH_LODGING_DAILY_FEE * HOW_TO_INTERVIEW_DAYS;
                    costListBox.Items.Add(howToInterviewLodgingTotal);
                }
            }
        }
        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            calculateTotal();
        }
        private void calculateTotal()
        {
            int totalCosts = 0, x = 0;
            int countOfCostsListbox = costListBox.Items.Count;
            for (int i = 0; i<countOfCostsListbox; i=i+1)
            {
                totalCosts = totalCosts + int.Parse(costListBox.Items[i].ToString());
                x++;
                if (x>=countOfCostsListbox)
                {
                    outputLabel.Text = totalCosts.ToString("c");
                }
            }
              
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetApplication();
        }
        private void ResetApplication()
        {
            costListBox.Items.Clear();
            workShopListBox.ClearSelected();
            locationListBox.ClearSelected();
            outputLabel.Text = " ";
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
