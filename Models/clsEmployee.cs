using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    public class clsEmployee : clsUser
    {
        private TimeSpan MorningCheckInTime;
        private TimeSpan MorningCheckOutTime;
        private TimeSpan EveningCheckInTime;
        private TimeSpan EveningCheckOutTime;

        public clsDepartment department { get; set; }

        public bool CheckInRequest = false;

        public void MorningCheckIn()
        {
            MorningCheckInTime = DateTime.Now.TimeOfDay;
        }
        public void MorningCheckOut()
        {
            MorningCheckOutTime = DateTime.Now.TimeOfDay;
        }
        public void EveningCheckIn()
        {
            EveningCheckInTime = DateTime.Now.TimeOfDay;
        }
        public void EveningCheckOut()
        {
            EveningCheckOutTime = DateTime.Now.TimeOfDay;
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
