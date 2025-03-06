namespace A2_Coursework
{
    partial class Report1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report1));
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnPrint = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1 = new Panel();
            panel2 = new Panel();
            DataGridBookings = new DataGridView();
            clmBookingID = new DataGridViewTextBoxColumn();
            clmBookingDate = new DataGridViewTextBoxColumn();
            clmCustomerID = new DataGridViewTextBoxColumn();
            printPreviewControl1 = new PrintPreviewControl();
            printDialog1 = new PrintDialog();
            pnlDataGrid = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridBookings).BeginInit();
            pnlDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(85, 193, 255);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 20F);
            btnPrint.Location = new Point(198, 359);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(193, 95);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
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
            // panel1
            // 
            panel1.Location = new Point(476, 679);
            panel1.Name = "panel1";
            panel1.Size = new Size(22, 268);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(1170, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 17);
            panel2.TabIndex = 4;
            // 
            // DataGridBookings
            // 
            DataGridBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridBookings.Columns.AddRange(new DataGridViewColumn[] { clmBookingID, clmBookingDate, clmCustomerID });
            DataGridBookings.Location = new Point(65, 52);
            DataGridBookings.Name = "DataGridBookings";
            DataGridBookings.Size = new Size(510, 301);
            DataGridBookings.TabIndex = 5;
            // 
            // clmBookingID
            // 
            clmBookingID.HeaderText = "Booking ID";
            clmBookingID.Name = "clmBookingID";
            clmBookingID.ReadOnly = true;
            clmBookingID.Width = 150;
            // 
            // clmBookingDate
            // 
            clmBookingDate.HeaderText = "Booking date";
            clmBookingDate.Name = "clmBookingDate";
            clmBookingDate.ReadOnly = true;
            clmBookingDate.Width = 150;
            // 
            // clmCustomerID
            // 
            clmCustomerID.HeaderText = "Customer ID";
            clmCustomerID.Name = "clmCustomerID";
            clmCustomerID.ReadOnly = true;
            clmCustomerID.Width = 150;
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.BackColor = Color.FromArgb(109, 132, 156);
            printPreviewControl1.Location = new Point(657, 107);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(545, 758);
            printPreviewControl1.TabIndex = 8;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // pnlDataGrid
            // 
            pnlDataGrid.Controls.Add(DataGridBookings);
            pnlDataGrid.Controls.Add(btnPrint);
            pnlDataGrid.Location = new Point(262, 55);
            pnlDataGrid.Name = "pnlDataGrid";
            pnlDataGrid.Size = new Size(774, 470);
            pnlDataGrid.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(344, 4);
            label1.Name = "label1";
            label1.Size = new Size(469, 65);
            label1.TabIndex = 21;
            label1.Text = "Booking Breakdown";
            // 
            // Report1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1220, 782);
            Controls.Add(label1);
            Controls.Add(pnlDataGrid);
            Controls.Add(printPreviewControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Report1";
            Text = "Report1";
            Load += Report1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridBookings).EndInit();
            pnlDataGrid.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnPrint;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView DataGridBookings;
        private DataGridViewTextBoxColumn clmBookingID;
        private DataGridViewTextBoxColumn clmBookingDate;
        private DataGridViewTextBoxColumn clmCustomerID;
        private PrintPreviewControl printPreviewControl1;
        private PrintDialog printDialog1;
        private Panel pnlDataGrid;
        private Label label1;
    }
}