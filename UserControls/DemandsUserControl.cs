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
    public partial class DemandsUserControl : UserControl
    {
        public DemandsUserControl()
        {
            InitializeComponent();
        }

        private void LoadEmployeeAttendance()
        {
            DataTable employeeAttendance = clsUsersData.GetEmployeeAttendance();
            dataGridView1.DataSource = employeeAttendance;

            // Add a checkbox column for approving check-ins
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Approve Check-In";
            checkBoxColumn.Name = "ApproveCheckIn";
            checkBoxColumn.FalseValue = false;
            checkBoxColumn.TrueValue = true;
            checkBoxColumn.DataPropertyName = "Request"; // Bind the checkbox to the 'Request' column
            dataGridView1.Columns.Add(checkBoxColumn);

            // Hide the Request column in the DataGridView
            dataGridView1.Columns["Request"].Visible = false;
        }


        private void DemandsUserControl_Load(object sender, EventArgs e)
        {
            LoadEmployeeAttendance();
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["ApproveCheckIn"].Index)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells["ApproveCheckIn"];
                bool isChecked = (bool)checkBoxCell.EditedFormattedValue;

                // Get the employee's Firstname and Lastname (assuming they are unique)
                string firstname = dataGridView1.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
                string lastname = dataGridView1.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();

                // Update the Request status in the database
                clsUsersData.UpdateRequestStatus(firstname, lastname, isChecked ? 1 : 0);
            }
        }
    }
}
