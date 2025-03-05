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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dtPicker = new DateTimePicker();
            pnlFilter = new Panel();
            label12 = new Label();
            cbIgnoreID = new CheckBox();
            btnReset = new Button();
            btnFilter = new Button();
            label2 = new Label();
            txtbCustomerID = new TextBox();
            cbDate = new CheckBox();
            panel1 = new Panel();
            BookingTable = new DataGridView();
            clmBookingID = new DataGridViewTextBoxColumn();
            clmCustomerID = new DataGridViewTextBoxColumn();
            clmFIrstname = new DataGridViewTextBoxColumn();
            clmSurname = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
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
            btnSave = new Button();
            pnlHideAddServices = new Panel();
            btnServiceDelete = new Button();
            cmbServiceDelete = new ComboBox();
            label14 = new Label();
            btnSaveQuantity = new Button();
            label13 = new Label();
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
            btnOpenFilter = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookingTable).BeginInit();
            pnlHideAddServices.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtPicker
            // 
            dtPicker.Font = new Font("Segoe UI", 24F);
            dtPicker.Location = new Point(173, 25);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(216, 50);
            dtPicker.TabIndex = 2;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.FromArgb(109, 132, 156);
            pnlFilter.Controls.Add(label12);
            pnlFilter.Controls.Add(cbIgnoreID);
            pnlFilter.Controls.Add(btnReset);
            pnlFilter.Controls.Add(btnFilter);
            pnlFilter.Controls.Add(label2);
            pnlFilter.Controls.Add(txtbCustomerID);
            pnlFilter.Controls.Add(cbDate);
            pnlFilter.Controls.Add(dtPicker);
            pnlFilter.Location = new Point(343, 496);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(499, 217);
            pnlFilter.TabIndex = 3;
            pnlFilter.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F);
            label12.Location = new Point(94, 36);
            label12.Name = "label12";
            label12.Size = new Size(73, 37);
            label12.TabIndex = 13;
            label12.Text = "Date";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbIgnoreID
            // 
            cbIgnoreID.AutoSize = true;
            cbIgnoreID.Font = new Font("Segoe UI", 15.25F);
            cbIgnoreID.Location = new Point(395, 92);
            cbIgnoreID.Name = "cbIgnoreID";
            cbIgnoreID.Size = new Size(92, 34);
            cbIgnoreID.TabIndex = 12;
            cbIgnoreID.Text = "Ignore";
            cbIgnoreID.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(85, 193, 255);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 20.25F);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(173, 148);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(105, 52);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(85, 193, 255);
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 20.25F);
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(281, 148);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(105, 52);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(3, 93);
            label2.Name = "label2";
            label2.Size = new Size(164, 37);
            label2.TabIndex = 9;
            label2.Text = "Customer ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbCustomerID
            // 
            txtbCustomerID.Font = new Font("Segoe UI", 20F);
            txtbCustomerID.Location = new Point(173, 84);
            txtbCustomerID.Name = "txtbCustomerID";
            txtbCustomerID.Size = new Size(216, 43);
            txtbCustomerID.TabIndex = 8;
            // 
            // cbDate
            // 
            cbDate.AutoSize = true;
            cbDate.Font = new Font("Segoe UI", 15.25F);
            cbDate.Location = new Point(395, 36);
            cbDate.Name = "cbDate";
            cbDate.Size = new Size(92, 34);
            cbDate.TabIndex = 7;
            cbDate.Text = "Ignore";
            cbDate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(1260, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 25);
            panel1.TabIndex = 43;
            // 
            // BookingTable
            // 
            BookingTable.AllowUserToAddRows = false;
            BookingTable.AllowUserToDeleteRows = false;
            BookingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingTable.Columns.AddRange(new DataGridViewColumn[] { clmBookingID, clmCustomerID, clmFIrstname, clmSurname, clmDate });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 17F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            BookingTable.DefaultCellStyle = dataGridViewCellStyle6;
            BookingTable.Location = new Point(13, 20);
            BookingTable.Name = "BookingTable";
            BookingTable.ReadOnly = true;
            BookingTable.RowHeadersWidth = 25;
            BookingTable.RowTemplate.Height = 35;
            BookingTable.Size = new Size(740, 336);
            BookingTable.StandardTab = true;
            BookingTable.TabIndex = 0;
            BookingTable.CellClick += BookingTable_CellClick;
            BookingTable.CellContentClick += BookingTable_CellContentClick;
            // 
            // clmBookingID
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmBookingID.DefaultCellStyle = dataGridViewCellStyle1;
            clmBookingID.FillWeight = 10F;
            clmBookingID.HeaderText = "Booking ID";
            clmBookingID.Name = "clmBookingID";
            clmBookingID.ReadOnly = true;
            // 
            // clmCustomerID
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmCustomerID.DefaultCellStyle = dataGridViewCellStyle2;
            clmCustomerID.HeaderText = "Customer ID";
            clmCustomerID.Name = "clmCustomerID";
            clmCustomerID.ReadOnly = true;
            // 
            // clmFIrstname
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmFIrstname.DefaultCellStyle = dataGridViewCellStyle3;
            clmFIrstname.HeaderText = "FIrstname";
            clmFIrstname.Name = "clmFIrstname";
            clmFIrstname.ReadOnly = true;
            clmFIrstname.Width = 150;
            // 
            // clmSurname
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmSurname.DefaultCellStyle = dataGridViewCellStyle4;
            clmSurname.HeaderText = "Surname";
            clmSurname.Name = "clmSurname";
            clmSurname.ReadOnly = true;
            clmSurname.Width = 150;
            // 
            // clmDate
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmDate.DefaultCellStyle = dataGridViewCellStyle5;
            clmDate.HeaderText = "Date";
            clmDate.Name = "clmDate";
            clmDate.ReadOnly = true;
            clmDate.Width = 200;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(85, 193, 255);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 22F);
            btnDelete.Location = new Point(280, 362);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(239, 51);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete booking";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // cmbEditQuantity
            // 
            cmbEditQuantity.Font = new Font("Segoe UI", 18F);
            cmbEditQuantity.FormattingEnabled = true;
            cmbEditQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cmbEditQuantity.Location = new Point(937, 243);
            cmbEditQuantity.Name = "cmbEditQuantity";
            cmbEditQuantity.Size = new Size(64, 40);
            cmbEditQuantity.TabIndex = 40;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 17F);
            label11.Location = new Point(564, 247);
            label11.Name = "label11";
            label11.Size = new Size(148, 31);
            label11.TabIndex = 39;
            label11.Text = "Edit Quantity";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(85, 193, 255);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 20F);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(1010, 299);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 41);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbQuantity
            // 
            cmbQuantity.Font = new Font("Segoe UI", 18F);
            cmbQuantity.FormattingEnabled = true;
            cmbQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cmbQuantity.Location = new Point(941, 299);
            cmbQuantity.Name = "cmbQuantity";
            cmbQuantity.Size = new Size(60, 40);
            cmbQuantity.TabIndex = 37;
            // 
            // cmbService
            // 
            cmbService.Font = new Font("Segoe UI", 18F);
            cmbService.FormattingEnabled = true;
            cmbService.Items.AddRange(new object[] { "Windows", "Doors", "Floors", "Carpets", "Curtains", "Dusting", "Bathroom", "Kitchen Appliances", "Deep Clean", "Furniture" });
            cmbService.Location = new Point(718, 299);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(217, 40);
            cmbService.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(572, 302);
            label10.Name = "label10";
            label10.Size = new Size(140, 32);
            label10.TabIndex = 35;
            label10.Text = "Add Service";
            // 
            // txtbService
            // 
            txtbService.Font = new Font("Segoe UI", 18F);
            txtbService.Location = new Point(718, 244);
            txtbService.Name = "txtbService";
            txtbService.ReadOnly = true;
            txtbService.Size = new Size(213, 39);
            txtbService.TabIndex = 10;
            txtbService.Text = "Select a service";
            txtbService.TextChanged += txtbService_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(937, 19);
            label9.Name = "label9";
            label9.Size = new Size(59, 37);
            label9.TabIndex = 31;
            label9.Text = "Qty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(777, 19);
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
            listbQuantity.Location = new Point(938, 59);
            listbQuantity.Name = "listbQuantity";
            listbQuantity.Size = new Size(63, 164);
            listbQuantity.TabIndex = 29;
            listbQuantity.SelectedIndexChanged += listbQuantity_SelectedIndexChanged;
            // 
            // listbServices
            // 
            listbServices.Font = new Font("Segoe UI", 18F);
            listbServices.FormattingEnabled = true;
            listbServices.ItemHeight = 32;
            listbServices.Location = new Point(718, 59);
            listbServices.Name = "listbServices";
            listbServices.Size = new Size(214, 164);
            listbServices.TabIndex = 28;
            listbServices.SelectedIndexChanged += listbServices_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(85, 193, 255);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 20F);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(223, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(228, 60);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // pnlHideAddServices
            // 
            pnlHideAddServices.BackColor = Color.FromArgb(109, 132, 156);
            pnlHideAddServices.Controls.Add(btnServiceDelete);
            pnlHideAddServices.Controls.Add(cmbServiceDelete);
            pnlHideAddServices.Controls.Add(label14);
            pnlHideAddServices.Controls.Add(btnSaveQuantity);
            pnlHideAddServices.Controls.Add(label13);
            pnlHideAddServices.Controls.Add(cmbEditQuantity);
            pnlHideAddServices.Controls.Add(txtbEmail);
            pnlHideAddServices.Controls.Add(txtbService);
            pnlHideAddServices.Controls.Add(label7);
            pnlHideAddServices.Controls.Add(label11);
            pnlHideAddServices.Controls.Add(txtbSurname);
            pnlHideAddServices.Controls.Add(btnAdd);
            pnlHideAddServices.Controls.Add(label6);
            pnlHideAddServices.Controls.Add(btnSave);
            pnlHideAddServices.Controls.Add(txtbFirstname);
            pnlHideAddServices.Controls.Add(listbServices);
            pnlHideAddServices.Controls.Add(label5);
            pnlHideAddServices.Controls.Add(cmbQuantity);
            pnlHideAddServices.Controls.Add(txtbCustID);
            pnlHideAddServices.Controls.Add(listbQuantity);
            pnlHideAddServices.Controls.Add(label4);
            pnlHideAddServices.Controls.Add(cmbService);
            pnlHideAddServices.Controls.Add(txtbBookingID);
            pnlHideAddServices.Controls.Add(label8);
            pnlHideAddServices.Controls.Add(label3);
            pnlHideAddServices.Controls.Add(label10);
            pnlHideAddServices.Controls.Add(label9);
            pnlHideAddServices.Location = new Point(48, 502);
            pnlHideAddServices.Name = "pnlHideAddServices";
            pnlHideAddServices.Size = new Size(1137, 427);
            pnlHideAddServices.TabIndex = 41;
            pnlHideAddServices.Visible = false;
            // 
            // btnServiceDelete
            // 
            btnServiceDelete.BackColor = Color.FromArgb(85, 193, 255);
            btnServiceDelete.FlatAppearance.BorderSize = 0;
            btnServiceDelete.FlatStyle = FlatStyle.Flat;
            btnServiceDelete.Font = new Font("Segoe UI", 20F);
            btnServiceDelete.ForeColor = Color.Black;
            btnServiceDelete.Location = new Point(1010, 353);
            btnServiceDelete.Name = "btnServiceDelete";
            btnServiceDelete.Size = new Size(109, 41);
            btnServiceDelete.TabIndex = 46;
            btnServiceDelete.Text = "Delete";
            btnServiceDelete.UseVisualStyleBackColor = false;
            btnServiceDelete.Click += btnServiceDelete_Click;
            // 
            // cmbServiceDelete
            // 
            cmbServiceDelete.Font = new Font("Segoe UI", 18F);
            cmbServiceDelete.FormattingEnabled = true;
            cmbServiceDelete.Items.AddRange(new object[] { "Windows", "Doors", "Floors", "Carpets", "Curtains", "Dusting", "Bathroom", "Kitchen Appliances", "Deep Clean", "Furniture" });
            cmbServiceDelete.Location = new Point(718, 353);
            cmbServiceDelete.Name = "cmbServiceDelete";
            cmbServiceDelete.Size = new Size(283, 40);
            cmbServiceDelete.TabIndex = 44;
            cmbServiceDelete.Text = "Select a service";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F);
            label14.Location = new Point(529, 356);
            label14.Name = "label14";
            label14.Size = new Size(183, 32);
            label14.TabIndex = 43;
            label14.Text = "Delete a service";
            // 
            // btnSaveQuantity
            // 
            btnSaveQuantity.BackColor = Color.FromArgb(85, 193, 255);
            btnSaveQuantity.FlatAppearance.BorderSize = 0;
            btnSaveQuantity.FlatStyle = FlatStyle.Flat;
            btnSaveQuantity.Font = new Font("Segoe UI", 20F);
            btnSaveQuantity.ForeColor = Color.Black;
            btnSaveQuantity.Location = new Point(1010, 242);
            btnSaveQuantity.Name = "btnSaveQuantity";
            btnSaveQuantity.Size = new Size(109, 41);
            btnSaveQuantity.TabIndex = 42;
            btnSaveQuantity.Text = "Save";
            btnSaveQuantity.UseVisualStyleBackColor = false;
            btnSaveQuantity.Click += btnSaveQuantity_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F);
            label13.Location = new Point(223, 25);
            label13.Name = "label13";
            label13.Size = new Size(216, 37);
            label13.TabIndex = 41;
            label13.Text = "Customer details";
            // 
            // txtbEmail
            // 
            txtbEmail.Font = new Font("Segoe UI", 20F);
            txtbEmail.Location = new Point(148, 304);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(364, 43);
            txtbEmail.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(72, 308);
            label7.Name = "label7";
            label7.Size = new Size(71, 32);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 20F);
            txtbSurname.Location = new Point(148, 244);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(364, 43);
            txtbSurname.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(34, 250);
            label6.Name = "label6";
            label6.Size = new Size(109, 32);
            label6.TabIndex = 16;
            label6.Text = "Surname";
            // 
            // txtbFirstname
            // 
            txtbFirstname.Font = new Font("Segoe UI", 20F);
            txtbFirstname.Location = new Point(148, 180);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(364, 43);
            txtbFirstname.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(27, 187);
            label5.Name = "label5";
            label5.Size = new Size(118, 32);
            label5.TabIndex = 14;
            label5.Text = "Firstname";
            // 
            // txtbCustID
            // 
            txtbCustID.Font = new Font("Segoe UI", 20F);
            txtbCustID.Location = new Point(148, 122);
            txtbCustID.Name = "txtbCustID";
            txtbCustID.ReadOnly = true;
            txtbCustID.Size = new Size(364, 43);
            txtbCustID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(-5, 129);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 12;
            label4.Text = "Customer ID";
            // 
            // txtbBookingID
            // 
            txtbBookingID.Font = new Font("Segoe UI", 20F);
            txtbBookingID.Location = new Point(148, 65);
            txtbBookingID.Name = "txtbBookingID";
            txtbBookingID.ReadOnly = true;
            txtbBookingID.Size = new Size(364, 43);
            txtbBookingID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(11, 72);
            label3.Name = "label3";
            label3.Size = new Size(132, 32);
            label3.TabIndex = 9;
            label3.Text = "Booking ID";
            // 
            // btnOpenFilter
            // 
            btnOpenFilter.BackColor = Color.FromArgb(85, 193, 255);
            btnOpenFilter.FlatAppearance.BorderSize = 0;
            btnOpenFilter.FlatStyle = FlatStyle.Flat;
            btnOpenFilter.Font = new Font("Segoe UI", 22F);
            btnOpenFilter.Location = new Point(13, 362);
            btnOpenFilter.Name = "btnOpenFilter";
            btnOpenFilter.Size = new Size(261, 51);
            btnOpenFilter.TabIndex = 13;
            btnOpenFilter.Text = "Filter bookings";
            btnOpenFilter.UseVisualStyleBackColor = false;
            btnOpenFilter.Click += btnOpenFilter_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(85, 193, 255);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 22F);
            button1.Location = new Point(525, 362);
            button1.Name = "button1";
            button1.Size = new Size(225, 51);
            button1.TabIndex = 14;
            button1.Text = "Edit booking";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(48, 889);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 221);
            panel2.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(406, 5);
            label1.Name = "label1";
            label1.Size = new Size(422, 65);
            label1.TabIndex = 20;
            label1.Text = "Manage Bookings";
            // 
            // panel3
            // 
            panel3.Controls.Add(BookingTable);
            panel3.Controls.Add(btnOpenFilter);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(234, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 423);
            panel3.TabIndex = 44;
            // 
            // ViewBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1315, 914);
            Controls.Add(pnlFilter);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlHideAddServices);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBookings";
            Text = "ViewBookings";
            Load += ViewBookings_Load;
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookingTable).EndInit();
            pnlHideAddServices.ResumeLayout(false);
            pnlHideAddServices.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtPicker;
        private Panel pnlFilter;
        private DataGridView BookingTable;
        private CheckBox cbDate;
        private Button btnDelete;
        private Button btnFilter;
        private Label label2;
        private TextBox txtbCustomerID;
        private Button btnReset;
        private CheckBox cbIgnoreID;
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
        private Button btnOpenFilter;
        private Panel pnlHideAddServices;
        private Button button1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label12;
        private Label label13;
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
        private DataGridViewTextBoxColumn clmBookingID;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmFIrstname;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn clmDate;
        private Button btnSaveQuantity;
        private Button btnServiceDelete;
        private ComboBox cmbServiceDelete;
        private Label label14;
    }
}