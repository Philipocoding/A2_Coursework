namespace A2_Coursework
{
    partial class ViewCustomers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridCustomers = new DataGridView();
            clmCustomerID = new DataGridViewTextBoxColumn();
            clmForename = new DataGridViewTextBoxColumn();
            clmSurname = new DataGridViewTextBoxColumn();
            clmDOB = new DataGridViewTextBoxColumn();
            clmGender = new DataGridViewTextBoxColumn();
            clmAddressOne = new DataGridViewTextBoxColumn();
            clmAddressTwo = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            txtbFirstname = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            panel1 = new Panel();
            btnSave = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtbAddressTwo = new TextBox();
            txtbEmail = new TextBox();
            txtbAddressOne = new TextBox();
            txtbGender = new TextBox();
            txtbDOB = new TextBox();
            txtbSurname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridCustomers
            // 
            DataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCustomers.Columns.AddRange(new DataGridViewColumn[] { clmCustomerID, clmForename, clmSurname, clmDOB, clmGender, clmAddressOne, clmAddressTwo, clmEmail });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGridCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            DataGridCustomers.Location = new Point(-3, -3);
            DataGridCustomers.Name = "DataGridCustomers";
            DataGridCustomers.Size = new Size(1280, 292);
            DataGridCustomers.TabIndex = 0;
            DataGridCustomers.CellClick += DataGridCustomers_CellClick;
            // 
            // clmCustomerID
            // 
            clmCustomerID.HeaderText = "ID";
            clmCustomerID.Name = "clmCustomerID";
            clmCustomerID.Width = 35;
            // 
            // clmForename
            // 
            clmForename.HeaderText = "Firstname";
            clmForename.Name = "clmForename";
            clmForename.Width = 150;
            // 
            // clmSurname
            // 
            clmSurname.HeaderText = "Surname";
            clmSurname.Name = "clmSurname";
            clmSurname.Width = 150;
            // 
            // clmDOB
            // 
            clmDOB.HeaderText = "Date of Birth";
            clmDOB.Name = "clmDOB";
            clmDOB.Width = 125;
            // 
            // clmGender
            // 
            clmGender.HeaderText = "Gender";
            clmGender.Name = "clmGender";
            // 
            // clmAddressOne
            // 
            clmAddressOne.HeaderText = "Address";
            clmAddressOne.Name = "clmAddressOne";
            clmAddressOne.Width = 250;
            // 
            // clmAddressTwo
            // 
            clmAddressTwo.HeaderText = "Address";
            clmAddressTwo.Name = "clmAddressTwo";
            clmAddressTwo.Width = 150;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.Name = "clmEmail";
            clmEmail.Width = 310;
            // 
            // txtbFirstname
            // 
            txtbFirstname.Font = new Font("Segoe UI", 20F);
            txtbFirstname.Location = new Point(169, 23);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(292, 43);
            txtbFirstname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(17, 29);
            label1.Name = "label1";
            label1.Size = new Size(132, 37);
            label1.TabIndex = 2;
            label1.Text = "Firstname";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(323, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 51);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtbAddressTwo);
            panel1.Controls.Add(txtbEmail);
            panel1.Controls.Add(txtbAddressOne);
            panel1.Controls.Add(txtbGender);
            panel1.Controls.Add(txtbDOB);
            panel1.Controls.Add(txtbSurname);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtbFirstname);
            panel1.Location = new Point(5, 295);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 459);
            panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(205, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 51);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(67, 320);
            label7.Name = "label7";
            label7.Size = new Size(82, 37);
            label7.TabIndex = 15;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(38, 268);
            label6.Name = "label6";
            label6.Size = new Size(111, 37);
            label6.TabIndex = 14;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(38, 222);
            label5.Name = "label5";
            label5.Size = new Size(111, 37);
            label5.TabIndex = 13;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(45, 173);
            label4.Name = "label4";
            label4.Size = new Size(104, 37);
            label4.TabIndex = 12;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(3, 124);
            label3.Name = "label3";
            label3.Size = new Size(166, 37);
            label3.TabIndex = 11;
            label3.Text = "Date of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(28, 78);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 10;
            label2.Text = "Surname";
            // 
            // txtbAddressTwo
            // 
            txtbAddressTwo.Font = new Font("Segoe UI", 20F);
            txtbAddressTwo.Location = new Point(169, 268);
            txtbAddressTwo.Name = "txtbAddressTwo";
            txtbAddressTwo.Size = new Size(292, 43);
            txtbAddressTwo.TabIndex = 9;
            // 
            // txtbEmail
            // 
            txtbEmail.Font = new Font("Segoe UI", 20F);
            txtbEmail.Location = new Point(169, 317);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(292, 43);
            txtbEmail.TabIndex = 8;
            // 
            // txtbAddressOne
            // 
            txtbAddressOne.Font = new Font("Segoe UI", 20F);
            txtbAddressOne.Location = new Point(169, 219);
            txtbAddressOne.Name = "txtbAddressOne";
            txtbAddressOne.Size = new Size(292, 43);
            txtbAddressOne.TabIndex = 7;
            // 
            // txtbGender
            // 
            txtbGender.Font = new Font("Segoe UI", 20F);
            txtbGender.Location = new Point(169, 170);
            txtbGender.Name = "txtbGender";
            txtbGender.Size = new Size(292, 43);
            txtbGender.TabIndex = 6;
            // 
            // txtbDOB
            // 
            txtbDOB.Font = new Font("Segoe UI", 20F);
            txtbDOB.Location = new Point(169, 121);
            txtbDOB.Name = "txtbDOB";
            txtbDOB.Size = new Size(292, 43);
            txtbDOB.TabIndex = 5;
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 20F);
            txtbSurname.Location = new Point(169, 72);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(292, 43);
            txtbSurname.TabIndex = 4;
            // 
            // ViewCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 756);
            Controls.Add(panel1);
            Controls.Add(DataGridCustomers);
            Name = "ViewCustomers";
            Text = "ViewCustomers";
            Load += ViewCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridCustomers;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmForename;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn clmDOB;
        private DataGridViewTextBoxColumn clmGender;
        private DataGridViewTextBoxColumn clmAddressOne;
        private DataGridViewTextBoxColumn clmAddressTwo;
        private DataGridViewTextBoxColumn clmEmail;
        private TextBox txtbFirstname;
        private Label label1;
        private Button btnDelete;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtbAddressTwo;
        private TextBox txtbEmail;
        private TextBox txtbAddressOne;
        private TextBox txtbGender;
        private TextBox txtbDOB;
        private TextBox txtbSurname;
        private Button btnSave;
    }
}