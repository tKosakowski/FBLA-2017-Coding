namespace Family_Entertainment_Center
{
    partial class Form7
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
            this.lblEnterDayInfo = new System.Windows.Forms.Label();
            this.txtEnterDay = new System.Windows.Forms.TextBox();
            this.lblEnterTimeInfo = new System.Windows.Forms.Label();
            this.txtEnterTime = new System.Windows.Forms.TextBox();
            this.lblEnterNumberInfo = new System.Windows.Forms.Label();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(271, 28);
            this.menuStrip1.TabIndex = 3;
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
            // lblEnterDayInfo
            // 
            this.lblEnterDayInfo.AutoSize = true;
            this.lblEnterDayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDayInfo.Location = new System.Drawing.Point(8, 49);
            this.lblEnterDayInfo.Name = "lblEnterDayInfo";
            this.lblEnterDayInfo.Size = new System.Drawing.Size(80, 20);
            this.lblEnterDayInfo.TabIndex = 4;
            this.lblEnterDayInfo.Text = "Enter Day";
            // 
            // txtEnterDay
            // 
            this.txtEnterDay.Location = new System.Drawing.Point(12, 72);
            this.txtEnterDay.Name = "txtEnterDay";
            this.txtEnterDay.Size = new System.Drawing.Size(147, 20);
            this.txtEnterDay.TabIndex = 1;
            // 
            // lblEnterTimeInfo
            // 
            this.lblEnterTimeInfo.AutoSize = true;
            this.lblEnterTimeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTimeInfo.Location = new System.Drawing.Point(8, 116);
            this.lblEnterTimeInfo.Name = "lblEnterTimeInfo";
            this.lblEnterTimeInfo.Size = new System.Drawing.Size(169, 20);
            this.lblEnterTimeInfo.TabIndex = 6;
            this.lblEnterTimeInfo.Text = "Enter Time (AM or PM)";
            // 
            // txtEnterTime
            // 
            this.txtEnterTime.Location = new System.Drawing.Point(12, 139);
            this.txtEnterTime.Name = "txtEnterTime";
            this.txtEnterTime.Size = new System.Drawing.Size(76, 20);
            this.txtEnterTime.TabIndex = 2;
            // 
            // lblEnterNumberInfo
            // 
            this.lblEnterNumberInfo.AutoSize = true;
            this.lblEnterNumberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumberInfo.Location = new System.Drawing.Point(8, 181);
            this.lblEnterNumberInfo.Name = "lblEnterNumberInfo";
            this.lblEnterNumberInfo.Size = new System.Drawing.Size(204, 20);
            this.lblEnterNumberInfo.TabIndex = 8;
            this.lblEnterNumberInfo.Text = "Enter Number of Attendees";
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Location = new System.Drawing.Point(12, 204);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(82, 20);
            this.txtNumberOfPeople.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(12, 258);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(115, 48);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter Data";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 357);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.lblEnterNumberInfo);
            this.Controls.Add(this.txtEnterTime);
            this.Controls.Add(this.lblEnterTimeInfo);
            this.Controls.Add(this.txtEnterDay);
            this.Controls.Add(this.lblEnterDayInfo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form7";
            this.Text = "Edit Attendence";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblEnterDayInfo;
        private System.Windows.Forms.TextBox txtEnterDay;
        private System.Windows.Forms.Label lblEnterTimeInfo;
        private System.Windows.Forms.TextBox txtEnterTime;
        private System.Windows.Forms.Label lblEnterNumberInfo;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.Button btnEnter;
    }
}