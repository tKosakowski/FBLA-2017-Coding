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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Sub values to display all of the chosen employees for each day in order
            int monSub = 0;
            int tueSub = 0;
            int wedSub = 0;
            int thrSub = 0;
            int friSub = 0;
            int satSub = 0;
            int sunSub = 0;

            // When there is data in the employee names array at the chosen location from
            // the schedule array add thee values of that location to the display 
            // on the form
            while (globalVar.employeeNames[globalVar.monSchLoc[monSub]] != null)
            {
                // if we are after the first pass and the scheduling sub is still 0 stop exectuing the loop
                if (monSub > 0 && globalVar.monSchLoc[monSub] == 0)
                {
                    // goto to exit loop
                    goto loc1;
                }

                // Adds the name slected to the list box for monday
                lstMonEmpNames.Items.Add(globalVar.employeeNames[globalVar.monSchLoc[monSub]]);

                // adds the start hour for the location selected
                lstMonStHr.Items.Add(globalVar.monStHr[monSub]);

                // adds the end hour for the location selected
                lstMonEndHr.Items.Add(globalVar.monEndHr[monSub]);

                // incraments the sub value to move to the next employee
                monSub++;

            }

        loc1:;

            // Repeats this process for tuesday
            while (globalVar.employeeNames[globalVar.tueSchLoc[tueSub]] != null)
            {
                if (tueSub > 0 && globalVar.tueSchLoc[tueSub] == 0)
                {
                    goto loc2;
                }

                lstTueEmpNames.Items.Add(globalVar.employeeNames[globalVar.tueSchLoc[tueSub]]);

                lstTueStHr.Items.Add(globalVar.tueStHr[monSub]);

                lstTueEndHr.Items.Add(globalVar.tueEndHr[monSub]);

                tueSub++;

            }

        loc2:;

            // Repeats this process for wednesday
            while (globalVar.employeeNames[globalVar.wedSchLoc[wedSub]] != null)
            {
                if (wedSub > 0 && globalVar.wedSchLoc[wedSub] == 0)
                {
                    goto loc3;
                }

                lstWedEmpNames.Items.Add(globalVar.employeeNames[globalVar.wedSchLoc[wedSub]]);

                lstWedStHr.Items.Add(globalVar.wedStHr[wedSub]);

                lstWedEndHr.Items.Add(globalVar.wedEndHr[wedSub]);

                wedSub++;

            }

        loc3:;

            // Repeats this process for thursday
            while (globalVar.employeeNames[globalVar.thrSchLoc[thrSub]] != null)
            {
                if (thrSub > 0 && globalVar.thrSchLoc[thrSub] == 0)
                {
                    goto loc4;
                }

                lstThrEmpNames.Items.Add(globalVar.employeeNames[globalVar.thrSchLoc[thrSub]]);

                lstThrStHr.Items.Add(globalVar.thrStHr[thrSub]);

                lstThrEndHr.Items.Add(globalVar.thrEndHr[thrSub]);

                thrSub++;

            }

        loc4:;

            // Repeats this process for friday
            while (globalVar.employeeNames[globalVar.friSchLoc[friSub]] != null)
            {
                if (friSub > 0 && globalVar.friSchLoc[friSub] == 0)
                {
                    goto loc5;
                }

                lstFriEmpNames.Items.Add(globalVar.employeeNames[globalVar.friSchLoc[friSub]]);

                lstFriStHr.Items.Add(globalVar.friStHr[friSub]);

                lstFriEndHr.Items.Add(globalVar.friEndHr[friSub]);

                friSub++;

            }

        loc5:;

            // Repeats this process for saturday
            while (globalVar.employeeNames[globalVar.satSchLoc[satSub]] != null)
            {
                if (satSub > 0 && globalVar.satSchLoc[satSub] == 0)
                {
                    goto loc6;
                }

                lstSatEmpNames.Items.Add(globalVar.employeeNames[globalVar.satSchLoc[satSub]]);

                lstSatStHr.Items.Add(globalVar.satStHr[satSub]);

                lstSatEndHr.Items.Add(globalVar.satEndHr[satSub]);

                satSub++;

            }

        loc6:;

            // Repeats this process for sunday
            while (globalVar.employeeNames[globalVar.sunSchLoc[sunSub]] != null)
            {
                if (sunSub > 0 && globalVar.sunSchLoc[sunSub] == 0)
                {
                    goto loc7;
                }

                lstSunEmpNames.Items.Add(globalVar.employeeNames[globalVar.sunSchLoc[sunSub]]);

                lstSunStHr.Items.Add(globalVar.sunStHr[sunSub]);

                lstSunEndHr.Items.Add(globalVar.sunEndHr[sunSub]);

                sunSub++;

            }

        loc7:;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
