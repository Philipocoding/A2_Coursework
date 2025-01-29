namespace A2_Coursework
{
    partial class ViewBookings
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnLeft = new Button();
            dtPicker = new DateTimePicker();
            pnlDatePicker = new Panel();
            cbIgnoreID = new CheckBox();
            btnReset = new Button();
            btnFilter = new Button();
            label2 = new Label();
            txtbCustomerID = new TextBox();
            cbDate = new CheckBox();
            btnRight = new Button();
            BookingTable = new DataGridView();
            panel1 = new Panel();
            btnDelete = new Button();
            txtbID = new TextBox();
            label1 = new Label();
            pnlBookingDetails = new Panel();
            cmbEditQuantity = new ComboBox();
            label11 = new Label();
            btnAdd = new Button();
            cmbQuantity = new ComboBox();
            cmbService = new ComboBox();
            label10 = new Label();
            txtbService = new TextBox();
            label9 = new Label();
            label8 = new Label();
            listbQuantity = new ListBox();
            listbServices = new ListBox();
            txtbEmail = new TextBox();
            label7 = new Label();
            txtbSurname = new TextBox();
            label6 = new Label();
            txtbFirstname = new TextBox();
            label5 = new Label();
            txtbCustID = new TextBox();
            label4 = new Label();
            txtbBookingID = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            clmBookingID = new DataGridViewTextBoxColumn();
            clmCustomerID = new DataGridViewTextBoxColumn();
            clmFIrstname = new DataGridViewTextBoxColumn();
            clmSurname = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            pnlDatePicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookingTable).BeginInit();
            panel1.SuspendLayout();
            pnlBookingDetails.SuspendLayout();
            SuspendLayout();
            // 
            // btnLeft
            // 
            btnLeft.Font = new Font("Segoe UI", 24F);
            btnLeft.Location = new Point(13, 20);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(51, 50);
            btnLeft.TabIndex = 1;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // dtPicker
            // 
            dtPicker.Font = new Font("Segoe UI", 24F);
            dtPicker.Location = new Point(70, 20);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(216, 50);
            dtPicker.TabIndex = 2;
            // 
            // pnlDatePicker
            // 
            pnlDatePicker.Controls.Add(cbIgnoreID);
            pnlDatePicker.Controls.Add(btnReset);
            pnlDatePicker.Controls.Add(btnFilter);
            pnlDatePicker.Controls.Add(label2);
            pnlDatePicker.Controls.Add(txtbCustomerID);
            pnlDatePicker.Controls.Add(cbDate);
            pnlDatePicker.Controls.Add(btnRight);
            pnlDatePicker.Controls.Add(btnLeft);
            pnlDatePicker.Controls.Add(dtPicker);
            pnlDatePicker.Location = new Point(4, 357);
            pnlDatePicker.Name = "pnlDatePicker";
            pnlDatePicker.Size = new Size(456, 316);
            pnlDatePicker.TabIndex = 3;
            // 
            // cbIgnoreID
            // 
            cbIgnoreID.AutoSize = true;
            cbIgnoreID.Font = new Font("Segoe UI", 15.25F);
            cbIgnoreID.Location = new Point(366, 120);
            cbIgnoreID.Name = "cbIgnoreID";
            cbIgnoreID.Size = new Size(92, 34);
            cbIgnoreID.TabIndex = 12;
            cbIgnoreID.Text = "Ignore";
            cbIgnoreID.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(138, 241);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(148, 62);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.Location = new Point(292, 241);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(148, 62);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(82, 115);
            label2.Name = "label2";
            label2.Size = new Size(157, 37);
            label2.TabIndex = 9;
            label2.Text = "CustomerID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbCustomerID
            // 
            txtbCustomerID.Font = new Font("Segoe UI", 20F);
            txtbCustomerID.Location = new Point(240, 115);
            txtbCustomerID.Name = "txtbCustomerID";
            txtbCustomerID.Size = new Size(106, 43);
            txtbCustomerID.TabIndex = 8;
            // 
            // cbDate
            // 
            cbDate.AutoSize = true;
            cbDate.Font = new Font("Segoe UI", 15.25F);
            cbDate.Location = new Point(366, 29);
            cbDate.Name = "cbDate";
            cbDate.Size = new Size(92, 34);
            cbDate.TabIndex = 7;
            cbDate.Text = "Ignore";
            cbDate.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            btnRight.Font = new Font("Segoe UI", 24F);
            btnRight.Location = new Point(292, 20);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(50, 50);
            btnRight.TabIndex = 3;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // BookingTable
            // 
            BookingTable.AllowUserToAddRows = false;
            BookingTable.AllowUserToDeleteRows = false;
            BookingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingTable.Columns.AddRange(new DataGridViewColumn[] { clmBookingID, clmCustomerID, clmFIrstname, clmSurname, clmDate });
            BookingTable.Location = new Point(12, 0);
            BookingTable.Name = "BookingTable";
            BookingTable.ReadOnly = true;
            BookingTable.RowHeadersWidth = 100;
            BookingTable.RowTemplate.Height = 35;
            BookingTable.Size = new Size(740, 336);
            BookingTable.StandardTab = true;
            BookingTable.TabIndex = 0;
            BookingTable.CellClick += BookingTable_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtbID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(469, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 166);
            panel1.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(3, 67);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 62);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // txtbID
            // 
            txtbID.Font = new Font("Segoe UI", 20.25F);
            txtbID.Location = new Point(157, 77);
            txtbID.Name = "txtbID";
            txtbID.Size = new Size(100, 43);
            txtbID.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F);
            label1.Location = new Point(109, 20);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 9;
            label1.Text = "Booking ID";
            // 
            // pnlBookingDetails
            // 
            pnlBookingDetails.Controls.Add(cmbEditQuantity);
            pnlBookingDetails.Controls.Add(label11);
            pnlBookingDetails.Controls.Add(btnAdd);
            pnlBookingDetails.Controls.Add(cmbQuantity);
            pnlBookingDetails.Controls.Add(cmbService);
            pnlBookingDetails.Controls.Add(label10);
            pnlBookingDetails.Controls.Add(txtbService);
            pnlBookingDetails.Controls.Add(label9);
            pnlBookingDetails.Controls.Add(label8);
            pnlBookingDetails.Controls.Add(listbQuantity);
            pnlBookingDetails.Controls.Add(listbServices);
            pnlBookingDetails.Controls.Add(txtbEmail);
            pnlBookingDetails.Controls.Add(label7);
            pnlBookingDetails.Controls.Add(txtbSurname);
            pnlBookingDetails.Controls.Add(label6);
            pnlBookingDetails.Controls.Add(txtbFirstname);
            pnlBookingDetails.Controls.Add(label5);
            pnlBookingDetails.Controls.Add(txtbCustID);
            pnlBookingDetails.Controls.Add(label4);
            pnlBookingDetails.Controls.Add(txtbBookingID);
            pnlBookingDetails.Controls.Add(label3);
            pnlBookingDetails.Controls.Add(btnSave);
            pnlBookingDetails.Location = new Point(758, 5);
            pnlBookingDetails.Name = "pnlBookingDetails";
            pnlBookingDetails.Size = new Size(427, 745);
            pnlBookingDetails.TabIndex = 8;
            // 
            // cmbEditQuantity
            // 
            cmbEditQuantity.Font = new Font("Segoe UI", 20F);
            cmbEditQuantity.FormattingEnabled = true;
            cmbEditQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cmbEditQuantity.Location = new Point(369, 543);
            cmbEditQuantity.Name = "cmbEditQuantity";
            cmbEditQuantity.Size = new Size(46, 45);
            cmbEditQuantity.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20F);
            label11.Location = new Point(3, 548);
            label11.Name = "label11";
            label11.Size = new Size(172, 37);
            label11.TabIndex = 39;
            label11.Text = "Edit Quantity";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 20F);
            btnAdd.Location = new Point(142, 644);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 45);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbQuantity
            // 
            cmbQuantity.Font = new Font("Segoe UI", 20F);
            cmbQuantity.FormattingEnabled = true;
            cmbQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cmbQuantity.Location = new Point(369, 593);
            cmbQuantity.Name = "cmbQuantity";
            cmbQuantity.Size = new Size(46, 45);
            cmbQuantity.TabIndex = 37;
            // 
            // cmbService
            // 
            cmbService.Font = new Font("Segoe UI", 20F);
            cmbService.FormattingEnabled = true;
            cmbService.Items.AddRange(new object[] { "Windows", "Doors", "Floors", "Carpets", "Curtains", "Room Vacuuing", "Dusting", "Bathroom" });
            cmbService.Location = new Point(142, 593);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(200, 45);
            cmbService.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F);
            label10.Location = new Point(-7, 596);
            label10.Name = "label10";
            label10.Size = new Size(156, 37);
            label10.TabIndex = 35;
            label10.Text = "Add Service";
            // 
            // txtbService
            // 
            txtbService.Font = new Font("Segoe UI", 20.25F);
            txtbService.Location = new Point(181, 544);
            txtbService.Name = "txtbService";
            txtbService.Size = new Size(151, 43);
            txtbService.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(306, 303);
            label9.Name = "label9";
            label9.Size = new Size(119, 37);
            label9.TabIndex = 31;
            label9.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(190, 303);
            label8.Name = "label8";
            label8.Size = new Size(100, 37);
            label8.TabIndex = 30;
            label8.Text = "Service";
            // 
            // listbQuantity
            // 
            listbQuantity.Font = new Font("Segoe UI", 18F);
            listbQuantity.FormattingEnabled = true;
            listbQuantity.ItemHeight = 32;
            listbQuantity.Location = new Point(320, 343);
            listbQuantity.Name = "listbQuantity";
            listbQuantity.Size = new Size(95, 196);
            listbQuantity.TabIndex = 29;
            listbQuantity.SelectedIndexChanged += listbQuantity_SelectedIndexChanged;
            // 
            // listbServices
            // 
            listbServices.Font = new Font("Segoe UI", 18F);
            listbServices.FormattingEnabled = true;
            listbServices.ItemHeight = 32;
            listbServices.Location = new Point(163, 343);
            listbServices.Name = "listbServices";
            listbServices.Size = new Size(151, 196);
            listbServices.TabIndex = 28;
            listbServices.SelectedIndexChanged += listbServices_SelectedIndexChanged;
            // 
            // txtbEmail
            // 
            txtbEmail.Font = new Font("Segoe UI", 20F);
            txtbEmail.Location = new Point(163, 250);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(261, 43);
            txtbEmail.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(75, 256);
            label7.Name = "label7";
            label7.Size = new Size(82, 37);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 20F);
            txtbSurname.Location = new Point(163, 190);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(261, 43);
            txtbSurname.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(36, 190);
            label6.Name = "label6";
            label6.Size = new Size(121, 37);
            label6.TabIndex = 16;
            label6.Text = "Surname";
            // 
            // txtbFirstname
            // 
            txtbFirstname.Font = new Font("Segoe UI", 20F);
            txtbFirstname.Location = new Point(163, 126);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(261, 43);
            txtbFirstname.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(25, 126);
            label5.Name = "label5";
            label5.Size = new Size(132, 37);
            label5.TabIndex = 14;
            label5.Text = "Firstname";
            // 
            // txtbCustID
            // 
            txtbCustID.Font = new Font("Segoe UI", 20F);
            txtbCustID.Location = new Point(163, 68);
            txtbCustID.Name = "txtbCustID";
            txtbCustID.Size = new Size(261, 43);
            txtbCustID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(-7, 68);
            label4.Name = "label4";
            label4.Size = new Size(164, 37);
            label4.TabIndex = 12;
            label4.Text = "Customer ID";
            // 
            // txtbBookingID
            // 
            txtbBookingID.Font = new Font("Segoe UI", 20F);
            txtbBookingID.Location = new Point(163, 11);
            txtbBookingID.Name = "txtbBookingID";
            txtbBookingID.Size = new Size(261, 43);
            txtbBookingID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(9, 11);
            label3.Name = "label3";
            label3.Size = new Size(148, 37);
            label3.TabIndex = 9;
            label3.Text = "Booking ID";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.Location = new Point(329, 694);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 45);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // clmBookingID
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmBookingID.DefaultCellStyle = dataGridViewCellStyle1;
            clmBookingID.FillWeight = 10F;
            clmBookingID.HeaderText = "Booking ID";
            clmBookingID.Name = "clmBookingID";
            clmBookingID.ReadOnly = true;
            clmBookingID.Width = 200;
            // 
            // clmCustomerID
            // 
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmCustomerID.DefaultCellStyle = dataGridViewCellStyle2;
            clmCustomerID.HeaderText = "Customer ID";
            clmCustomerID.Name = "clmCustomerID";
            clmCustomerID.ReadOnly = true;
            clmCustomerID.Width = 200;
            // 
            // clmFIrstname
            // 
            clmFIrstname.HeaderText = "FIrstname";
            clmFIrstname.Name = "clmFIrstname";
            clmFIrstname.ReadOnly = true;
            // 
            // clmSurname
            // 
            clmSurname.HeaderText = "Surname";
            clmSurname.Name = "clmSurname";
            clmSurname.ReadOnly = true;
            // 
            // clmDate
            // 
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmDate.DefaultCellStyle = dataGridViewCellStyle3;
            clmDate.HeaderText = "Date";
            clmDate.Name = "clmDate";
            clmDate.ReadOnly = true;
            clmDate.Width = 200;
            // 
            // ViewBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1197, 756);
            Controls.Add(pnlBookingDetails);
            Controls.Add(panel1);
            Controls.Add(BookingTable);
            Controls.Add(pnlDatePicker);
            Name = "ViewBookings";
            Text = "ViewBookings";
            Load += ViewBookings_Load;
            pnlDatePicker.ResumeLayout(false);
            pnlDatePicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookingTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlBookingDetails.ResumeLayout(false);
            pnlBookingDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLeft;
        private DateTimePicker dtPicker;
        private Panel pnlDatePicker;
        private Button btnRight;
        private DataGridView BookingTable;
        private CheckBox cbDate;
        private Panel panel1;
        private Button btnDelete;
        private TextBox txtbID;
        private Label label1;
        private Button btnFilter;
        private Label label2;
        private TextBox txtbCustomerID;
        private Button btnReset;
        private CheckBox cbIgnoreID;
        private Panel pnlBookingDetails;
        private TextBox txtbEmail;
        private Label label7;
        private TextBox txtbSurname;
        private Label label6;
        private TextBox txtbFirstname;
        private Label label5;
        private TextBox txtbCustID;
        private Label label4;
        private TextBox txtbBookingID;
        private Label label3;
        private Button btnSave;
        private ListBox listbServices;
        private ListBox listbQuantity;
        private Label label9;
        private Label label8;
        private TextBox txtbService;
        private ComboBox cmbService;
        private Label label10;
        private ComboBox cmbQuantity;
        private Button btnAdd;
        private ComboBox cmbEditQuantity;
        private Label label11;
        private DataGridViewTextBoxColumn clmBookingID;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmFIrstname;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn clmDate;
    }
}