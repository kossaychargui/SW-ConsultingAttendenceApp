using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(new ManagerForm());
        }
    }
}
//EmployeeClockingForm
//new ManagerForm()


// I just want to the login form to start at the center of the screen . The code before was
// Application.EnableVisualStyles(); // same as now
// Application.SetCompatibleTextRenderingDefault(false); // same as now
// Application.Run(new LoginForm()); // that's what did edit