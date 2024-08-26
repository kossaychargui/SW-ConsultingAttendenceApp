using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    public class clsUser
    {

        public int UserID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }    
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

      

      

        public int RoleID {  get; set; }
        // 0 for admin 1 for manager and 2 for employees


        public string FullName => $"{Firstname} {Lastname}";
        public static clsUser Login(string Username, string Password)
        {
            //clsUser user = new clsUser();
            //user.Username = Username;
            //user.Password = Password;
            //if (Username == "Admin")
            //    user.RoleID = 0;
            //else if(Username == "Manager")
            //    user.RoleID = 1;
            //else
            //    user.RoleID = 2;
            //user.Firstname= "Kossay";
            
            return clsUsersData.GetUserByUsernameAndPassword(Username, Password);
        }

        public void Logout()
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {

                Application.Restart();
            }

            //DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (check == DialogResult.Yes)
            //{
            //    Application.Restart();
            //}
        }

    }
}
