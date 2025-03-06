namespace A2_Coursework
{
    partial class NewCustomer
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
            label1 = new Label();
            txtbFirstname = new TextBox();
            panel1 = new Panel();
            cmbGender = new ComboBox();
            dtPicker = new DateTimePicker();
            Add = new Label();
            txtbAddressTwo = new TextBox();
            txtbEmail = new TextBox();
            label6 = new Label();
            txtbAddressOne = new TextBox();
            label5 = new Label();
            txtbSurname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(50, 55, 59);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(466, 444);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(141, 53);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(222, 46);
            label1.Name = "label1";
            label1.Size = new Size(159, 45);
            label1.TabIndex = 1;
            label1.Text = "Firstname";
            // 
            // txtbFirstname
            // 
            txtbFirstname.Font = new Font("Segoe UI", 24F);
            txtbFirstname.Location = new Point(387, 46);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(326, 50);
            txtbFirstname.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(dtPicker);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(txtbAddressTwo);
            panel1.Controls.Add(txtbEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtbAddressOne);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtbSurname);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtbFirstname);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(100, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 570);
            panel1.TabIndex = 3;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 20F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(387, 218);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(326, 45);
            cmbGender.TabIndex = 3;
            // 
            // dtPicker
            // 
            dtPicker.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPicker.Location = new Point(387, 158);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(326, 50);
            dtPicker.TabIndex = 2;
            // 
            // Add
            // 
            Add.AutoSize = true;
            Add.Font = new Font("Segoe UI", 24F);
            Add.Location = new Point(115, 332);
            Add.Name = "Add";
            Add.Size = new Size(257, 45);
            Add.TabIndex = 14;
            Add.Text = "Address line two";
            // 
            // txtbAddressTwo
            // 
            txtbAddressTwo.Font = new Font("Segoe UI", 24F);
            txtbAddressTwo.Location = new Point(387, 332);
            txtbAddressTwo.Name = "txtbAddressTwo";
            txtbAddressTwo.Size = new Size(326, 50);
            txtbAddressTwo.TabIndex = 5;
            // 
            // txtbEmail
            // 
            txtbEmail.Font = new Font("Segoe UI", 24F);
            txtbEmail.Location = new Point(387, 388);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(326, 50);
            txtbEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F);
            label6.Location = new Point(276, 388);
            label6.Name = "label6";
            label6.Size = new Size(96, 45);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // txtbAddressOne
            // 
            txtbAddressOne.Font = new Font("Segoe UI", 24F);
            txtbAddressOne.Location = new Point(387, 274);
            txtbAddressOne.Name = "txtbAddressOne";
            txtbAddressOne.Size = new Size(326, 50);
            txtbAddressOne.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24F);
            label5.Location = new Point(107, 277);
            label5.Name = "label5";
            label5.Size = new Size(258, 45);
            label5.TabIndex = 9;
            label5.Text = "Address line one";
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 24F);
            txtbSurname.Location = new Point(387, 102);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(326, 50);
            txtbSurname.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(248, 214);
            label4.Name = "label4";
            label4.Size = new Size(124, 45);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F);
            label3.Location = new Point(173, 158);
            label3.Name = "label3";
            label3.Size = new Size(199, 45);
            label3.TabIndex = 5;
            label3.Text = "Date of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(227, 102);
            label2.Name = "label2";
            label2.Size = new Size(145, 45);
            label2.TabIndex = 3;
            label2.Text = "Surname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold);
            label7.Location = new Point(480, 9);
            label7.Name = "label7";
            label7.Size = new Size(344, 65);
            label7.TabIndex = 18;
            label7.Text = "Add Customer";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(71, 867);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(48, 237);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(1297, 515);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(255, 33);
            flowLayoutPanel2.TabIndex = 21;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1390, 922);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NewCustomer";
            Text = "NewCustomer";
            Load += NewCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label label1;
        private TextBox txtbFirstname;
        private Panel panel1;
        private TextBox txtbEmail;
        private Label label6;
        private TextBox txtbAddressOne;
        private Label label5;
        private TextBox txtbSurname;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Add;
        private TextBox txtbAddressTwo;
        private DateTimePicker dtPicker;
        private ComboBox cmbGender;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}