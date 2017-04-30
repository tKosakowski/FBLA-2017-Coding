using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Family_Entertainment_Center
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Calls the function to load employee data from files
            loadData();
        }

        // Exit Function to save data to the text files and close the program
        private void mnuExit_Click(object sender, EventArgs e)
        {
            saveData();
        }

        // Function to save the 
        public void saveData()
        {
            // Variable for the location in the array to be used
            int saveNameSub = 0;

            // Opens a connection to the text file storing the employee names
            StreamWriter swEmpNames = new StreamWriter("employeeNames.txt", false);

            // Loop to write a line to the textfile while there is data in the array at the location requested
            while (globalVar.employeeNames[saveNameSub] != null)
            {
                swEmpNames.WriteLine(globalVar.employeeNames[saveNameSub]);
                
                // Incraments the sub vaule to enter the next data location
                saveNameSub++;
            }

            // Closes the file connection
            swEmpNames.Close();

            int savePayRateSub = 0;

            // Opens a connection to the text file containing the pay rate values
            StreamWriter swPayRates = new StreamWriter("payRate.txt", false);

            while (globalVar.payRates[savePayRateSub] != 0.0)
            {
                swPayRates.WriteLine(globalVar.payRates[savePayRateSub]);

                savePayRateSub++;
            }

            swPayRates.Close();

            int saveWklyHrsSub = 0;

            // Opens a connection to the text file containing hours per week data
            StreamWriter swWklyHrs = new StreamWriter("wklyHrs.txt", false);

            while (globalVar.wklyHrs[saveWklyHrsSub] != 0)
            {
                swWklyHrs.WriteLine(globalVar.wklyHrs[saveWklyHrsSub]);

                saveWklyHrsSub++;

            }

            swWklyHrs.Close();

            // Closes the application
            System.Windows.Forms.Application.Exit();
        }

        public void loadData()
        {
            // Employee Names Update

            // String to store the employee name before being placed into the global array
            string name;

            // Sub value to incrament which position in the array isbeing filled
            int loadNameSub = 0;

            // Opens a reading connection to the employee names text file
            StreamReader srEmpName = new StreamReader("employeeNames.txt");

            // sets the name variable to the value of the first line on the text file
            name = srEmpName.ReadLine();

            // While there is data at this location in the text file run the loop
            while (name != null)
            {
                // Sets a location in the employee names array to the value found in the file
                globalVar.employeeNames[loadNameSub] = name;

                // incraments the value of the sub value to find the next name
                loadNameSub++;

                // sets the name variable to the value of the next line on the text file 
                name = srEmpName.ReadLine();
            }

            // Sets the global sub equal to the number of time the loop has run so new data is entered into a new location
            globalVar.addEmpNameSub = loadNameSub;

            srEmpName.Close();


            // Pay Rate Update

            // String to store the character value of pay rate
            string loadPayRateString;

            // double for storing pay rate
            double loadPayRate = 0.0;

            int loadPayRateSub = 0;

            StreamReader srPayRates = new StreamReader("payRate.txt");

            loadPayRateString = srPayRates.ReadLine();

            // Temp variable for the parse loop
            double tempPayRate = 0.0;

            // Priming read
            // Attempte to convert the string read from the file into a double
            if (double.TryParse(loadPayRateString, out tempPayRate))
            {
                // if sucessful the pay rate value is stored
                loadPayRate = tempPayRate;
            }

            // when there is data in the load value string
            while (loadPayRateString != null)
            {
                // add the value to the pay rates array
                globalVar.payRates[loadPayRateSub] = loadPayRate;

                // incrament sub value
                loadPayRateSub++;

                // Update Read

                // Repeats process above to convert string readed from file to a numerical value
                loadPayRateString = srPayRates.ReadLine();

                if (double.TryParse(loadPayRateString, out tempPayRate))
                {
                    loadPayRate = tempPayRate;
                }
            }

            // Closes the connection
            srPayRates.Close();

            // Weekly Hours Update
            // Runs the same as the pay rates except for being an integer instead of a double
            string loadWklyHrsString;

            int loadWklyHrs = 0;

            int loadWklyHrsSub = 0;

            StreamReader srWklyHrs = new StreamReader("wklyHrs.txt");

            loadWklyHrsString = srWklyHrs.ReadLine();

            int tempWklyHrs = 0;

            if (int.TryParse(loadWklyHrsString, out tempWklyHrs))
            {
                loadWklyHrs = tempWklyHrs;
            }

            while (loadWklyHrsString != null)
            {
                globalVar.wklyHrs[loadWklyHrsSub] = loadWklyHrs;

                loadWklyHrsSub++;

                loadWklyHrsString = srWklyHrs.ReadLine();

                if (int.TryParse(loadWklyHrsString, out tempWklyHrs))
                {
                    loadWklyHrs = tempWklyHrs;
                }
            }

            srWklyHrs.Close();


        }

        // Opens the Add Employee Form
        private void mnuAddEmployee_Click(object sender, EventArgs e)
        {
            Form2 addEmp = new Form2();

            addEmp.Show();
        }

        // Opens the view employees Form
        private void mnuViewEmployees_Click(object sender, EventArgs e)
        {
            Form3 viewEmp = new Form3();

            viewEmp.Show();
        }

        // Opens the view work schedule form
        private void mnuViewWorkSchedule_Click(object sender, EventArgs e)
        {
            Form4 viewSchedule = new Form4();

            viewSchedule.Show();
        }

        // opens the form to create a work schedule
        private void mnuCreateWorkSchedule_Click(object sender, EventArgs e)
        {
            Form5 createSchedule = new Form5();

            createSchedule.Show();
        }

        // opens the form containing the weekly schedule creater and report
        private void mnuWklySchedule_Click(object sender, EventArgs e)
        {
            Form6 wklySchedule = new Form6();

            wklySchedule.Show();
        }

        // Opens the edit attendce form
        private void mnuEditAttendance_Click(object sender, EventArgs e)
        {
            Form7 editAttendence = new Form7();

            editAttendence.Show();
        }

        // Opens a form to view an attendecne report
        private void mnuViewAttRept_Click(object sender, EventArgs e)
        {
            Form8 viewAttendence = new Form8();

            viewAttendence.Show();
        }

        // Opens a form to view sales data from the point of sale software
        private void mnuSalesData_Click(object sender, EventArgs e)
        {
            Form10 salesData = new Form10();

            salesData.Show();
        }
    }


    // Class used to store global variables that are used for transefer of data between forms
    public class globalVar
    {
        // Employee Names string array to store the names
        public static string[] employeeNames = new string[25];

        // Pay rates array to store hourly rates for the employees
        public static double[] payRates = new double[25];

        // Employee Hours array to store hours per week for employees
        public static int[] wklyHrs = new int[25];

        // sub 0 = Mon AM sub 1 = Mon PM and so on for rest of days
        public static int[] atndByDayAndTime = new int[14];

        // stores sales by day to be displayed later
        public static double[] salesByDay = new double[7];


        // Arrays to store array locations for scheduling employees
        public static int[] monSchLoc = new int[10];
        public static int[] tueSchLoc = new int[10];
        public static int[] wedSchLoc = new int[10];
        public static int[] thrSchLoc = new int[10];
        public static int[] friSchLoc = new int[10];
        public static int[] satSchLoc = new int[10];
        public static int[] sunSchLoc = new int[10];


        // arrays to store start and end hours for schedule creation
        public static double[] monStHr = new double[10];
        public static double[] tueStHr = new double[10];
        public static double[] wedStHr = new double[10];
        public static double[] thrStHr = new double[10];
        public static double[] friStHr = new double[10];
        public static double[] satStHr = new double[10];
        public static double[] sunStHr = new double[10];

        public static double[] monEndHr = new double[10];
        public static double[] tueEndHr = new double[10];
        public static double[] wedEndHr = new double[10];
        public static double[] thrEndHr = new double[10];
        public static double[] friEndHr = new double[10];
        public static double[] satEndHr = new double[10];
        public static double[] sunEndHr = new double[10];


        // Integer to store sub value for the next employee to be added
        public static int addEmpNameSub = 0;

        // double to store total sales value from Point of Sale software
        public static double totalSales = 0.0;

        // Integer to store sub value for the scheduling transfer from View employees to the schedule creation form
        public static int scheduleEmpSub = 0;

        // When opeing the view employees form from anywhere except schedule creation this causes the add to schedule
        // button to remain invisible
        public static bool scheduling = false;

        // Stores the start and end hours from the hour entering form and transfers them to the schedule creation form
        public static double startHr = 0;
        public static double endHr = 0;


    }

}
