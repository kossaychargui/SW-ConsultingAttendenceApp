namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbWelcomeUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnDemands = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.customInstaller2 = new MySql.Data.MySqlClient.CustomInstaller();
            this.customInstaller3 = new MySql.Data.MySqlClient.CustomInstaller();
            this.reportsUserControl1 = new SW_ConsultingAttendenceApp_FirstTrial_.ReportsUserControl();
            this.demandsUserControl1 = new SW_ConsultingAttendenceApp_FirstTrial_.DemandsUserControl();
            this.managerDashboard1 = new SW_ConsultingAttendenceApp_FirstTrial_.ManagerDashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
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
            this.panel1.Size = new System.Drawing.Size(200, 464);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox4.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.icons8_reports_50;
            this.pictureBox4.Location = new System.Drawing.Point(17, 360);
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
            this.pictureBox3.Location = new System.Drawing.Point(15, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lbWelcomeUser
            // 
            this.lbWelcomeUser.AutoSize = true;
            this.lbWelcomeUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeUser.Location = new System.Drawing.Point(26, 126);
            this.lbWelcomeUser.Name = "lbWelcomeUser";
            this.lbWelcomeUser.Size = new System.Drawing.Size(144, 24);
            this.lbWelcomeUser.TabIndex = 1;
            this.lbWelcomeUser.Text = "Welcome, User";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox2.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.icons8_dashboard_50;
            this.pictureBox2.Location = new System.Drawing.Point(15, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.managerSpaceIcon;
            this.pictureBox1.Location = new System.Drawing.Point(28, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(9, 349);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(185, 50);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "        Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnDemands
            // 
            this.btnDemands.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDemands.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemands.Location = new System.Drawing.Point(5, 277);
            this.btnDemands.Name = "btnDemands";
            this.btnDemands.Size = new System.Drawing.Size(185, 50);
            this.btnDemands.TabIndex = 2;
            this.btnDemands.Text = "Demands";
            this.btnDemands.UseVisualStyleBackColor = false;
            this.btnDemands.Click += new System.EventHandler(this.btnDemands_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(5, 201);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(185, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // reportsUserControl1
            // 
            this.reportsUserControl1.BackColor = System.Drawing.Color.SkyBlue;
            this.reportsUserControl1.Location = new System.Drawing.Point(196, 0);
            this.reportsUserControl1.Name = "reportsUserControl1";
            this.reportsUserControl1.Size = new System.Drawing.Size(1043, 462);
            this.reportsUserControl1.TabIndex = 3;
            // 
            // demandsUserControl1
            // 
            this.demandsUserControl1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.demandsUserControl1.Location = new System.Drawing.Point(196, 0);
            this.demandsUserControl1.Name = "demandsUserControl1";
            this.demandsUserControl1.Size = new System.Drawing.Size(1046, 464);
            this.demandsUserControl1.TabIndex = 2;
            // 
            // managerDashboard1
            // 
            this.managerDashboard1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.managerDashboard1.Location = new System.Drawing.Point(200, 0);
            this.managerDashboard1.Name = "managerDashboard1";
            this.managerDashboard1.Size = new System.Drawing.Size(1042, 464);
            this.managerDashboard1.TabIndex = 1;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1240, 464);
            this.Controls.Add(this.reportsUserControl1);
            this.Controls.Add(this.demandsUserControl1);
            this.Controls.Add(this.managerDashboard1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm";
            this.Text = "Manager Space";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lbWelcomeUser;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnDemands;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller2;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller3;
        private ManagerDashboard managerDashboard1;
        private DemandsUserControl demandsUserControl1;
        private ReportsUserControl reportsUserControl1;
    }
}