using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    public static class clsCurrentEmployee
    {
        public static clsEmployee CurrentEmployee { get; private set; }

        public static void Initialize(clsUser user)
        {
            if (user.RoleID == 2) // Check if the user is an employee
            {
                // Initialize CurrentEmployee with properties from user
                CurrentEmployee = new clsEmployee
                {
                    UserID = user.UserID,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    Age = user.Age,
                    Email = user.Email,
                    Phone = user.Phone,
                    Username = user.Username,
                    Password = user.Password,
                    RoleID = user.RoleID
                    // Set other properties if needed
                };
            }
            else
            {
                CurrentEmployee = null; // Not an employee
            }
        }
    }
}
