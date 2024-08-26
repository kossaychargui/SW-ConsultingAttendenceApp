namespace SW_ConsultingAttendenceApp_FirstTrial_
{
    partial class ReportsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDailyRange = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.rbWeakly = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cbFullNames = new System.Windows.Forms.ComboBox();
            this.btnExportToPdf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportToPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Attendence Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 286);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDailyRange);
            this.groupBox1.Controls.Add(this.rbMonthly);
            this.groupBox1.Controls.Add(this.rbDaily);
            this.groupBox1.Controls.Add(this.rbWeakly);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Period";
            // 
            // rbDailyRange
            // 
            this.rbDailyRange.AutoSize = true;
            this.rbDailyRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDailyRange.Location = new System.Drawing.Point(109, 65);
            this.rbDailyRange.Name = "rbDailyRange";
            this.rbDailyRange.Size = new System.Drawing.Size(101, 20);
            this.rbDailyRange.TabIndex = 6;
            this.rbDailyRange.Text = "Date Range";
            this.rbDailyRange.UseVisualStyleBackColor = true;
            this.rbDailyRange.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMonthly.Location = new System.Drawing.Point(109, 31);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(74, 20);
            this.rbMonthly.TabIndex = 5;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Checked = true;
            this.rbDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDaily.Location = new System.Drawing.Point(6, 31);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(59, 20);
            this.rbDaily.TabIndex = 3;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            this.rbDaily.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // rbWeakly
            // 
            this.rbWeakly.AutoSize = true;
            this.rbWeakly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWeakly.Location = new System.Drawing.Point(6, 65);
            this.rbWeakly.Name = "rbWeakly";
            this.rbWeakly.Size = new System.Drawing.Size(74, 20);
            this.rbWeakly.TabIndex = 4;
            this.rbWeakly.Text = "Weakly";
            this.rbWeakly.UseVisualStyleBackColor = true;
            this.rbWeakly.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(490, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // cbFullNames
            // 
            this.cbFullNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFullNames.FormattingEnabled = true;
            this.cbFullNames.Location = new System.Drawing.Point(841, 99);
            this.cbFullNames.Name = "cbFullNames";
            this.cbFullNames.Size = new System.Drawing.Size(180, 24);
            this.cbFullNames.TabIndex = 5;
            this.cbFullNames.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbFullNames.Click += new System.EventHandler(this.cbFullNames_Click);
            // 
            // btnExportToPdf
            // 
            this.btnExportToPdf.Image = global::SW_ConsultingAttendenceApp_FirstTrial_.Properties.Resources.icons8_print_100;
            this.btnExportToPdf.Location = new System.Drawing.Point(966, 10);
            this.btnExportToPdf.Name = "btnExportToPdf";
            this.btnExportToPdf.Size = new System.Drawing.Size(55, 48);
            this.btnExportToPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExportToPdf.TabIndex = 32;
            this.btnExportToPdf.TabStop = false;
            this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
            // 
            // ReportsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.btnExportToPdf);
            this.Controls.Add(this.cbFullNames);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ReportsUserControl";
            this.Size = new System.Drawing.Size(1043, 462);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExportToPdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.RadioButton rbWeakly;
        private System.Windows.Forms.RadioButton rbDailyRange;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cbFullNames;
        private System.Windows.Forms.PictureBox btnExportToPdf;
    }
}
