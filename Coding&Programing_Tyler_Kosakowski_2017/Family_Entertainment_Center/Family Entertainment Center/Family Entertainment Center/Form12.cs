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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        // When enter button is clicked take the hour values and place them in arrays
        private void btnEnter_Click(object sender, EventArgs e)
        {
            double tempStartHr;
            double tempEndHr;
            // starting hour

            // attempt to convert string to double
            if(double.TryParse(txtStartHr.Text, out tempStartHr))
            {
                // if sucessful add to array
                globalVar.startHr = tempStartHr;
            }
            else
            {
                // otherwise display error
                MessageBox.Show("Invalid Data Type");
            }

            // repeat process for ending hour
            if (double.TryParse(txtEndHr.Text, out tempEndHr))
            {
                globalVar.endHr = tempEndHr;
            }
            else
            {
                MessageBox.Show("Invalid Data Type");
            }

            // close the form
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
