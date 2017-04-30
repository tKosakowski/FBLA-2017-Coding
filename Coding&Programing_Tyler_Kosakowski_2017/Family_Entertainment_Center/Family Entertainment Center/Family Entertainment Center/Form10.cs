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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        // closes when exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // Sales equal to the number of tickets sold times $10 per ticket
            for (int x = 0; x < 7; x++)
            {
                globalVar.salesByDay[x] = 10* globalVar.atndByDayAndTime[x * 2];
            }

            // displays the sales data from the global sales data array
            lblMonSales.Text = ("$" + globalVar.salesByDay[0].ToString());
            lblTueSales.Text = ("$" + globalVar.salesByDay[1].ToString());
            lblWedSales.Text = ("$" + globalVar.salesByDay[2].ToString());
            lblThrSales.Text = ("$" + globalVar.salesByDay[3].ToString());
            lblFriSales.Text = ("$" + globalVar.salesByDay[4].ToString());
            lblSatSales.Text = ("$" + globalVar.salesByDay[5].ToString());
            lblSunSales.Text = ("$" + globalVar.salesByDay[6].ToString());

            for (int x = 0; x < 7; x++)
            {

            }

        }
    }
}
