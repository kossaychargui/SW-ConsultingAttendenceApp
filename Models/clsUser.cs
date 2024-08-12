using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    internal class clsUser
    {

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set }
        public string Password { get; set; }

        public void Login()
        {

        }

        public void Logout()
        {

        }
        public void ResetPassword()
        {

        }
    }
}
