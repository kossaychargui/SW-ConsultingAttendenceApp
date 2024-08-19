using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    internal class clsManager : clsUser
    {
        public clsDepartment Department { get; set; }

        public void ApproveCheckInRequest(clsEmployee employee)
        {
            employee.CheckInRequest = true;
        }
        public void GenerateReport()
        {

        } 
    }
}
