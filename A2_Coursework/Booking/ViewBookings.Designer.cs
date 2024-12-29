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
            clmBookingID = new DataGridViewTextBoxColumn();
            clmCustomerID = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnDelete = new Button();
            txtbID = new TextBox();
            label1 = new Label();
            pnlDatePicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookingTable).BeginInit();
            panel1.SuspendLayout();
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
            pnlDatePicker.Size = new Size(531, 316);
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
            btnReset.Location = new Point(224, 241);
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
            btnFilter.Location = new Point(378, 241);
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
            // clmDate
            // 
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmDate.DefaultCellStyle = dataGridViewCellStyle3;
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
            panel1.Location = new Point(558, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 166);
            panel1.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(18, 67);
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
            txtbID.Location = new Point(196, 79);
            txtbID.Name = "txtbID";
            txtbID.Size = new Size(100, 43);
            txtbID.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F);
            label1.Location = new Point(184, 37);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 9;
            label1.Text = "Booking ID";
            // 
            // ViewBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 756);
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
    }
}