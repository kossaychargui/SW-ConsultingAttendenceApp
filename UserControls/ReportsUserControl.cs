using SW_ConsultingAttendenceApp_FirstTrial_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            LoadReport();
        }

        private void LoadReport()
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

        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            DataTable attendanceData = (DataTable)dataGridView1.DataSource;

            if (attendanceData != null && attendanceData.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
                saveFileDialog.FileName = "AttendanceReport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPdf(attendanceData, saveFileDialog.FileName);
                    MessageBox.Show("PDF report has been successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No data available to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToPdf(DataTable dt, string filePath)
        {
            // Initialize the PDF document
            Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
            try
            {
                PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                pdfDoc.Open();

                // Add a title to the PDF
                Paragraph title = new Paragraph("Attendance Report");
                title.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(title);

                pdfDoc.Add(new Paragraph(" ")); // Blank line for spacing

                // Create a PDF table with the number of columns based on the DataTable
                PdfPTable pdfTable = new PdfPTable(dt.Columns.Count);
                pdfTable.WidthPercentage = 100;

                // Add table headers
                foreach (DataColumn column in dt.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    cell.BackgroundColor = BaseColor.LightGray;
                    pdfTable.AddCell(cell);
                }

                // Add table rows
                foreach (DataRow row in dt.Rows)
                {
                    foreach (object cellData in row.ItemArray)
                    {
                        pdfTable.AddCell(cellData.ToString());
                    }
                }

                // Add the table to the PDF document
                pdfDoc.Add(pdfTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting the PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pdfDoc.Close();
            }
        }

        private void rbDaily_CheckedChanged(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}
