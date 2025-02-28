﻿namespace A2_Coursework
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
            btnOrder = new Button();
            label3 = new Label();
            dtPickerOrderDate = new DateTimePicker();
            label2 = new Label();
            cmbQuantity = new ComboBox();
            cmbStock = new ComboBox();
            label1 = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnViewOrders = new Button();
            btnViewAllOrders = new Button();
            button1 = new Button();
            pnlButtons = new Panel();
            pnlEdit = new Panel();
            pnlEdithide = new Panel();
            btnSaveChanges = new Button();
            cmbDTEdit = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            cmbStockEdit = new ComboBox();
            label5 = new Label();
            cmbQtyEdit = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridStockOrder).BeginInit();
            pnlStockReorder.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlEdit.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridStockOrder
            // 
            dataGridStockOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStockOrder.Columns.AddRange(new DataGridViewColumn[] { clmStockID, clmStockName, clmQuantity, clmOrderDate, clmCostPerUnit });
            dataGridStockOrder.Location = new Point(12, 281);
            dataGridStockOrder.Name = "dataGridStockOrder";
            dataGridStockOrder.Size = new Size(645, 253);
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
            // 
            // clmCostPerUnit
            // 
            clmCostPerUnit.HeaderText = "Cost per unit";
            clmCostPerUnit.Name = "clmCostPerUnit";
            // 
            // pnlStockReorder
            // 
            pnlStockReorder.Controls.Add(btnOrder);
            pnlStockReorder.Controls.Add(label3);
            pnlStockReorder.Controls.Add(dtPickerOrderDate);
            pnlStockReorder.Controls.Add(label2);
            pnlStockReorder.Controls.Add(cmbQuantity);
            pnlStockReorder.Controls.Add(cmbStock);
            pnlStockReorder.Controls.Add(label1);
            pnlStockReorder.Location = new Point(12, 12);
            pnlStockReorder.Name = "pnlStockReorder";
            pnlStockReorder.Size = new Size(553, 263);
            pnlStockReorder.TabIndex = 3;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 20F);
            btnOrder.Location = new Point(208, 195);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(200, 56);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(29, 138);
            label3.Name = "label3";
            label3.Size = new Size(173, 37);
            label3.TabIndex = 9;
            label3.Text = "Delivery date";
            // 
            // dtPickerOrderDate
            // 
            dtPickerOrderDate.CalendarFont = new Font("Segoe UI", 20F);
            dtPickerOrderDate.Font = new Font("Segoe UI", 20F);
            dtPickerOrderDate.Location = new Point(208, 133);
            dtPickerOrderDate.Name = "dtPickerOrderDate";
            dtPickerOrderDate.Size = new Size(262, 43);
            dtPickerOrderDate.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(83, 81);
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
            cmbQuantity.Location = new Point(208, 73);
            cmbQuantity.Name = "cmbQuantity";
            cmbQuantity.Size = new Size(95, 45);
            cmbQuantity.TabIndex = 7;
            // 
            // cmbStock
            // 
            cmbStock.Font = new Font("Segoe UI", 20F);
            cmbStock.FormattingEnabled = true;
            cmbStock.Location = new Point(208, 22);
            cmbStock.Name = "cmbStock";
            cmbStock.Size = new Size(247, 45);
            cmbStock.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(107, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 37);
            label1.TabIndex = 5;
            label1.Text = "Stock";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 20F);
            btnDelete.Location = new Point(3, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(191, 54);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Order";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft Sans Serif", 20F);
            btnEdit.Location = new Point(3, 63);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(191, 54);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit Order";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnViewOrders
            // 
            btnViewOrders.Font = new Font("Microsoft Sans Serif", 20F);
            btnViewOrders.Location = new Point(3, 243);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(273, 54);
            btnViewOrders.TabIndex = 6;
            btnViewOrders.Text = "View pending orders";
            btnViewOrders.UseVisualStyleBackColor = true;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnViewAllOrders
            // 
            btnViewAllOrders.Font = new Font("Microsoft Sans Serif", 20F);
            btnViewAllOrders.Location = new Point(3, 123);
            btnViewAllOrders.Name = "btnViewAllOrders";
            btnViewAllOrders.Size = new Size(202, 54);
            btnViewAllOrders.TabIndex = 7;
            btnViewAllOrders.Text = "View all orders";
            btnViewAllOrders.UseVisualStyleBackColor = true;
            btnViewAllOrders.Click += btnViewAllOrders_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 20F);
            button1.Location = new Point(3, 183);
            button1.Name = "button1";
            button1.Size = new Size(267, 54);
            button1.TabIndex = 8;
            button1.Text = "View orders by date";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Controls.Add(btnEdit);
            pnlButtons.Controls.Add(btnViewAllOrders);
            pnlButtons.Controls.Add(button1);
            pnlButtons.Controls.Add(btnViewOrders);
            pnlButtons.Location = new Point(663, 281);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(275, 348);
            pnlButtons.TabIndex = 10;
            // 
            // pnlEdit
            // 
            pnlEdit.Controls.Add(pnlEdithide);
            pnlEdit.Controls.Add(btnSaveChanges);
            pnlEdit.Controls.Add(cmbDTEdit);
            pnlEdit.Controls.Add(label4);
            pnlEdit.Controls.Add(label6);
            pnlEdit.Controls.Add(cmbStockEdit);
            pnlEdit.Controls.Add(label5);
            pnlEdit.Controls.Add(cmbQtyEdit);
            pnlEdit.Location = new Point(14, 540);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(643, 242);
            pnlEdit.TabIndex = 11;
            // 
            // pnlEdithide
            // 
            pnlEdithide.Location = new Point(0, 0);
            pnlEdithide.Name = "pnlEdithide";
            pnlEdithide.Size = new Size(646, 242);
            pnlEdithide.TabIndex = 18;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Font = new Font("Segoe UI", 20F);
            btnSaveChanges.Location = new Point(215, 171);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(200, 56);
            btnSaveChanges.TabIndex = 17;
            btnSaveChanges.Text = "Save changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // cmbDTEdit
            // 
            cmbDTEdit.CalendarFont = new Font("Segoe UI", 20F);
            cmbDTEdit.Font = new Font("Segoe UI", 20F);
            cmbDTEdit.Location = new Point(215, 118);
            cmbDTEdit.Name = "cmbDTEdit";
            cmbDTEdit.Size = new Size(262, 43);
            cmbDTEdit.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(36, 123);
            label4.Name = "label4";
            label4.Size = new Size(173, 37);
            label4.TabIndex = 16;
            label4.Text = "Delivery date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(114, 11);
            label6.Name = "label6";
            label6.Size = new Size(80, 37);
            label6.TabIndex = 12;
            label6.Text = "Stock";
            // 
            // cmbStockEdit
            // 
            cmbStockEdit.Font = new Font("Segoe UI", 20F);
            cmbStockEdit.FormattingEnabled = true;
            cmbStockEdit.Location = new Point(215, 7);
            cmbStockEdit.Name = "cmbStockEdit";
            cmbStockEdit.Size = new Size(247, 45);
            cmbStockEdit.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(90, 66);
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
            cmbQtyEdit.Location = new Point(215, 58);
            cmbQtyEdit.Name = "cmbQtyEdit";
            cmbQtyEdit.Size = new Size(95, 45);
            cmbQtyEdit.TabIndex = 14;
            // 
            // OrderStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1167, 779);
            Controls.Add(pnlEdit);
            Controls.Add(pnlButtons);
            Controls.Add(pnlStockReorder);
            Controls.Add(dataGridStockOrder);
            Name = "OrderStock";
            Text = "OrderStock";
            Load += OrderStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStockOrder).EndInit();
            pnlStockReorder.ResumeLayout(false);
            pnlStockReorder.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            ResumeLayout(false);
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
        private DataGridViewTextBoxColumn clmStockID;
        private DataGridViewTextBoxColumn clmStockName;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmOrderDate;
        private DataGridViewTextBoxColumn clmCostPerUnit;
        private Button btnViewOrders;
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
        private Panel pnlEdithide;
    }
}