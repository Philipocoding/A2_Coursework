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
            dateTimePicker1 = new DateTimePicker();
            pnlDatePicker = new Panel();
            btnRight = new Button();
            btnDelete = new Button();
            txtbID = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            DTPicker = new DateTimePicker();
            label2 = new Label();
            button1 = new Button();
            listViewBookings = new ListView();
            BookingTable = new DataGridView();
            clmBookingID = new DataGridViewTextBoxColumn();
            clmCustomerID = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            pnlDatePicker.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookingTable).BeginInit();
            SuspendLayout();
            // 
            // btnLeft
            // 
            btnLeft.Font = new Font("Segoe UI", 24F);
            btnLeft.Location = new Point(248, 47);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(51, 50);
            btnLeft.TabIndex = 1;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 24F);
            dateTimePicker1.Location = new Point(305, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 50);
            dateTimePicker1.TabIndex = 2;
            // 
            // pnlDatePicker
            // 
            pnlDatePicker.Controls.Add(btnRight);
            pnlDatePicker.Controls.Add(btnLeft);
            pnlDatePicker.Controls.Add(dateTimePicker1);
            pnlDatePicker.Location = new Point(95, -1);
            pnlDatePicker.Name = "pnlDatePicker";
            pnlDatePicker.Size = new Size(821, 102);
            pnlDatePicker.TabIndex = 3;
            // 
            // btnRight
            // 
            btnRight.Font = new Font("Segoe UI", 24F);
            btnRight.Location = new Point(527, 47);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(50, 50);
            btnRight.TabIndex = 3;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(95, 515);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 62);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtbID
            // 
            txtbID.Font = new Font("Segoe UI", 20.25F);
            txtbID.Location = new Point(273, 527);
            txtbID.Name = "txtbID";
            txtbID.Size = new Size(100, 43);
            txtbID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F);
            label1.Location = new Point(261, 485);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 6;
            label1.Text = "Booking ID";
            // 
            // panel1
            // 
            panel1.Controls.Add(DTPicker);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(622, 488);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 256);
            panel1.TabIndex = 7;
            // 
            // DTPicker
            // 
            DTPicker.Location = new Point(49, 20);
            DTPicker.Name = "DTPicker";
            DTPicker.Size = new Size(200, 23);
            DTPicker.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Date";
            // 
            // button1
            // 
            button1.Location = new Point(525, 499);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // listViewBookings
            // 
            listViewBookings.Location = new Point(12, 136);
            listViewBookings.Name = "listViewBookings";
            listViewBookings.Size = new Size(157, 325);
            listViewBookings.TabIndex = 4;
            listViewBookings.UseCompatibleStateImageBehavior = false;
            // 
            // BookingTable
            // 
            BookingTable.AllowUserToAddRows = false;
            BookingTable.AllowUserToDeleteRows = false;
            BookingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingTable.Columns.AddRange(new DataGridViewColumn[] { clmBookingID, clmCustomerID, clmDate });
            BookingTable.Location = new Point(293, 107);
            BookingTable.Name = "BookingTable";
            BookingTable.ReadOnly = true;
            BookingTable.RowHeadersWidth = 100;
            BookingTable.RowTemplate.Height = 35;
            BookingTable.Size = new Size(770, 336);
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
            // ViewBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 756);
            Controls.Add(listViewBookings);
            Controls.Add(panel1);
            Controls.Add(BookingTable);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtbID);
            Controls.Add(btnDelete);
            Controls.Add(pnlDatePicker);
            Name = "ViewBookings";
            Text = "ViewBookings";
            Load += ViewBookings_Load;
            pnlDatePicker.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BookingTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLeft;
        private DateTimePicker dateTimePicker1;
        private Panel pnlDatePicker;
        private Button btnRight;
        private Button btnDelete;
        private TextBox txtbID;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private DateTimePicker DTPicker;
        private ListView listViewBookings;
        private DataGridView BookingTable;
        private DataGridViewTextBoxColumn clmBookingID;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmDate;
    }
}