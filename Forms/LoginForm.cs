﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using SW_ConsultingAttendenceApp_FirstTrial_.Models;
using SW_ConsultingAttendenceApp_FirstTrial_.Forms;
using SW_ConsultingAttendenceApp_FirstTrial_.GlobalVariables;


namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        
        }
        private ErrorProvider _errorProvider1 = new ErrorProvider();
        private ErrorProvider _errorProvider2 = new ErrorProvider();

        private Region GetRoundedImagePictureBox(PictureBox pictureBox) 
        {
            GraphicsPath graphicspath = new GraphicsPath();
            graphicspath.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            Region rgn = new Region(graphicspath);
            return rgn;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pbLogo.Region = GetRoundedImagePictureBox(pbLogo);

            ToolTip toolTip = new ToolTip();

            // Set the tooltip text for a button
            toolTip.SetToolTip(pbInformation, "To Reset Password You can Re-SignIn and Update Your Username/Password");
        }

      

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if(tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;   
            }
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.Silver;
                _errorProvider1.SetError(tbUsername, "Please Enter Username!");
            }
            else
                _errorProvider1.Clear();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
                tbPassword.PasswordChar = '*';

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Silver;
                tbPassword.PasswordChar = '\0';
                _errorProvider2.SetError(tbPassword, "Please Enter Password!");
            }
            else
                _errorProvider2.Clear();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsFieldsEmpty())
                return;
            clsCurrentUser.LoggedInUser = clsUser.Login(tbUsername.Text, tbPassword.Text);

            
            if (clsCurrentUser.LoggedInUser != null)
            {
                
                if(clsCurrentUser.LoggedInUser.RoleID == 2)
                {

                    clsCurrentEmployee.Initialize(clsCurrentUser.LoggedInUser);

                    tbPassword.Text = "";
                    tbUsername.Text = "";
                    tbUsername_Leave(sender, e);
                    textBox1_Leave(sender, e);
                    EmployeeClockingForm emp = new EmployeeClockingForm();
                    emp.StartPosition = FormStartPosition.CenterScreen;
                    emp.Show();
                    emp.FormClosed += (s, args) => this.Close();
                

                }
                else if (clsCurrentUser.LoggedInUser.RoleID == 1)
                {
                    clsCurrentManager.Initialize(clsCurrentUser.LoggedInUser);
                    tbPassword.Text = "";
                    tbUsername.Text = "";
                    tbUsername_Leave(sender, e);
                    textBox1_Leave(sender, e);
                    ManagerForm manager = new ManagerForm();
                    manager.StartPosition = FormStartPosition.CenterScreen;
                    manager.Show();
                    manager.FormClosed += (s, args) => this.Close();
                 


                }
                else
                {
                    clsCurrentAdmin.Initialize(clsCurrentUser.LoggedInUser);
                    tbPassword.Text = "";
                    tbUsername.Text = "";
                    tbUsername_Leave(sender, e);
                    textBox1_Leave(sender, e);
                    AdminForm admin = new AdminForm();
                    admin.StartPosition = FormStartPosition.CenterScreen;
                    admin.Show();
                    admin.FormClosed += (s, args) => this.Close();
                
                }
                this.Hide();
            
                
            }
            else
            {
                MessageBox.Show("Invalid Username/Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.StartPosition = FormStartPosition.CenterScreen;
            signInForm.Show();
        }

        private bool IsFieldsEmpty()
        {

            if(tbUsername.Text == "Username" || tbPassword.Text == "Password")
            {
                MessageBox.Show("Please Fill The Empty Fields!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }


    }
}
