using ServiceStack;
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

namespace SW_ConsultingAttendenceApp_FirstTrial_.UserControls
{
    public partial class AddEmployeeUserControl : UserControl
    {
        public AddEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void ClearAllFields()
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            tbAge.Text = string.Empty;
            cbDepartment.SelectedIndex = -1;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyFields())
                return;
            clsUser user = new clsUser();
            user.Firstname = tbFirstName.Text;
            user.Lastname = tbLastName.Text;
            user.Email = tbEmail.Text;
            user.Phone = tbPhoneNumber.Text;
            user.Age = Convert.ToInt32(tbAge.Text);
            user.DepartmentID = Convert.ToInt32(cbDepartment.SelectedIndex);
            if (clsUsersData.AddUser(user))
            {
                MessageBox.Show("UserAdded Successfully", "Successful Operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Railed", "Eroor Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyFields())
                return;
            clsUser user =  GetUserSelectedUser();
            user.Firstname = tbFirstName.Text;
            user.Lastname = tbLastName.Text;
            user.Email = tbEmail.Text;
            user.Phone = tbPhoneNumber.Text;
            user.Age = Convert.ToInt32(tbAge.Text);
            user.DepartmentID = Convert.ToInt32(cbDepartment.SelectedIndex);
            if(clsUsersData.UpdateUser(user, true, true))
            {
                MessageBox.Show("User Updated Successfully", "Successful Operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed", "Error Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyFields())
                return;
            clsUser user = GetUserSelectedUser();
            user.Firstname = tbFirstName.Text;
            user.Lastname = tbLastName.Text;
            user.Email = tbEmail.Text;
            user.Phone = tbPhoneNumber.Text;
            user.Age = Convert.ToInt32(tbAge.Text);
            user.DepartmentID = Convert.ToInt32(cbDepartment.SelectedIndex);
            if (clsUsersData.DeleteUser(user.UserID))
            {
                MessageBox.Show("User Deleted Successfully", "Successful Operation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed", "Error Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells["FirstName"].Value = tbFirstName.Text;
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells["Lastname"].Value = tbLastName.Text;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells["Email"].Value = tbEmail.Text;
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells["Age"].Value = tbAge.Text;
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells["Phone"].Value = tbPhoneNumber.Text;
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartment.SelectedIndex == -1)
                return;
            dataGridView1.Rows[0].Cells["Department"].Value = cbDepartment.SelectedItem.ToString();
        }
        private bool CheckEmptyFields()
        {
            if (tbFirstName.Text.IsNullOrEmpty() || tbLastName.Text.IsNullOrEmpty() || tbEmail.Text.IsNullOrEmpty() || tbPhoneNumber.Text.IsNullOrEmpty() || tbAge.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please Fill all the fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; 
            }
            return true;
        }

        private void LoadFullnames()
        {
            List<clsUser> users = clsUsersData.GetUsers();

            // Create a list of full names
            var fullNames = users.Select(user => $"{user.Firstname} {user.Lastname}").ToList();

            // Bind the list of full names to the ComboBox
            cbFullNames.DataSource = fullNames;
        }
        private void AddEmployeeUserControl_Load(object sender, EventArgs e)
        {
            LoadFullnames();
        }

        private void cbFullNames_Click(object sender, EventArgs e)
        {
            LoadFullnames();
        }

        private clsUser GetUserSelectedUser()
        {
            string[] nameParts = cbFullNames.SelectedItem.ToString().Split(' ');
            string firstname = nameParts[0];
            string lastname = nameParts[1];
            clsUser user = clsUsersData.GetUserByFullName(firstname, lastname);
            return user;
        }
        private void cbFullNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsUser user = GetUserSelectedUser();
            if (user != null) {
                tbFirstName.Text = user.Firstname;
                tbLastName.Text = user.Lastname;
                tbEmail.Text = user.Email;
                tbPhoneNumber.Text = user.Phone;
                tbAge.Text = Convert.ToString(user.Age);
                cbDepartment.SelectedIndex = user.DepartmentID;
            }
        }
    }
}
