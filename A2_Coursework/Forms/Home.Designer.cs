namespace A2_Coursework
{
    partial class Home
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label14 = new Label();
            label11 = new Label();
            panel7 = new Panel();
            label3 = new Label();
            label7 = new Label();
            lblBusyMonth = new Label();
            lblCustomers = new Label();
            lblLeastMonth = new Label();
            label8 = new Label();
            label10 = new Label();
            lblStaff = new Label();
            panel8 = new Panel();
            label4 = new Label();
            pictureBox9 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            lblYear = new Label();
            lblYearRevenue = new Label();
            label6 = new Label();
            panel5 = new Panel();
            lblRevenueMonth = new Label();
            label9 = new Label();
            lblMonth = new Label();
            label5 = new Label();
            panel6 = new Panel();
            label13 = new Label();
            lblWeek = new Label();
            lblWeekRevenue = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(1402, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 32);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(523, 799);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 234);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox9);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1253, 876);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("MV Boli", 30F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(523, 272);
            label14.Name = "label14";
            label14.Size = new Size(209, 52);
            label14.TabIndex = 36;
            label14.Text = "Statistics";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("MV Boli", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(326, 149);
            label11.Name = "label11";
            label11.Size = new Size(662, 85);
            label11.TabIndex = 34;
            label11.Text = "Welcome to Movers!";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(lblBusyMonth);
            panel7.Controls.Add(lblCustomers);
            panel7.Controls.Add(lblLeastMonth);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(lblStaff);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(424, 652);
            panel7.Name = "panel7";
            panel7.Size = new Size(423, 208);
            panel7.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(78, 66);
            label3.Name = "label3";
            label3.Size = new Size(249, 28);
            label3.TabIndex = 13;
            label3.Text = "Month with least bookings:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(74, 19);
            label7.Name = "label7";
            label7.Size = new Size(253, 28);
            label7.TabIndex = 11;
            label7.Text = "Month with most bookings:";
            // 
            // lblBusyMonth
            // 
            lblBusyMonth.AutoSize = true;
            lblBusyMonth.Font = new Font("Segoe UI", 15F);
            lblBusyMonth.Location = new Point(322, 21);
            lblBusyMonth.Name = "lblBusyMonth";
            lblBusyMonth.Size = new Size(23, 28);
            lblBusyMonth.TabIndex = 12;
            lblBusyMonth.Text = "0";
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.BackColor = Color.FromArgb(135, 195, 255);
            lblCustomers.Font = new Font("Segoe UI", 15F);
            lblCustomers.Location = new Point(322, 160);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(23, 28);
            lblCustomers.TabIndex = 18;
            lblCustomers.Text = "0";
            // 
            // lblLeastMonth
            // 
            lblLeastMonth.AutoSize = true;
            lblLeastMonth.Font = new Font("Segoe UI", 15F);
            lblLeastMonth.Location = new Point(322, 66);
            lblLeastMonth.Name = "lblLeastMonth";
            lblLeastMonth.Size = new Size(23, 28);
            lblLeastMonth.TabIndex = 14;
            lblLeastMonth.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(135, 195, 255);
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(120, 160);
            label8.Name = "label8";
            label8.Size = new Size(205, 28);
            label8.TabIndex = 17;
            label8.Text = "Number of customers:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(135, 195, 255);
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(170, 113);
            label10.Name = "label10";
            label10.Size = new Size(155, 28);
            label10.TabIndex = 15;
            label10.Text = "Number of Staff:";
            // 
            // lblStaff
            // 
            lblStaff.AutoSize = true;
            lblStaff.BackColor = Color.FromArgb(135, 195, 255);
            lblStaff.Font = new Font("Segoe UI", 15F);
            lblStaff.Location = new Point(322, 113);
            lblStaff.Name = "lblStaff";
            lblStaff.Size = new Size(23, 28);
            lblStaff.TabIndex = 16;
            lblStaff.Text = "0";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(135, 195, 255);
            panel8.Location = new Point(0, 104);
            panel8.Name = "panel8";
            panel8.Size = new Size(423, 104);
            panel8.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(69, 90, 100);
            label4.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(588, 697);
            label4.Name = "label4";
            label4.Size = new Size(109, 38);
            label4.TabIndex = 32;
            label4.Text = "Movers";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.LogoTransparent__1_;
            pictureBox9.Location = new Point(1024, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(191, 168);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 31;
            pictureBox9.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(544, 25);
            label1.Name = "label1";
            label1.Size = new Size(212, 86);
            label1.TabIndex = 0;
            label1.Text = "Home";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightBlue;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(lblYear);
            panel4.Controls.Add(lblYearRevenue);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(424, 341);
            panel4.Name = "panel4";
            panel4.Size = new Size(423, 104);
            panel4.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightBlue;
            label12.Font = new Font("Segoe UI", 15F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(114, 59);
            label12.Name = "label12";
            label12.Size = new Size(210, 28);
            label12.TabIndex = 19;
            label12.Text = "Revenue for the year: £";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.BackColor = Color.LightBlue;
            lblYear.Font = new Font("Segoe UI", 15F);
            lblYear.ForeColor = Color.Black;
            lblYear.Location = new Point(303, 17);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(23, 28);
            lblYear.TabIndex = 8;
            lblYear.Text = "0";
            // 
            // lblYearRevenue
            // 
            lblYearRevenue.AutoSize = true;
            lblYearRevenue.BackColor = Color.LightBlue;
            lblYearRevenue.Font = new Font("Segoe UI", 15F);
            lblYearRevenue.ForeColor = Color.Black;
            lblYearRevenue.Location = new Point(319, 59);
            lblYearRevenue.Name = "lblYearRevenue";
            lblYearRevenue.Size = new Size(23, 28);
            lblYearRevenue.TabIndex = 20;
            lblYearRevenue.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightBlue;
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(7, 17);
            label6.Name = "label6";
            label6.Size = new Size(303, 28);
            label6.TabIndex = 7;
            label6.Text = "Number of bookings for the year:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(lblRevenueMonth);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(lblMonth);
            panel5.Controls.Add(label5);
            panel5.ForeColor = Color.Gainsboro;
            panel5.Location = new Point(424, 445);
            panel5.Name = "panel5";
            panel5.Size = new Size(423, 104);
            panel5.TabIndex = 30;
            // 
            // lblRevenueMonth
            // 
            lblRevenueMonth.AutoSize = true;
            lblRevenueMonth.BackColor = Color.Gainsboro;
            lblRevenueMonth.Font = new Font("Segoe UI", 15F);
            lblRevenueMonth.ForeColor = Color.Black;
            lblRevenueMonth.Location = new Point(332, 59);
            lblRevenueMonth.Name = "lblRevenueMonth";
            lblRevenueMonth.Size = new Size(23, 28);
            lblRevenueMonth.TabIndex = 22;
            lblRevenueMonth.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Gainsboro;
            label9.Font = new Font("Segoe UI", 15F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(109, 59);
            label9.Name = "label9";
            label9.Size = new Size(231, 28);
            label9.TabIndex = 21;
            label9.Text = "Revenue for the month: £";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.BackColor = Color.Gainsboro;
            lblMonth.Font = new Font("Segoe UI", 15F);
            lblMonth.ForeColor = Color.Black;
            lblMonth.Location = new Point(320, 16);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new Size(23, 28);
            lblMonth.TabIndex = 10;
            lblMonth.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Segoe UI", 15F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 16);
            label5.Name = "label5";
            label5.Size = new Size(324, 28);
            label5.TabIndex = 6;
            label5.Text = "Number of bookings for the month:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label13);
            panel6.Controls.Add(lblWeek);
            panel6.Controls.Add(lblWeekRevenue);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(424, 548);
            panel6.Name = "panel6";
            panel6.Size = new Size(423, 104);
            panel6.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI", 15F);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(118, 58);
            label13.Name = "label13";
            label13.Size = new Size(201, 28);
            label13.TabIndex = 23;
            label13.Text = "Revenue for the week:";
            // 
            // lblWeek
            // 
            lblWeek.AutoSize = true;
            lblWeek.BackColor = Color.White;
            lblWeek.Font = new Font("Segoe UI", 17.25F);
            lblWeek.ForeColor = Color.Black;
            lblWeek.Location = new Point(314, 15);
            lblWeek.Name = "lblWeek";
            lblWeek.Size = new Size(26, 31);
            lblWeek.TabIndex = 9;
            lblWeek.Text = "0";
            // 
            // lblWeekRevenue
            // 
            lblWeekRevenue.AutoSize = true;
            lblWeekRevenue.BackColor = Color.White;
            lblWeekRevenue.Font = new Font("Segoe UI", 15F);
            lblWeekRevenue.ForeColor = Color.Black;
            lblWeekRevenue.Location = new Point(314, 58);
            lblWeekRevenue.Name = "lblWeekRevenue";
            lblWeekRevenue.Size = new Size(23, 28);
            lblWeekRevenue.TabIndex = 24;
            lblWeekRevenue.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 15);
            label2.Name = "label2";
            label2.Size = new Size(310, 28);
            label2.TabIndex = 3;
            label2.Text = "Number of bookings for the week:";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1479, 931);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label7;
        private Label lblMonth;
        private Label lblWeek;
        private Label lblYear;
        private Label lblCustomers;
        private Label label8;
        private Label lblStaff;
        private Label label10;
        private Label lblLeastMonth;
        private Label label3;
        private Label lblBusyMonth;
        private Label lblWeekRevenue;
        private Label label13;
        private Label lblRevenueMonth;
        private Label label9;
        private Label lblYearRevenue;
        private Label label12;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label label4;
        private PictureBox pictureBox9;
        private Label label11;
        private Label label14;
        private Panel panel8;
    }
}