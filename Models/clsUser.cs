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
        public string FullName { get; set; }
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
            user.RoleID = 0;
            user.FullName= "Kossay";
            
            return user;
        }

        public void Logout()
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {

                LoginForm loginForm = new LoginForm();
                loginForm.StartPosition = FormStartPosition.CenterScreen;
                loginForm.Show();
            }

            //DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (check == DialogResult.Yes)
            //{
            //    Application.Restart();
            //}
        }
        public void ResetPassword()
        {

        }
    }
}
