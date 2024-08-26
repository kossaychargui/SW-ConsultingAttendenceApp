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
    public partial class ManagerDashboard : UserControl
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateEmployeeCount();
        }

        private void UpdateEmployeeCount()
        {
            int activeEmployees = GetActiveEmployees();
            int inactiveEmployees = GetInactiveEmployees();

            lbActiveEmployeesCount.Text = activeEmployees.ToString();
            lbInactiveEmployees.Text = inactiveEmployees.ToString();
           
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            lbTotalEmployeesCount.Text = Convert.ToString(GetTotalEmployees());
        }

        private int GetTotalEmployees() 
        {
            return clsUsersData.GetNumberOfEmployees();
        }
        private int GetInactiveEmployees() 
        {
            return clsUsersData.GetAbsentEmployeeCount();
        }

        private int GetActiveEmployees()
        {
            return clsUsersData.GetActiveEmployeeCount();
            
        }
    }
}
