using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    public static class clsCurrentUser
    {
        public static clsUser LoggedInUser { get; set; }

        public static clsEmployee LoggedInEmployee { get; set; } = (clsEmployee)LoggedInUser;

        public static clsManager LoggedInManager { get; set; } = (clsManager)LoggedInUser;

        public static clsAdmin LoggedInAdmin { get; set; } = (clsAdmin)LoggedInUser;


    }
}
