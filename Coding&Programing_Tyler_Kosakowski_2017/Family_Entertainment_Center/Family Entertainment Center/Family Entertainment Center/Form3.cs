using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Family_Entertainment_Center
{
    public partial class Form3 : Form
    {
        int employeeSubThree = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Decreaces the value of the sub selector and calls the display function
            employeeSubThree -= 1;
            showEmployeeInfo();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Decreaces the value of the sub selector and calls the display function
            employeeSubThree++;
            showEmployeeInfo();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // When the function loads show the first employee location inforamtion
            showEmployeeInfo();

            // If coming from the scheduling form show the add to schedule button
            if (globalVar.scheduling)
            {
                btnAddToSchedule.Visible = true;
            }
        }

        public void showEmployeeInfo()
        {
            // Prevents the user from haveing an application crash when clicking the previous employee
            // button when on the first employee
            if (employeeSubThree < 0)
            {
                MessageBox.Show("Employee cannot have a negative id number returning to previous employee.");
                // Resets to the first employee
                employeeSubThree = 0;
            }

            // If there is data in the selected location in the name array display the 
            // data from the name, pay rate, and hrs arrays
            if (globalVar.employeeNames[employeeSubThree] != null)
            {
                lblEmployeeName.Text = globalVar.employeeNames[employeeSubThree];
                lblHrlyRate.Text = Convert.ToString(globalVar.payRates[employeeSubThree]);
                lblHrsPerWeek.Text = Convert.ToString(globalVar.wklyHrs[employeeSubThree]);
                lblSalary.Text = Convert.ToString(globalVar.payRates[employeeSubThree] * globalVar.wklyHrs[employeeSubThree]);

            }
                // If there is no data for a location return to the previous location and 
                // decrament the sub selector
            else
            {
                MessageBox.Show("No Data for this location!");
                employeeSubThree -=1;
            }

        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Deletes the data if the uses chooses to remove the employee
            globalVar.employeeNames[employeeSubThree] = " ";
            globalVar.payRates[employeeSubThree] = 0.0;
            globalVar.wklyHrs[employeeSubThree] = 0;
        }

        // Transfers data of selected employee to the scheduling array
        private void btnAddToSchedule_Click(object sender, EventArgs e)
        {
            // returns the scheduling variable to false and sets the add to schedule button to invisible
            globalVar.scheduling = false;
            btnAddToSchedule.Visible = false;

            globalVar.scheduleEmpSub = employeeSubThree;

            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
