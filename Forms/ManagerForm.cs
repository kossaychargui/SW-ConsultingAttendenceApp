using SW_ConsultingAttendenceApp_FirstTrial_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
      
        private void btnDashboard_Click(object sender, EventArgs e)
        {

            managerDashboard1.Visible = true;
            managerDashboard1.Dock = DockStyle.Right;
            demandsUserControl1.Visible = false;
            demandsUserControl1.Dock = DockStyle.None;
            reportsUserControl1.Visible = false;
            reportsUserControl1.Dock = DockStyle.None;
        }

        private void btnDemands_Click(object sender, EventArgs e)
        {

            managerDashboard1.Visible = false;
            demandsUserControl1.Visible = true;
            reportsUserControl1.Visible = false;
            
            reportsUserControl1.Dock = DockStyle.None;
            managerDashboard1.Dock = DockStyle.None;
            demandsUserControl1.Dock = DockStyle.Right;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            lbWelcomeUser.Text = "Welcome,\n" + clsCurrentUser.LoggedInUser.Firstname;
            managerDashboard1.Visible = true;
            demandsUserControl1.Visible = false;
            reportsUserControl1.Visible = false;
            demandsUserControl1.Dock = DockStyle.None;
            reportsUserControl1.Dock = DockStyle.None;
            managerDashboard1.Dock = DockStyle.Right;

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            managerDashboard1.Visible =false;
            demandsUserControl1.Visible = false;
            reportsUserControl1.Visible = true;
            demandsUserControl1.Dock = DockStyle.None;
            managerDashboard1.Dock = DockStyle.None;
            reportsUserControl1.Dock = DockStyle.Right;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            clsCurrentUser.LoggedInUser.Logout();
        }
    }
}
