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

        public enum CheckInState { EmployeeArrived, MorningCheckInApproval, MorningCheckOut, EveningCheckIn, EveningCheckInClicked };
        public bool isCheckInApproval;
        public CheckInState checkInState;
        private void EmployeeClockingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            checkInState = CheckInState.EmployeeArrived;

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
            if (checkInState == CheckInState.EmployeeArrived)
            {
                lbMorningEntryTime.Text = DateTime.Now.ToString();
                btn1.Text = "Check Out";
                //btn1.Enabled = false;
                checkInState = CheckInState.MorningCheckInApproval;
            }
            else if (checkInState == CheckInState.MorningCheckInApproval)
            {
                btn1.Text = "Check In";
                lbMorningLeavetime.Text = DateTime.Now.ToString();
                checkInState = CheckInState.MorningCheckOut;

            }
            else if (checkInState == CheckInState.MorningCheckOut)
            {
                
                
                checkInState = CheckInState.EveningCheckIn;
                
            }
            else if (checkInState == CheckInState.EveningCheckIn)
            {

            }


        }
    }
}
