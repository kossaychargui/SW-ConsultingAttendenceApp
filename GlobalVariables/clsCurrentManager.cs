﻿using SW_ConsultingAttendenceApp_FirstTrial_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsultingAttendenceApp_FirstTrial_.GlobalVariables
{
    public static class clsCurrentManager
    {
        public static clsManager CurrentManager { get; private set; }


        public static void Initialize(clsUser user)
        {
            if (user.RoleID == 1) // Check if the user is a Manager
            {
                // Initialize CurrentManager with properties from user
                CurrentManager = new clsManager
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
                CurrentManager = null; // Not a manager
            }
        }
    }
}
