namespace SW_ConsultingAttendenceApp_FirstTrial_.Forms
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVerificationCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.timvcode = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSignIn.FlatAppearance.BorderSize = 100;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignIn.Location = new System.Drawing.Point(345, 362);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(118, 34);
            this.btnSignIn.TabIndex = 16;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(370, 185);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(171, 22);
            this.tbPassword.TabIndex = 15;
            this.tbPassword.Text = "Password";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbUsername.Location = new System.Drawing.Point(370, 146);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(171, 22);
            this.tbUsername.TabIndex = 13;
            this.tbUsername.Text = "Username";
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(254, 145);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(90, 22);
            this.lbUsername.TabIndex = 12;
            this.lbUsername.Text = "Username";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.swconsultingLogo;
            this.pbLogo.Location = new System.Drawing.Point(261, 22);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(85, 84);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // lbSignIn
            // 
            this.lbSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignIn.Location = new System.Drawing.Point(352, 34);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(111, 48);
            this.lbSignIn.TabIndex = 10;
            this.lbSignIn.Text = "Sign In";
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.ForeColor = System.Drawing.Color.Silver;
            this.tbEmail.Location = new System.Drawing.Point(372, 224);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(171, 22);
            this.tbEmail.TabIndex = 18;
            this.tbEmail.Text = "Email";
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email";
            // 
            // tbVerificationCode
            // 
            this.tbVerificationCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbVerificationCode.ForeColor = System.Drawing.Color.Silver;
            this.tbVerificationCode.Location = new System.Drawing.Point(370, 300);
            this.tbVerificationCode.Name = "tbVerificationCode";
            this.tbVerificationCode.Size = new System.Drawing.Size(171, 22);
            this.tbVerificationCode.TabIndex = 20;
            this.tbVerificationCode.Text = "Verification Code";
            this.tbVerificationCode.Enter += new System.EventHandler(this.tbVerificationCode_Enter);
            this.tbVerificationCode.Leave += new System.EventHandler(this.tbVerificationCode_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Confirmation Code";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Location = new System.Drawing.Point(457, 252);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timvcode
            // 
            this.timvcode.Enabled = true;
            this.timvcode.Interval = 1000;
            this.timvcode.Tick += new System.EventHandler(this.timvcode_Tick);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbVerificationCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lbSignIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignInForm";
            this.Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbSignIn;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVerificationCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timvcode;
    }
}