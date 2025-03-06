namespace A2_Coursework
{
    partial class BookingSchedules
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
            DtPicker = new DateTimePicker();
            lblDateOne = new Label();
            dataGridOne = new DataGridView();
            clmBookingID = new DataGridViewTextBoxColumn();
            clmCustomerID = new DataGridViewTextBoxColumn();
            clmFirstname = new DataGridViewTextBoxColumn();
            clmSurname = new DataGridViewTextBoxColumn();
            lblDateFive = new Label();
            lblDateFour = new Label();
            lblDateThree = new Label();
            lblDateTwo = new Label();
            btnRight = new Button();
            btnLeft = new Button();
            dataGrid2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGrid3 = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGrid4 = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGrid5 = new DataGridView();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            btnPostpone = new Button();
            panel1 = new Panel();
            pnlPostponeDetails = new Panel();
            dtPickerPostpone = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            btnWcOne = new Button();
            btnWCTwo = new Button();
            btnWcFour = new Button();
            btnWcThree = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid5).BeginInit();
            panel1.SuspendLayout();
            pnlPostponeDetails.SuspendLayout();
            SuspendLayout();
            // 
            // DtPicker
            // 
            DtPicker.CalendarFont = new Font("Segoe UI", 21F);
            DtPicker.Font = new Font("Microsoft Sans Serif", 20F);
            DtPicker.Location = new Point(470, 124);
            DtPicker.Name = "DtPicker";
            DtPicker.Size = new Size(268, 38);
            DtPicker.TabIndex = 0;
            DtPicker.ValueChanged += DtPicker_ValueChanged;
            // 
            // lblDateOne
            // 
            lblDateOne.AutoSize = true;
            lblDateOne.Font = new Font("Segoe UI", 18F);
            lblDateOne.Location = new Point(49, 165);
            lblDateOne.Name = "lblDateOne";
            lblDateOne.Size = new Size(64, 32);
            lblDateOne.TabIndex = 1;
            lblDateOne.Text = "Date";
            // 
            // dataGridOne
            // 
            dataGridOne.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOne.Columns.AddRange(new DataGridViewColumn[] { clmBookingID, clmCustomerID, clmFirstname, clmSurname });
            dataGridOne.Location = new Point(49, 200);
            dataGridOne.Name = "dataGridOne";
            dataGridOne.Size = new Size(494, 178);
            dataGridOne.TabIndex = 16;
            // 
            // clmBookingID
            // 
            clmBookingID.HeaderText = "Booking ID";
            clmBookingID.Name = "clmBookingID";
            // 
            // clmCustomerID
            // 
            clmCustomerID.HeaderText = "Customer ID";
            clmCustomerID.Name = "clmCustomerID";
            // 
            // clmFirstname
            // 
            clmFirstname.HeaderText = "Firstname";
            clmFirstname.Name = "clmFirstname";
            clmFirstname.Width = 125;
            // 
            // clmSurname
            // 
            clmSurname.HeaderText = "Surname";
            clmSurname.Name = "clmSurname";
            clmSurname.Width = 125;
            // 
            // lblDateFive
            // 
            lblDateFive.AutoSize = true;
            lblDateFive.Font = new Font("Segoe UI", 18F);
            lblDateFive.Location = new Point(49, 621);
            lblDateFive.Name = "lblDateFive";
            lblDateFive.Size = new Size(64, 32);
            lblDateFive.TabIndex = 5;
            lblDateFive.Text = "Date";
            // 
            // lblDateFour
            // 
            lblDateFour.AutoSize = true;
            lblDateFour.Font = new Font("Segoe UI", 18F);
            lblDateFour.Location = new Point(548, 396);
            lblDateFour.Name = "lblDateFour";
            lblDateFour.Size = new Size(64, 32);
            lblDateFour.TabIndex = 4;
            lblDateFour.Text = "Date";
            // 
            // lblDateThree
            // 
            lblDateThree.AutoSize = true;
            lblDateThree.Font = new Font("Segoe UI", 18F);
            lblDateThree.Location = new Point(49, 396);
            lblDateThree.Name = "lblDateThree";
            lblDateThree.Size = new Size(64, 32);
            lblDateThree.TabIndex = 3;
            lblDateThree.Text = "Date";
            // 
            // lblDateTwo
            // 
            lblDateTwo.AutoSize = true;
            lblDateTwo.Font = new Font("Segoe UI", 18F);
            lblDateTwo.Location = new Point(548, 165);
            lblDateTwo.Name = "lblDateTwo";
            lblDateTwo.Size = new Size(64, 32);
            lblDateTwo.TabIndex = 2;
            lblDateTwo.Text = "Date";
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.FromArgb(50, 55, 59);
            btnRight.FlatAppearance.BorderSize = 0;
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Font = new Font("Segoe UI", 20F);
            btnRight.ForeColor = Color.White;
            btnRight.Location = new Point(744, 124);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(46, 41);
            btnRight.TabIndex = 6;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.FromArgb(50, 55, 59);
            btnLeft.FlatAppearance.BorderSize = 0;
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Font = new Font("Segoe UI", 20F);
            btnLeft.ForeColor = Color.White;
            btnLeft.Location = new Point(418, 124);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(46, 41);
            btnLeft.TabIndex = 7;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // dataGrid2
            // 
            dataGrid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGrid2.Location = new Point(548, 200);
            dataGrid2.Name = "dataGrid2";
            dataGrid2.Size = new Size(494, 178);
            dataGrid2.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Booking ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Customer ID";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Firstname";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Surname";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGrid3
            // 
            dataGrid3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGrid3.Location = new Point(49, 431);
            dataGrid3.Name = "dataGrid3";
            dataGrid3.Size = new Size(494, 178);
            dataGrid3.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Booking ID";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Customer ID";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Firstname";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Surname";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGrid4
            // 
            dataGrid4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGrid4.Location = new Point(549, 431);
            dataGrid4.Name = "dataGrid4";
            dataGrid4.Size = new Size(493, 178);
            dataGrid4.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Booking ID";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Customer ID";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Firstname";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Surname";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGrid5
            // 
            dataGrid5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid5.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16 });
            dataGrid5.Location = new Point(47, 656);
            dataGrid5.Name = "dataGrid5";
            dataGrid5.Size = new Size(496, 178);
            dataGrid5.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Booking ID";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Customer ID";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Firstname";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Surname";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.Width = 125;
            // 
            // btnPostpone
            // 
            btnPostpone.BackColor = Color.FromArgb(50, 55, 59);
            btnPostpone.FlatAppearance.BorderSize = 0;
            btnPostpone.FlatStyle = FlatStyle.Flat;
            btnPostpone.Font = new Font("Segoe UI", 20F);
            btnPostpone.ForeColor = Color.White;
            btnPostpone.Location = new Point(16, 20);
            btnPostpone.Name = "btnPostpone";
            btnPostpone.Size = new Size(210, 47);
            btnPostpone.TabIndex = 21;
            btnPostpone.Text = "Postpone";
            btnPostpone.UseVisualStyleBackColor = false;
            btnPostpone.Click += btnPostpone_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlPostponeDetails);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnPostpone);
            panel1.Location = new Point(570, 615);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 239);
            panel1.TabIndex = 22;
            // 
            // pnlPostponeDetails
            // 
            pnlPostponeDetails.Controls.Add(dtPickerPostpone);
            pnlPostponeDetails.Controls.Add(btnSave);
            pnlPostponeDetails.Location = new Point(232, 16);
            pnlPostponeDetails.Name = "pnlPostponeDetails";
            pnlPostponeDetails.Size = new Size(415, 69);
            pnlPostponeDetails.TabIndex = 23;
            pnlPostponeDetails.Visible = false;
            // 
            // dtPickerPostpone
            // 
            dtPickerPostpone.CalendarFont = new Font("Segoe UI", 20F);
            dtPickerPostpone.Font = new Font("Segoe UI", 20F);
            dtPickerPostpone.Location = new Point(4, 9);
            dtPickerPostpone.Name = "dtPickerPostpone";
            dtPickerPostpone.Size = new Size(263, 43);
            dtPickerPostpone.TabIndex = 22;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(50, 55, 59);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(273, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 59);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(50, 55, 59);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 20F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(16, 73);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(210, 59);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel booking";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnWcOne
            // 
            btnWcOne.BackColor = Color.FromArgb(50, 55, 59);
            btnWcOne.FlatAppearance.BorderSize = 0;
            btnWcOne.FlatStyle = FlatStyle.Flat;
            btnWcOne.Font = new Font("Segoe UI", 20F);
            btnWcOne.ForeColor = Color.White;
            btnWcOne.Location = new Point(1051, 156);
            btnWcOne.Name = "btnWcOne";
            btnWcOne.Size = new Size(171, 47);
            btnWcOne.TabIndex = 24;
            btnWcOne.Text = "Postpone";
            btnWcOne.UseVisualStyleBackColor = false;
            btnWcOne.Click += btnWcOne_Click;
            // 
            // btnWCTwo
            // 
            btnWCTwo.BackColor = Color.FromArgb(50, 55, 59);
            btnWCTwo.FlatAppearance.BorderSize = 0;
            btnWCTwo.FlatStyle = FlatStyle.Flat;
            btnWCTwo.Font = new Font("Segoe UI", 20F);
            btnWCTwo.ForeColor = Color.White;
            btnWCTwo.Location = new Point(1051, 206);
            btnWCTwo.Name = "btnWCTwo";
            btnWCTwo.Size = new Size(171, 47);
            btnWCTwo.TabIndex = 25;
            btnWCTwo.Text = "Postpone";
            btnWCTwo.UseVisualStyleBackColor = false;
            btnWCTwo.Click += btnWCTwo_Click;
            // 
            // btnWcFour
            // 
            btnWcFour.BackColor = Color.FromArgb(50, 55, 59);
            btnWcFour.FlatAppearance.BorderSize = 0;
            btnWcFour.FlatStyle = FlatStyle.Flat;
            btnWcFour.Font = new Font("Segoe UI", 20F);
            btnWcFour.ForeColor = Color.White;
            btnWcFour.Location = new Point(1051, 312);
            btnWcFour.Name = "btnWcFour";
            btnWcFour.Size = new Size(171, 47);
            btnWcFour.TabIndex = 26;
            btnWcFour.Text = "Postpone";
            btnWcFour.UseVisualStyleBackColor = false;
            btnWcFour.Click += btnWcFour_Click;
            // 
            // btnWcThree
            // 
            btnWcThree.BackColor = Color.FromArgb(50, 55, 59);
            btnWcThree.FlatAppearance.BorderSize = 0;
            btnWcThree.FlatStyle = FlatStyle.Flat;
            btnWcThree.Font = new Font("Segoe UI", 20F);
            btnWcThree.ForeColor = Color.White;
            btnWcThree.Location = new Point(1051, 259);
            btnWcThree.Name = "btnWcThree";
            btnWcThree.Size = new Size(171, 47);
            btnWcThree.TabIndex = 27;
            btnWcThree.Text = "Postpone";
            btnWcThree.UseVisualStyleBackColor = false;
            btnWcThree.Click += btnWcThree_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(1051, 116);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 28;
            label1.Text = "View by week";
            // 
            // panel2
            // 
            panel2.Location = new Point(528, 840);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 221);
            panel2.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.Location = new Point(1168, 479);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 13);
            panel3.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold);
            label2.Location = new Point(442, 9);
            label2.Name = "label2";
            label2.Size = new Size(348, 65);
            label2.TabIndex = 31;
            label2.Text = "View Schedule";
            // 
            // BookingSchedules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1382, 856);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(btnWcThree);
            Controls.Add(btnWcFour);
            Controls.Add(btnWCTwo);
            Controls.Add(btnWcOne);
            Controls.Add(panel1);
            Controls.Add(dataGrid5);
            Controls.Add(dataGrid4);
            Controls.Add(dataGrid3);
            Controls.Add(dataGrid2);
            Controls.Add(dataGridOne);
            Controls.Add(btnLeft);
            Controls.Add(btnRight);
            Controls.Add(DtPicker);
            Controls.Add(lblDateFive);
            Controls.Add(lblDateOne);
            Controls.Add(lblDateFour);
            Controls.Add(lblDateTwo);
            Controls.Add(lblDateThree);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingSchedules";
            Text = "BookingSchedules";
            Load += BookingSchedules_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid5).EndInit();
            panel1.ResumeLayout(false);
            pnlPostponeDetails.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtPicker;
        private Label lblDateOne;
        private Label lblDateFive;
        private Label lblDateFour;
        private Label lblDateThree;
        private Label lblDateTwo;
        private Button btnRight;
        private Button btnLeft;
        private DataGridView dataGridOne;
        private DataGridView dataGrid2;
        private DataGridView dataGrid3;
        private DataGridView dataGrid4;
        private DataGridView dataGrid5;
        private Button btnPostpone;
        private Panel panel1;
        private Button btnCancel;
        private Panel pnlPostponeDetails;
        private DateTimePicker dtPickerPostpone;
        private Button btnSave;
        private Button btnWcOne;
        private Button btnWCTwo;
        private Button btnWcFour;
        private Button btnWcThree;
        private Label label1;
        private DataGridViewTextBoxColumn clmBookingID;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmFirstname;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
    }
}