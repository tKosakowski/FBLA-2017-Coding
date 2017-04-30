namespace Family_Entertainment_Center
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuStpOne = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWorkSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewWorkSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateWorkSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWklySchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewAttRept = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPoS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalesData = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.mnuStpOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStpOne
            // 
            this.mnuStpOne.BackColor = System.Drawing.Color.DarkOrange;
            this.mnuStpOne.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStpOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEmployees,
            this.mnuWorkSchedule,
            this.mnuWklySchedule,
            this.mnuAttendance,
            this.mnuPoS});
            this.mnuStpOne.Location = new System.Drawing.Point(0, 0);
            this.mnuStpOne.Name = "mnuStpOne";
            this.mnuStpOne.Size = new System.Drawing.Size(1021, 28);
            this.mnuStpOne.TabIndex = 0;
            this.mnuStpOne.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(45, 24);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEmployees
            // 
            this.mnuEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddEmployee,
            this.mnuViewEmployees});
            this.mnuEmployees.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEmployees.Name = "mnuEmployees";
            this.mnuEmployees.Size = new System.Drawing.Size(94, 24);
            this.mnuEmployees.Text = "Employees";
            // 
            // mnuAddEmployee
            // 
            this.mnuAddEmployee.Name = "mnuAddEmployee";
            this.mnuAddEmployee.Size = new System.Drawing.Size(188, 24);
            this.mnuAddEmployee.Text = "Add Employee";
            this.mnuAddEmployee.Click += new System.EventHandler(this.mnuAddEmployee_Click);
            // 
            // mnuViewEmployees
            // 
            this.mnuViewEmployees.Name = "mnuViewEmployees";
            this.mnuViewEmployees.Size = new System.Drawing.Size(188, 24);
            this.mnuViewEmployees.Text = "View Employees";
            this.mnuViewEmployees.Click += new System.EventHandler(this.mnuViewEmployees_Click);
            // 
            // mnuWorkSchedule
            // 
            this.mnuWorkSchedule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewWorkSchedule,
            this.mnuCreateWorkSchedule});
            this.mnuWorkSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuWorkSchedule.Name = "mnuWorkSchedule";
            this.mnuWorkSchedule.Size = new System.Drawing.Size(124, 24);
            this.mnuWorkSchedule.Text = "Work Schedule";
            // 
            // mnuViewWorkSchedule
            // 
            this.mnuViewWorkSchedule.Name = "mnuViewWorkSchedule";
            this.mnuViewWorkSchedule.Size = new System.Drawing.Size(188, 24);
            this.mnuViewWorkSchedule.Text = "View Schedule";
            this.mnuViewWorkSchedule.Click += new System.EventHandler(this.mnuViewWorkSchedule_Click);
            // 
            // mnuCreateWorkSchedule
            // 
            this.mnuCreateWorkSchedule.Name = "mnuCreateWorkSchedule";
            this.mnuCreateWorkSchedule.Size = new System.Drawing.Size(188, 24);
            this.mnuCreateWorkSchedule.Text = "Create Schedule";
            this.mnuCreateWorkSchedule.Click += new System.EventHandler(this.mnuCreateWorkSchedule_Click);
            // 
            // mnuWklySchedule
            // 
            this.mnuWklySchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuWklySchedule.Name = "mnuWklySchedule";
            this.mnuWklySchedule.Size = new System.Drawing.Size(137, 24);
            this.mnuWklySchedule.Text = "Weekly Schedule";
            this.mnuWklySchedule.Click += new System.EventHandler(this.mnuWklySchedule_Click);
            // 
            // mnuAttendance
            // 
            this.mnuAttendance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditAttendance,
            this.mnuViewAttRept});
            this.mnuAttendance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAttendance.Name = "mnuAttendance";
            this.mnuAttendance.Size = new System.Drawing.Size(99, 24);
            this.mnuAttendance.Text = "Attendance";
            // 
            // mnuEditAttendance
            // 
            this.mnuEditAttendance.Name = "mnuEditAttendance";
            this.mnuEditAttendance.Size = new System.Drawing.Size(243, 24);
            this.mnuEditAttendance.Text = "Edit Attendance";
            this.mnuEditAttendance.Click += new System.EventHandler(this.mnuEditAttendance_Click);
            // 
            // mnuViewAttRept
            // 
            this.mnuViewAttRept.Name = "mnuViewAttRept";
            this.mnuViewAttRept.Size = new System.Drawing.Size(243, 24);
            this.mnuViewAttRept.Text = "View Attendance Report";
            this.mnuViewAttRept.Click += new System.EventHandler(this.mnuViewAttRept_Click);
            // 
            // mnuPoS
            // 
            this.mnuPoS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalesData});
            this.mnuPoS.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPoS.Name = "mnuPoS";
            this.mnuPoS.Size = new System.Drawing.Size(91, 24);
            this.mnuPoS.Text = "Sales Data";
            // 
            // mnuSalesData
            // 
            this.mnuSalesData.Name = "mnuSalesData";
            this.mnuSalesData.Size = new System.Drawing.Size(185, 24);
            this.mnuSalesData.Text = "View Sales Data";
            this.mnuSalesData.Click += new System.EventHandler(this.mnuSalesData_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(167, 125);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(685, 33);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to Purple Gorilla Entertainment Center";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Family_Entertainment_Center.Properties.Resources.Background_Image;
            this.ClientSize = new System.Drawing.Size(1021, 521);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.mnuStpOne);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuStpOne;
            this.Name = "Form1";
            this.Text = "Purple Gorilla";
            this.mnuStpOne.ResumeLayout(false);
            this.mnuStpOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStpOne;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuWorkSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateWorkSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuAttendance;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAttendance;
        private System.Windows.Forms.ToolStripMenuItem mnuViewAttRept;
        private System.Windows.Forms.ToolStripMenuItem mnuPoS;
        private System.Windows.Forms.ToolStripMenuItem mnuSalesData;
        private System.Windows.Forms.ToolStripMenuItem mnuViewWorkSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuViewEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuWklySchedule;
        private System.Windows.Forms.Label lblWelcome;
    }
}

