using ServiceStack;
using SW_ConsultingAttendenceApp_FirstTrial_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_ConsultingAttendenceApp_FirstTrial_.Forms
{
    public partial class SignInForm : Form
    {
        private Region GetRoundedImagePictureBox(PictureBox pictureBox)
        {
            GraphicsPath graphicspath = new GraphicsPath();
            graphicspath.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            Region rgn = new Region(graphicspath);
            return rgn;
        }
        public SignInForm()
        {
            InitializeComponent();
        }

        private int vcode = 1000;
        private ErrorProvider errorProviderUsername = new ErrorProvider();
        private ErrorProvider errorProviderPassword = new ErrorProvider();
        private ErrorProvider errorProviderEmail = new ErrorProvider();
        private ErrorProvider errorProviderVerificationCode = new ErrorProvider();
        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
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
            if (tbUsername.Text == "Username")
            {
                errorProviderUsername.SetError(tbUsername, "Username Required");
                return;
            }
            else
                errorProviderUsername.Clear();


        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
                tbPassword.PasswordChar = '*';

            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Silver;
                tbPassword.PasswordChar = '\0';

            }
            if (tbPassword.Text == "Password")
            {
                errorProviderPassword.SetError(tbPassword, "Password Required");
            }
            else
                errorProviderPassword.Clear();
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if(tbEmail.Text == "Email")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;

            }
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if(tbEmail.Text == "")
            {
                tbEmail.Text = "Email";
                tbEmail.ForeColor = Color.Silver;
            }
            if(tbEmail.Text == "Email")
            {
                errorProviderEmail.SetError(tbEmail, "Email Required!");
            }
            else
                errorProviderEmail.Clear();
        }

        private void tbVerificationCode_Enter(object sender, EventArgs e)
        {
            if(tbVerificationCode.Text == "Verification Code")
            {
                tbVerificationCode.Text = "";
                tbVerificationCode.ForeColor = Color.Black;
            }
        }

        private void tbVerificationCode_Leave(object sender, EventArgs e)
        {
            if(tbVerificationCode.Text == "")
            {
                tbVerificationCode.Text = "Verification Code";
                tbVerificationCode.ForeColor = Color.Silver;
            }
            if (tbVerificationCode.Text == "Verification Code")
            {
                errorProviderVerificationCode.SetError(tbVerificationCode, "Verification Code Required!");
            }
            else
                errorProviderVerificationCode.Clear();
        }

       

        private void timvcode_Tick(object sender, EventArgs e)
        {
            vcode += 10;
            if(vcode > 9999)
            {
                vcode = 1000;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Please Fill All the Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            timvcode.Stop(); 

            string to = tbEmail.Text; 
            string from = "kossay134@gmail.com";
            string pass = "kslm szke hmjn wdxr";// My application password
            string mail = vcode.ToString(); 

            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Subject = "SW-Consulting - Verification Code";
            mailMessage.Body = $"Your verification code is: {mail}";
            mailMessage.IsBodyHtml = false; // Set to true if you're sending HTML content

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(mailMessage);
                MessageBox.Show("Verification Code sent successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            if (tbVerificationCode.Text == vcode.ToString())
            {
                //clsUser user = getUser(tbEmail.Text);
                //user.Username = tbUsername.Text;
                //user.Password = tbPassword.Text;
                //save to data base;
                clsUser user = clsUsersData.GetUserByEmail(tbEmail.Text);
                user.Username = tbUsername.Text;
                user.Password = tbPassword.Text;
                if (clsUsersData.UpdateUser(user))
                    MessageBox.Show("You are sign in successfully", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed Updating User Authentication Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
               
            }
        }
        private bool CheckEmptyFields()
        {
            return (tbUsername.Text == "Username" || tbPassword.Text == "Password" || tbEmail.Text == "Email");
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            pbLogo.Region = GetRoundedImagePictureBox(pbLogo);
  
        }
    }

    
}
