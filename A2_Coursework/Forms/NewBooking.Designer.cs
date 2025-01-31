namespace A2_Coursework
{
    partial class NewBooking
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
            btnWindows = new Button();
            txtbCustomerID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCarpets = new Button();
            btnDusting = new Button();
            btnDoors = new Button();
            btnFloors = new Button();
            btnBathrooms = new Button();
            btnRoomVacuum = new Button();
            btnCurtains = new Button();
            BookingDate = new DateTimePicker();
            pnlCustomerDetails = new Panel();
            btnUnselect = new Button();
            pnlDatabase = new Panel();
            DataGridCustomers = new DataGridView();
            clmCustomerID = new DataGridViewTextBoxColumn();
            clmForename = new DataGridViewTextBoxColumn();
            clmSurname = new DataGridViewTextBoxColumn();
            clmDOB = new DataGridViewTextBoxColumn();
            clmGender = new DataGridViewTextBoxColumn();
            clmAddressOne = new DataGridViewTextBoxColumn();
            clmAddressTwo = new DataGridViewTextBoxColumn();
            clmEmail = new DataGridViewTextBoxColumn();
            lblCustSelected = new Label();
            ExistingCustomer = new CheckBox();
            pnlBookingDetails = new Panel();
            btnFurniture = new Button();
            numUpDownDeepclean = new NumericUpDown();
            btnViewPrice = new Button();
            btndeepClean = new Button();
            pnlPrices = new Panel();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label20 = new Label();
            label19 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label12 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            NumKitchenApp = new NumericUpDown();
            btnKitchenApp = new Button();
            NumFurniture = new NumericUpDown();
            NumCurtains = new NumericUpDown();
            NumCarpets = new NumericUpDown();
            NumDusting = new NumericUpDown();
            NumDoors = new NumericUpDown();
            NumFloors = new NumericUpDown();
            NumWindows = new NumericUpDown();
            NumBathroom = new NumericUpDown();
            lblDateError = new Label();
            btnSubmit = new Button();
            pnlAddCustomer = new Panel();
            cmbGender_ = new ComboBox();
            dtPickerDOB_ = new DateTimePicker();
            Add = new Label();
            txtbAddressTwo_ = new TextBox();
            txtbEmail_ = new TextBox();
            label6 = new Label();
            txtbAddressOne_ = new TextBox();
            label7 = new Label();
            txtbSurname_ = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtbFirstname_ = new TextBox();
            label11 = new Label();
            btnNext = new Button();
            btnBack = new Button();
            pnlCustomerDetails.SuspendLayout();
            pnlDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).BeginInit();
            pnlBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownDeepclean).BeginInit();
            pnlPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumKitchenApp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumFurniture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumCurtains).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumCarpets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumDusting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumDoors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumFloors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumWindows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumBathroom).BeginInit();
            pnlAddCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // btnWindows
            // 
            btnWindows.BackColor = SystemColors.ButtonHighlight;
            btnWindows.FlatStyle = FlatStyle.Flat;
            btnWindows.Font = new Font("Segoe UI", 18F);
            btnWindows.ForeColor = Color.Black;
            btnWindows.Location = new Point(18, 202);
            btnWindows.Name = "btnWindows";
            btnWindows.Size = new Size(329, 53);
            btnWindows.TabIndex = 0;
            btnWindows.Text = "Window wash and dry";
            btnWindows.UseVisualStyleBackColor = false;
            btnWindows.Click += btnWindows_Click;
            // 
            // txtbCustomerID
            // 
            txtbCustomerID.Font = new Font("Segoe UI", 18F);
            txtbCustomerID.Location = new Point(155, 75);
            txtbCustomerID.Name = "txtbCustomerID";
            txtbCustomerID.Size = new Size(93, 39);
            txtbCustomerID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(15, 80);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 5;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(144, 151);
            label2.Name = "label2";
            label2.Size = new Size(73, 37);
            label2.TabIndex = 6;
            label2.Text = "Date";
            // 
            // btnCarpets
            // 
            btnCarpets.BackColor = SystemColors.ButtonHighlight;
            btnCarpets.FlatStyle = FlatStyle.Flat;
            btnCarpets.Font = new Font("Segoe UI", 18F);
            btnCarpets.ForeColor = Color.Black;
            btnCarpets.Location = new Point(439, 251);
            btnCarpets.Name = "btnCarpets";
            btnCarpets.Size = new Size(325, 53);
            btnCarpets.TabIndex = 11;
            btnCarpets.Text = "Complete carpet clean";
            btnCarpets.UseVisualStyleBackColor = false;
            btnCarpets.Click += btnVacuuming_Click;
            // 
            // btnDusting
            // 
            btnDusting.BackColor = SystemColors.ButtonHighlight;
            btnDusting.FlatStyle = FlatStyle.Flat;
            btnDusting.Font = new Font("Segoe UI", 18F);
            btnDusting.ForeColor = Color.Black;
            btnDusting.Location = new Point(18, 356);
            btnDusting.Name = "btnDusting";
            btnDusting.Size = new Size(329, 53);
            btnDusting.TabIndex = 13;
            btnDusting.Text = "Room dusting";
            btnDusting.UseVisualStyleBackColor = false;
            btnDusting.Click += btnDusting_Click;
            // 
            // btnDoors
            // 
            btnDoors.BackColor = SystemColors.ButtonHighlight;
            btnDoors.FlatStyle = FlatStyle.Flat;
            btnDoors.Font = new Font("Segoe UI", 18F);
            btnDoors.ForeColor = Color.Black;
            btnDoors.Location = new Point(18, 305);
            btnDoors.Name = "btnDoors";
            btnDoors.Size = new Size(329, 53);
            btnDoors.TabIndex = 14;
            btnDoors.Text = "Door clean";
            btnDoors.UseVisualStyleBackColor = false;
            btnDoors.Click += btnDoors_Click;
            // 
            // btnFloors
            // 
            btnFloors.BackColor = SystemColors.ButtonHighlight;
            btnFloors.FlatStyle = FlatStyle.Flat;
            btnFloors.Font = new Font("Segoe UI", 18F);
            btnFloors.ForeColor = Color.Black;
            btnFloors.Location = new Point(18, 253);
            btnFloors.Name = "btnFloors";
            btnFloors.Size = new Size(329, 53);
            btnFloors.TabIndex = 15;
            btnFloors.Text = "Floor hoover and mop";
            btnFloors.UseVisualStyleBackColor = false;
            btnFloors.Click += btnFloors_Click;
            // 
            // btnBathrooms
            // 
            btnBathrooms.BackColor = SystemColors.ButtonHighlight;
            btnBathrooms.FlatStyle = FlatStyle.Flat;
            btnBathrooms.Font = new Font("Segoe UI", 18F);
            btnBathrooms.ForeColor = Color.Black;
            btnBathrooms.Location = new Point(439, 199);
            btnBathrooms.Name = "btnBathrooms";
            btnBathrooms.Size = new Size(325, 53);
            btnBathrooms.TabIndex = 16;
            btnBathrooms.TabStop = false;
            btnBathrooms.Text = "Full bathroom clean";
            btnBathrooms.UseVisualStyleBackColor = false;
            btnBathrooms.Click += btnBathrooms_Click;
            // 
            // btnRoomVacuum
            // 
            btnRoomVacuum.BackColor = SystemColors.ButtonHighlight;
            btnRoomVacuum.FlatStyle = FlatStyle.Flat;
            btnRoomVacuum.Font = new Font("Segoe UI", 18F);
            btnRoomVacuum.ForeColor = Color.Black;
            btnRoomVacuum.Location = new Point(173, 4);
            btnRoomVacuum.Name = "btnRoomVacuum";
            btnRoomVacuum.Size = new Size(207, 54);
            btnRoomVacuum.TabIndex = 41;
            btnRoomVacuum.Text = "Room Vacuum";
            btnRoomVacuum.UseVisualStyleBackColor = false;
            btnRoomVacuum.Click += btnRoomVacuum_Click;
            // 
            // btnCurtains
            // 
            btnCurtains.BackColor = SystemColors.ButtonHighlight;
            btnCurtains.FlatStyle = FlatStyle.Flat;
            btnCurtains.Font = new Font("Segoe UI", 18F);
            btnCurtains.ForeColor = Color.Black;
            btnCurtains.Location = new Point(439, 303);
            btnCurtains.Name = "btnCurtains";
            btnCurtains.Size = new Size(325, 53);
            btnCurtains.TabIndex = 42;
            btnCurtains.Text = "Complete curtain clean";
            btnCurtains.UseVisualStyleBackColor = false;
            btnCurtains.Click += btnCurtains_Click;
            // 
            // BookingDate
            // 
            BookingDate.CalendarFont = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BookingDate.Font = new Font("Segoe UI", 22F);
            BookingDate.Location = new Point(223, 144);
            BookingDate.Name = "BookingDate";
            BookingDate.Size = new Size(277, 47);
            BookingDate.TabIndex = 47;
            BookingDate.ValueChanged += BookingDate_ValueChanged;
            // 
            // pnlCustomerDetails
            // 
            pnlCustomerDetails.BackColor = Color.FromArgb(109, 132, 156);
            pnlCustomerDetails.Controls.Add(btnUnselect);
            pnlCustomerDetails.Controls.Add(pnlDatabase);
            pnlCustomerDetails.Controls.Add(lblCustSelected);
            pnlCustomerDetails.Controls.Add(label1);
            pnlCustomerDetails.Controls.Add(txtbCustomerID);
            pnlCustomerDetails.Controls.Add(ExistingCustomer);
            pnlCustomerDetails.Location = new Point(30, 29);
            pnlCustomerDetails.Name = "pnlCustomerDetails";
            pnlCustomerDetails.Size = new Size(1164, 600);
            pnlCustomerDetails.TabIndex = 48;
            // 
            // btnUnselect
            // 
            btnUnselect.BackColor = Color.FromArgb(50, 55, 59);
            btnUnselect.FlatAppearance.BorderSize = 0;
            btnUnselect.FlatStyle = FlatStyle.Flat;
            btnUnselect.Font = new Font("Microsoft Sans Serif", 20F);
            btnUnselect.ForeColor = Color.White;
            btnUnselect.Location = new Point(585, 576);
            btnUnselect.Name = "btnUnselect";
            btnUnselect.Size = new Size(164, 68);
            btnUnselect.TabIndex = 60;
            btnUnselect.Text = "Unselect";
            btnUnselect.UseVisualStyleBackColor = false;
            btnUnselect.Click += btnUnselect_Click;
            // 
            // pnlDatabase
            // 
            pnlDatabase.Controls.Add(DataGridCustomers);
            pnlDatabase.Location = new Point(9, 182);
            pnlDatabase.Name = "pnlDatabase";
            pnlDatabase.Size = new Size(1154, 388);
            pnlDatabase.TabIndex = 57;
            pnlDatabase.Visible = false;
            // 
            // DataGridCustomers
            // 
            DataGridCustomers.AllowUserToAddRows = false;
            DataGridCustomers.AllowUserToDeleteRows = false;
            DataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCustomers.Columns.AddRange(new DataGridViewColumn[] { clmCustomerID, clmForename, clmSurname, clmDOB, clmGender, clmAddressOne, clmAddressTwo, clmEmail });
            DataGridCustomers.Dock = DockStyle.Fill;
            DataGridCustomers.GridColor = Color.FromArgb(109, 132, 156);
            DataGridCustomers.Location = new Point(0, 0);
            DataGridCustomers.Name = "DataGridCustomers";
            DataGridCustomers.ReadOnly = true;
            DataGridCustomers.Size = new Size(1154, 388);
            DataGridCustomers.TabIndex = 0;
            DataGridCustomers.CellClick += DataGridCustomers_CellClick;
            // 
            // clmCustomerID
            // 
            clmCustomerID.HeaderText = "ID";
            clmCustomerID.Name = "clmCustomerID";
            clmCustomerID.ReadOnly = true;
            clmCustomerID.Width = 50;
            // 
            // clmForename
            // 
            clmForename.HeaderText = "Forename";
            clmForename.Name = "clmForename";
            clmForename.ReadOnly = true;
            clmForename.Width = 125;
            // 
            // clmSurname
            // 
            clmSurname.HeaderText = "Surname";
            clmSurname.Name = "clmSurname";
            clmSurname.ReadOnly = true;
            clmSurname.Width = 125;
            // 
            // clmDOB
            // 
            clmDOB.HeaderText = "Date of Birth";
            clmDOB.Name = "clmDOB";
            clmDOB.ReadOnly = true;
            clmDOB.Width = 125;
            // 
            // clmGender
            // 
            clmGender.HeaderText = "Gender";
            clmGender.Name = "clmGender";
            clmGender.ReadOnly = true;
            // 
            // clmAddressOne
            // 
            clmAddressOne.HeaderText = "Address";
            clmAddressOne.Name = "clmAddressOne";
            clmAddressOne.ReadOnly = true;
            clmAddressOne.Width = 200;
            // 
            // clmAddressTwo
            // 
            clmAddressTwo.HeaderText = "Address";
            clmAddressTwo.Name = "clmAddressTwo";
            clmAddressTwo.ReadOnly = true;
            clmAddressTwo.Width = 125;
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.Name = "clmEmail";
            clmEmail.ReadOnly = true;
            clmEmail.Width = 275;
            // 
            // lblCustSelected
            // 
            lblCustSelected.AutoSize = true;
            lblCustSelected.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustSelected.ForeColor = Color.Black;
            lblCustSelected.Location = new Point(862, 66);
            lblCustSelected.Name = "lblCustSelected";
            lblCustSelected.Size = new Size(164, 25);
            lblCustSelected.TabIndex = 56;
            lblCustSelected.Text = "CustomerSelected";
            lblCustSelected.Visible = false;
            // 
            // ExistingCustomer
            // 
            ExistingCustomer.AutoSize = true;
            ExistingCustomer.Font = new Font("Segoe UI", 20F);
            ExistingCustomer.ForeColor = Color.Black;
            ExistingCustomer.Location = new Point(862, 19);
            ExistingCustomer.Name = "ExistingCustomer";
            ExistingCustomer.Size = new Size(248, 41);
            ExistingCustomer.TabIndex = 50;
            ExistingCustomer.Text = "Existing Customer";
            ExistingCustomer.UseVisualStyleBackColor = true;
            ExistingCustomer.CheckedChanged += ExistingCustomer_CheckedChanged;
            // 
            // pnlBookingDetails
            // 
            pnlBookingDetails.Controls.Add(btnFurniture);
            pnlBookingDetails.Controls.Add(numUpDownDeepclean);
            pnlBookingDetails.Controls.Add(btnViewPrice);
            pnlBookingDetails.Controls.Add(btndeepClean);
            pnlBookingDetails.Controls.Add(pnlPrices);
            pnlBookingDetails.Controls.Add(NumKitchenApp);
            pnlBookingDetails.Controls.Add(btnKitchenApp);
            pnlBookingDetails.Controls.Add(NumFurniture);
            pnlBookingDetails.Controls.Add(NumCurtains);
            pnlBookingDetails.Controls.Add(NumCarpets);
            pnlBookingDetails.Controls.Add(NumDusting);
            pnlBookingDetails.Controls.Add(NumDoors);
            pnlBookingDetails.Controls.Add(NumFloors);
            pnlBookingDetails.Controls.Add(NumWindows);
            pnlBookingDetails.Controls.Add(NumBathroom);
            pnlBookingDetails.Controls.Add(lblDateError);
            pnlBookingDetails.Controls.Add(btnSubmit);
            pnlBookingDetails.Controls.Add(btnFloors);
            pnlBookingDetails.Controls.Add(label2);
            pnlBookingDetails.Controls.Add(btnWindows);
            pnlBookingDetails.Controls.Add(BookingDate);
            pnlBookingDetails.Controls.Add(btnCarpets);
            pnlBookingDetails.Controls.Add(btnDusting);
            pnlBookingDetails.Controls.Add(btnDoors);
            pnlBookingDetails.Controls.Add(btnCurtains);
            pnlBookingDetails.Controls.Add(btnBathrooms);
            pnlBookingDetails.Controls.Add(btnRoomVacuum);
            pnlBookingDetails.ForeColor = Color.White;
            pnlBookingDetails.Location = new Point(12, 8);
            pnlBookingDetails.Name = "pnlBookingDetails";
            pnlBookingDetails.Size = new Size(1167, 653);
            pnlBookingDetails.TabIndex = 1;
            pnlBookingDetails.Visible = false;
            // 
            // btnFurniture
            // 
            btnFurniture.BackColor = SystemColors.ButtonHighlight;
            btnFurniture.FlatStyle = FlatStyle.Flat;
            btnFurniture.Font = new Font("Segoe UI", 18F);
            btnFurniture.ForeColor = Color.Black;
            btnFurniture.Location = new Point(439, 354);
            btnFurniture.Name = "btnFurniture";
            btnFurniture.Size = new Size(325, 53);
            btnFurniture.TabIndex = 62;
            btnFurniture.Text = "Furniture clean";
            btnFurniture.UseVisualStyleBackColor = false;
            btnFurniture.Click += button1_Click;
            // 
            // numUpDownDeepclean
            // 
            numUpDownDeepclean.Font = new Font("Segoe UI", 25F);
            numUpDownDeepclean.Location = new Point(770, 409);
            numUpDownDeepclean.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numUpDownDeepclean.Name = "numUpDownDeepclean";
            numUpDownDeepclean.Size = new Size(62, 52);
            numUpDownDeepclean.TabIndex = 61;
            // 
            // btnViewPrice
            // 
            btnViewPrice.BackColor = Color.FromArgb(50, 55, 59);
            btnViewPrice.FlatAppearance.BorderSize = 0;
            btnViewPrice.FlatStyle = FlatStyle.Flat;
            btnViewPrice.Font = new Font("Segoe UI", 20F);
            btnViewPrice.ForeColor = Color.White;
            btnViewPrice.Location = new Point(892, 26);
            btnViewPrice.Name = "btnViewPrice";
            btnViewPrice.Size = new Size(225, 62);
            btnViewPrice.TabIndex = 58;
            btnViewPrice.Text = "View Price list";
            btnViewPrice.UseVisualStyleBackColor = false;
            btnViewPrice.Click += btnViewPrice_Click;
            // 
            // btndeepClean
            // 
            btndeepClean.BackColor = SystemColors.ButtonHighlight;
            btndeepClean.FlatStyle = FlatStyle.Flat;
            btndeepClean.Font = new Font("Segoe UI", 18F);
            btndeepClean.ForeColor = Color.Black;
            btndeepClean.Location = new Point(439, 406);
            btndeepClean.Name = "btndeepClean";
            btndeepClean.Size = new Size(325, 53);
            btndeepClean.TabIndex = 60;
            btndeepClean.Text = "Room deep clean";
            btndeepClean.UseVisualStyleBackColor = false;
            btndeepClean.Click += btndeepClean_Click;
            // 
            // pnlPrices
            // 
            pnlPrices.Controls.Add(label28);
            pnlPrices.Controls.Add(label27);
            pnlPrices.Controls.Add(label26);
            pnlPrices.Controls.Add(label25);
            pnlPrices.Controls.Add(label24);
            pnlPrices.Controls.Add(label23);
            pnlPrices.Controls.Add(label22);
            pnlPrices.Controls.Add(label20);
            pnlPrices.Controls.Add(label19);
            pnlPrices.Controls.Add(label16);
            pnlPrices.Controls.Add(label17);
            pnlPrices.Controls.Add(label18);
            pnlPrices.Controls.Add(label13);
            pnlPrices.Controls.Add(label14);
            pnlPrices.Controls.Add(label15);
            pnlPrices.Controls.Add(label12);
            pnlPrices.Controls.Add(label5);
            pnlPrices.Controls.Add(label4);
            pnlPrices.Controls.Add(label3);
            pnlPrices.Location = new Point(847, 96);
            pnlPrices.Name = "pnlPrices";
            pnlPrices.Size = new Size(318, 503);
            pnlPrices.TabIndex = 61;
            pnlPrices.Visible = false;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 20F);
            label28.ForeColor = Color.White;
            label28.Location = new Point(96, 452);
            label28.Name = "label28";
            label28.Size = new Size(47, 37);
            label28.TabIndex = 19;
            label28.Text = "£1";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 20F);
            label27.ForeColor = Color.White;
            label27.Location = new Point(188, 400);
            label27.Name = "label27";
            label27.Size = new Size(47, 37);
            label27.TabIndex = 18;
            label27.Text = "£5";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 20F);
            label26.ForeColor = Color.White;
            label26.Location = new Point(108, 357);
            label26.Name = "label26";
            label26.Size = new Size(47, 37);
            label26.TabIndex = 17;
            label26.Text = "£1";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 20F);
            label25.ForeColor = Color.White;
            label25.Location = new Point(96, 303);
            label25.Name = "label25";
            label25.Size = new Size(47, 37);
            label25.TabIndex = 16;
            label25.Text = "£1";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 20F);
            label24.ForeColor = Color.White;
            label24.Location = new Point(88, 105);
            label24.Name = "label24";
            label24.Size = new Size(47, 37);
            label24.TabIndex = 15;
            label24.Text = "£1";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 20F);
            label23.ForeColor = Color.White;
            label23.Location = new Point(83, 158);
            label23.Name = "label23";
            label23.Size = new Size(47, 37);
            label23.TabIndex = 14;
            label23.Text = "£1";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 20F);
            label22.ForeColor = Color.White;
            label22.Location = new Point(110, 208);
            label22.Name = "label22";
            label22.Size = new Size(47, 37);
            label22.TabIndex = 13;
            label22.Text = "£1";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 20F);
            label20.ForeColor = Color.White;
            label20.Location = new Point(134, 253);
            label20.Name = "label20";
            label20.Size = new Size(62, 37);
            label20.TabIndex = 11;
            label20.Text = "£15";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 20F);
            label19.ForeColor = Color.White;
            label19.Location = new Point(124, 59);
            label19.Name = "label19";
            label19.Size = new Size(47, 37);
            label19.TabIndex = 10;
            label19.Text = "£1";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 20F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(3, 354);
            label16.Name = "label16";
            label16.Size = new Size(109, 37);
            label16.TabIndex = 9;
            label16.Text = "Curtain:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 20F);
            label17.ForeColor = Color.White;
            label17.Location = new Point(3, 400);
            label17.Name = "label17";
            label17.Size = new Size(192, 37);
            label17.TabIndex = 8;
            label17.Text = "Room vacuum:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 20F);
            label18.ForeColor = Color.White;
            label18.Location = new Point(3, 452);
            label18.Name = "label18";
            label18.Size = new Size(102, 37);
            label18.TabIndex = 7;
            label18.Text = "Carpet:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 20F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(3, 205);
            label13.Name = "label13";
            label13.Size = new Size(115, 37);
            label13.TabIndex = 6;
            label13.Text = "Dusting:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(3, 251);
            label14.Name = "label14";
            label14.Size = new Size(140, 37);
            label14.TabIndex = 5;
            label14.Text = "Bathroom:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 20F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(3, 303);
            label15.Name = "label15";
            label15.Size = new Size(102, 37);
            label15.TabIndex = 4;
            label15.Text = "Carpet:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 58);
            label12.Name = "label12";
            label12.Size = new Size(129, 37);
            label12.TabIndex = 3;
            label12.Text = "Window :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 104);
            label5.Name = "label5";
            label5.Size = new Size(91, 37);
            label5.TabIndex = 2;
            label5.Text = "Floor :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 156);
            label4.Name = "label4";
            label4.Size = new Size(83, 37);
            label4.TabIndex = 1;
            label4.Text = "Door:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(132, 37);
            label3.TabIndex = 0;
            label3.Text = "Price per:";
            // 
            // NumKitchenApp
            // 
            NumKitchenApp.Font = new Font("Segoe UI", 25F);
            NumKitchenApp.Location = new Point(353, 409);
            NumKitchenApp.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumKitchenApp.Name = "NumKitchenApp";
            NumKitchenApp.Size = new Size(62, 52);
            NumKitchenApp.TabIndex = 59;
            // 
            // btnKitchenApp
            // 
            btnKitchenApp.BackColor = SystemColors.ButtonHighlight;
            btnKitchenApp.FlatStyle = FlatStyle.Flat;
            btnKitchenApp.Font = new Font("Segoe UI", 18F);
            btnKitchenApp.ForeColor = Color.Black;
            btnKitchenApp.Location = new Point(18, 409);
            btnKitchenApp.Name = "btnKitchenApp";
            btnKitchenApp.Size = new Size(329, 53);
            btnKitchenApp.TabIndex = 58;
            btnKitchenApp.Text = "All kitchen appliances";
            btnKitchenApp.UseVisualStyleBackColor = false;
            btnKitchenApp.Click += btnKitchenApp_Click;
            // 
            // NumFurniture
            // 
            NumFurniture.Font = new Font("Segoe UI", 25F);
            NumFurniture.Location = new Point(770, 355);
            NumFurniture.Name = "NumFurniture";
            NumFurniture.Size = new Size(62, 52);
            NumFurniture.TabIndex = 57;
            // 
            // NumCurtains
            // 
            NumCurtains.Font = new Font("Segoe UI", 25F);
            NumCurtains.Location = new Point(770, 303);
            NumCurtains.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumCurtains.Name = "NumCurtains";
            NumCurtains.Size = new Size(62, 52);
            NumCurtains.TabIndex = 56;
            // 
            // NumCarpets
            // 
            NumCarpets.Font = new Font("Segoe UI", 25F);
            NumCarpets.Location = new Point(770, 251);
            NumCarpets.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumCarpets.Name = "NumCarpets";
            NumCarpets.Size = new Size(62, 52);
            NumCarpets.TabIndex = 55;
            // 
            // NumDusting
            // 
            NumDusting.Font = new Font("Segoe UI", 25F);
            NumDusting.Location = new Point(353, 356);
            NumDusting.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumDusting.Name = "NumDusting";
            NumDusting.Size = new Size(62, 52);
            NumDusting.TabIndex = 54;
            // 
            // NumDoors
            // 
            NumDoors.Font = new Font("Segoe UI", 25F);
            NumDoors.Location = new Point(353, 306);
            NumDoors.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumDoors.Name = "NumDoors";
            NumDoors.Size = new Size(62, 52);
            NumDoors.TabIndex = 53;
            // 
            // NumFloors
            // 
            NumFloors.Font = new Font("Segoe UI", 25F);
            NumFloors.Location = new Point(353, 254);
            NumFloors.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumFloors.Name = "NumFloors";
            NumFloors.Size = new Size(62, 52);
            NumFloors.TabIndex = 52;
            // 
            // NumWindows
            // 
            NumWindows.Font = new Font("Segoe UI", 25F);
            NumWindows.Location = new Point(353, 202);
            NumWindows.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumWindows.Name = "NumWindows";
            NumWindows.Size = new Size(62, 52);
            NumWindows.TabIndex = 51;
            // 
            // NumBathroom
            // 
            NumBathroom.Font = new Font("Segoe UI", 25F);
            NumBathroom.Location = new Point(770, 199);
            NumBathroom.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumBathroom.Name = "NumBathroom";
            NumBathroom.Size = new Size(62, 52);
            NumBathroom.TabIndex = 49;
            // 
            // lblDateError
            // 
            lblDateError.AutoSize = true;
            lblDateError.Font = new Font("Segoe UI", 12F);
            lblDateError.ForeColor = Color.White;
            lblDateError.Location = new Point(540, 157);
            lblDateError.Name = "lblDateError";
            lblDateError.Size = new Size(265, 21);
            lblDateError.TabIndex = 48;
            lblDateError.Text = "Booking must be 2 weeks in advance";
            lblDateError.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(50, 55, 59);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 20F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(461, 537);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(139, 62);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pnlAddCustomer
            // 
            pnlAddCustomer.Controls.Add(cmbGender_);
            pnlAddCustomer.Controls.Add(dtPickerDOB_);
            pnlAddCustomer.Controls.Add(Add);
            pnlAddCustomer.Controls.Add(txtbAddressTwo_);
            pnlAddCustomer.Controls.Add(txtbEmail_);
            pnlAddCustomer.Controls.Add(label6);
            pnlAddCustomer.Controls.Add(txtbAddressOne_);
            pnlAddCustomer.Controls.Add(label7);
            pnlAddCustomer.Controls.Add(txtbSurname_);
            pnlAddCustomer.Controls.Add(label8);
            pnlAddCustomer.Controls.Add(label9);
            pnlAddCustomer.Controls.Add(label10);
            pnlAddCustomer.Controls.Add(txtbFirstname_);
            pnlAddCustomer.Controls.Add(label11);
            pnlAddCustomer.Location = new Point(12, 8);
            pnlAddCustomer.Name = "pnlAddCustomer";
            pnlAddCustomer.Size = new Size(823, 665);
            pnlAddCustomer.TabIndex = 58;
            // 
            // cmbGender_
            // 
            cmbGender_.Font = new Font("Segoe UI", 20F);
            cmbGender_.FormattingEnabled = true;
            cmbGender_.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender_.Location = new Point(283, 195);
            cmbGender_.Name = "cmbGender_";
            cmbGender_.Size = new Size(326, 45);
            cmbGender_.TabIndex = 32;
            // 
            // dtPickerDOB_
            // 
            dtPickerDOB_.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerDOB_.Location = new Point(283, 135);
            dtPickerDOB_.Name = "dtPickerDOB_";
            dtPickerDOB_.Size = new Size(326, 50);
            dtPickerDOB_.TabIndex = 22;
            dtPickerDOB_.ValueChanged += dtPickerDOB__ValueChanged;
            // 
            // Add
            // 
            Add.AutoSize = true;
            Add.Font = new Font("Segoe UI", 24F);
            Add.ForeColor = Color.Black;
            Add.Location = new Point(11, 309);
            Add.Name = "Add";
            Add.Size = new Size(257, 45);
            Add.TabIndex = 31;
            Add.Text = "Address line two";
            // 
            // txtbAddressTwo_
            // 
            txtbAddressTwo_.Font = new Font("Segoe UI", 24F);
            txtbAddressTwo_.Location = new Point(283, 309);
            txtbAddressTwo_.Name = "txtbAddressTwo_";
            txtbAddressTwo_.Size = new Size(326, 50);
            txtbAddressTwo_.TabIndex = 30;
            // 
            // txtbEmail_
            // 
            txtbEmail_.Font = new Font("Segoe UI", 24F);
            txtbEmail_.Location = new Point(283, 365);
            txtbEmail_.Name = "txtbEmail_";
            txtbEmail_.Size = new Size(326, 50);
            txtbEmail_.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(172, 365);
            label6.Name = "label6";
            label6.Size = new Size(96, 45);
            label6.TabIndex = 28;
            label6.Text = "Email";
            // 
            // txtbAddressOne_
            // 
            txtbAddressOne_.Font = new Font("Segoe UI", 24F);
            txtbAddressOne_.Location = new Point(283, 251);
            txtbAddressOne_.Name = "txtbAddressOne_";
            txtbAddressOne_.Size = new Size(326, 50);
            txtbAddressOne_.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(3, 254);
            label7.Name = "label7";
            label7.Size = new Size(258, 45);
            label7.TabIndex = 26;
            label7.Text = "Address line one";
            // 
            // txtbSurname_
            // 
            txtbSurname_.Font = new Font("Segoe UI", 24F);
            txtbSurname_.Location = new Point(283, 79);
            txtbSurname_.Name = "txtbSurname_";
            txtbSurname_.Size = new Size(326, 50);
            txtbSurname_.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(144, 191);
            label8.Name = "label8";
            label8.Size = new Size(124, 45);
            label8.TabIndex = 24;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(69, 135);
            label9.Name = "label9";
            label9.Size = new Size(199, 45);
            label9.TabIndex = 23;
            label9.Text = "Date of Birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(123, 79);
            label10.Name = "label10";
            label10.Size = new Size(145, 45);
            label10.TabIndex = 21;
            label10.Text = "Surname";
            // 
            // txtbFirstname_
            // 
            txtbFirstname_.Font = new Font("Segoe UI", 24F);
            txtbFirstname_.Location = new Point(283, 23);
            txtbFirstname_.Name = "txtbFirstname_";
            txtbFirstname_.Size = new Size(326, 50);
            txtbFirstname_.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 24F);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(118, 23);
            label11.Name = "label11";
            label11.Size = new Size(159, 45);
            label11.TabIndex = 19;
            label11.Text = "Firstname";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(50, 55, 59);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 20F);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1076, 683);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(115, 61);
            btnNext.TabIndex = 58;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(50, 55, 59);
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 20F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(937, 683);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(133, 61);
            btnBack.TabIndex = 59;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // NewBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1197, 756);
            Controls.Add(pnlBookingDetails);
            Controls.Add(pnlAddCustomer);
            Controls.Add(pnlCustomerDetails);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            ForeColor = Color.DarkGreen;
            Name = "NewBooking";
            Text = "NewBooking";
            Load += NewBooking_Load;
            pnlCustomerDetails.ResumeLayout(false);
            pnlCustomerDetails.PerformLayout();
            pnlDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).EndInit();
            pnlBookingDetails.ResumeLayout(false);
            pnlBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUpDownDeepclean).EndInit();
            pnlPrices.ResumeLayout(false);
            pnlPrices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumKitchenApp).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumFurniture).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumCurtains).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumCarpets).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumDusting).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumDoors).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumFloors).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumWindows).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumBathroom).EndInit();
            pnlAddCustomer.ResumeLayout(false);
            pnlAddCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnWindows;
        private TextBox txtbCustomerID;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button btnCarpets;
        private Button btnDusting;
        private Button btnDoors;
        private Button btnFloors;
        private Button btnBathrooms;
        private TrackBar trackBar1;
        private Button btnRoomVacuum;
        private Button btnCurtains;
        private DateTimePicker BookingDate;
        private Panel pnlCustomerDetails;
        private Button btnSubmit;
        private CheckBox ExistingCustomer;
        private Label lblCustSelected;
        private Panel pnlDatabase;
        private DataGridView DataGridCustomers;
        private Panel pnlBookingDetails;
        private Button btnNext;
        private Button btnBack;
        private Button btnUnselect;
        private Panel pnlAddCustomer;
        private ComboBox cmbGender_;
        private DateTimePicker dtPickerDOB_;
        private Label Add;
        private TextBox txtbAddressTwo_;
        private TextBox txtbEmail_;
        private Label label6;
        private TextBox txtbAddressOne_;
        private Label label7;
        private TextBox txtbSurname_;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtbFirstname_;
        private Label label11;
        private Label lblDateError;
        private NumericUpDown NumBathroom;
        private NumericUpDown NumFurniture;
        private NumericUpDown NumCurtains;
        private NumericUpDown NumCarpets;
        private NumericUpDown NumDusting;
        private NumericUpDown NumDoors;
        private NumericUpDown NumFloors;
        private NumericUpDown NumWindows;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmForename;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn clmDOB;
        private DataGridViewTextBoxColumn clmGender;
        private DataGridViewTextBoxColumn clmAddressOne;
        private DataGridViewTextBoxColumn clmAddressTwo;
        private DataGridViewTextBoxColumn clmEmail;
        private Panel pnlPrices;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label12;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label19;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button btnViewPrice;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label20;
        private NumericUpDown numUpDownDeepclean;
        private Button btndeepClean;
        private NumericUpDown NumKitchenApp;
        private Button btnKitchenApp;
        private Button btnFurniture;
    }
}