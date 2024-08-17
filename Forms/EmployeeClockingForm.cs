using SW_ConsultingAttendenceApp_FirstTrial_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    public partial class EmployeeClockingForm : Form
    {
        public EmployeeClockingForm()
        {
            InitializeComponent();
        }

        public enum CheckInState { EmployeeArrived, MorningCheckInApproval, EveningCheckIn, EveningCheckOut, EndOfTheDay };
        public bool isCheckInApproval;
        public CheckInState checkInState;

        /**
         * NotifyIconConfiguration - customized function to make a notification to the user
         * @Title: title
         * @TextMessage: the message to show to the user
         * @Time: Notification duration
         * 
         */
        public void NotifyIconConfiguration(string Title, string TextMessage, int Time)
        {
            notifyIcon1.Icon = SystemIcons.Information;
            //notifyIcon1.BalloonTipIcon = ToolTipIcon;
            notifyIcon1.BalloonTipTitle = Title;
            notifyIcon1.BalloonTipText = Text;
            notifyIcon1.ShowBalloonTip(Time);
        }
         
       
        private void EmployeeClockingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            checkInState = CheckInState.EmployeeArrived;
            LoginForm.ActiveForm.Hide();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbClock.Text = DateTime.Now.ToString("HH:mm:ss");
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //checkInState = waitForApproval();
        }

        private void roundedButton1_MouseHover(object sender, EventArgs e)
        {

            btn1.FlatStyle = FlatStyle.Flat;
        }

        private async void btn1_Click(object sender, EventArgs e)
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
                checkInState = CheckInState.EveningCheckIn;

            }
            else if (checkInState == CheckInState.EveningCheckIn)
            {
                TimeSpan EveningEntryTime = new TimeSpan(13, 00, 00);
                if (DateTime.Now.TimeOfDay < EveningEntryTime)
                    return;
                // just wanna make sure that the employee doesn't check in the evening session at the morning or at the break time!
                // because he can (not by intention) click multiple times on the checkIn/Out button 
                btn1.Text = "Check Out";
                lbEveningEntryTime.Text = DateTime.Now.ToString();
                checkInState = CheckInState.EveningCheckOut;

            }
            else if (checkInState == CheckInState.EveningCheckOut)
            {
                lbEveningLeaveTime.Text = DateTime.Now.ToString();
                checkInState = CheckInState.EndOfTheDay;

                
                clsCurrentUser.LoggedInUser.Logout();
                this.Hide();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
            clsCurrentUser.LoggedInUser.Logout();
            this.Hide();
        }
    }
}
