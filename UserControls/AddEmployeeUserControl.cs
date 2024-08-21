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

namespace SW_ConsultingAttendenceApp_FirstTrial_.UserControls
{
    public partial class AddEmployeeUserControl : UserControl
    {
        public AddEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void ClearAllFields()
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            tbAge.Text = string.Empty;
            cbDepartment.SelectedIndex = 0;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsEmployee emp = new clsEmployee();
            emp.Email = tbEmail.Text;
            clsCurrentUser.LoggedInAdmin.AddEmployee(emp);
        }
    }
}
