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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        
        // Loads the attendence values from global arrays
        private void Form8_Load(object sender, EventArgs e)
        {
            lblMonAMAtnd.Text = globalVar.atndByDayAndTime[0].ToString();
            lblMonPMAtnd.Text = globalVar.atndByDayAndTime[1].ToString();
            lblTueAMAtnd.Text = globalVar.atndByDayAndTime[2].ToString();
            lblTuePMAtnd.Text = globalVar.atndByDayAndTime[3].ToString();
            lblWedAMAtnd.Text = globalVar.atndByDayAndTime[4].ToString();
            lblWedPMAtnd.Text = globalVar.atndByDayAndTime[5].ToString();
            lblThrAMAtnd.Text = globalVar.atndByDayAndTime[6].ToString();
            lblThrPMAtnd.Text = globalVar.atndByDayAndTime[7].ToString();
            lblFriAMAtnd.Text = globalVar.atndByDayAndTime[8].ToString();
            lblFriPMAtnd.Text = globalVar.atndByDayAndTime[9].ToString();
            lblSatAMAtnd.Text = globalVar.atndByDayAndTime[10].ToString();
            lblSatPmAtnd.Text = globalVar.atndByDayAndTime[11].ToString();
            lblSunAMAtnd.Text = globalVar.atndByDayAndTime[12].ToString();
            lblSunPMAtnd.Text = globalVar.atndByDayAndTime[13].ToString();

            // adds the am and pm values for each day into a total attendance
            lblMonTotAtnd.Text = (globalVar.atndByDayAndTime[0] + globalVar.atndByDayAndTime[1]).ToString();
            lblTueTotAtnd.Text = (globalVar.atndByDayAndTime[2] + globalVar.atndByDayAndTime[3]).ToString();
            lblWedTotAtnd.Text = (globalVar.atndByDayAndTime[4] + globalVar.atndByDayAndTime[5]).ToString();
            lblThrTotAtnd.Text = (globalVar.atndByDayAndTime[6] + globalVar.atndByDayAndTime[7]).ToString();
            lblFriTotAtnd.Text = (globalVar.atndByDayAndTime[8] + globalVar.atndByDayAndTime[9]).ToString();
            lblSatTotAtnd.Text = (globalVar.atndByDayAndTime[10] + globalVar.atndByDayAndTime[11]).ToString();
            lblSunTotAtnd.Text = (globalVar.atndByDayAndTime[12] + globalVar.atndByDayAndTime[13]).ToString();


        }

        private void grpTuesday_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
