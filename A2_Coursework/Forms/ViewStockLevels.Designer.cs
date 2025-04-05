namespace A2_Coursework
{
    partial class ViewStockLevels
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridStock = new DataGridView();
            clmStockID = new DataGridViewTextBoxColumn();
            clmStockName = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
            clmReorderQuantity = new DataGridViewTextBoxColumn();
            clmReorderValue = new DataGridViewTextBoxColumn();
            clmCost = new DataGridViewTextBoxColumn();
            btnAutoOrder = new Button();
            cmbStock = new ComboBox();
            pnlReorder = new Panel();
            txtbReorderLevel = new TextBox();
            txtbQuantity = new TextBox();
            btnconfirm = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridStock).BeginInit();
            pnlReorder.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridStock
            // 
            dataGridStock.AllowUserToAddRows = false;
            dataGridStock.AllowUserToDeleteRows = false;
            dataGridStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStock.Columns.AddRange(new DataGridViewColumn[] { clmStockID, clmStockName, clmQuantity, clmStatus, clmReorderQuantity, clmReorderValue, clmCost });
            dataGridStock.Location = new Point(277, 116);
            dataGridStock.Name = "dataGridStock";
            dataGridStock.ReadOnly = true;
            dataGridStock.Size = new Size(769, 416);
            dataGridStock.TabIndex = 0;
            // 
            // clmStockID
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmStockID.DefaultCellStyle = dataGridViewCellStyle1;
            clmStockID.HeaderText = "Stock ID";
            clmStockID.Name = "clmStockID";
            clmStockID.ReadOnly = true;
            clmStockID.Width = 75;
            // 
            // clmStockName
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmStockName.DefaultCellStyle = dataGridViewCellStyle2;
            clmStockName.HeaderText = "Stock";
            clmStockName.Name = "clmStockName";
            clmStockName.ReadOnly = true;
            clmStockName.Width = 150;
            // 
            // clmQuantity
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            clmQuantity.HeaderText = "Quantity";
            clmQuantity.Name = "clmQuantity";
            clmQuantity.ReadOnly = true;
            // 
            // clmStatus
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmStatus.DefaultCellStyle = dataGridViewCellStyle4;
            clmStatus.HeaderText = "Status";
            clmStatus.Name = "clmStatus";
            clmStatus.ReadOnly = true;
            // 
            // clmReorderQuantity
            // 
            clmReorderQuantity.HeaderText = "Reorder Quantity";
            clmReorderQuantity.Name = "clmReorderQuantity";
            clmReorderQuantity.ReadOnly = true;
            // 
            // clmReorderValue
            // 
            clmReorderValue.HeaderText = "Reorder value";
            clmReorderValue.Name = "clmReorderValue";
            clmReorderValue.ReadOnly = true;
            // 
            // clmCost
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmCost.DefaultCellStyle = dataGridViewCellStyle5;
            clmCost.HeaderText = "Cost";
            clmCost.Name = "clmCost";
            clmCost.ReadOnly = true;
            // 
            // btnAutoOrder
            // 
            btnAutoOrder.BackColor = Color.FromArgb(85, 193, 255);
            btnAutoOrder.FlatAppearance.BorderSize = 0;
            btnAutoOrder.FlatStyle = FlatStyle.Flat;
            btnAutoOrder.Font = new Font("Microsoft Sans Serif", 17.25F);
            btnAutoOrder.ForeColor = Color.Black;
            btnAutoOrder.Location = new Point(523, 548);
            btnAutoOrder.Name = "btnAutoOrder";
            btnAutoOrder.Size = new Size(290, 52);
            btnAutoOrder.TabIndex = 1;
            btnAutoOrder.Text = "Create automatic reorder";
            btnAutoOrder.UseVisualStyleBackColor = false;
            btnAutoOrder.Click += btnAutoOrder_Click;
            // 
            // cmbStock
            // 
            cmbStock.Font = new Font("Segoe UI", 20F);
            cmbStock.FormattingEnabled = true;
            cmbStock.Location = new Point(285, 14);
            cmbStock.Name = "cmbStock";
            cmbStock.Size = new Size(150, 45);
            cmbStock.TabIndex = 2;
            // 
            // pnlReorder
            // 
            pnlReorder.Controls.Add(txtbReorderLevel);
            pnlReorder.Controls.Add(txtbQuantity);
            pnlReorder.Controls.Add(btnconfirm);
            pnlReorder.Controls.Add(label3);
            pnlReorder.Controls.Add(label2);
            pnlReorder.Controls.Add(label1);
            pnlReorder.Controls.Add(cmbStock);
            pnlReorder.Location = new Point(356, 622);
            pnlReorder.Name = "pnlReorder";
            pnlReorder.Size = new Size(457, 264);
            pnlReorder.TabIndex = 3;
            pnlReorder.Visible = false;
            // 
            // txtbReorderLevel
            // 
            txtbReorderLevel.Font = new Font("Segoe UI", 20F);
            txtbReorderLevel.Location = new Point(285, 119);
            txtbReorderLevel.Name = "txtbReorderLevel";
            txtbReorderLevel.Size = new Size(150, 43);
            txtbReorderLevel.TabIndex = 24;
            // 
            // txtbQuantity
            // 
            txtbQuantity.Font = new Font("Segoe UI", 20F);
            txtbQuantity.Location = new Point(285, 68);
            txtbQuantity.Name = "txtbQuantity";
            txtbQuantity.Size = new Size(150, 43);
            txtbQuantity.TabIndex = 23;
            // 
            // btnconfirm
            // 
            btnconfirm.BackColor = Color.FromArgb(50, 55, 59);
            btnconfirm.FlatAppearance.BorderSize = 0;
            btnconfirm.FlatStyle = FlatStyle.Flat;
            btnconfirm.Font = new Font("Microsoft Sans Serif", 20F);
            btnconfirm.ForeColor = Color.White;
            btnconfirm.Location = new Point(285, 177);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(143, 69);
            btnconfirm.TabIndex = 4;
            btnconfirm.Text = "Confirm";
            btnconfirm.UseVisualStyleBackColor = false;
            btnconfirm.Click += btnconfirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(2, 119);
            label3.Name = "label3";
            label3.Size = new Size(277, 37);
            label3.TabIndex = 7;
            label3.Text = "Reorder quantity level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(160, 68);
            label2.Name = "label2";
            label2.Size = new Size(119, 37);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(199, 14);
            label1.Name = "label1";
            label1.Size = new Size(80, 37);
            label1.TabIndex = 4;
            label1.Text = "Stock";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 20F);
            button1.Location = new Point(1101, 859);
            button1.Name = "button1";
            button1.Size = new Size(143, 69);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(1268, 863);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 221);
            panel1.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold);
            label9.Location = new Point(516, 18);
            label9.Name = "label9";
            label9.Size = new Size(297, 65);
            label9.TabIndex = 8;
            label9.Text = "Stock Levels";
            // 
            // ViewStockLevels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1382, 898);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pnlReorder);
            Controls.Add(dataGridStock);
            Controls.Add(btnAutoOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStockLevels";
            Text = "ViewStockLevels";
            Load += ViewStockLevels_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStock).EndInit();
            pnlReorder.ResumeLayout(false);
            pnlReorder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridStock;
        private Button btnAutoOrder;
        private ComboBox cmbStock;
        private Panel pnlReorder;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnconfirm;
        private Button button1;
        private Panel panel1;
        private Label label9;
        private DataGridViewTextBoxColumn clmStockID;
        private DataGridViewTextBoxColumn clmStockName;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmStatus;
        private DataGridViewTextBoxColumn clmReorderQuantity;
        private DataGridViewTextBoxColumn clmReorderValue;
        private DataGridViewTextBoxColumn clmCost;
        private TextBox txtbReorderLevel;
        private TextBox txtbQuantity;
    }
}