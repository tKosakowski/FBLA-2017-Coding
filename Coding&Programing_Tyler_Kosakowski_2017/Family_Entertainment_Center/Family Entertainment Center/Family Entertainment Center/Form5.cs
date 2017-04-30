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
    public partial class Form5 : Form
    {

        int monSub = 0;
        int tueSub = 0;
        int wedSub = 0;
        int thrSub = 0;
        int friSub = 0;
        int satSub = 0;
        int sunSub = 0;

        public Form5()
        {
            InitializeComponent();
        }

        // Three button click events to add/remove employees and et their hours

        // Button adds to the monday employee list
        private void btnAddMonday_Click(object sender, EventArgs e)
        {
            // Opens the view employee form and sets the bool so that it knows
            // it has been opened from the scheduling form
            Form3 viewEmp = new Form3();

            globalVar.scheduling = true;

            // Dialog pauses the code here until this form is reutrned to view
            viewEmp.ShowDialog();

            // Add the name of the employee selected in the view employee form to the list box
            lstMonday.Items.Add(globalVar.employeeNames[globalVar.scheduleEmpSub]);

            // sets the monSub location in the monday schedule array to the value of the
            // sub from the scheduling form
            globalVar.monSchLoc[monSub] = globalVar.scheduleEmpSub;

            // incraments the monSub value
            monSub++;
        }

        // removes the values of the last employee and hours added
        private void btnRemoveMonday_Click(object sender, EventArgs e)
        {
            lstMonday.Items.Remove(globalVar.employeeNames[globalVar.monSchLoc[monSub -1]]);
            lstMonday.Items.Remove(globalVar.monStHr[monSub -1] + " - " + globalVar.monEndHr[monSub -1]);

        }

        // Prompts for the hours when the button is clicked
        private void btnStartHrMon_Click(object sender, EventArgs e)
        {
            // Opens the form to enter hours
            Form12 addHrs = new Form12();

            // If an employee has not yet been entered tell the user to enter an employee first and exit the function
            if (monSub <= 0)
            {
                MessageBox.Show("Please enter a name first.");
                goto loc1;
            }

            // Pauses while user enters data
            addHrs.ShowDialog();

            // Adds to the lstbox the hour values given by the user
            lstMonday.Items.Add(globalVar.startHr + " - " + globalVar.endHr);

            // sets the locations in the hours arrays equal to the values entered
            globalVar.monStHr[monSub - 1] = globalVar.startHr;
            globalVar.monEndHr[monSub - 1] = globalVar.endHr;

                loc1:;
        }

        // Three button click events to add/remove employees and et their hours
        // Same as monday for tuesday
        private void btnAddEmpTues_Click(object sender, EventArgs e)
        {
            Form3 viewEmp = new Form3();

            globalVar.scheduling = true;

            viewEmp.ShowDialog();

            lstTuesday.Items.Add(globalVar.employeeNames[globalVar.scheduleEmpSub]);

            globalVar.tueSchLoc[tueSub] = globalVar.scheduleEmpSub;

            tueSub++;
        }

        private void btnRemoveEmpTues_Click(object sender, EventArgs e)
        {
            lstTuesday.Items.Remove(globalVar.employeeNames[globalVar.scheduleEmpSub]);
            lstTuesday.Items.Remove(globalVar.tueStHr[tueSub - 1] + " - " + globalVar.tueEndHr[tueSub - 1]);
        }

        private void btnStartHrTues_Click(object sender, EventArgs e)
        {
            Form12 addHrs = new Form12();

            if (tueSub <= 0)
            {
                MessageBox.Show("Please enter a name first.");
                goto loc2;
            }

            addHrs.ShowDialog();

            lstTuesday.Items.Add(globalVar.startHr + " - " + globalVar.endHr);

            globalVar.tueStHr[tueSub - 1] = globalVar.startHr;
            globalVar.tueEndHr[tueSub - 1] = globalVar.endHr;

        loc2:;
        }

        // Three button click events to add/remove employees and et their hours
        // Same as monday for wednesday

        private void btnAddEmpWed_Click(object sender, EventArgs e)
        {
            Form3 viewEmp = new Form3();

            globalVar.scheduling = true;

            viewEmp.ShowDialog();

            lstWednesday.Items.Add(globalVar.employeeNames[globalVar.scheduleEmpSub]);

            globalVar.wedSchLoc[wedSub] = globalVar.scheduleEmpSub;

            wedSub++;
        }

        private void btnRemoveEmpWed_Click(object sender, EventArgs e)
        {
            lstWednesday.Items.Remove(globalVar.employeeNames[globalVar.scheduleEmpSub]);
            lstWednesday.Items.Remove(globalVar.wedStHr[wedSub - 1] + " - " + globalVar.wedEndHr[wedSub - 1]);

        }

        private void btnStartHrWed_Click(object sender, EventArgs e)
        {
            Form12 addHrs = new Form12();

            if (wedSub <= 0)
            {
                MessageBox.Show("Please enter a name first.");
                goto loc3;
            }

            addHrs.ShowDialog();

            lstWednesday.Items.Add(globalVar.startHr + " - " + globalVar.endHr);

            globalVar.wedStHr[wedSub - 1] = globalVar.startHr;
            globalVar.wedEndHr[wedSub - 1] = globalVar.endHr;

        loc3:;
        }

        // Three button click events to add/remove employees and et their hours
        // Same as monday for thursday
        private void btnAddEmpThur_Click(object sender, EventArgs e)
        {
            Form3 viewEmp = new Form3();

            globalVar.scheduling = true;

            viewEmp.ShowDialog();

            lstThursday.Items.Add(globalVar.employeeNames[globalVar.scheduleEmpSub]);

            globalVar.thrSchLoc[thrSub] = globalVar.scheduleEmpSub;

            thrSub++;
        }

        private void btnRemoveThur_Click(object sender, EventArgs e)
        {
            lstThursday.Items.Remove(globalVar.employeeNames[globalVar.scheduleEmpSub]);
            lstThursday.Items.Remove(globalVar.thrStHr[thrSub - 1] + " - " + globalVar.thrEndHr[thrSub - 1]);

        }

        private void btnStartHrThur_Click(object sender, EventArgs e)
        {
            Form12 addHrs = new Form12();

            if (thrSub <= 0)
            {
                MessageBox.Show("Please enter a name first.");
                goto loc4;
            }

            addHrs.ShowDialog();

            lstThursday.Items.Add(globalVar.startHr + " - " + globalVar.endHr);

            globalVar.thrStHr[thrSub - 1] = globalVar.startHr;
            globalVar.thrEndHr[thrSub - 1] = globalVar.endHr;

        loc4:;
        }

        // Three button click events to add/remove employees and et their hours
        // Same as monday for friday
        private void btnAddEmpFri_Click(object sender, EventArgs e)
        {
            Form3 viewEmp = new Form3();

            globalVar.scheduling = true;

            viewEmp.ShowDialog();

            lstFriday.Items.Add(globalVar.employeeNames[globalVar.scheduleEmpSub]);

            globalVar.friSchLoc[friSub] = globalVar.scheduleEmpSub;

            friSub++;
        }

        private void btnRemoveEmpFri_Click(object sender, EventArgs e)
        {
            lstFriday.Items.Remove(globalVar.employeeNames[globalVar.scheduleEmpSub]);
            lstFriday.Items.Remove(globalVar.friStHr[friSub - 1] + " - " + globalVar.friEndHr[friSub - 1]);
        }

        private void btnStartHrFri_Click(object sender, EventArgs e)
        {
            Form12 addHrs = new Form12();

            if (friSub <= 0)
            {
                MessageBox.Show("Please enter a name first.");
                goto loc5;
            }

            addHrs.ShowDialog();

            lstFriday.Items.Add(globalVar.startHr + " - " + globalVar.endHr);

            globalVar.friStHr[friSub - 1] = globalVar.startHr;
            globalVar.friEndHr[friSub - 1] = globalVar.endHr;

        loc5:;
        }

        // Three button click events to add/remove employees and et their hours
        // Same as monday for saturday
        private void btnAddEmpSat_Click(object sender, EventArgs e)
        {
            Form3 viewEmp = new Form3();

            globalVar.scheduling = true;

            viewEmp.ShowDialog();

            lstSaturday.Items.Add(globalVar.employeeNames[globalVar.scheduleEmpSub]);

            globalVar.satSchLoc[satSub] = globalVar.scheduleEmpSub;

            satSub++;
        }

        private void btnRemoveEmpSat_Click(object sender, EventArgs e)
        {
            lstSaturday.Items.Remove(globalVar.employeeNames[globalVar.scheduleEmpSub]);
            lstSaturday.Items.Remove(globalVar.satStHr[satSub - 1] + " - " + globalVar.satEndHr[satSub - 1]);

        }

        private void btnStartHrSat_Click(object sender, EventArgs e)
        {
            Form12 addHrs = new Form12();

            if (satSub <= 0)
            {
                MessageBox.Show("Please enter a name first.");
                goto loc6;
            }

            addHrs.ShowDialog();

            lstSaturday.Items.Add(globalVar.startHr + " - " + globalVar.endHr);

            globalVar.satStHr[satSub - 1] = globalVar.startHr;
            globalVar.satEndHr[satSub - 1] = globalVar.endHr;

        loc6:;
        }

        // Three button click events to add/remove employees and et their hours
        // Same as monday for sunday
        private void btnAddEmpSun_Click(object sender, EventArgs e)
        {
            Form3 viewEmp = new Form3();

            globalVar.scheduling = true;

            viewEmp.ShowDialog();

            lstSunday.Items.Add(globalVar.employeeNames[globalVar.scheduleEmpSub]);

            globalVar.sunSchLoc[sunSub] = globalVar.scheduleEmpSub;

            sunSub++;
        }

        private void btnRemoveEmpSun_Click(object sender, EventArgs e)
        {
            lstSunday.Items.Remove(globalVar.employeeNames[globalVar.scheduleEmpSub]);
            lstSunday.Items.Remove(globalVar.sunStHr[sunSub - 1] + " - " + globalVar.sunEndHr[sunSub - 1]);

        }

        private void btnStartHrSun_Click(object sender, EventArgs e)
        {
            Form12 addHrs = new Form12();

            if (sunSub <= 0)
            {
                MessageBox.Show("Please enter a name first.");
                goto loc7;
            }

            addHrs.ShowDialog();

            lstSunday.Items.Add(globalVar.startHr + " - " + globalVar.endHr);

            globalVar.sunStHr[sunSub - 1] = globalVar.startHr;
            globalVar.sunEndHr[sunSub - 1] = globalVar.endHr;

        loc7:;
        }

        // Closes the form when exit menu is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
