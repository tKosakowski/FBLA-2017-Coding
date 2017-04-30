namespace Family_Entertainment_Center
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHrsPerWeekInfo = new System.Windows.Forms.Label();
            this.lblPayRateInfo = new System.Windows.Forms.Label();
            this.lblEmpNameInfo = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblSalaryInfo = new System.Windows.Forms.Label();
            this.lblHrsPerWeek = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblHrlyRate = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddToSchedule = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblHrsPerWeekInfo
            // 
            this.lblHrsPerWeekInfo.AutoSize = true;
            this.lblHrsPerWeekInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsPerWeekInfo.Location = new System.Drawing.Point(12, 155);
            this.lblHrsPerWeekInfo.Name = "lblHrsPerWeekInfo";
            this.lblHrsPerWeekInfo.Size = new System.Drawing.Size(131, 18);
            this.lblHrsPerWeekInfo.TabIndex = 12;
            this.lblHrsPerWeekInfo.Text = "Hours Per Week : ";
            // 
            // lblPayRateInfo
            // 
            this.lblPayRateInfo.AutoSize = true;
            this.lblPayRateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRateInfo.Location = new System.Drawing.Point(12, 105);
            this.lblPayRateInfo.Name = "lblPayRateInfo";
            this.lblPayRateInfo.Size = new System.Drawing.Size(98, 18);
            this.lblPayRateInfo.TabIndex = 11;
            this.lblPayRateInfo.Text = "Hourly Rate : ";
            // 
            // lblEmpNameInfo
            // 
            this.lblEmpNameInfo.AutoSize = true;
            this.lblEmpNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpNameInfo.Location = new System.Drawing.Point(12, 55);
            this.lblEmpNameInfo.Name = "lblEmpNameInfo";
            this.lblEmpNameInfo.Size = new System.Drawing.Size(130, 18);
            this.lblEmpNameInfo.TabIndex = 10;
            this.lblEmpNameInfo.Text = "Employee Name : ";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(308, 264);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 43);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(197, 264);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(93, 43);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblSalaryInfo
            // 
            this.lblSalaryInfo.AutoSize = true;
            this.lblSalaryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryInfo.Location = new System.Drawing.Point(12, 205);
            this.lblSalaryInfo.Name = "lblSalaryInfo";
            this.lblSalaryInfo.Size = new System.Drawing.Size(114, 18);
            this.lblSalaryInfo.TabIndex = 15;
            this.lblSalaryInfo.Text = "Weekly Salary : ";
            // 
            // lblHrsPerWeek
            // 
            this.lblHrsPerWeek.AutoSize = true;
            this.lblHrsPerWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrsPerWeek.Location = new System.Drawing.Point(149, 155);
            this.lblHrsPerWeek.Name = "lblHrsPerWeek";
            this.lblHrsPerWeek.Size = new System.Drawing.Size(0, 18);
            this.lblHrsPerWeek.TabIndex = 16;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(149, 205);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(0, 18);
            this.lblSalary.TabIndex = 17;
            // 
            // lblHrlyRate
            // 
            this.lblHrlyRate.AutoSize = true;
            this.lblHrlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHrlyRate.Location = new System.Drawing.Point(149, 105);
            this.lblHrlyRate.Name = "lblHrlyRate";
            this.lblHrlyRate.Size = new System.Drawing.Size(0, 18);
            this.lblHrlyRate.TabIndex = 18;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(149, 55);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 18);
            this.lblEmployeeName.TabIndex = 19;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(15, 264);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 43);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddToSchedule
            // 
            this.btnAddToSchedule.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddToSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToSchedule.Location = new System.Drawing.Point(197, 328);
            this.btnAddToSchedule.Name = "btnAddToSchedule";
            this.btnAddToSchedule.Size = new System.Drawing.Size(201, 43);
            this.btnAddToSchedule.TabIndex = 21;
            this.btnAddToSchedule.Text = "Add To Schedule";
            this.btnAddToSchedule.UseVisualStyleBackColor = false;
            this.btnAddToSchedule.Visible = false;
            this.btnAddToSchedule.Click += new System.EventHandler(this.btnAddToSchedule_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 383);
            this.Controls.Add(this.btnAddToSchedule);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblHrlyRate);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblHrsPerWeek);
            this.Controls.Add(this.lblSalaryInfo);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblHrsPerWeekInfo);
            this.Controls.Add(this.lblPayRateInfo);
            this.Controls.Add(this.lblEmpNameInfo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "View Employees";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblHrsPerWeekInfo;
        private System.Windows.Forms.Label lblPayRateInfo;
        private System.Windows.Forms.Label lblEmpNameInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblSalaryInfo;
        private System.Windows.Forms.Label lblHrsPerWeek;
        private System.Windows.Forms.Label lblHrlyRate;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddToSchedule;
    }
}