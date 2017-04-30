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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closes the form when the exit menu is clicked
            this.Hide();
        }


        // When the enter button is clicked save the data in the text boxes to the global arrays
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Retrives the data entered into the pay rate text box
            var sourcePayRate = txtHrlyRate.Text;
            //temp pay rate to store the value returned by the parse
            double tempPayRate;
            // Atmepts to convert the sourcePayRate data to a double
            if (double.TryParse(sourcePayRate, out tempPayRate))
            {
                // if sucessful adds this value to the pay rates array
                globalVar.payRates[globalVar.addEmpNameSub] = tempPayRate;

                // Sets the employee names array location of the add employee sub equal to the name text box text value
                globalVar.employeeNames[globalVar.addEmpNameSub] = txtEmpName.Text;

            }
            else
            {
                // Otherwise displays an error message
                MessageBox.Show("Invalid Pay Rate Input");
            }

            // Repeate the same process as pay rates but uses integer parse instad of double
            var sourceEmpHrs = txtHrsPerWeek.Text;
            int tempEmpHrs;
            if (int.TryParse(sourceEmpHrs, out tempEmpHrs))
            {
                // Adds the value to the wklyHrs array
                globalVar.wklyHrs[globalVar.addEmpNameSub] = tempEmpHrs;
            }
            else
            {
                MessageBox.Show("Invalid Weekly Hours Input");
            }

            // Resets the text boxes
            txtEmpName.Text = "";
            txtHrlyRate.Text = "";
            txtHrsPerWeek.Text = "";

            // incraments the add employee sub for the next employee
            globalVar.addEmpNameSub++;
        }
    }
}
