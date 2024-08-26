using System;
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
           

        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            //Color gray = Color.Gray;
            //Pen pen = new Pen(gray);
            //pen.Width = 2;
            //pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            //pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            
            //Point StartPoint = new Point(420, 30);
            //Point EndPoint = new Point(420, 330);

            //e.Graphics.DrawLine(pen, StartPoint, EndPoint);
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
            }
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
        
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

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
                tbPassword.Text = "";
                tbUsername.Text = "";
                tbUsername_Leave(sender, e);
                textBox1_Leave(sender, e);
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
    }
}
