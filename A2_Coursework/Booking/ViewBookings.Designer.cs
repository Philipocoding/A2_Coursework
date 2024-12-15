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
            BookingTable = new DataGridView();
            btnLeft = new Button();
            dateTimePicker1 = new DateTimePicker();
            pnlDatePicker = new Panel();
            btnRight = new Button();
            btnDelete = new Button();
            txtbID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)BookingTable).BeginInit();
            pnlDatePicker.SuspendLayout();
            SuspendLayout();
            // 
            // BookingTable
            // 
            BookingTable.AllowUserToAddRows = false;
            BookingTable.AllowUserToDeleteRows = false;
            BookingTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingTable.Location = new Point(95, 107);
            BookingTable.Name = "BookingTable";
            BookingTable.ReadOnly = true;
            BookingTable.Size = new Size(821, 375);
            BookingTable.TabIndex = 0;
            BookingTable.CellClick += BookingTable_CellClick;
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
            // ViewBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 672);
            Controls.Add(label1);
            Controls.Add(txtbID);
            Controls.Add(btnDelete);
            Controls.Add(BookingTable);
            Controls.Add(pnlDatePicker);
            Name = "ViewBookings";
            Text = "ViewBookings";
            Load += ViewBookings_Load;
            ((System.ComponentModel.ISupportInitialize)BookingTable).EndInit();
            pnlDatePicker.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView BookingTable;
        private Button btnLeft;
        private DateTimePicker dateTimePicker1;
        private Panel pnlDatePicker;
        private Button btnRight;
        private Button btnDelete;
        private TextBox txtbID;
        private Label label1;
    }
}