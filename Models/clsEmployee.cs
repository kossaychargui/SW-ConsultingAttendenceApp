using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    public class clsEmployee : clsUser
    {
        public DateTime MorningCheckInTime;
        public DateTime MorningCheckOutTime;
        public DateTime EveningCheckInTime;
        public DateTime EveningCheckOutTime;

        public clsDepartment department { get; set; }

        public bool CheckInRequest = false;

    
        public void MorningCheckIn()
        {
            MorningCheckInTime = DateTime.Now;
            clsUsersData.SaveMorningCheckIn(clsCurrentUser.LoggedInUser.UserID, DateTime.Now.Date, MorningCheckInTime);
                
        }
        public void MorningCheckOut()
        {
            MorningCheckOutTime = DateTime.Now;
            //save Morning CheckOUt into db
            clsUsersData.SaveEveningCheckOut(clsCurrentUser.LoggedInUser.UserID, DateTime.Now.Date, MorningCheckOutTime);
        }
        public void EveningCheckIn()
        {
            EveningCheckInTime = DateTime.Now;
            // save Evening CheckIn into db
            clsUsersData.SaveEveningCheckOut(clsCurrentUser.LoggedInUser.UserID, DateTime.Now.Date, EveningCheckInTime);

        }
        public void EveningCheckOut()
        {
            EveningCheckOutTime = DateTime.Now;
            //  save Evdning Check out into db
            clsUsersData.SaveEveningCheckOut(clsCurrentUser.LoggedInUser.UserID, DateTime.Now.Date, EveningCheckOutTime);
        }

        private TimeSpan GetMorningWorkingHours()
        {
            return MorningCheckOutTime.Subtract(MorningCheckInTime);
        }
        private TimeSpan GetEveningWorkingHours()
        {
            return EveningCheckOutTime.Subtract(EveningCheckInTime);
        }
        public TimeSpan GetWorkingHours()
        {
            return GetEveningWorkingHours() + GetMorningWorkingHours();
        }
    }
}
