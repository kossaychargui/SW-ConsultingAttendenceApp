using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    public class clsUser
    {

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int RoleID {  get; set; }
        // 0 for admin 1 for manager and 2 for employees

        public static clsUser Login(string Username, string Password)
        {
            clsUser user = new clsUser();
            user.Username = Username;
            user.Password = Password;
            user.RoleID = 2;
            return user;
        }

        public static void Logout()
        {

        }
        public void ResetPassword()
        {

        }
    }
}
