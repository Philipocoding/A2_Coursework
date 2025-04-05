namespace A2_Coursework
{
    partial class Report2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report2));
            btnPrint = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            printPreviewControl1 = new PrintPreviewControl();
            DataGridCustomers = new DataGridView();
            clmCustomerID = new DataGridViewTextBoxColumn();
            clmFIrstname = new DataGridViewTextBoxColumn();
            clmSurname = new DataGridViewTextBoxColumn();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pnlDataGrid = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).BeginInit();
            pnlDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(85, 193, 255);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 20F);
            btnPrint.Location = new Point(166, 330);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(193, 95);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(538, 870);
            panel1.Name = "panel1";
            panel1.Size = new Size(22, 268);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(1191, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 26);
            panel2.TabIndex = 4;
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.BackColor = Color.FromArgb(109, 132, 156);
            printPreviewControl1.Location = new Point(640, 100);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(545, 775);
            printPreviewControl1.TabIndex = 9;
            // 
            // DataGridCustomers
            // 
            DataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridCustomers.Columns.AddRange(new DataGridViewColumn[] { clmCustomerID, clmFIrstname, clmSurname });
            DataGridCustomers.Location = new Point(26, 23);
            DataGridCustomers.Name = "DataGridCustomers";
            DataGridCustomers.Size = new Size(495, 301);
            DataGridCustomers.TabIndex = 11;
            // 
            // clmCustomerID
            // 
            clmCustomerID.HeaderText = "Customer ID";
            clmCustomerID.Name = "clmCustomerID";
            clmCustomerID.ReadOnly = true;
            clmCustomerID.Width = 150;
            // 
            // clmFIrstname
            // 
            clmFIrstname.HeaderText = "Firstname";
            clmFIrstname.Name = "clmFIrstname";
            clmFIrstname.ReadOnly = true;
            clmFIrstname.Width = 150;
            // 
            // clmSurname
            // 
            clmSurname.HeaderText = "Surname";
            clmSurname.Name = "clmSurname";
            clmSurname.ReadOnly = true;
            clmSurname.Width = 150;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // pnlDataGrid
            // 
            pnlDataGrid.Controls.Add(DataGridCustomers);
            pnlDataGrid.Controls.Add(btnPrint);
            pnlDataGrid.Location = new Point(296, 80);
            pnlDataGrid.Name = "pnlDataGrid";
            pnlDataGrid.Size = new Size(723, 427);
            pnlDataGrid.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(383, 12);
            label1.Name = "label1";
            label1.Size = new Size(457, 65);
            label1.TabIndex = 22;
            label1.Text = "Customer Bookings";
            // 
            // Report2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1220, 971);
            Controls.Add(pnlDataGrid);
            Controls.Add(label1);
            Controls.Add(printPreviewControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Report2";
            Text = "Report2";
            Load += Report2_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridCustomers).EndInit();
            pnlDataGrid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrint;
        private Panel panel1;
        private Panel panel2;
        private PrintPreviewControl printPreviewControl1;
        private DataGridView DataGridCustomers;
        private DataGridViewTextBoxColumn clmCustomerID;
        private DataGridViewTextBoxColumn clmFIrstname;
        private DataGridViewTextBoxColumn clmSurname;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel pnlDataGrid;
        private Label label1;
    }
}