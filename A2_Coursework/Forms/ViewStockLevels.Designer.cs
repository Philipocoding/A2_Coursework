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
            dataGridStock = new DataGridView();
            clmStockID = new DataGridViewTextBoxColumn();
            clmStockName = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmCost = new DataGridViewTextBoxColumn();
            btnAutoOrder = new Button();
            cmbStock = new ComboBox();
            pnlReorder = new Panel();
            btnconfirm = new Button();
            label3 = new Label();
            cmbReorderLevel = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cmbQuantity = new ComboBox();
            btnReorderStock = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridStock).BeginInit();
            pnlReorder.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridStock
            // 
            dataGridStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStock.Columns.AddRange(new DataGridViewColumn[] { clmStockID, clmStockName, clmQuantity, clmCost });
            dataGridStock.Location = new Point(317, 12);
            dataGridStock.Name = "dataGridStock";
            dataGridStock.Size = new Size(545, 349);
            dataGridStock.TabIndex = 0;
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
            // clmCost
            // 
            clmCost.HeaderText = "Cost";
            clmCost.Name = "clmCost";
            // 
            // btnAutoOrder
            // 
            btnAutoOrder.Font = new Font("Microsoft Sans Serif", 20F);
            btnAutoOrder.Location = new Point(317, 390);
            btnAutoOrder.Name = "btnAutoOrder";
            btnAutoOrder.Size = new Size(326, 69);
            btnAutoOrder.TabIndex = 1;
            btnAutoOrder.Text = "Create automatic reorder";
            btnAutoOrder.UseVisualStyleBackColor = true;
            btnAutoOrder.Click += btnAutoOrder_Click;
            // 
            // cmbStock
            // 
            cmbStock.Font = new Font("Segoe UI", 20F);
            cmbStock.FormattingEnabled = true;
            cmbStock.Location = new Point(300, 14);
            cmbStock.Name = "cmbStock";
            cmbStock.Size = new Size(150, 45);
            cmbStock.TabIndex = 2;
            // 
            // pnlReorder
            // 
            pnlReorder.Controls.Add(btnconfirm);
            pnlReorder.Controls.Add(label3);
            pnlReorder.Controls.Add(cmbReorderLevel);
            pnlReorder.Controls.Add(label2);
            pnlReorder.Controls.Add(label1);
            pnlReorder.Controls.Add(cmbQuantity);
            pnlReorder.Controls.Add(cmbStock);
            pnlReorder.Location = new Point(317, 475);
            pnlReorder.Name = "pnlReorder";
            pnlReorder.Size = new Size(646, 264);
            pnlReorder.TabIndex = 3;
            pnlReorder.Visible = false;
            // 
            // btnconfirm
            // 
            btnconfirm.Font = new Font("Microsoft Sans Serif", 20F);
            btnconfirm.Location = new Point(300, 192);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(143, 69);
            btnconfirm.TabIndex = 4;
            btnconfirm.Text = "Confirm";
            btnconfirm.UseVisualStyleBackColor = true;
            btnconfirm.Click += btnconfirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(17, 119);
            label3.Name = "label3";
            label3.Size = new Size(277, 37);
            label3.TabIndex = 7;
            label3.Text = "Reorder quantity level";
            // 
            // cmbReorderLevel
            // 
            cmbReorderLevel.Font = new Font("Segoe UI", 20F);
            cmbReorderLevel.FormattingEnabled = true;
            cmbReorderLevel.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbReorderLevel.Location = new Point(300, 116);
            cmbReorderLevel.Name = "cmbReorderLevel";
            cmbReorderLevel.Size = new Size(150, 45);
            cmbReorderLevel.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(175, 68);
            label2.Name = "label2";
            label2.Size = new Size(119, 37);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(214, 14);
            label1.Name = "label1";
            label1.Size = new Size(80, 37);
            label1.TabIndex = 4;
            label1.Text = "Stock";
            // 
            // cmbQuantity
            // 
            cmbQuantity.Font = new Font("Segoe UI", 20F);
            cmbQuantity.FormattingEnabled = true;
            cmbQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cmbQuantity.Location = new Point(300, 65);
            cmbQuantity.Name = "cmbQuantity";
            cmbQuantity.Size = new Size(150, 45);
            cmbQuantity.TabIndex = 3;
            // 
            // btnReorderStock
            // 
            btnReorderStock.Font = new Font("Microsoft Sans Serif", 20F);
            btnReorderStock.Location = new Point(649, 390);
            btnReorderStock.Name = "btnReorderStock";
            btnReorderStock.Size = new Size(213, 69);
            btnReorderStock.TabIndex = 4;
            btnReorderStock.Text = "Reorder stock";
            btnReorderStock.UseVisualStyleBackColor = true;
            btnReorderStock.Click += btnReorderStock_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 20F);
            button1.Location = new Point(1091, 684);
            button1.Name = "button1";
            button1.Size = new Size(143, 69);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            // 
            // ViewStockLevels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1246, 765);
            Controls.Add(button1);
            Controls.Add(btnReorderStock);
            Controls.Add(pnlReorder);
            Controls.Add(dataGridStock);
            Controls.Add(btnAutoOrder);
            Name = "ViewStockLevels";
            Text = "ViewStockLevels";
            Load += ViewStockLevels_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStock).EndInit();
            pnlReorder.ResumeLayout(false);
            pnlReorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridStock;
        private DataGridViewTextBoxColumn clmStockID;
        private DataGridViewTextBoxColumn clmStockName;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmCost;
        private Button btnAutoOrder;
        private ComboBox cmbStock;
        private Panel pnlReorder;
        private Label label3;
        private ComboBox cmbReorderLevel;
        private Label label2;
        private Label label1;
        private ComboBox cmbQuantity;
        private Button btnconfirm;
        private Button btnReorderStock;
        private Button button1;
    }
}