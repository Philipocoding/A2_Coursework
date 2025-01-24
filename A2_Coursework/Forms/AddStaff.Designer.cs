namespace A2_Coursework
{
    partial class AddStaff
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
            btnSubmit = new Button();
            txtbFirstname = new TextBox();
            Firstname = new Label();
            label2 = new Label();
            txtbAge = new TextBox();
            label3 = new Label();
            txtbSurname = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtbHourlyRate = new TextBox();
            label6 = new Label();
            cmbGender = new ComboBox();
            cmbTeamNo = new ComboBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(442, 414);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(133, 52);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtbFirstname
            // 
            txtbFirstname.Font = new Font("Segoe UI", 24F);
            txtbFirstname.Location = new Point(293, 49);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(282, 50);
            txtbFirstname.TabIndex = 1;
            // 
            // Firstname
            // 
            Firstname.AutoSize = true;
            Firstname.Font = new Font("Segoe UI", 24F);
            Firstname.Location = new Point(128, 54);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(159, 45);
            Firstname.TabIndex = 2;
            Firstname.Text = "Firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(132, 108);
            label2.Name = "label2";
            label2.Size = new Size(145, 45);
            label2.TabIndex = 4;
            label2.Text = "Surname";
            // 
            // txtbAge
            // 
            txtbAge.Font = new Font("Segoe UI", 24F);
            txtbAge.Location = new Point(293, 160);
            txtbAge.Name = "txtbAge";
            txtbAge.Size = new Size(282, 50);
            txtbAge.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(197, 160);
            label3.Name = "label3";
            label3.Size = new Size(77, 45);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 24F);
            txtbSurname.Location = new Point(293, 105);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(282, 50);
            txtbSurname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(150, 219);
            label4.Name = "label4";
            label4.Size = new Size(124, 45);
            label4.TabIndex = 8;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F);
            label5.Location = new Point(109, 278);
            label5.Name = "label5";
            label5.Size = new Size(178, 45);
            label5.TabIndex = 10;
            label5.Text = "Hourly rate";
            // 
            // txtbHourlyRate
            // 
            txtbHourlyRate.Font = new Font("Segoe UI", 24F);
            txtbHourlyRate.Location = new Point(293, 275);
            txtbHourlyRate.Name = "txtbHourlyRate";
            txtbHourlyRate.Size = new Size(282, 50);
            txtbHourlyRate.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F);
            label6.Location = new Point(72, 336);
            label6.Name = "label6";
            label6.Size = new Size(215, 45);
            label6.TabIndex = 12;
            label6.Text = "Team number";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(293, 221);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(282, 48);
            cmbGender.TabIndex = 13;
            // 
            // cmbTeamNo
            // 
            cmbTeamNo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTeamNo.FormattingEnabled = true;
            cmbTeamNo.Items.AddRange(new object[] { "1", "2", "3" });
            cmbTeamNo.Location = new Point(293, 333);
            cmbTeamNo.Name = "cmbTeamNo";
            cmbTeamNo.Size = new Size(282, 48);
            cmbTeamNo.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(txtbFirstname);
            panel1.Controls.Add(cmbTeamNo);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(Firstname);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtbAge);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtbHourlyRate);
            panel1.Controls.Add(txtbSurname);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(272, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 478);
            panel1.TabIndex = 15;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1197, 756);
            Controls.Add(panel1);
            Name = "AddStaff";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSubmit;
        private TextBox txtbFirstname;
        private Label Firstname;
        private Label label2;
        private TextBox txtbAge;
        private Label label3;
        private TextBox txtbSurname;
        private Label label4;
        private Label label5;
        private TextBox txtbHourlyRate;
        private Label label6;
        private ComboBox cmbGender;
        private ComboBox cmbTeamNo;
        private Panel panel1;
    }
}