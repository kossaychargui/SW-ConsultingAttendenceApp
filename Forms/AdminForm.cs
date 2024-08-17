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
    public partial class AdminForm : Form
    {
        public AdminForm()
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
            addEmployeeUserControl1.Visible = false;
            addEmployeeUserControl1.Dock = DockStyle.None;
        }

        private void btnDemands_Click(object sender, EventArgs e)
        {
            managerDashboard1.Visible = false;
            demandsUserControl1.Visible = true;
            reportsUserControl1.Visible = false;
            addEmployeeUserControl1.Visible = false;

            addEmployeeUserControl1.Dock = DockStyle.None;
            reportsUserControl1.Dock = DockStyle.None;
            managerDashboard1.Dock = DockStyle.None;
            demandsUserControl1.Dock = DockStyle.Right;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            addEmployeeUserControl1.Visible = false;
            managerDashboard1.Visible = false;
            demandsUserControl1.Visible = false;
            reportsUserControl1.Visible = true;
            addEmployeeUserControl1.Dock = DockStyle.None;
            demandsUserControl1.Dock = DockStyle.None;
            managerDashboard1.Dock = DockStyle.None;
            reportsUserControl1.Dock = DockStyle.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            managerDashboard1.Visible = false;
            demandsUserControl1.Visible = false;
            reportsUserControl1.Visible = false;
            addEmployeeUserControl1.Visible = true;
            demandsUserControl1.Dock = DockStyle.None;
            managerDashboard1.Dock = DockStyle.None;
            reportsUserControl1.Dock = DockStyle.None;
            addEmployeeUserControl1.Dock = DockStyle.Right;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }
    }
}
