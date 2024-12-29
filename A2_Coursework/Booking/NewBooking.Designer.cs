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
            button5 = new Button();
            btnDusting = new Button();
            btnDoors = new Button();
            btnFloors = new Button();
            btnBathrooms = new Button();
            lblWindowPlus = new Label();
            lblDoorPlus = new Label();
            lblFloorPlus = new Label();
            lblDustPlus = new Label();
            lblBathroomPlus = new Label();
            lblCarpetsPlus = new Label();
            lblCurtainsPlus = new Label();
            lblWIndows = new Label();
            lblDoors = new Label();
            lblFloors = new Label();
            lblDusting = new Label();
            lblBathrooms = new Label();
            lblCarpets = new Label();
            lblCurtains = new Label();
            lblCurtainsMinus = new Label();
            lblCarpetsMinus = new Label();
            lblBathroomMinus = new Label();
            lblDustMinus = new Label();
            lblFloorMinus = new Label();
            lblDoorMinus = new Label();
            lblWIndowsMinus = new Label();
            btnRoomVacuum = new Button();
            btnCurtains = new Button();
            lblVacuumMinus = new Label();
            lblVacuum = new Label();
            lblVacuumPlus = new Label();
            DTPicker = new DateTimePicker();
            pnlCustomerDetails = new Panel();
            pnlBookingDetails = new Panel();
            btnSubmit = new Button();
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
            txtbAddress = new TextBox();
            label5 = new Label();
            txtbSurname = new TextBox();
            label4 = new Label();
            ExistingCustomer = new CheckBox();
            txtbFirstName = new TextBox();
            label3 = new Label();
            btnNext = new Button();
            btnBack = new Button();
            pnlCustomerDetails.SuspendLayout();
            pnlBookingDetails.SuspendLayout();
            pnlDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).BeginInit();
            SuspendLayout();
            // 
            // btnWindows
            // 
            btnWindows.FlatStyle = FlatStyle.Flat;
            btnWindows.Font = new Font("Segoe UI", 18F);
            btnWindows.Location = new Point(62, 73);
            btnWindows.Name = "btnWindows";
            btnWindows.Size = new Size(206, 53);
            btnWindows.TabIndex = 0;
            btnWindows.Text = "Windows";
            btnWindows.UseVisualStyleBackColor = true;
            btnWindows.Click += btnWindows_Click;
            // 
            // txtbCustomerID
            // 
            txtbCustomerID.Font = new Font("Segoe UI", 18F);
            txtbCustomerID.Location = new Point(129, 22);
            txtbCustomerID.Name = "txtbCustomerID";
            txtbCustomerID.Size = new Size(293, 39);
            txtbCustomerID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 27);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "Date";
            // 
            // btnCarpets
            // 
            btnCarpets.FlatStyle = FlatStyle.Flat;
            btnCarpets.Font = new Font("Segoe UI", 18F);
            btnCarpets.Location = new Point(394, 121);
            btnCarpets.Name = "btnCarpets";
            btnCarpets.Size = new Size(206, 53);
            btnCarpets.TabIndex = 11;
            btnCarpets.Text = "Carpets";
            btnCarpets.UseVisualStyleBackColor = true;
            btnCarpets.Click += btnVacuuming_Click;
            // 
            // button5
            // 
            button5.Location = new Point(853, 50);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnDusting
            // 
            btnDusting.FlatStyle = FlatStyle.Flat;
            btnDusting.Font = new Font("Segoe UI", 18F);
            btnDusting.Location = new Point(62, 227);
            btnDusting.Name = "btnDusting";
            btnDusting.Size = new Size(206, 53);
            btnDusting.TabIndex = 13;
            btnDusting.Text = "Dusting";
            btnDusting.UseVisualStyleBackColor = true;
            btnDusting.Click += btnDusting_Click;
            // 
            // btnDoors
            // 
            btnDoors.FlatStyle = FlatStyle.Flat;
            btnDoors.Font = new Font("Segoe UI", 18F);
            btnDoors.Location = new Point(62, 176);
            btnDoors.Name = "btnDoors";
            btnDoors.Size = new Size(206, 53);
            btnDoors.TabIndex = 14;
            btnDoors.Text = "Doors";
            btnDoors.UseVisualStyleBackColor = true;
            btnDoors.Click += btnDoors_Click;
            // 
            // btnFloors
            // 
            btnFloors.FlatStyle = FlatStyle.Flat;
            btnFloors.Font = new Font("Segoe UI", 18F);
            btnFloors.Location = new Point(62, 124);
            btnFloors.Name = "btnFloors";
            btnFloors.Size = new Size(206, 53);
            btnFloors.TabIndex = 15;
            btnFloors.Text = "Floors";
            btnFloors.UseVisualStyleBackColor = true;
            btnFloors.Click += btnFloors_Click;
            // 
            // btnBathrooms
            // 
            btnBathrooms.FlatStyle = FlatStyle.Flat;
            btnBathrooms.Font = new Font("Segoe UI", 18F);
            btnBathrooms.Location = new Point(394, 69);
            btnBathrooms.Name = "btnBathrooms";
            btnBathrooms.Size = new Size(206, 53);
            btnBathrooms.TabIndex = 16;
            btnBathrooms.TabStop = false;
            btnBathrooms.Text = "Bathrooms";
            btnBathrooms.UseVisualStyleBackColor = true;
            btnBathrooms.Click += btnBathrooms_Click;
            // 
            // lblWindowPlus
            // 
            lblWindowPlus.AutoSize = true;
            lblWindowPlus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWindowPlus.Location = new Point(340, 78);
            lblWindowPlus.Name = "lblWindowPlus";
            lblWindowPlus.Size = new Size(48, 50);
            lblWindowPlus.TabIndex = 19;
            lblWindowPlus.Text = "+";
            lblWindowPlus.Click += lblWindowPlus_Click;
            // 
            // lblDoorPlus
            // 
            lblDoorPlus.AutoSize = true;
            lblDoorPlus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoorPlus.Location = new Point(340, 183);
            lblDoorPlus.Name = "lblDoorPlus";
            lblDoorPlus.Size = new Size(48, 50);
            lblDoorPlus.TabIndex = 20;
            lblDoorPlus.Text = "+";
            lblDoorPlus.Click += lblDoorPlus_Click;
            // 
            // lblFloorPlus
            // 
            lblFloorPlus.AutoSize = true;
            lblFloorPlus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFloorPlus.Location = new Point(340, 128);
            lblFloorPlus.Name = "lblFloorPlus";
            lblFloorPlus.Size = new Size(48, 50);
            lblFloorPlus.TabIndex = 21;
            lblFloorPlus.Text = "+";
            lblFloorPlus.Click += lblFloorPlus_Click;
            // 
            // lblDustPlus
            // 
            lblDustPlus.AutoSize = true;
            lblDustPlus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDustPlus.Location = new Point(340, 233);
            lblDustPlus.Name = "lblDustPlus";
            lblDustPlus.Size = new Size(48, 50);
            lblDustPlus.TabIndex = 22;
            lblDustPlus.Text = "+";
            lblDustPlus.Click += lblDustPlus_Click;
            // 
            // lblBathroomPlus
            // 
            lblBathroomPlus.AutoSize = true;
            lblBathroomPlus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBathroomPlus.Location = new Point(672, 74);
            lblBathroomPlus.Name = "lblBathroomPlus";
            lblBathroomPlus.Size = new Size(48, 50);
            lblBathroomPlus.TabIndex = 23;
            lblBathroomPlus.Text = "+";
            lblBathroomPlus.Click += lblBathroomPlus_Click;
            // 
            // lblCarpetsPlus
            // 
            lblCarpetsPlus.AutoSize = true;
            lblCarpetsPlus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarpetsPlus.Location = new Point(672, 131);
            lblCarpetsPlus.Name = "lblCarpetsPlus";
            lblCarpetsPlus.Size = new Size(48, 50);
            lblCarpetsPlus.TabIndex = 24;
            lblCarpetsPlus.Text = "+";
            lblCarpetsPlus.Click += lblCarpetsPlus_Click;
            // 
            // lblCurtainsPlus
            // 
            lblCurtainsPlus.AutoSize = true;
            lblCurtainsPlus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurtainsPlus.Location = new Point(672, 186);
            lblCurtainsPlus.Name = "lblCurtainsPlus";
            lblCurtainsPlus.Size = new Size(48, 50);
            lblCurtainsPlus.TabIndex = 25;
            lblCurtainsPlus.Text = "+";
            lblCurtainsPlus.Click += lblCurtainsPlus_Click;
            // 
            // lblWIndows
            // 
            lblWIndows.AutoSize = true;
            lblWIndows.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWIndows.Location = new Point(310, 87);
            lblWIndows.Name = "lblWIndows";
            lblWIndows.Size = new Size(33, 37);
            lblWIndows.TabIndex = 26;
            lblWIndows.Text = "0";
            // 
            // lblDoors
            // 
            lblDoors.AutoSize = true;
            lblDoors.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoors.Location = new Point(310, 191);
            lblDoors.Name = "lblDoors";
            lblDoors.Size = new Size(33, 37);
            lblDoors.TabIndex = 27;
            lblDoors.Text = "0";
            // 
            // lblFloors
            // 
            lblFloors.AutoSize = true;
            lblFloors.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFloors.Location = new Point(310, 140);
            lblFloors.Name = "lblFloors";
            lblFloors.Size = new Size(33, 37);
            lblFloors.TabIndex = 28;
            lblFloors.Text = "0";
            // 
            // lblDusting
            // 
            lblDusting.AutoSize = true;
            lblDusting.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDusting.Location = new Point(310, 242);
            lblDusting.Name = "lblDusting";
            lblDusting.Size = new Size(33, 37);
            lblDusting.TabIndex = 29;
            lblDusting.Text = "0";
            // 
            // lblBathrooms
            // 
            lblBathrooms.AutoSize = true;
            lblBathrooms.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBathrooms.Location = new Point(642, 84);
            lblBathrooms.Name = "lblBathrooms";
            lblBathrooms.Size = new Size(33, 37);
            lblBathrooms.TabIndex = 30;
            lblBathrooms.Text = "0";
            // 
            // lblCarpets
            // 
            lblCarpets.AutoSize = true;
            lblCarpets.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarpets.Location = new Point(642, 142);
            lblCarpets.Name = "lblCarpets";
            lblCarpets.Size = new Size(33, 37);
            lblCarpets.TabIndex = 31;
            lblCarpets.Text = "0";
            // 
            // lblCurtains
            // 
            lblCurtains.AutoSize = true;
            lblCurtains.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurtains.Location = new Point(642, 196);
            lblCurtains.Name = "lblCurtains";
            lblCurtains.Size = new Size(33, 37);
            lblCurtains.TabIndex = 32;
            lblCurtains.Text = "0";
            // 
            // lblCurtainsMinus
            // 
            lblCurtainsMinus.AutoSize = true;
            lblCurtainsMinus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurtainsMinus.Location = new Point(604, 186);
            lblCurtainsMinus.Name = "lblCurtainsMinus";
            lblCurtainsMinus.Size = new Size(37, 50);
            lblCurtainsMinus.TabIndex = 39;
            lblCurtainsMinus.Text = "-";
            lblCurtainsMinus.Click += lblCurtainsMinus_Click;
            // 
            // lblCarpetsMinus
            // 
            lblCarpetsMinus.AutoSize = true;
            lblCarpetsMinus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarpetsMinus.Location = new Point(604, 132);
            lblCarpetsMinus.Name = "lblCarpetsMinus";
            lblCarpetsMinus.Size = new Size(37, 50);
            lblCarpetsMinus.TabIndex = 38;
            lblCarpetsMinus.Text = "-";
            lblCarpetsMinus.Click += lblCarpetsMinus_Click;
            // 
            // lblBathroomMinus
            // 
            lblBathroomMinus.AutoSize = true;
            lblBathroomMinus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBathroomMinus.Location = new Point(604, 75);
            lblBathroomMinus.Name = "lblBathroomMinus";
            lblBathroomMinus.Size = new Size(37, 50);
            lblBathroomMinus.TabIndex = 37;
            lblBathroomMinus.Text = "-";
            lblBathroomMinus.Click += lblBathroomMinus_Click;
            // 
            // lblDustMinus
            // 
            lblDustMinus.AutoSize = true;
            lblDustMinus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDustMinus.Location = new Point(272, 234);
            lblDustMinus.Name = "lblDustMinus";
            lblDustMinus.Size = new Size(37, 50);
            lblDustMinus.TabIndex = 36;
            lblDustMinus.Text = "-";
            lblDustMinus.Click += lblDustMinus_Click;
            // 
            // lblFloorMinus
            // 
            lblFloorMinus.AutoSize = true;
            lblFloorMinus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFloorMinus.Location = new Point(272, 129);
            lblFloorMinus.Name = "lblFloorMinus";
            lblFloorMinus.Size = new Size(37, 50);
            lblFloorMinus.TabIndex = 35;
            lblFloorMinus.Text = "-";
            lblFloorMinus.Click += lblFloorMinus_Click;
            // 
            // lblDoorMinus
            // 
            lblDoorMinus.AutoSize = true;
            lblDoorMinus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoorMinus.Location = new Point(272, 184);
            lblDoorMinus.Name = "lblDoorMinus";
            lblDoorMinus.Size = new Size(37, 50);
            lblDoorMinus.TabIndex = 34;
            lblDoorMinus.Text = "-";
            lblDoorMinus.Click += lblDoorMinus_Click;
            // 
            // lblWIndowsMinus
            // 
            lblWIndowsMinus.AutoSize = true;
            lblWIndowsMinus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWIndowsMinus.Location = new Point(272, 79);
            lblWIndowsMinus.Name = "lblWIndowsMinus";
            lblWIndowsMinus.Size = new Size(37, 50);
            lblWIndowsMinus.TabIndex = 33;
            lblWIndowsMinus.Text = "-";
            lblWIndowsMinus.Click += lblWIndowsMinus_Click;
            // 
            // btnRoomVacuum
            // 
            btnRoomVacuum.FlatStyle = FlatStyle.Flat;
            btnRoomVacuum.Font = new Font("Segoe UI", 18F);
            btnRoomVacuum.Location = new Point(393, 225);
            btnRoomVacuum.Name = "btnRoomVacuum";
            btnRoomVacuum.Size = new Size(206, 76);
            btnRoomVacuum.TabIndex = 41;
            btnRoomVacuum.Text = "Room Vacuuming";
            btnRoomVacuum.UseVisualStyleBackColor = true;
            btnRoomVacuum.Click += btnRoomVacuum_Click;
            // 
            // btnCurtains
            // 
            btnCurtains.FlatStyle = FlatStyle.Flat;
            btnCurtains.Font = new Font("Segoe UI", 18F);
            btnCurtains.Location = new Point(394, 173);
            btnCurtains.Name = "btnCurtains";
            btnCurtains.Size = new Size(206, 53);
            btnCurtains.TabIndex = 42;
            btnCurtains.Text = "Curtains";
            btnCurtains.UseVisualStyleBackColor = true;
            btnCurtains.Click += btnCurtains_Click;
            // 
            // lblVacuumMinus
            // 
            lblVacuumMinus.AutoSize = true;
            lblVacuumMinus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVacuumMinus.Location = new Point(604, 233);
            lblVacuumMinus.Name = "lblVacuumMinus";
            lblVacuumMinus.Size = new Size(37, 50);
            lblVacuumMinus.TabIndex = 45;
            lblVacuumMinus.Text = "-";
            lblVacuumMinus.Click += lblVacuumMinus_Click;
            // 
            // lblVacuum
            // 
            lblVacuum.AutoSize = true;
            lblVacuum.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVacuum.Location = new Point(642, 243);
            lblVacuum.Name = "lblVacuum";
            lblVacuum.Size = new Size(33, 37);
            lblVacuum.TabIndex = 44;
            lblVacuum.Text = "0";
            // 
            // lblVacuumPlus
            // 
            lblVacuumPlus.AutoSize = true;
            lblVacuumPlus.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVacuumPlus.Location = new Point(672, 233);
            lblVacuumPlus.Name = "lblVacuumPlus";
            lblVacuumPlus.Size = new Size(48, 50);
            lblVacuumPlus.TabIndex = 43;
            lblVacuumPlus.Text = "+";
            lblVacuumPlus.Click += lblVacuumPlus_Click;
            // 
            // DTPicker
            // 
            DTPicker.CalendarFont = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPicker.Font = new Font("Segoe UI", 22F);
            DTPicker.Location = new Point(95, 13);
            DTPicker.Name = "DTPicker";
            DTPicker.Size = new Size(200, 47);
            DTPicker.TabIndex = 47;
            // 
            // pnlCustomerDetails
            // 
            pnlCustomerDetails.Controls.Add(pnlBookingDetails);
            pnlCustomerDetails.Controls.Add(pnlDatabase);
            pnlCustomerDetails.Controls.Add(lblCustSelected);
            pnlCustomerDetails.Controls.Add(label1);
            pnlCustomerDetails.Controls.Add(txtbAddress);
            pnlCustomerDetails.Controls.Add(label5);
            pnlCustomerDetails.Controls.Add(txtbCustomerID);
            pnlCustomerDetails.Controls.Add(txtbSurname);
            pnlCustomerDetails.Controls.Add(label4);
            pnlCustomerDetails.Controls.Add(ExistingCustomer);
            pnlCustomerDetails.Controls.Add(txtbFirstName);
            pnlCustomerDetails.Controls.Add(label3);
            pnlCustomerDetails.Location = new Point(24, 20);
            pnlCustomerDetails.Name = "pnlCustomerDetails";
            pnlCustomerDetails.Size = new Size(1042, 607);
            pnlCustomerDetails.TabIndex = 48;
            // 
            // pnlBookingDetails
            // 
            pnlBookingDetails.Controls.Add(btnSubmit);
            pnlBookingDetails.Controls.Add(btnFloors);
            pnlBookingDetails.Controls.Add(label2);
            pnlBookingDetails.Controls.Add(btnWindows);
            pnlBookingDetails.Controls.Add(DTPicker);
            pnlBookingDetails.Controls.Add(btnCarpets);
            pnlBookingDetails.Controls.Add(lblVacuumMinus);
            pnlBookingDetails.Controls.Add(button5);
            pnlBookingDetails.Controls.Add(lblVacuum);
            pnlBookingDetails.Controls.Add(btnDusting);
            pnlBookingDetails.Controls.Add(lblVacuumPlus);
            pnlBookingDetails.Controls.Add(btnDoors);
            pnlBookingDetails.Controls.Add(btnCurtains);
            pnlBookingDetails.Controls.Add(btnBathrooms);
            pnlBookingDetails.Controls.Add(btnRoomVacuum);
            pnlBookingDetails.Controls.Add(lblWindowPlus);
            pnlBookingDetails.Controls.Add(lblCurtainsMinus);
            pnlBookingDetails.Controls.Add(lblDoorPlus);
            pnlBookingDetails.Controls.Add(lblCarpetsMinus);
            pnlBookingDetails.Controls.Add(lblFloorPlus);
            pnlBookingDetails.Controls.Add(lblBathroomMinus);
            pnlBookingDetails.Controls.Add(lblDustPlus);
            pnlBookingDetails.Controls.Add(lblDustMinus);
            pnlBookingDetails.Controls.Add(lblBathroomPlus);
            pnlBookingDetails.Controls.Add(lblFloorMinus);
            pnlBookingDetails.Controls.Add(lblCarpetsPlus);
            pnlBookingDetails.Controls.Add(lblDoorMinus);
            pnlBookingDetails.Controls.Add(lblCurtainsPlus);
            pnlBookingDetails.Controls.Add(lblWIndowsMinus);
            pnlBookingDetails.Controls.Add(lblWIndows);
            pnlBookingDetails.Controls.Add(lblCurtains);
            pnlBookingDetails.Controls.Add(lblDoors);
            pnlBookingDetails.Controls.Add(lblCarpets);
            pnlBookingDetails.Controls.Add(lblFloors);
            pnlBookingDetails.Controls.Add(lblBathrooms);
            pnlBookingDetails.Controls.Add(lblDusting);
            pnlBookingDetails.Location = new Point(18, 254);
            pnlBookingDetails.Name = "pnlBookingDetails";
            pnlBookingDetails.Size = new Size(956, 321);
            pnlBookingDetails.TabIndex = 1;
            pnlBookingDetails.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(758, 239);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pnlDatabase
            // 
            pnlDatabase.Controls.Add(DataGridCustomers);
            pnlDatabase.Location = new Point(27, 275);
            pnlDatabase.Name = "pnlDatabase";
            pnlDatabase.Size = new Size(873, 300);
            pnlDatabase.TabIndex = 57;
            pnlDatabase.Visible = false;
            // 
            // DataGridCustomers
            // 
            DataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCustomers.Columns.AddRange(new DataGridViewColumn[] { clmCustomerID, clmForename, clmSurname, clmDOB, clmGender, clmAddressOne, clmAddressTwo, clmEmail });
            DataGridCustomers.Location = new Point(3, 21);
            DataGridCustomers.Name = "DataGridCustomers";
            DataGridCustomers.Size = new Size(831, 259);
            DataGridCustomers.TabIndex = 0;
            DataGridCustomers.CellClick += DataGridCustomers_CellClick;
            // 
            // clmCustomerID
            // 
            clmCustomerID.HeaderText = "ID";
            clmCustomerID.Name = "clmCustomerID";
            // 
            // clmForename
            // 
            clmForename.HeaderText = "Forename";
            clmForename.Name = "clmForename";
            // 
            // clmSurname
            // 
            clmSurname.HeaderText = "Surname";
            clmSurname.Name = "clmSurname";
            // 
            // clmDOB
            // 
            clmDOB.HeaderText = "Date of Birth";
            clmDOB.Name = "clmDOB";
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
            // 
            // clmAddressTwo
            // 
            clmAddressTwo.HeaderText = "Address";
            clmAddressTwo.Name = "clmAddressTwo";
            // 
            // clmEmail
            // 
            clmEmail.HeaderText = "Email";
            clmEmail.Name = "clmEmail";
            // 
            // lblCustSelected
            // 
            lblCustSelected.AutoSize = true;
            lblCustSelected.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustSelected.ForeColor = Color.Green;
            lblCustSelected.Location = new Point(574, 135);
            lblCustSelected.Name = "lblCustSelected";
            lblCustSelected.Size = new Size(164, 25);
            lblCustSelected.TabIndex = 56;
            lblCustSelected.Text = "CustomerSelected";
            // 
            // txtbAddress
            // 
            txtbAddress.Font = new Font("Segoe UI", 18F);
            txtbAddress.Location = new Point(129, 197);
            txtbAddress.Name = "txtbAddress";
            txtbAddress.Size = new Size(293, 39);
            txtbAddress.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 214);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 54;
            label5.Text = "Address";
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 18F);
            txtbSurname.Location = new Point(129, 135);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(293, 39);
            txtbSurname.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 152);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 52;
            label4.Text = "Surname";
            // 
            // ExistingCustomer
            // 
            ExistingCustomer.AutoSize = true;
            ExistingCustomer.Font = new Font("Segoe UI", 20F);
            ExistingCustomer.Location = new Point(541, 33);
            ExistingCustomer.Name = "ExistingCustomer";
            ExistingCustomer.Size = new Size(248, 41);
            ExistingCustomer.TabIndex = 50;
            ExistingCustomer.Text = "Existing Customer";
            ExistingCustomer.UseVisualStyleBackColor = true;
            ExistingCustomer.CheckedChanged += ExistingCustomer_CheckedChanged;
            // 
            // txtbFirstName
            // 
            txtbFirstName.Font = new Font("Segoe UI", 18F);
            txtbFirstName.Location = new Point(129, 80);
            txtbFirstName.Name = "txtbFirstName";
            txtbFirstName.Size = new Size(293, 39);
            txtbFirstName.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 97);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 49;
            label3.Text = "First Name";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Sans Serif", 20F);
            btnNext.Location = new Point(1079, 629);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(106, 42);
            btnNext.TabIndex = 58;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 20F);
            btnBack.Location = new Point(967, 629);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 42);
            btnBack.TabIndex = 59;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // NewBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1197, 756);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(pnlCustomerDetails);
            Name = "NewBooking";
            Text = "NewBooking";
            Load += NewBooking_Load;
            pnlCustomerDetails.ResumeLayout(false);
            pnlCustomerDetails.PerformLayout();
            pnlBookingDetails.ResumeLayout(false);
            pnlBookingDetails.PerformLayout();
            pnlDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnWindows;
        private TextBox txtbCustomerID;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button btnCarpets;
        private Button button5;
        private Button btnDusting;
        private Button btnDoors;
        private Button btnFloors;
        private Button btnBathrooms;
        private TrackBar trackBar1;
        private Label lblWindowPlus;
        private Label lblDoorPlus;
        private Label lblFloorPlus;
        private Label lblDustPlus;
        private Label lblBathroomPlus;
        private Label lblCarpetsPlus;
        private Label lblCurtainsPlus;
        private Label lblWIndows;
        private Label lblDoors;
        private Label lblFloors;
        private Label lblDusting;
        private Label lblBathrooms;
        private Label lblCarpets;
        private Label lblCurtains;
        private Label lblCurtainsMinus;
        private Label lblCarpetsMinus;
        private Label lblBathroomMinus;
        private Label lblDustMinus;
        private Label lblFloorMinus;
        private Label lblDoorMinus;
        private Label lblWIndowsMinus;
        private Button btnRoomVacuum;
        private Button btnCurtains;
        private Label lblVacuumMinus;
        private Label lblVacuum;
        private Label lblVacuumPlus;
        private DateTimePicker DTPicker;
        private Panel pnlCustomerDetails;
        private Button btnSubmit;
        private TextBox txtbFirstName;
        private Label label3;
        private CheckBox ExistingCustomer;
        private TextBox txtbAddress;
        private Label label5;
        private TextBox txtbSurname;
        private Label label4;
        private Label lblCustSelected;
        private Panel pnlDatabase;
        private DataGridView DataGridCustomers;
        private Panel pnlBookingDetails;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmForename;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn clmDOB;
        private DataGridViewTextBoxColumn clmGender;
        private DataGridViewTextBoxColumn clmAddressOne;
        private DataGridViewTextBoxColumn clmAddressTwo;
        private DataGridViewTextBoxColumn clmEmail;
        private Button btnNext;
        private Button btnBack;
    }
}