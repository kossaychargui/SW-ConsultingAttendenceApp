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
    }
}
