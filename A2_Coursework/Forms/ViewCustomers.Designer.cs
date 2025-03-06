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
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
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
            pnlEdit = new Panel();
            dtPicketDOB = new DateTimePicker();
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
            txtbSurname = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            btnEdit = new Button();
            btnDeleteCustomer = new Button();
            cmbGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).BeginInit();
            pnlEdit.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridCustomers
            // 
            DataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCustomers.Columns.AddRange(new DataGridViewColumn[] { clmCustomerID, clmForename, clmSurname, clmDOB, clmGender, clmAddressOne, clmAddressTwo, clmEmail });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            DataGridCustomers.DefaultCellStyle = dataGridViewCellStyle18;
            DataGridCustomers.Location = new Point(12, 82);
            DataGridCustomers.Name = "DataGridCustomers";
            DataGridCustomers.Size = new Size(1268, 292);
            DataGridCustomers.TabIndex = 0;
            DataGridCustomers.CellClick += DataGridCustomers_CellClick;
            DataGridCustomers.CellContentClick += DataGridCustomers_CellContentClick;
            // 
            // clmCustomerID
            // 
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmCustomerID.DefaultCellStyle = dataGridViewCellStyle10;
            clmCustomerID.HeaderText = "ID";
            clmCustomerID.Name = "clmCustomerID";
            clmCustomerID.Width = 35;
            // 
            // clmForename
            // 
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmForename.DefaultCellStyle = dataGridViewCellStyle11;
            clmForename.HeaderText = "Firstname";
            clmForename.Name = "clmForename";
            clmForename.Width = 130;
            // 
            // clmSurname
            // 
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmSurname.DefaultCellStyle = dataGridViewCellStyle12;
            clmSurname.HeaderText = "Surname";
            clmSurname.Name = "clmSurname";
            clmSurname.Width = 130;
            // 
            // clmDOB
            // 
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmDOB.DefaultCellStyle = dataGridViewCellStyle13;
            clmDOB.HeaderText = "Date of Birth";
            clmDOB.Name = "clmDOB";
            clmDOB.Width = 125;
            // 
            // clmGender
            // 
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmGender.DefaultCellStyle = dataGridViewCellStyle14;
            clmGender.HeaderText = "Gender";
            clmGender.Name = "clmGender";
            // 
            // clmAddressOne
            // 
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmAddressOne.DefaultCellStyle = dataGridViewCellStyle15;
            clmAddressOne.HeaderText = "Address";
            clmAddressOne.Name = "clmAddressOne";
            clmAddressOne.Width = 200;
            // 
            // clmAddressTwo
            // 
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmAddressTwo.DefaultCellStyle = dataGridViewCellStyle16;
            clmAddressTwo.HeaderText = "Address";
            clmAddressTwo.Name = "clmAddressTwo";
            clmAddressTwo.Width = 150;
            // 
            // clmEmail
            // 
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmEmail.DefaultCellStyle = dataGridViewCellStyle17;
            clmEmail.HeaderText = "Email";
            clmEmail.Name = "clmEmail";
            clmEmail.Width = 360;
            // 
            // txtbFirstname
            // 
            txtbFirstname.Font = new Font("Segoe UI", 20F);
            txtbFirstname.Location = new Point(169, 23);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(371, 43);
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
            // pnlEdit
            // 
            pnlEdit.Controls.Add(cmbGender);
            pnlEdit.Controls.Add(dtPicketDOB);
            pnlEdit.Controls.Add(btnSave);
            pnlEdit.Controls.Add(label7);
            pnlEdit.Controls.Add(label6);
            pnlEdit.Controls.Add(label5);
            pnlEdit.Controls.Add(label4);
            pnlEdit.Controls.Add(label3);
            pnlEdit.Controls.Add(label2);
            pnlEdit.Controls.Add(txtbAddressTwo);
            pnlEdit.Controls.Add(txtbEmail);
            pnlEdit.Controls.Add(txtbAddressOne);
            pnlEdit.Controls.Add(txtbSurname);
            pnlEdit.Controls.Add(label1);
            pnlEdit.Controls.Add(txtbFirstname);
            pnlEdit.Location = new Point(328, 437);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(551, 459);
            pnlEdit.TabIndex = 4;
            pnlEdit.Visible = false;
            // 
            // dtPicketDOB
            // 
            dtPicketDOB.Font = new Font("Segoe UI", 20F);
            dtPicketDOB.Location = new Point(169, 121);
            dtPicketDOB.Name = "dtPicketDOB";
            dtPicketDOB.Size = new Size(371, 43);
            dtPicketDOB.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(50, 55, 59);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(270, 366);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 51);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
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
            txtbAddressTwo.Size = new Size(371, 43);
            txtbAddressTwo.TabIndex = 9;
            // 
            // txtbEmail
            // 
            txtbEmail.Font = new Font("Segoe UI", 20F);
            txtbEmail.Location = new Point(169, 317);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(371, 43);
            txtbEmail.TabIndex = 8;
            // 
            // txtbAddressOne
            // 
            txtbAddressOne.Font = new Font("Segoe UI", 20F);
            txtbAddressOne.Location = new Point(169, 219);
            txtbAddressOne.Name = "txtbAddressOne";
            txtbAddressOne.Size = new Size(371, 43);
            txtbAddressOne.TabIndex = 7;
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 20F);
            txtbSurname.Location = new Point(169, 72);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(371, 43);
            txtbSurname.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(328, 850);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 221);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Location = new Point(1201, 512);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 25);
            panel3.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold);
            label8.Location = new Point(443, 9);
            label8.Name = "label8";
            label8.Size = new Size(452, 65);
            label8.TabIndex = 17;
            label8.Text = "Manage Customers";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(85, 193, 255);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(637, 380);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(261, 51);
            btnEdit.TabIndex = 23;
            btnEdit.Text = "Edit customer";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.FromArgb(85, 193, 255);
            btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            btnDeleteCustomer.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomer.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteCustomer.ForeColor = Color.Black;
            btnDeleteCustomer.Location = new Point(370, 380);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(261, 51);
            btnDeleteCustomer.TabIndex = 24;
            btnDeleteCustomer.Text = "Delete customer";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 20F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(169, 170);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(371, 45);
            cmbGender.TabIndex = 26;
            // 
            // ViewCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1414, 867);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnEdit);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlEdit);
            Controls.Add(DataGridCustomers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewCustomers";
            Text = "ViewCustomers";
            Load += ViewCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).EndInit();
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridCustomers;
        private TextBox txtbFirstname;
        private Label label1;
        private Button btnDelete;
        private Panel pnlEdit;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtbAddressTwo;
        private TextBox txtbEmail;
        private TextBox txtbAddressOne;
        private TextBox txtbSurname;
        private Button btnSave;
        private Panel panel2;
        private Panel panel3;
        private Label label8;
        private Button btnEdit;
        private Button btnDeleteCustomer;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmForename;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn clmDOB;
        private DataGridViewTextBoxColumn clmGender;
        private DataGridViewTextBoxColumn clmAddressOne;
        private DataGridViewTextBoxColumn clmAddressTwo;
        private DataGridViewTextBoxColumn clmEmail;
        private DateTimePicker dtPicketDOB;
        private ComboBox cmbGender;
    }
}