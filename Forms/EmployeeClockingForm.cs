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
using static SW_ConsultingAttendenceApp_FirstTrial_.EmployeeClockingForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    public partial class EmployeeClockingForm : Form
    {
        public EmployeeClockingForm()
        {
            InitializeComponent();
        }
        public DateTime? MorningCheckInTime;
        public DateTime? MorningCheckOutTime;
        public DateTime? EveningCheckInTime;
        public DateTime? EveningCheckOutTime;

       public DateTime morningEndTime;
        public DateTime lunchStartTime;
        public DateTime eveningEndTime;

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

            DateTime currentDate = DateTime.Now.Date;
            morningEndTime = currentDate.AddHours(12); // 12:00 PM
            lunchStartTime = currentDate.AddHours(13); // 1:00 PM
            eveningEndTime = currentDate.AddHours(18); // 6:00 PM


            // Load attendance records
            clsUsersData.LoadAllAttendanceEvents(clsCurrentUser.LoggedInUser.UserID, currentDate, out MorningCheckInTime, out MorningCheckOutTime, out EveningCheckInTime, out EveningCheckOutTime);

            FillTimeLabelsValues();

            checkInState = GetCheckInState();
           
        }

        private CheckInState GetCheckInState()
        {
            
            DateTime CurrentTime = DateTime.Now;
           if(MorningCheckInTime == null)
            {
                if (CurrentTime < morningEndTime)
                {
                    btn1.Text = "Check In";
                    return CheckInState.EmployeeArrived;
                }
                else
                {
                    MessageBox.Show("You are absent Today:-(!");
                    Task.Delay(2000);
                    clsCurrentUser.LoggedInUser.Logout();
                }
            }
            if (MorningCheckInTime != null && MorningCheckOutTime == null) {
                if(CurrentTime < morningEndTime)
                {
                    btn1.Text = "Check Out";
                    return CheckInState.MorningCheckInApproval;
                }
                else
                {
                    MorningCheckOutTime = morningEndTime;
                    clsUsersData.SaveMorningCheckOut(clsCurrentUser.LoggedInUser.UserID, DateTime.Now.Date, MorningCheckOutTime.Value);
                    btn1.Text = "Check In";
                    lbMorningLeavetime.Text = MorningCheckOutTime.ToString();
                    return CheckInState.EveningCheckIn; 
                   
                }
            }
            if (MorningCheckInTime != null && MorningCheckOutTime != null && EveningCheckInTime == null)
            {
                btn1.Text = "Check In";
                return CheckInState.EveningCheckIn;
            }
            if (MorningCheckInTime != null && MorningCheckOutTime != null && EveningCheckInTime != null && EveningCheckOutTime == null)
            {
                btn1.Text = "Check Out";
                return CheckInState.EveningCheckOut;
            }
            else
                btn1.Text = "EndOfDay";
                btn1.Enabled = false;
                return CheckInState.EndOfTheDay;
        }
 
        private void FillTimeLabelsValues()
        {
            if (MorningCheckInTime != null)
                lbMorningEntryTime.Text = MorningCheckInTime.Value.ToString();
            else
                lbMorningEntryTime.Text = "-";

            if (MorningCheckOutTime != null)
                lbMorningLeavetime.Text = MorningCheckOutTime.Value.ToString();
            else
                lbMorningLeavetime.Text = "-";

            if (EveningCheckInTime != null)
                lbEveningEntryTime.Text = EveningCheckInTime.Value.ToString();
            else
                lbEveningEntryTime.Text = "-";

            if (EveningCheckOutTime != null)
                lbEveningLeaveTime.Text = EveningCheckOutTime.Value.ToString();
            else
                lbEveningLeaveTime.Text = "-";
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

        private async void btn1_Click(object sender, EventArgs e)// it's one button that checks in and out for the mornign and the evenign
        {
            if (checkInState == CheckInState.EmployeeArrived)
            {
                lbMorningEntryTime.Text = DateTime.Now.ToString();
                btn1.Text = "Check Out";
              
                checkInState = CheckInState.MorningCheckInApproval;
                clsCurrentEmployee.CurrentEmployee.MorningCheckIn();
            }

            else if (checkInState == CheckInState.MorningCheckInApproval)
            {
                if (!clsUsersData.GetCheckInRequestStatus(clsCurrentEmployee.CurrentEmployee.UserID, DateTime.Now.Date))
                {
                    MessageBox.Show("Waiting For Your Admin/Manager Approval", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // user will wait until manager approves his attendance
                }
                
                btn1.Text = "Check In";
                lbMorningLeavetime.Text = DateTime.Now.ToString();
                checkInState = CheckInState.EveningCheckIn;
                clsCurrentEmployee.CurrentEmployee.MorningCheckOut();

            }
            else if (checkInState == CheckInState.EveningCheckIn)
            {
                TimeSpan EveningEntryTime = new TimeSpan(13, 00, 00);
                if (DateTime.Now.TimeOfDay < EveningEntryTime)
                {
                    MessageBox.Show("This Is Your Lunch Break Time Now! ;-)");
                    return;
                }
                // just wanna make sure that the employee doesn't check in the evening session at the morning or at the break time!
                // because he can (not by intention) click multiple times on the checkIn/Out button 
                btn1.Text = "Check Out";
                lbEveningEntryTime.Text = DateTime.Now.ToString();
                checkInState = CheckInState.EveningCheckOut;
                clsCurrentEmployee.CurrentEmployee.EveningCheckIn();

            }
            else if (checkInState == CheckInState.EveningCheckOut)
            {
                lbEveningLeaveTime.Text = DateTime.Now.ToString();
                checkInState = CheckInState.EndOfTheDay;

                clsCurrentEmployee.CurrentEmployee.EveningCheckOut();
                clsCurrentUser.LoggedInUser.Logout();
               
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
            clsCurrentUser.LoggedInUser.Logout();
           
        }
    }
}
