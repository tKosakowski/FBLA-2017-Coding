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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // strings for the entered vales of day and time stamp
            // uppercase for reliability
            string day = txtEnterDay.Text.ToUpper();
            string amOpm = txtEnterTime.Text.ToUpper();

            // integer for number of people
            int numOPeps = 0;

            // atempts to convert the value of people entered to an integer
            int tempNumOPeps;
            if (int.TryParse(txtNumberOfPeople.Text, out tempNumOPeps))
            {
                // if sucessful return value of people
                numOPeps = tempNumOPeps;
            }

            // slection stcutre for day entered

            // then selects am or pm as entered
            // if there is an invalid time stamp display an error

            // set a location in the attendance array to the value entered

            // repeats for all 7 days
            if (day == "MONDAY")
            {
                if (amOpm == "AM")
                {
                    globalVar.atndByDayAndTime[0] = numOPeps;
                }
                else if (amOpm == "PM")
                {
                    globalVar.atndByDayAndTime[1] = numOPeps;
                }
                else
                {
                    MessageBox.Show("Invalid Time Stamp");
                }
            }
            if (day == "TUESDAY")
            {
                if (amOpm == "AM")
                {
                    globalVar.atndByDayAndTime[2] = numOPeps;

                }
                else if (amOpm == "PM")
                {
                    globalVar.atndByDayAndTime[3] = numOPeps;

                }
                else
                {
                    MessageBox.Show("Invalid Time Stamp");
                }
            }
            if (day == "WEDNESDAY")
            {
                if (amOpm == "AM")
                {
                    globalVar.atndByDayAndTime[4] = numOPeps;

                }
                else if (amOpm == "PM")
                {
                    globalVar.atndByDayAndTime[5] = numOPeps;

                }
                else
                {
                    MessageBox.Show("Invalid Time Stamp");
                }
            }
            if (day == "THURSDAY")
            {
                if (amOpm == "AM")
                {
                    globalVar.atndByDayAndTime[6] = numOPeps;

                }
                else if (amOpm == "PM")
                {
                    globalVar.atndByDayAndTime[7] = numOPeps;

                }
                else
                {
                    MessageBox.Show("Invalid Time Stamp");
                }
            }
            if (day == "FRIDAY")
            {
                if (amOpm == "AM")
                {
                    globalVar.atndByDayAndTime[7] = numOPeps;

                }
                else if (amOpm == "PM")
                {
                    globalVar.atndByDayAndTime[9] = numOPeps;

                }
                else
                {
                    MessageBox.Show("Invalid Time Stamp");
                }
            }
            if (day == "SATURDAY")
            {
                if (amOpm == "AM")
                {
                    globalVar.atndByDayAndTime[10] = numOPeps;

                }
                else if (amOpm == "PM")
                {
                    globalVar.atndByDayAndTime[11] = numOPeps;

                }
                else
                {
                    MessageBox.Show("Invalid Time Stamp");
                }
            }
            if (day == "SUNDAY")
            {
                if (amOpm == "AM")
                {
                    globalVar.atndByDayAndTime[12] = numOPeps;

                }
                else if (amOpm == "PM")
                {
                    globalVar.atndByDayAndTime[13] = numOPeps;

                }
                else
                {
                    MessageBox.Show("Invalid Time Stamp");
                }
            }

            // clears the text boxes
            txtEnterDay.Text = "";
            txtEnterTime.Text = "";
            txtNumberOfPeople.Text = "";

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
