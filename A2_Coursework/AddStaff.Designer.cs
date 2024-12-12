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
            txtbGender = new TextBox();
            label5 = new Label();
            txtbHourlyRate = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(605, 465);
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
            txtbFirstname.Location = new Point(456, 100);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(282, 50);
            txtbFirstname.TabIndex = 1;
            // 
            // Firstname
            // 
            Firstname.AutoSize = true;
            Firstname.Font = new Font("Segoe UI", 24F);
            Firstname.Location = new Point(291, 105);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(159, 45);
            Firstname.TabIndex = 2;
            Firstname.Text = "Firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(295, 159);
            label2.Name = "label2";
            label2.Size = new Size(142, 45);
            label2.TabIndex = 4;
            label2.Text = "surname";
            // 
            // txtbAge
            // 
            txtbAge.Font = new Font("Segoe UI", 24F);
            txtbAge.Location = new Point(456, 211);
            txtbAge.Name = "txtbAge";
            txtbAge.Size = new Size(282, 50);
            txtbAge.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(360, 211);
            label3.Name = "label3";
            label3.Size = new Size(77, 45);
            label3.TabIndex = 6;
            label3.Text = "Age";
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 24F);
            txtbSurname.Location = new Point(456, 156);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(282, 50);
            txtbSurname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(313, 270);
            label4.Name = "label4";
            label4.Size = new Size(124, 45);
            label4.TabIndex = 8;
            label4.Text = "Gender";
            // 
            // txtbGender
            // 
            txtbGender.Font = new Font("Segoe UI", 24F);
            txtbGender.Location = new Point(456, 270);
            txtbGender.Name = "txtbGender";
            txtbGender.Size = new Size(282, 50);
            txtbGender.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F);
            label5.Location = new Point(272, 329);
            label5.Name = "label5";
            label5.Size = new Size(178, 45);
            label5.TabIndex = 10;
            label5.Text = "Hourly rate";
            // 
            // txtbHourlyRate
            // 
            txtbHourlyRate.Font = new Font("Segoe UI", 24F);
            txtbHourlyRate.Location = new Point(456, 326);
            txtbHourlyRate.Name = "txtbHourlyRate";
            txtbHourlyRate.Size = new Size(282, 50);
            txtbHourlyRate.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F);
            label6.Location = new Point(332, 385);
            label6.Name = "label6";
            label6.Size = new Size(105, 45);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 24F);
            textBox6.Location = new Point(456, 382);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(282, 50);
            textBox6.TabIndex = 11;
            // 
            // AddStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 672);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(txtbHourlyRate);
            Controls.Add(label4);
            Controls.Add(txtbGender);
            Controls.Add(label3);
            Controls.Add(txtbSurname);
            Controls.Add(label2);
            Controls.Add(txtbAge);
            Controls.Add(Firstname);
            Controls.Add(txtbFirstname);
            Controls.Add(btnSubmit);
            Name = "AddStaff";
            Text = "AddStaff";
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox txtbGender;
        private Label label5;
        private TextBox txtbHourlyRate;
        private Label label6;
        private TextBox textBox6;
    }
}