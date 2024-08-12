using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Models
{
    internal class clsManager : clsUser
    {
        public int ManagerID {  get; set; }

        public clsDepartment Department { get; set; }


        public void ApproveCheckInRequest(clsEmployee employee)
        {
            employee.CheckInApproved = true;
        }
        public void GenerateReport()
        {

        } 
    }
}
