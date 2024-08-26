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
    public partial class ReportsUserControl : UserControl
    {
        public ReportsUserControl()
        {
            InitializeComponent();
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
        }

       

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void LoadFullnames()
        {
            List<clsUser> users = clsUsersData.GetUsers();

            // Create a list of full names
            var fullNames = users.Select(user => $"{user.Firstname} {user.Lastname}").ToList();

            // Bind the list of full names to the ComboBox
            cbFullNames.DataSource = fullNames;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFullName = cbFullNames.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedFullName))
            {
                MessageBox.Show("Please select a valid user.");
                return;
            }

            // Find the user ID based on the selected full name
            clsUser selectedUser = clsUsersData.GetUsers().FirstOrDefault(user => $"{user.Firstname} {user.Lastname}" == selectedFullName);

            if (selectedUser != null)
            {
                // Load the attendance report for the selected user
                switch (GetSelectedPeriod())
                {
                    case 0:
                        LoadUserAttendanceReport(selectedUser.UserID, "daily");
                        break;
                    case 1:
                        LoadUserAttendanceReport(selectedUser.UserID, "weekly");
                        break;
                    case 2:
                        LoadUserAttendanceReport(selectedUser.UserID, "monthly");
                        break;
                    case 3:
                        LoadUserAttendanceReport(selectedUser.UserID, "range", dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
                        break;
                    default:
                        MessageBox.Show("Invalid report type selected.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void LoadUserAttendanceReport(int userId, string reportType, DateTime? startDate = null, DateTime? endDate = null)
        {
            DataTable attendanceData;

            // Fetch the attendance report data based on the report type
            if (reportType == "range" && startDate.HasValue && endDate.HasValue)
            {
                attendanceData = clsUsersData.LoadUserAttendanceReport(userId, reportType, startDate.Value, endDate.Value);
            }
            else
            {
                attendanceData = clsUsersData.LoadUserAttendanceReport(userId, reportType);
            }

            // Bind the fetched data to the DataGridView
            dataGridView1.DataSource = attendanceData;
        }

        private void cbFullNames_Click(object sender, EventArgs e)
        {
            LoadFullnames();
        }
        private int GetSelectedPeriod()
        {
            if(rbDaily.Checked)
                return 0;
            if (rbWeakly.Checked)
                return 1;
            if(rbMonthly.Checked)
                return 2;

            return 3;
        }
    }
}
