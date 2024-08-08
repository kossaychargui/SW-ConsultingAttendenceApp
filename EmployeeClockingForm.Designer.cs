namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    partial class EmployeeClockingForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbClock = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.roundedButton1 = new SW_ConsultingAttendenceApp_FirstTrial_.RoundedButton();
            this.roundedButton2 = new SW_ConsultingAttendenceApp_FirstTrial_.RoundedButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.Location = new System.Drawing.Point(428, 59);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(115, 33);
            this.lbClock.TabIndex = 0;
            this.lbClock.Text = "00:00:00";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(415, 92);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(67, 33);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date";
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.roundedButton1.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundedButton1.ButtonColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.roundedButton1.FlatAppearance.BorderSize = 11;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.Location = new System.Drawing.Point(107, 73);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.OnHoverBorderColor = System.Drawing.Color.PaleTurquoise;
            this.roundedButton1.OnHoverButtonColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundedButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButton1.Size = new System.Drawing.Size(180, 94);
            this.roundedButton1.TabIndex = 2;
            this.roundedButton1.Text = "ClockIn";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.MouseHover += new System.EventHandler(this.roundedButton1_MouseHover);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.roundedButton2.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundedButton2.ButtonColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundedButton2.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.roundedButton2.FlatAppearance.BorderSize = 11;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.Location = new System.Drawing.Point(694, 73);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.OnHoverBorderColor = System.Drawing.Color.PaleTurquoise;
            this.roundedButton2.OnHoverButtonColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundedButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.roundedButton2.Size = new System.Drawing.Size(180, 94);
            this.roundedButton2.TabIndex = 3;
            this.roundedButton2.Text = "ClockOut";
            this.roundedButton2.TextColor = System.Drawing.Color.White;
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // EmployeeClockingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(988, 475);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbClock);
            this.Name = "EmployeeClockingForm";
            this.Text = "EmployeeClockingForm";
            this.Load += new System.EventHandler(this.EmployeeClockingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Label lbDate;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
    }
}