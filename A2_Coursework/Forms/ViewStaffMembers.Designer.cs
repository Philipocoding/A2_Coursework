namespace A2_Coursework
{
    partial class ViewStaffMembers
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
            DataGridStaff = new DataGridView();
            clmStaffID = new DataGridViewTextBoxColumn();
            clmFirstname = new DataGridViewTextBoxColumn();
            clmSurname = new DataGridViewTextBoxColumn();
            clmGender = new DataGridViewTextBoxColumn();
            clmAge = new DataGridViewTextBoxColumn();
            clmHourlyRate = new DataGridViewTextBoxColumn();
            clmTeamNo = new DataGridViewTextBoxColumn();
            pnlDetails = new Panel();
            cmbTeamNo = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            Firstname = new Label();
            btnSave = new Button();
            panel1 = new Panel();
            label1 = new Label();
            txtbSurname = new TextBox();
            txtbGender = new TextBox();
            txtbAge = new TextBox();
            txtbHourlyRate = new TextBox();
            txtbFirstname = new TextBox();
            panel3 = new Panel();
            label7 = new Label();
            btnDeleteCustomer = new Button();
            btnEditStaffMember = new Button();
            label9 = new Label();
            btnSearch = new Button();
            txtbSearch = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridStaff).BeginInit();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridStaff
            // 
            DataGridStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridStaff.Columns.AddRange(new DataGridViewColumn[] { clmStaffID, clmFirstname, clmSurname, clmGender, clmAge, clmHourlyRate, clmTeamNo });
            DataGridStaff.Location = new Point(249, 151);
            DataGridStaff.Name = "DataGridStaff";
            DataGridStaff.Size = new Size(745, 304);
            DataGridStaff.TabIndex = 0;
            DataGridStaff.CellClick += DataGridStaff_CellClick;
            DataGridStaff.CellContentClick += DataGridStaff_CellContentClick;
            // 
            // clmStaffID
            // 
            clmStaffID.HeaderText = "StaffID";
            clmStaffID.Name = "clmStaffID";
            clmStaffID.ReadOnly = true;
            // 
            // clmFirstname
            // 
            clmFirstname.HeaderText = "Firstname";
            clmFirstname.Name = "clmFirstname";
            clmFirstname.ReadOnly = true;
            // 
            // clmSurname
            // 
            clmSurname.HeaderText = "Surname";
            clmSurname.Name = "clmSurname";
            clmSurname.ReadOnly = true;
            // 
            // clmGender
            // 
            clmGender.HeaderText = "Gender";
            clmGender.Name = "clmGender";
            clmGender.ReadOnly = true;
            // 
            // clmAge
            // 
            clmAge.HeaderText = "Age";
            clmAge.Name = "clmAge";
            clmAge.ReadOnly = true;
            // 
            // clmHourlyRate
            // 
            clmHourlyRate.HeaderText = "Hourly Rate";
            clmHourlyRate.Name = "clmHourlyRate";
            clmHourlyRate.ReadOnly = true;
            // 
            // clmTeamNo
            // 
            clmTeamNo.HeaderText = "TeamNo";
            clmTeamNo.Name = "clmTeamNo";
            clmTeamNo.ReadOnly = true;
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(cmbTeamNo);
            pnlDetails.Controls.Add(label5);
            pnlDetails.Controls.Add(label4);
            pnlDetails.Controls.Add(label3);
            pnlDetails.Controls.Add(label6);
            pnlDetails.Controls.Add(label2);
            pnlDetails.Controls.Add(Firstname);
            pnlDetails.Controls.Add(btnSave);
            pnlDetails.Controls.Add(label1);
            pnlDetails.Controls.Add(txtbSurname);
            pnlDetails.Controls.Add(txtbGender);
            pnlDetails.Controls.Add(txtbAge);
            pnlDetails.Controls.Add(txtbHourlyRate);
            pnlDetails.Controls.Add(txtbFirstname);
            pnlDetails.Location = new Point(384, 518);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(425, 386);
            pnlDetails.TabIndex = 17;
            pnlDetails.Visible = false;
            // 
            // cmbTeamNo
            // 
            cmbTeamNo.Font = new Font("Segoe UI", 20F);
            cmbTeamNo.FormattingEnabled = true;
            cmbTeamNo.Items.AddRange(new object[] { "1", "2", "3" });
            cmbTeamNo.Location = new Point(144, 262);
            cmbTeamNo.Name = "cmbTeamNo";
            cmbTeamNo.Size = new Size(273, 45);
            cmbTeamNo.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(74, 164);
            label5.Name = "label5";
            label5.Size = new Size(64, 37);
            label5.TabIndex = 31;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(34, 114);
            label4.Name = "label4";
            label4.Size = new Size(104, 37);
            label4.TabIndex = 30;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(17, 64);
            label3.Name = "label3";
            label3.Size = new Size(121, 37);
            label3.TabIndex = 29;
            label3.Text = "Surname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(-6, 214);
            label6.Name = "label6";
            label6.Size = new Size(149, 37);
            label6.TabIndex = 27;
            label6.Text = "HourlyRate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(27, 264);
            label2.Name = "label2";
            label2.Size = new Size(115, 37);
            label2.TabIndex = 28;
            label2.Text = "TeamNo";
            // 
            // Firstname
            // 
            Firstname.AutoSize = true;
            Firstname.Font = new Font("Segoe UI", 20F);
            Firstname.Location = new Point(10, 14);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(132, 37);
            Firstname.TabIndex = 26;
            Firstname.Text = "Firstname";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(50, 55, 59);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(230, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 53);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(258, 858);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 221);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 159);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 23;
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 22F);
            txtbSurname.Location = new Point(144, 59);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(273, 47);
            txtbSurname.TabIndex = 22;
            // 
            // txtbGender
            // 
            txtbGender.Font = new Font("Segoe UI", 22F);
            txtbGender.Location = new Point(144, 109);
            txtbGender.Name = "txtbGender";
            txtbGender.Size = new Size(273, 47);
            txtbGender.TabIndex = 21;
            // 
            // txtbAge
            // 
            txtbAge.Font = new Font("Segoe UI", 22F);
            txtbAge.Location = new Point(144, 159);
            txtbAge.Name = "txtbAge";
            txtbAge.Size = new Size(273, 47);
            txtbAge.TabIndex = 20;
            // 
            // txtbHourlyRate
            // 
            txtbHourlyRate.Font = new Font("Segoe UI", 22F);
            txtbHourlyRate.Location = new Point(144, 209);
            txtbHourlyRate.Name = "txtbHourlyRate";
            txtbHourlyRate.Size = new Size(273, 47);
            txtbHourlyRate.TabIndex = 19;
            // 
            // txtbFirstname
            // 
            txtbFirstname.Font = new Font("Segoe UI", 22F);
            txtbFirstname.Location = new Point(144, 9);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(273, 47);
            txtbFirstname.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Location = new Point(1224, 780);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 25);
            panel3.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold);
            label7.Location = new Point(489, 9);
            label7.Name = "label7";
            label7.Size = new Size(320, 65);
            label7.TabIndex = 32;
            label7.Text = "Manage Staff";
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.BackColor = Color.FromArgb(85, 193, 255);
            btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            btnDeleteCustomer.FlatStyle = FlatStyle.Flat;
            btnDeleteCustomer.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteCustomer.ForeColor = Color.Black;
            btnDeleteCustomer.Location = new Point(246, 461);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(276, 51);
            btnDeleteCustomer.TabIndex = 34;
            btnDeleteCustomer.Text = "Delete staff member";
            btnDeleteCustomer.UseVisualStyleBackColor = false;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnEditStaffMember
            // 
            btnEditStaffMember.BackColor = Color.FromArgb(85, 193, 255);
            btnEditStaffMember.FlatAppearance.BorderSize = 0;
            btnEditStaffMember.FlatStyle = FlatStyle.Flat;
            btnEditStaffMember.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditStaffMember.ForeColor = Color.Black;
            btnEditStaffMember.Location = new Point(756, 461);
            btnEditStaffMember.Name = "btnEditStaffMember";
            btnEditStaffMember.Size = new Size(238, 51);
            btnEditStaffMember.TabIndex = 33;
            btnEditStaffMember.Text = "Edit staff member";
            btnEditStaffMember.UseVisualStyleBackColor = false;
            btnEditStaffMember.Click += btnDeleteStaffMember_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(335, 106);
            label9.Name = "label9";
            label9.Size = new Size(95, 37);
            label9.TabIndex = 37;
            label9.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(85, 193, 255);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(807, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 47);
            btnSearch.TabIndex = 36;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtbSearch
            // 
            txtbSearch.Font = new Font("Segoe UI", 20F);
            txtbSearch.Location = new Point(430, 102);
            txtbSearch.Name = "txtbSearch";
            txtbSearch.Size = new Size(371, 43);
            txtbSearch.TabIndex = 35;
            txtbSearch.Text = "Enter staff ID";
            txtbSearch.MouseClick += txtbSearch_MouseClick;
            txtbSearch.KeyDown += txtbSearch_KeyDown;
            txtbSearch.KeyPress += txtbSearch_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(85, 193, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(528, 461);
            button1.Name = "button1";
            button1.Size = new Size(222, 51);
            button1.TabIndex = 38;
            button1.Text = "View all staff";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewStaffMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1488, 880);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(btnSearch);
            Controls.Add(txtbSearch);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnEditStaffMember);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pnlDetails);
            Controls.Add(DataGridStaff);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStaffMembers";
            Text = "ViewStaffMembers";
            Load += ViewStaffMembers_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridStaff).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridStaff;
        private DataGridViewTextBoxColumn clmStaffID;
        private DataGridViewTextBoxColumn clmFirstname;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn clmGender;
        private DataGridViewTextBoxColumn clmAge;
        private DataGridViewTextBoxColumn clmHourlyRate;
        private DataGridViewTextBoxColumn clmTeamNo;
        private Panel pnlDetails;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label Firstname;
        private Button btnSave;
        private Label label1;
        private TextBox txtbSurname;
        private TextBox txtbGender;
        private TextBox txtbAge;
        private TextBox txtbHourlyRate;
        private TextBox txtbFirstname;
        private Panel panel1;
        private Panel panel3;
        private Label label7;
        private Button btnDeleteCustomer;
        private Button btnEditStaffMember;
        private ComboBox cmbTeamNo;
        private Label label9;
        private Button btnSearch;
        private TextBox txtbSearch;
        private Button button1;
    }
}