using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Family_Entertainment_Center
{
    public partial class Form6 : Form
    {
        // holds values to be added to each day
        string addMonday = "";
        string addTuesday = "";
        string addWednesday = "";
        string addThursday = "";
        string addFriday = "";
        string addSaturday = "";
        string addSunday = "";

        // holds the number of entries into each day
        int monMaxValue = 0;
        int tuesMaxValue = 0;
        int wedMaxValue = 0;
        int thurMaxValue = 0;
        int friMaxValue = 0;
        int satMaxValue = 0;
        int sunMaxValue = 0;

        // printing delcrations
        private PrintDocument printDocument1 = new PrintDocument();
        private string stringToPrint;

        public Form6()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // When exiting before closing the form call the update functions
            updateMonday();
            updateTuesday();
            updateWednesday();
            updateThursday();
            updateFriday();
            updateSaturday();
            updateSunday();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Load data from text files when opened
            readData();
        }

        private void readData()
        {
            // opens conncetion to the monday text file
            StreamReader srReadMondayData = new StreamReader("monday.txt");

            // sets a variable to the value read from the text file
            string readMonLine = srReadMondayData.ReadLine();

            // while there is data at this selected location
            while(readMonLine != null)
            {
                // write the data to the list box
                lstMonday.Items.Add(readMonLine);

                // incrament the max value
                monMaxValue++;

                // load the next line of data
                readMonLine = srReadMondayData.ReadLine();

            }

            // close the connction to monday
            srReadMondayData.Close();

            // repeats the above for tuesday

            StreamReader srReadTuesData = new StreamReader("tuesdaySchedule.txt");

            string readTueLine = srReadTuesData.ReadLine();

            while(readTueLine != null)
            {
                lstTuesday.Items.Add(readTueLine);

                tuesMaxValue++;

                readTueLine = srReadTuesData.ReadLine();
            }

            srReadTuesData.Close();

            // repeats the above for wednesday 

            StreamReader srReadWedData = new StreamReader("wednesdaySchedule.txt");

            string readWedLine = srReadWedData.ReadLine();

            while(readWedLine != null)
            {
                lstWednesday.Items.Add(readWedLine);

                wedMaxValue++;

                readWedLine = srReadWedData.ReadLine();
            }

            srReadWedData.Close();

            // repeats the above for tursday

            StreamReader srReadThurData = new StreamReader("thursdaySchedule.txt");

            string readThurLine = srReadThurData.ReadLine();

            while (readThurLine != null)
            {
                lstThursday.Items.Add(readThurLine);

                thurMaxValue++;

                readThurLine = srReadThurData.ReadLine();
            }

            srReadThurData.Close();

            // repeats the above for friday

            StreamReader srReadFriData = new StreamReader("fridaySchedule.txt");

            string readFriLine = srReadFriData.ReadLine();

            while (readFriLine != null)
            {
                lstFriday.Items.Add(readFriLine);

                friMaxValue++;

                readFriLine = srReadFriData.ReadLine();
            }

            srReadFriData.Close();

            // repeats the above for saturday

            StreamReader srReadSatData = new StreamReader("saturdaySchedule.txt");

            string readSatLine = srReadSatData.ReadLine();

            while (readSatLine != null)
            {
                lstSaturday.Items.Add(readSatLine);

                satMaxValue++;

                readSatLine = srReadSatData.ReadLine();
            }

            srReadSatData.Close();

            // repeats the above for sunday

            StreamReader srReadSunData = new StreamReader("sundaySchedule.txt");

            string readSunLine = srReadSunData.ReadLine();

            while (readSunLine != null)
            {
                lstSunday.Items.Add(readSunLine);

                sunMaxValue++;

                readSunLine = srReadSunData.ReadLine();
            }

            srReadSunData.Close();


        }


        // Add and item to the monday list
        private void btnMonAddToSchedule_Click(object sender, EventArgs e)
        {
            // add monday string equal to the textbox value
            addMonday = txtMonday.Text;

            // Add the monday value to the list box
            lstMonday.Items.Add(addMonday);

            // reset the textbox value
            txtMonday.Text = "";

            // incrament the monday max value
            monMaxValue++;

        }

      
        // updates the monday storage file
        public void updateMonday()
        {
            // opens a connection to the monday data file
            StreamWriter swWriteMonData = new StreamWriter("monday.txt", false);

            // string for data to write
            string writeData;

            // for loop from 0 to the monMaxValue
            for (int x = 0; x < monMaxValue; x++)
            {
                // sets the write data variable to the value of the listbox item
                writeData = lstMonday.Items[x].ToString();

                // writes this value to the data file
                swWriteMonData.WriteLine(writeData);
            }

            // closes the connection to the data file
            swWriteMonData.Close();
        }

        // Same two events as above for tuesday
        private void btnTuesAddToSchedule_Click(object sender, EventArgs e)
        {
            addTuesday = txtTuesday.Text;

            lstTuesday.Items.Add(addTuesday);

            txtTuesday.Text = "";
        }


        public void updateTuesday()
        {
            StreamWriter swWriteTuesData = new StreamWriter("tuesdaySchedule.txt", false);

            string writeData;

            for (int x = 0; x < tuesMaxValue; x++)
            {

                writeData = lstTuesday.Items[x].ToString();

                swWriteTuesData.WriteLine(writeData);

            }

            swWriteTuesData.Close();
        }

        // Same two events as above for wednesday
        private void btnWedAddToSchedule_Click(object sender, EventArgs e)
        {
            addWednesday = txtWednesday.Text;

            lstWednesday.Items.Add(addWednesday);

            txtWednesday.Text = "";
        }

        public void updateWednesday()
        {
            StreamWriter swWriteWedData = new StreamWriter("wednesdaySchedule", false);

            string writeData;

            for (int x = 0; x < wedMaxValue; x++)
            {

                writeData = lstWednesday.Items[x].ToString();

                swWriteWedData.WriteLine(writeData);

            }

            swWriteWedData.Close();
        }

        // Same two events as above for thursday
        private void btnThurAddToSchedule_Click(object sender, EventArgs e)
        {
            addThursday = txtThursday.Text;

            lstThursday.Items.Add(addThursday);

            txtThursday.Text = "";
        }

        public void updateThursday()
        {
            StreamWriter swWriteThursData = new StreamWriter("thursdaySchedule.txt", false);

            string writeData;

            for (int x = 0; x < thurMaxValue; x++)
            {

                writeData = lstThursday.Items[x].ToString();

                swWriteThursData.WriteLine(writeData);

            }

            swWriteThursData.Close();
        }

        // Same two events as above for friday
        private void btnFriAddToSchedule_Click(object sender, EventArgs e)
        {
            addFriday = txtFriday.Text;

            lstFriday.Items.Add(addFriday);

            txtFriday.Text = "";
        }

        public void updateFriday()
        {
            StreamWriter swWriteFriData = new StreamWriter("fridaySchedule.txt", false);

            string writeData;

            for (int x = 0; x < friMaxValue; x++)
            {

                writeData = lstFriday.Items[x].ToString();

                swWriteFriData.WriteLine(writeData);

            }

            swWriteFriData.Close();
        }

        // Same two events as above for saturday
        private void btnSatAddToSchedule_Click(object sender, EventArgs e)
        {
            addSaturday = txtSaturday.Text;

            lstSaturday.Items.Add(addSaturday);

            txtSaturday.Text = "";
        }


        public void updateSaturday()
        {
            StreamWriter swWriteSatData = new StreamWriter("saturdaySchedule.txt", false);

            string writeData;

            for (int x = 0; x < satMaxValue; x++)
            {

                writeData = lstSaturday.Items[x].ToString();

                swWriteSatData.WriteLine(writeData);

            }

            swWriteSatData.Close();
        }

        // Same two events as above for sunday
        private void btnSunAddToSchedule_Click(object sender, EventArgs e)
        {
            addSunday = txtSunday.Text;

            lstSunday.Items.Add(addSunday);

            txtSunday.Text = "";
        }

        public void updateSunday()
        {
            StreamWriter swWriteSunData = new StreamWriter("sundaySchedule.txt", false);

            string writeData;

            for (int x = 0; x < sunMaxValue; x++)
            {

                writeData = lstSunday.Items[x].ToString();

                swWriteSunData.WriteLine(writeData);

            }

            swWriteSunData.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Sets a string equal to the address of the requested text file
            string printAddress = "";

            if (cmbPrint.Items[cmbPrint.SelectedIndex].ToString() == "Monday")
            {
                printAddress = "monday.txt";
            }

            if (cmbPrint.Items[cmbPrint.SelectedIndex].ToString() == "Tuesday")
            {
                printAddress = "tuesdaySchedule.txt";
            }

            if (cmbPrint.Items[cmbPrint.SelectedIndex].ToString() == "Wednesday")
            {
                printAddress = "wednesdaySchedule.txt";
            }

            if (cmbPrint.Items[cmbPrint.SelectedIndex].ToString() == "Thursday")
            {
                printAddress = "thursdaySchedule.txt";
            }

            if (cmbPrint.Items[cmbPrint.SelectedIndex].ToString() == "Friday")
            {
                printAddress = "fridaySchedule.txt";
            }

            if (cmbPrint.Items[cmbPrint.SelectedIndex].ToString() == "Saturday")
            {
                printAddress = "saturdaySchedule.txt";
            }

            if (cmbPrint.Items[cmbPrint.SelectedIndex].ToString() == "Sunday")
            {
                printAddress = "sundaySchedule.txt";
            }

            string docName = printAddress;
            printDocument1.DocumentName = docName;

            StreamReader srPrintRecieve = new StreamReader(docName);

            stringToPrint = srPrintRecieve.ReadToEnd();

            MessageBox.Show(stringToPrint);

            srPrintRecieve.Close();

            printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            e.Graphics.MeasureString(stringToPrint, this.Font, e.MarginBounds.Size, StringFormat.GenericTypographic, out charactersOnPage, out linesPerPage);

            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            stringToPrint = stringToPrint.Substring(charactersOnPage);

            e.HasMorePages = (stringToPrint.Length > 0);
        }


    }
}
