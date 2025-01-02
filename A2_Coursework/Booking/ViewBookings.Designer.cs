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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            clmBookingID = new DataGridViewTextBoxColumn();
            clmCustomerID = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnDelete = new Button();
            txtbID = new TextBox();
            label1 = new Label();
            pnlBookingDetails = new Panel();
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
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
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
            pnlDatePicker.Location = new Point(12, 357);
            pnlDatePicker.Name = "pnlDatePicker";
            pnlDatePicker.Size = new Size(469, 316);
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
            BookingTable.Columns.AddRange(new DataGridViewColumn[] { clmBookingID, clmCustomerID, clmDate });
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
            // clmBookingID
            // 
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmBookingID.DefaultCellStyle = dataGridViewCellStyle4;
            clmBookingID.FillWeight = 10F;
            clmBookingID.HeaderText = "Booking ID";
            clmBookingID.Name = "clmBookingID";
            clmBookingID.ReadOnly = true;
            clmBookingID.Width = 200;
            // 
            // clmCustomerID
            // 
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmCustomerID.DefaultCellStyle = dataGridViewCellStyle5;
            clmCustomerID.HeaderText = "Customer ID";
            clmCustomerID.Name = "clmCustomerID";
            clmCustomerID.ReadOnly = true;
            clmCustomerID.Width = 200;
            // 
            // clmDate
            // 
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmDate.DefaultCellStyle = dataGridViewCellStyle6;
            clmDate.HeaderText = "Date";
            clmDate.Name = "clmDate";
            clmDate.ReadOnly = true;
            clmDate.Width = 200;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txtbID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(487, 357);
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
            pnlBookingDetails.Controls.Add(button1);
            pnlBookingDetails.Location = new Point(758, 5);
            pnlBookingDetails.Name = "pnlBookingDetails";
            pnlBookingDetails.Size = new Size(427, 712);
            pnlBookingDetails.TabIndex = 8;
            // 
            // listbQuantity
            // 
            listbQuantity.Font = new Font("Segoe UI", 18F);
            listbQuantity.FormattingEnabled = true;
            listbQuantity.ItemHeight = 32;
            listbQuantity.Location = new Point(293, 403);
            listbQuantity.Name = "listbQuantity";
            listbQuantity.Size = new Size(95, 196);
            listbQuantity.TabIndex = 29;
            // 
            // listbServices
            // 
            listbServices.Font = new Font("Segoe UI", 18F);
            listbServices.FormattingEnabled = true;
            listbServices.ItemHeight = 32;
            listbServices.Location = new Point(136, 403);
            listbServices.Name = "listbServices";
            listbServices.Size = new Size(151, 196);
            listbServices.TabIndex = 28;
            // 
            // txtbEmail
            // 
            txtbEmail.Font = new Font("Segoe UI", 20F);
            txtbEmail.Location = new Point(163, 288);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(261, 43);
            txtbEmail.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(75, 294);
            label7.Name = "label7";
            label7.Size = new Size(82, 37);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // txtbSurname
            // 
            txtbSurname.Font = new Font("Segoe UI", 20F);
            txtbSurname.Location = new Point(163, 228);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(261, 43);
            txtbSurname.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(36, 228);
            label6.Name = "label6";
            label6.Size = new Size(121, 37);
            label6.TabIndex = 16;
            label6.Text = "Surname";
            // 
            // txtbFirstname
            // 
            txtbFirstname.Font = new Font("Segoe UI", 20F);
            txtbFirstname.Location = new Point(163, 164);
            txtbFirstname.Name = "txtbFirstname";
            txtbFirstname.Size = new Size(261, 43);
            txtbFirstname.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(25, 164);
            label5.Name = "label5";
            label5.Size = new Size(132, 37);
            label5.TabIndex = 14;
            label5.Text = "Firstname";
            // 
            // txtbCustID
            // 
            txtbCustID.Font = new Font("Segoe UI", 20F);
            txtbCustID.Location = new Point(163, 106);
            txtbCustID.Name = "txtbCustID";
            txtbCustID.Size = new Size(261, 43);
            txtbCustID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(-7, 106);
            label4.Name = "label4";
            label4.Size = new Size(164, 37);
            label4.TabIndex = 12;
            label4.Text = "Customer ID";
            // 
            // txtbBookingID
            // 
            txtbBookingID.Font = new Font("Segoe UI", 20F);
            txtbBookingID.Location = new Point(163, 49);
            txtbBookingID.Name = "txtbBookingID";
            txtbBookingID.Size = new Size(261, 43);
            txtbBookingID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(9, 49);
            label3.Name = "label3";
            label3.Size = new Size(148, 37);
            label3.TabIndex = 9;
            label3.Text = "Booking ID";
            // 
            // button1
            // 
            button1.Location = new Point(301, 669);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(163, 363);
            label8.Name = "label8";
            label8.Size = new Size(100, 37);
            label8.TabIndex = 30;
            label8.Text = "Service";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F);
            label9.Location = new Point(279, 363);
            label9.Name = "label9";
            label9.Size = new Size(119, 37);
            label9.TabIndex = 31;
            label9.Text = "Quantity";
            // 
            // ViewBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private DataGridViewTextBoxColumn clmBookingID;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmDate;
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
        private Button button1;
        private ListBox listbServices;
        private ListBox listbQuantity;
        private Label label9;
        private Label label8;
    }
}