namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lbWelcomeUser = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDemands = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.reportsUserControl1 = new SW_ConsultingAttendenceApp_FirstTrial_.ReportsUserControl();
            this.managerDashboard1 = new SW_ConsultingAttendenceApp_FirstTrial_.ManagerDashboard();
            this.addEmployeeUserControl1 = new SW_ConsultingAttendenceApp_FirstTrial_.UserControls.AddEmployeeUserControl();
            this.demandsUserControl1 = new SW_ConsultingAttendenceApp_FirstTrial_.DemandsUserControl();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.btnAddEmployee);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lbWelcomeUser);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnDemands);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 616);
            this.panel1.TabIndex = 29;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 434);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(210, 50);
            this.btnAddEmployee.TabIndex = 29;
            this.btnAddEmployee.Text = "   Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lbWelcomeUser
            // 
            this.lbWelcomeUser.AutoSize = true;
            this.lbWelcomeUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeUser.Location = new System.Drawing.Point(33, 117);
            this.lbWelcomeUser.Name = "lbWelcomeUser";
            this.lbWelcomeUser.Size = new System.Drawing.Size(144, 24);
            this.lbWelcomeUser.TabIndex = 1;
            this.lbWelcomeUser.Text = "Welcome, User";
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(12, 360);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(210, 50);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "          Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click_1);
            // 
            // btnDemands
            // 
            this.btnDemands.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDemands.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemands.Location = new System.Drawing.Point(12, 286);
            this.btnDemands.Name = "btnDemands";
            this.btnDemands.Size = new System.Drawing.Size(210, 50);
            this.btnDemands.TabIndex = 2;
            this.btnDemands.Text = "          Demands";
            this.btnDemands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemands.UseVisualStyleBackColor = false;
            this.btnDemands.Click += new System.EventHandler(this.btnDemands_Click_1);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(12, 212);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click_1);
            // 
            // reportsUserControl1
            // 
            this.reportsUserControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportsUserControl1.BackColor = System.Drawing.Color.SkyBlue;
            this.reportsUserControl1.Location = new System.Drawing.Point(245, 0);
            this.reportsUserControl1.Name = "reportsUserControl1";
            this.reportsUserControl1.Size = new System.Drawing.Size(1043, 462);
            this.reportsUserControl1.TabIndex = 4;
            // 
            // managerDashboard1
            // 
            this.managerDashboard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.managerDashboard1.BackColor = System.Drawing.Color.SkyBlue;
            this.managerDashboard1.Location = new System.Drawing.Point(245, 0);
            this.managerDashboard1.Name = "managerDashboard1";
            this.managerDashboard1.Size = new System.Drawing.Size(1042, 464);
            this.managerDashboard1.TabIndex = 6;
            // 
            // addEmployeeUserControl1
            // 
            this.addEmployeeUserControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addEmployeeUserControl1.BackColor = System.Drawing.Color.SkyBlue;
            this.addEmployeeUserControl1.Location = new System.Drawing.Point(245, 3);
            this.addEmployeeUserControl1.Name = "addEmployeeUserControl1";
            this.addEmployeeUserControl1.Size = new System.Drawing.Size(1036, 469);
            this.addEmployeeUserControl1.TabIndex = 30;
            // 
            // demandsUserControl1
            // 
            this.demandsUserControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.demandsUserControl1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.demandsUserControl1.Location = new System.Drawing.Point(245, -2);
            this.demandsUserControl1.Name = "demandsUserControl1";
            this.demandsUserControl1.Size = new System.Drawing.Size(1046, 464);
            this.demandsUserControl1.TabIndex = 5;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.icons8_logout_rounded_50;
            this.pictureBox8.Location = new System.Drawing.Point(1238, 565);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 39);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox5.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.icons8_reports_50;
            this.pictureBox5.Location = new System.Drawing.Point(20, 444);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox4.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.icons8_reports_50;
            this.pictureBox4.Location = new System.Drawing.Point(20, 368);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox3.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.icons8_demand_50;
            this.pictureBox3.Location = new System.Drawing.Point(22, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox2.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.icons8_dashboard_50;
            this.pictureBox2.Location = new System.Drawing.Point(23, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.managerSpaceIcon;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1287, 616);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportsUserControl1);
            this.Controls.Add(this.managerDashboard1);
            this.Controls.Add(this.addEmployeeUserControl1);
            this.Controls.Add(this.demandsUserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Admin Space";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReportsUserControl reportsUserControl1;
        private DemandsUserControl demandsUserControl1;
        private ManagerDashboard managerDashboard1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbWelcomeUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDemands;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnAddEmployee;
        private UserControls.AddEmployeeUserControl addEmployeeUserControl1;
    }
}