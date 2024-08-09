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
    public partial class EmployeeClockingForm : Form
    {
        public EmployeeClockingForm()
        {
            InitializeComponent();
        }

        private void EmployeeClockingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btn2.Enabled = false;

    
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("hh:mm:ss");
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void roundedButton1_MouseHover(object sender, EventArgs e)
        {
            btn1.FlatStyle = FlatStyle.Flat;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbEntryTime.Text = DateTime.Now.ToString();
        }

 
    }
}
