using SW_ConsultingAttendenceApp_FirstTrial_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    public partial class DemandsUserControl : UserControl
    {
        public DemandsUserControl()
        {
            InitializeComponent();
        }

        private void DemandsUserControl_Load(object sender, EventArgs e)
        {



            List<clsUser> users = clsUsersData.GetUsers();
           dataGridView1.DataSource = users;
        }
    }
}
