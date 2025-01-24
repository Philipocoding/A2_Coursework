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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            Firstname = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtbSurname = new TextBox();
            txtbGender = new TextBox();
            txtbAge = new TextBox();
            txtbHourlyRate = new TextBox();
            txtbTeamNo = new TextBox();
            txtbFirstname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridStaff).BeginInit();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridStaff
            // 
            DataGridStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridStaff.Columns.AddRange(new DataGridViewColumn[] { clmStaffID, clmFirstname, clmSurname, clmGender, clmAge, clmHourlyRate, clmTeamNo });
            DataGridStaff.Location = new Point(0, 0);
            DataGridStaff.Name = "DataGridStaff";
            DataGridStaff.Size = new Size(745, 356);
            DataGridStaff.TabIndex = 0;
            DataGridStaff.CellClick += DataGridStaff_CellClick;
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
            pnlDetails.Controls.Add(label5);
            pnlDetails.Controls.Add(label4);
            pnlDetails.Controls.Add(label3);
            pnlDetails.Controls.Add(label6);
            pnlDetails.Controls.Add(label2);
            pnlDetails.Controls.Add(Firstname);
            pnlDetails.Controls.Add(btnSave);
            pnlDetails.Controls.Add(btnDelete);
            pnlDetails.Controls.Add(label1);
            pnlDetails.Controls.Add(txtbSurname);
            pnlDetails.Controls.Add(txtbGender);
            pnlDetails.Controls.Add(txtbAge);
            pnlDetails.Controls.Add(txtbHourlyRate);
            pnlDetails.Controls.Add(txtbTeamNo);
            pnlDetails.Controls.Add(txtbFirstname);
            pnlDetails.Location = new Point(776, 0);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(420, 611);
            pnlDetails.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(77, 254);
            label5.Name = "label5";
            label5.Size = new Size(64, 37);
            label5.TabIndex = 31;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(37, 173);
            label4.Name = "label4";
            label4.Size = new Size(104, 37);
            label4.TabIndex = 30;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(20, 95);
            label3.Name = "label3";
            label3.Size = new Size(121, 37);
            label3.TabIndex = 29;
            label3.Text = "Surname";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(-7, 333);
            label6.Name = "label6";
            label6.Size = new Size(149, 37);
            label6.TabIndex = 27;
            label6.Text = "HourlyRate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(23, 413);
            label2.Name = "label2";
            label2.Size = new Size(115, 37);
            label2.TabIndex = 28;
            label2.Text = "TeamNo";
            // 
            // Firstname
            // 
            Firstname.AutoSize = true;
            Firstname.Font = new Font("Segoe UI", 20F);
            Firstname.Location = new Point(9, 14);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(132, 37);
            Firstname.TabIndex = 26;
            Firstname.Text = "Firstname";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(288, 483);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 53);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 20F);
            btnDelete.Location = new Point(152, 483);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 53);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
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
            txtbSurname.Location = new Point(144, 90);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(273, 47);
            txtbSurname.TabIndex = 22;
            // 
            // txtbGender
            // 
            txtbGender.Font = new Font("Segoe UI", 22F);
            txtbGender.Location = new Point(144, 168);
            txtbGender.Name = "txtbGender";
            txtbGender.Size = new Size(273, 47);
            txtbGender.TabIndex = 21;
            // 
            // txtbAge
            // 
            txtbAge.Font = new Font("Segoe UI", 22F);
            txtbAge.Location = new Point(144, 249);
            txtbAge.Name = "txtbAge";
            txtbAge.Size = new Size(273, 47);
            txtbAge.TabIndex = 20;
            // 
            // txtbHourlyRate
            // 
            txtbHourlyRate.Font = new Font("Segoe UI", 22F);
            txtbHourlyRate.Location = new Point(144, 329);
            txtbHourlyRate.Name = "txtbHourlyRate";
            txtbHourlyRate.Size = new Size(273, 47);
            txtbHourlyRate.TabIndex = 19;
            // 
            // txtbTeamNo
            // 
            txtbTeamNo.Font = new Font("Segoe UI", 22F);
            txtbTeamNo.Location = new Point(144, 408);
            txtbTeamNo.Name = "txtbTeamNo";
            txtbTeamNo.Size = new Size(273, 47);
            txtbTeamNo.TabIndex = 18;
            // 
            // txtbFirstname
            // 
            txtbFirstname.Font = new Font("Segoe UI", 22F);
            txtbFirstname.Location = new Point(144, 9);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(273, 47);
            txtbFirstname.TabIndex = 17;
            // 
            // ViewStaffMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1197, 756);
            Controls.Add(pnlDetails);
            Controls.Add(DataGridStaff);
            Name = "ViewStaffMembers";
            Text = "ViewStaffMembers";
            Load += ViewStaffMembers_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridStaff).EndInit();
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
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
        private Button btnDelete;
        private Label label1;
        private TextBox txtbSurname;
        private TextBox txtbGender;
        private TextBox txtbAge;
        private TextBox txtbHourlyRate;
        private TextBox txtbTeamNo;
        private TextBox txtbFirstname;
    }
}