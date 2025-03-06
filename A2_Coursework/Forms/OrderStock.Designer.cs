namespace A2_Coursework
{
    partial class OrderStock
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
            dataGridStockOrder = new DataGridView();
            clmStockID = new DataGridViewTextBoxColumn();
            clmStockName = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmOrderDate = new DataGridViewTextBoxColumn();
            clmCostPerUnit = new DataGridViewTextBoxColumn();
            pnlStockReorder = new Panel();
            pnlEdit = new Panel();
            button2 = new Button();
            btnSaveChanges = new Button();
            cmbDTEdit = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            cmbStockEdit = new ComboBox();
            label5 = new Label();
            cmbQtyEdit = new ComboBox();
            btnOrder = new Button();
            label3 = new Label();
            dtPickerOrderDate = new DateTimePicker();
            label2 = new Label();
            cmbQuantity = new ComboBox();
            lblOrderStock = new Label();
            cmbStock = new ComboBox();
            label1 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnViewAllOrders = new Button();
            button1 = new Button();
            pnlButtons = new Panel();
            button3 = new Button();
            pnlDateFilter = new Panel();
            btnReset = new Button();
            dtPickerFilter = new DateTimePicker();
            btnFIlterByDate = new Button();
            btnMarkasReceived = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridStockOrder).BeginInit();
            pnlStockReorder.SuspendLayout();
            pnlEdit.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlDateFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridStockOrder
            // 
            dataGridStockOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStockOrder.Columns.AddRange(new DataGridViewColumn[] { clmStockID, clmStockName, clmQuantity, clmOrderDate, clmCostPerUnit });
            dataGridStockOrder.Location = new Point(267, 421);
            dataGridStockOrder.Name = "dataGridStockOrder";
            dataGridStockOrder.Size = new Size(742, 253);
            dataGridStockOrder.TabIndex = 2;
            dataGridStockOrder.CellClick += dataGridStockOrder_CellClick;
            // 
            // clmStockID
            // 
            clmStockID.HeaderText = "Stock ID";
            clmStockID.Name = "clmStockID";
            // 
            // clmStockName
            // 
            clmStockName.HeaderText = "Stock";
            clmStockName.Name = "clmStockName";
            clmStockName.Width = 200;
            // 
            // clmQuantity
            // 
            clmQuantity.HeaderText = "Quantity";
            clmQuantity.Name = "clmQuantity";
            // 
            // clmOrderDate
            // 
            clmOrderDate.HeaderText = "Order date";
            clmOrderDate.Name = "clmOrderDate";
            clmOrderDate.Width = 150;
            // 
            // clmCostPerUnit
            // 
            clmCostPerUnit.HeaderText = "Cost per unit";
            clmCostPerUnit.Name = "clmCostPerUnit";
            clmCostPerUnit.Width = 150;
            // 
            // pnlStockReorder
            // 
            pnlStockReorder.Controls.Add(pnlEdit);
            pnlStockReorder.Controls.Add(btnOrder);
            pnlStockReorder.Controls.Add(label3);
            pnlStockReorder.Controls.Add(dtPickerOrderDate);
            pnlStockReorder.Controls.Add(label2);
            pnlStockReorder.Controls.Add(cmbQuantity);
            pnlStockReorder.Controls.Add(lblOrderStock);
            pnlStockReorder.Controls.Add(cmbStock);
            pnlStockReorder.Controls.Add(label1);
            pnlStockReorder.Location = new Point(321, 67);
            pnlStockReorder.Name = "pnlStockReorder";
            pnlStockReorder.Size = new Size(514, 298);
            pnlStockReorder.TabIndex = 3;
            pnlStockReorder.Paint += pnlStockReorder_Paint;
            // 
            // pnlEdit
            // 
            pnlEdit.Controls.Add(button2);
            pnlEdit.Controls.Add(btnSaveChanges);
            pnlEdit.Controls.Add(cmbDTEdit);
            pnlEdit.Controls.Add(label4);
            pnlEdit.Controls.Add(label6);
            pnlEdit.Controls.Add(cmbStockEdit);
            pnlEdit.Controls.Add(label5);
            pnlEdit.Controls.Add(cmbQtyEdit);
            pnlEdit.Location = new Point(6, 55);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(444, 282);
            pnlEdit.TabIndex = 11;
            pnlEdit.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(50, 55, 59);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 17F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(178, 184);
            button2.Name = "button2";
            button2.Size = new Size(125, 56);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(50, 55, 59);
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 17F);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(316, 184);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(125, 56);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "Save";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // cmbDTEdit
            // 
            cmbDTEdit.CalendarFont = new Font("Segoe UI", 20F);
            cmbDTEdit.Font = new Font("Segoe UI", 20F);
            cmbDTEdit.Location = new Point(179, 120);
            cmbDTEdit.Name = "cmbDTEdit";
            cmbDTEdit.Size = new Size(262, 43);
            cmbDTEdit.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(0, 125);
            label4.Name = "label4";
            label4.Size = new Size(173, 37);
            label4.TabIndex = 16;
            label4.Text = "Delivery date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(78, 13);
            label6.Name = "label6";
            label6.Size = new Size(80, 37);
            label6.TabIndex = 12;
            label6.Text = "Stock";
            // 
            // cmbStockEdit
            // 
            cmbStockEdit.Font = new Font("Segoe UI", 20F);
            cmbStockEdit.FormattingEnabled = true;
            cmbStockEdit.Location = new Point(179, 9);
            cmbStockEdit.Name = "cmbStockEdit";
            cmbStockEdit.Size = new Size(263, 45);
            cmbStockEdit.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(54, 69);
            label5.Name = "label5";
            label5.Size = new Size(119, 37);
            label5.TabIndex = 15;
            label5.Text = "Quantity";
            // 
            // cmbQtyEdit
            // 
            cmbQtyEdit.Font = new Font("Segoe UI", 20F);
            cmbQtyEdit.FormattingEnabled = true;
            cmbQtyEdit.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cmbQtyEdit.Location = new Point(178, 68);
            cmbQtyEdit.Name = "cmbQtyEdit";
            cmbQtyEdit.Size = new Size(263, 45);
            cmbQtyEdit.TabIndex = 1;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(50, 55, 59);
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 20F);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(216, 233);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(200, 56);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(9, 180);
            label3.Name = "label3";
            label3.Size = new Size(173, 37);
            label3.TabIndex = 9;
            label3.Text = "Delivery date";
            // 
            // dtPickerOrderDate
            // 
            dtPickerOrderDate.CalendarFont = new Font("Segoe UI", 20F);
            dtPickerOrderDate.Font = new Font("Segoe UI", 20F);
            dtPickerOrderDate.Location = new Point(188, 175);
            dtPickerOrderDate.Name = "dtPickerOrderDate";
            dtPickerOrderDate.Size = new Size(262, 43);
            dtPickerOrderDate.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(63, 123);
            label2.Name = "label2";
            label2.Size = new Size(119, 37);
            label2.TabIndex = 8;
            label2.Text = "Quantity";
            // 
            // cmbQuantity
            // 
            cmbQuantity.Font = new Font("Segoe UI", 20F);
            cmbQuantity.FormattingEnabled = true;
            cmbQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cmbQuantity.Location = new Point(188, 123);
            cmbQuantity.Name = "cmbQuantity";
            cmbQuantity.Size = new Size(262, 45);
            cmbQuantity.TabIndex = 7;
            // 
            // lblOrderStock
            // 
            lblOrderStock.AutoSize = true;
            lblOrderStock.Font = new Font("Segoe UI Symbol", 20F, FontStyle.Bold);
            lblOrderStock.Location = new Point(220, 15);
            lblOrderStock.Name = "lblOrderStock";
            lblOrderStock.Size = new Size(144, 37);
            lblOrderStock.TabIndex = 21;
            lblOrderStock.Text = "Edit order";
            // 
            // cmbStock
            // 
            cmbStock.Font = new Font("Segoe UI", 20F);
            cmbStock.FormattingEnabled = true;
            cmbStock.Location = new Point(188, 64);
            cmbStock.Name = "cmbStock";
            cmbStock.Size = new Size(262, 45);
            cmbStock.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(87, 68);
            label1.Name = "label1";
            label1.Size = new Size(80, 37);
            label1.TabIndex = 5;
            label1.Text = "Stock";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(85, 193, 255);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 18F);
            btnDelete.Location = new Point(3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(209, 54);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Order";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(85, 193, 255);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Microsoft Sans Serif", 18F);
            btnEdit.Location = new Point(3, 63);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(209, 54);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit Order";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnViewAllOrders
            // 
            btnViewAllOrders.BackColor = Color.FromArgb(85, 193, 255);
            btnViewAllOrders.FlatStyle = FlatStyle.Flat;
            btnViewAllOrders.Font = new Font("Microsoft Sans Serif", 18F);
            btnViewAllOrders.Location = new Point(218, 63);
            btnViewAllOrders.Name = "btnViewAllOrders";
            btnViewAllOrders.Size = new Size(247, 54);
            btnViewAllOrders.TabIndex = 7;
            btnViewAllOrders.Text = "View order history";
            btnViewAllOrders.UseVisualStyleBackColor = false;
            btnViewAllOrders.Click += btnViewAllOrders_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(85, 193, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 18F);
            button1.Location = new Point(471, 63);
            button1.Name = "button1";
            button1.Size = new Size(271, 54);
            button1.TabIndex = 8;
            button1.Text = "View orders by date";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(button1);
            pnlButtons.Controls.Add(button3);
            pnlButtons.Controls.Add(pnlDateFilter);
            pnlButtons.Controls.Add(btnMarkasReceived);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnEdit);
            pnlButtons.Controls.Add(btnViewAllOrders);
            pnlButtons.Location = new Point(267, 680);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(751, 274);
            pnlButtons.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(85, 193, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(218, 3);
            button3.Name = "button3";
            button3.Size = new Size(247, 54);
            button3.TabIndex = 10;
            button3.Text = "View pending orders";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pnlDateFilter
            // 
            pnlDateFilter.BackColor = Color.FromArgb(109, 132, 156);
            pnlDateFilter.Controls.Add(btnReset);
            pnlDateFilter.Controls.Add(dtPickerFilter);
            pnlDateFilter.Controls.Add(btnFIlterByDate);
            pnlDateFilter.ForeColor = Color.Black;
            pnlDateFilter.Location = new Point(471, 118);
            pnlDateFilter.Name = "pnlDateFilter";
            pnlDateFilter.Size = new Size(271, 111);
            pnlDateFilter.TabIndex = 20;
            pnlDateFilter.Visible = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(85, 193, 255);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Microsoft Sans Serif", 18F);
            btnReset.Location = new Point(135, 41);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(136, 54);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dtPickerFilter
            // 
            dtPickerFilter.Dock = DockStyle.Top;
            dtPickerFilter.Font = new Font("Segoe UI", 19F);
            dtPickerFilter.Location = new Point(0, 0);
            dtPickerFilter.Name = "dtPickerFilter";
            dtPickerFilter.Size = new Size(271, 41);
            dtPickerFilter.TabIndex = 9;
            // 
            // btnFIlterByDate
            // 
            btnFIlterByDate.BackColor = Color.FromArgb(85, 193, 255);
            btnFIlterByDate.FlatStyle = FlatStyle.Flat;
            btnFIlterByDate.Font = new Font("Microsoft Sans Serif", 18F);
            btnFIlterByDate.Location = new Point(-3, 41);
            btnFIlterByDate.Name = "btnFIlterByDate";
            btnFIlterByDate.Size = new Size(136, 54);
            btnFIlterByDate.TabIndex = 8;
            btnFIlterByDate.Text = "Filter";
            btnFIlterByDate.UseVisualStyleBackColor = false;
            btnFIlterByDate.Click += btnFIlterByDate_Click;
            // 
            // btnMarkasReceived
            // 
            btnMarkasReceived.BackColor = Color.FromArgb(85, 193, 255);
            btnMarkasReceived.FlatStyle = FlatStyle.Flat;
            btnMarkasReceived.Font = new Font("Microsoft Sans Serif", 18F);
            btnMarkasReceived.Location = new Point(471, 3);
            btnMarkasReceived.Name = "btnMarkasReceived";
            btnMarkasReceived.Size = new Size(271, 54);
            btnMarkasReceived.TabIndex = 9;
            btnMarkasReceived.Text = "Mark order as received";
            btnMarkasReceived.UseVisualStyleBackColor = false;
            btnMarkasReceived.Click += btnMarkasReceived_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(1131, 855);
            panel1.Name = "panel1";
            panel1.Size = new Size(92, 207);
            panel1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold);
            label7.Location = new Point(477, 14);
            label7.Name = "label7";
            label7.Size = new Size(291, 65);
            label7.TabIndex = 19;
            label7.Text = "Order Stock";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 20F, FontStyle.Bold);
            label8.Location = new Point(541, 381);
            label8.Name = "label8";
            label8.Size = new Size(175, 37);
            label8.TabIndex = 20;
            label8.Text = "Stock orders";
            // 
            // OrderStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1345, 994);
            Controls.Add(label8);
            Controls.Add(pnlStockReorder);
            Controls.Add(label7);
            Controls.Add(pnlButtons);
            Controls.Add(panel1);
            Controls.Add(dataGridStockOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderStock";
            Text = "OrderStock";
            Load += OrderStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStockOrder).EndInit();
            pnlStockReorder.ResumeLayout(false);
            pnlStockReorder.PerformLayout();
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlDateFilter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridStockOrder;
        private Panel pnlStockReorder;
        private Label label2;
        private ComboBox cmbQuantity;
        private ComboBox cmbStock;
        private Label label1;
        private Label label3;
        private DateTimePicker dtPickerOrderDate;
        private Button btnOrder;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnViewAllOrders;
        private Button button1;
        private Panel pnlButtons;
        private Panel pnlEdit;
        private Button btnSaveChanges;
        private DateTimePicker cmbDTEdit;
        private Label label4;
        private Label label6;
        private ComboBox cmbStockEdit;
        private Label label5;
        private ComboBox cmbQtyEdit;
        private Button btnMarkasReceived;
        private Panel panel1;
        private DataGridViewTextBoxColumn clmStockID;
        private DataGridViewTextBoxColumn clmStockName;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmOrderDate;
        private DataGridViewTextBoxColumn clmCostPerUnit;
        private Button button2;
        private Panel pnlDateFilter;
        private Button btnFIlterByDate;
        private DateTimePicker dtPickerFilter;
        private Button button3;
        private Label label7;
        private Label label8;
        private Button btnReset;
        private Label lblOrderStock;
    }
}