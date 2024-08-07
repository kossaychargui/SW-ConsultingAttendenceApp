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
            Color gray = Color.Gray;
            Pen pen = new Pen(gray);
            pen.Width = 2;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            Point StartPoint = new Point(420, 30);
            Point EndPoint = new Point(420, 330);

            e.Graphics.DrawLine(pen, StartPoint, EndPoint);
        }

 
    }
}
