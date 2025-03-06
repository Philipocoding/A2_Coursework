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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            dataGridStock = new DataGridView();
            clmStockID = new DataGridViewTextBoxColumn();
            clmStockName = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
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
            button2 = new Button();
            pnlReportIssue = new Panel();
            dtPickerSolutionDate = new DateTimePicker();
            label7 = new Label();
            btnConfirmIssue = new Button();
            label4 = new Label();
            panel1 = new Panel();
            cmbIsueDescription = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cmbQuantityIssue = new ComboBox();
            cmbStockIssue = new ComboBox();
            DataGridStockIssues = new DataGridView();
            clmStockIDIssue = new DataGridViewTextBoxColumn();
            cmStockNameIssue = new DataGridViewTextBoxColumn();
            clmQuantityIssue = new DataGridViewTextBoxColumn();
            clmIssue = new DataGridViewTextBoxColumn();
            clmResolutionDate = new DataGridViewTextBoxColumn();
            STockIssueResolved = new Button();
            btnPendingIssues = new Button();
            btnIssueHistory = new Button();
            pnlIssueResolveConfirm = new Panel();
            pnlIssueResolvedHide = new Panel();
            label8 = new Label();
            btnKept = new Button();
            btnReturned = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridStock).BeginInit();
            pnlReorder.SuspendLayout();
            pnlReportIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridStockIssues).BeginInit();
            pnlIssueResolveConfirm.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridStock
            // 
            dataGridStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStock.Columns.AddRange(new DataGridViewColumn[] { clmStockID, clmStockName, clmQuantity, clmStatus, clmCost });
            dataGridStock.Location = new Point(2, 187);
            dataGridStock.Name = "dataGridStock";
            dataGridStock.Size = new Size(569, 349);
            dataGridStock.TabIndex = 0;
            // 
            // clmStockID
            // 
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmStockID.DefaultCellStyle = dataGridViewCellStyle11;
            clmStockID.HeaderText = "Stock ID";
            clmStockID.Name = "clmStockID";
            clmStockID.Width = 75;
            // 
            // clmStockName
            // 
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmStockName.DefaultCellStyle = dataGridViewCellStyle12;
            clmStockName.HeaderText = "Stock";
            clmStockName.Name = "clmStockName";
            clmStockName.Width = 150;
            // 
            // clmQuantity
            // 
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmQuantity.DefaultCellStyle = dataGridViewCellStyle13;
            clmQuantity.HeaderText = "Quantity";
            clmQuantity.Name = "clmQuantity";
            // 
            // clmStatus
            // 
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmStatus.DefaultCellStyle = dataGridViewCellStyle14;
            clmStatus.HeaderText = "Status";
            clmStatus.Name = "clmStatus";
            // 
            // clmCost
            // 
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmCost.DefaultCellStyle = dataGridViewCellStyle15;
            clmCost.HeaderText = "Cost";
            clmCost.Name = "clmCost";
            // 
            // btnAutoOrder
            // 
            btnAutoOrder.BackColor = Color.FromArgb(85, 193, 255);
            btnAutoOrder.FlatAppearance.BorderSize = 0;
            btnAutoOrder.FlatStyle = FlatStyle.Flat;
            btnAutoOrder.Font = new Font("Microsoft Sans Serif", 17.25F);
            btnAutoOrder.ForeColor = Color.Black;
            btnAutoOrder.Location = new Point(12, 542);
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
            pnlReorder.Controls.Add(btnconfirm);
            pnlReorder.Controls.Add(label3);
            pnlReorder.Controls.Add(cmbReorderLevel);
            pnlReorder.Controls.Add(label2);
            pnlReorder.Controls.Add(label1);
            pnlReorder.Controls.Add(cmbQuantity);
            pnlReorder.Controls.Add(cmbStock);
            pnlReorder.Location = new Point(37, 650);
            pnlReorder.Name = "pnlReorder";
            pnlReorder.Size = new Size(457, 264);
            pnlReorder.TabIndex = 3;
            pnlReorder.Visible = false;
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
            // cmbReorderLevel
            // 
            cmbReorderLevel.Font = new Font("Segoe UI", 20F);
            cmbReorderLevel.FormattingEnabled = true;
            cmbReorderLevel.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cmbReorderLevel.Location = new Point(285, 116);
            cmbReorderLevel.Name = "cmbReorderLevel";
            cmbReorderLevel.Size = new Size(150, 45);
            cmbReorderLevel.TabIndex = 6;
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
            // cmbQuantity
            // 
            cmbQuantity.Font = new Font("Segoe UI", 20F);
            cmbQuantity.FormattingEnabled = true;
            cmbQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cmbQuantity.Location = new Point(285, 65);
            cmbQuantity.Name = "cmbQuantity";
            cmbQuantity.Size = new Size(150, 45);
            cmbQuantity.TabIndex = 3;
            // 
            // btnReorderStock
            // 
            btnReorderStock.BackColor = Color.FromArgb(85, 193, 255);
            btnReorderStock.FlatAppearance.BorderSize = 0;
            btnReorderStock.FlatStyle = FlatStyle.Flat;
            btnReorderStock.Font = new Font("Microsoft Sans Serif", 17.25F);
            btnReorderStock.ForeColor = Color.Black;
            btnReorderStock.Location = new Point(308, 542);
            btnReorderStock.Name = "btnReorderStock";
            btnReorderStock.Size = new Size(254, 52);
            btnReorderStock.TabIndex = 4;
            btnReorderStock.Text = "Reorder stock";
            btnReorderStock.UseVisualStyleBackColor = false;
            btnReorderStock.Click += btnReorderStock_Click;
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
            // button2
            // 
            button2.BackColor = Color.FromArgb(85, 193, 255);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 17.25F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(600, 542);
            button2.Name = "button2";
            button2.Size = new Size(313, 52);
            button2.TabIndex = 9;
            button2.Text = "Report stock faults";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnlReportIssue
            // 
            pnlReportIssue.Controls.Add(dtPickerSolutionDate);
            pnlReportIssue.Controls.Add(label7);
            pnlReportIssue.Controls.Add(btnConfirmIssue);
            pnlReportIssue.Controls.Add(label4);
            pnlReportIssue.Controls.Add(cmbIsueDescription);
            pnlReportIssue.Controls.Add(label5);
            pnlReportIssue.Controls.Add(label6);
            pnlReportIssue.Controls.Add(cmbQuantityIssue);
            pnlReportIssue.Controls.Add(cmbStockIssue);
            pnlReportIssue.Location = new Point(489, 650);
            pnlReportIssue.Name = "pnlReportIssue";
            pnlReportIssue.Size = new Size(428, 290);
            pnlReportIssue.TabIndex = 10;
            pnlReportIssue.Visible = false;
            // 
            // dtPickerSolutionDate
            // 
            dtPickerSolutionDate.Font = new Font("Segoe UI", 20F);
            dtPickerSolutionDate.Location = new Point(224, 162);
            dtPickerSolutionDate.Name = "dtPickerSolutionDate";
            dtPickerSolutionDate.Size = new Size(175, 43);
            dtPickerSolutionDate.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(64, 162);
            label7.Name = "label7";
            label7.Size = new Size(154, 64);
            label7.TabIndex = 8;
            label7.Text = "Estimated \r\nsolution date";
            // 
            // btnConfirmIssue
            // 
            btnConfirmIssue.BackColor = Color.FromArgb(50, 55, 59);
            btnConfirmIssue.FlatAppearance.BorderSize = 0;
            btnConfirmIssue.FlatStyle = FlatStyle.Flat;
            btnConfirmIssue.Font = new Font("Microsoft Sans Serif", 20F);
            btnConfirmIssue.ForeColor = Color.White;
            btnConfirmIssue.Location = new Point(255, 213);
            btnConfirmIssue.Name = "btnConfirmIssue";
            btnConfirmIssue.Size = new Size(132, 51);
            btnConfirmIssue.TabIndex = 4;
            btnConfirmIssue.Text = "Confirm";
            btnConfirmIssue.UseVisualStyleBackColor = false;
            btnConfirmIssue.Click += btnConfirmIssue_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(138, 114);
            label4.Name = "label4";
            label4.Size = new Size(75, 37);
            label4.TabIndex = 7;
            label4.Text = "Issue";
            // 
            // panel1
            // 
            panel1.Location = new Point(1268, 863);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 221);
            panel1.TabIndex = 20;
            // 
            // cmbIsueDescription
            // 
            cmbIsueDescription.Font = new Font("Segoe UI", 20F);
            cmbIsueDescription.FormattingEnabled = true;
            cmbIsueDescription.Items.AddRange(new object[] { "Broken", "Cracked", "Won't turn on", "Wrong item", "Poor quality" });
            cmbIsueDescription.Location = new Point(224, 111);
            cmbIsueDescription.Name = "cmbIsueDescription";
            cmbIsueDescription.Size = new Size(175, 45);
            cmbIsueDescription.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(99, 63);
            label5.Name = "label5";
            label5.Size = new Size(119, 37);
            label5.TabIndex = 5;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(138, 9);
            label6.Name = "label6";
            label6.Size = new Size(80, 37);
            label6.TabIndex = 4;
            label6.Text = "Stock";
            // 
            // cmbQuantityIssue
            // 
            cmbQuantityIssue.Font = new Font("Segoe UI", 20F);
            cmbQuantityIssue.FormattingEnabled = true;
            cmbQuantityIssue.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" });
            cmbQuantityIssue.Location = new Point(224, 60);
            cmbQuantityIssue.Name = "cmbQuantityIssue";
            cmbQuantityIssue.Size = new Size(175, 45);
            cmbQuantityIssue.TabIndex = 3;
            // 
            // cmbStockIssue
            // 
            cmbStockIssue.Font = new Font("Segoe UI", 20F);
            cmbStockIssue.FormattingEnabled = true;
            cmbStockIssue.Location = new Point(224, 9);
            cmbStockIssue.Name = "cmbStockIssue";
            cmbStockIssue.Size = new Size(175, 45);
            cmbStockIssue.TabIndex = 2;
            // 
            // DataGridStockIssues
            // 
            DataGridStockIssues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridStockIssues.Columns.AddRange(new DataGridViewColumn[] { clmStockIDIssue, cmStockNameIssue, clmQuantityIssue, clmIssue, clmResolutionDate });
            DataGridStockIssues.Location = new Point(587, 187);
            DataGridStockIssues.Name = "DataGridStockIssues";
            DataGridStockIssues.Size = new Size(623, 349);
            DataGridStockIssues.TabIndex = 11;
            // 
            // clmStockIDIssue
            // 
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmStockIDIssue.DefaultCellStyle = dataGridViewCellStyle16;
            clmStockIDIssue.HeaderText = "Stock ID";
            clmStockIDIssue.Name = "clmStockIDIssue";
            clmStockIDIssue.Width = 75;
            // 
            // cmStockNameIssue
            // 
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmStockNameIssue.DefaultCellStyle = dataGridViewCellStyle17;
            cmStockNameIssue.HeaderText = "Stock";
            cmStockNameIssue.Name = "cmStockNameIssue";
            cmStockNameIssue.Width = 160;
            // 
            // clmQuantityIssue
            // 
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmQuantityIssue.DefaultCellStyle = dataGridViewCellStyle18;
            clmQuantityIssue.HeaderText = "Quantity";
            clmQuantityIssue.Name = "clmQuantityIssue";
            // 
            // clmIssue
            // 
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmIssue.DefaultCellStyle = dataGridViewCellStyle19;
            clmIssue.HeaderText = "Issue";
            clmIssue.Name = "clmIssue";
            clmIssue.Width = 150;
            // 
            // clmResolutionDate
            // 
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmResolutionDate.DefaultCellStyle = dataGridViewCellStyle20;
            clmResolutionDate.HeaderText = "Resolution Date";
            clmResolutionDate.Name = "clmResolutionDate";
            // 
            // STockIssueResolved
            // 
            STockIssueResolved.BackColor = Color.FromArgb(85, 193, 255);
            STockIssueResolved.FlatAppearance.BorderSize = 0;
            STockIssueResolved.FlatStyle = FlatStyle.Flat;
            STockIssueResolved.Font = new Font("Microsoft Sans Serif", 17.25F);
            STockIssueResolved.ForeColor = Color.Black;
            STockIssueResolved.Location = new Point(917, 597);
            STockIssueResolved.Name = "STockIssueResolved";
            STockIssueResolved.Size = new Size(284, 52);
            STockIssueResolved.TabIndex = 12;
            STockIssueResolved.Text = "Stock issue resolved";
            STockIssueResolved.UseVisualStyleBackColor = false;
            STockIssueResolved.Click += STockIssueResolved_Click;
            // 
            // btnPendingIssues
            // 
            btnPendingIssues.BackColor = Color.FromArgb(85, 193, 255);
            btnPendingIssues.FlatAppearance.BorderSize = 0;
            btnPendingIssues.FlatStyle = FlatStyle.Flat;
            btnPendingIssues.Font = new Font("Microsoft Sans Serif", 17.25F);
            btnPendingIssues.ForeColor = Color.Black;
            btnPendingIssues.Location = new Point(917, 542);
            btnPendingIssues.Name = "btnPendingIssues";
            btnPendingIssues.Size = new Size(284, 52);
            btnPendingIssues.TabIndex = 14;
            btnPendingIssues.Text = "View pending issues";
            btnPendingIssues.UseVisualStyleBackColor = false;
            btnPendingIssues.Click += btnPendingIssues_Click;
            // 
            // btnIssueHistory
            // 
            btnIssueHistory.BackColor = Color.FromArgb(85, 193, 255);
            btnIssueHistory.FlatAppearance.BorderSize = 0;
            btnIssueHistory.FlatStyle = FlatStyle.Flat;
            btnIssueHistory.Font = new Font("Microsoft Sans Serif", 17.25F);
            btnIssueHistory.ForeColor = Color.Black;
            btnIssueHistory.Location = new Point(600, 597);
            btnIssueHistory.Name = "btnIssueHistory";
            btnIssueHistory.Size = new Size(313, 52);
            btnIssueHistory.TabIndex = 13;
            btnIssueHistory.Text = "View stock issue history";
            btnIssueHistory.UseVisualStyleBackColor = false;
            btnIssueHistory.Click += btnIssueHistory_Click;
            // 
            // pnlIssueResolveConfirm
            // 
            pnlIssueResolveConfirm.Controls.Add(pnlIssueResolvedHide);
            pnlIssueResolveConfirm.Controls.Add(label8);
            pnlIssueResolveConfirm.Controls.Add(btnKept);
            pnlIssueResolveConfirm.Controls.Add(btnReturned);
            pnlIssueResolveConfirm.Location = new Point(926, 655);
            pnlIssueResolveConfirm.Name = "pnlIssueResolveConfirm";
            pnlIssueResolveConfirm.Size = new Size(275, 279);
            pnlIssueResolveConfirm.TabIndex = 15;
            // 
            // pnlIssueResolvedHide
            // 
            pnlIssueResolvedHide.Location = new Point(6, 9);
            pnlIssueResolvedHide.Name = "pnlIssueResolvedHide";
            pnlIssueResolvedHide.Size = new Size(269, 275);
            pnlIssueResolvedHide.TabIndex = 1;
            pnlIssueResolvedHide.Paint += pnlIssueResolvedHide_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(1, 4);
            label8.Name = "label8";
            label8.Size = new Size(280, 64);
            label8.TabIndex = 18;
            label8.Text = "Was the stock kept or\r\nreturned to the supplier?";
            // 
            // btnKept
            // 
            btnKept.BackColor = Color.FromArgb(50, 55, 59);
            btnKept.FlatAppearance.BorderSize = 0;
            btnKept.FlatStyle = FlatStyle.Flat;
            btnKept.Font = new Font("Microsoft Sans Serif", 20F);
            btnKept.ForeColor = Color.White;
            btnKept.Location = new Point(63, 139);
            btnKept.Name = "btnKept";
            btnKept.Size = new Size(135, 52);
            btnKept.TabIndex = 17;
            btnKept.Text = "Item kept";
            btnKept.UseVisualStyleBackColor = false;
            btnKept.Click += btnKept_Click;
            // 
            // btnReturned
            // 
            btnReturned.BackColor = Color.FromArgb(50, 55, 59);
            btnReturned.FlatAppearance.BorderSize = 0;
            btnReturned.FlatStyle = FlatStyle.Flat;
            btnReturned.Font = new Font("Microsoft Sans Serif", 20F);
            btnReturned.ForeColor = Color.White;
            btnReturned.Location = new Point(63, 81);
            btnReturned.Name = "btnReturned";
            btnReturned.Size = new Size(135, 52);
            btnReturned.TabIndex = 16;
            btnReturned.Text = "Returned";
            btnReturned.UseVisualStyleBackColor = false;
            btnReturned.Click += btnReturned_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold);
            label9.Location = new Point(489, 8);
            label9.Name = "label9";
            label9.Size = new Size(340, 65);
            label9.TabIndex = 8;
            label9.Text = "Manage Stock";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Symbol", 25F, FontStyle.Bold);
            label10.Location = new Point(193, 138);
            label10.Name = "label10";
            label10.Size = new Size(206, 46);
            label10.TabIndex = 21;
            label10.Text = "Stock levels";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Symbol", 25F, FontStyle.Bold);
            label11.Location = new Point(769, 138);
            label11.Name = "label11";
            label11.Size = new Size(211, 46);
            label11.TabIndex = 22;
            label11.Text = "Stock issues";
            // 
            // ViewStockLevels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1382, 898);
            Controls.Add(pnlIssueResolveConfirm);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(btnPendingIssues);
            Controls.Add(btnIssueHistory);
            Controls.Add(STockIssueResolved);
            Controls.Add(DataGridStockIssues);
            Controls.Add(pnlReportIssue);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnReorderStock);
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
            pnlReportIssue.ResumeLayout(false);
            pnlReportIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridStockIssues).EndInit();
            pnlIssueResolveConfirm.ResumeLayout(false);
            pnlIssueResolveConfirm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridStock;
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
        private Button button2;
        private Panel pnlReportIssue;
        private Button btnConfirmIssue;
        private Label label4;
        private ComboBox cmbIsueDescription;
        private Label label5;
        private Label label6;
        private ComboBox cmbQuantityIssue;
        private ComboBox cmbStockIssue;
        private DateTimePicker dtPickerSolutionDate;
        private Label label7;
        private DataGridView DataGridStockIssues;
        private Button STockIssueResolved;
        private Button btnPendingIssues;
        private Button btnIssueHistory;
        private Panel pnlIssueResolveConfirm;
        private Button btnKept;
        private Button btnReturned;
        private Label label8;
        private Panel pnlIssueResolvedHide;
        private Panel panel1;
        private Label label9;
        private Label label10;
        private Label label11;
        private DataGridViewTextBoxColumn clmStockID;
        private DataGridViewTextBoxColumn clmStockName;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmStatus;
        private DataGridViewTextBoxColumn clmCost;
        private DataGridViewTextBoxColumn clmStockIDIssue;
        private DataGridViewTextBoxColumn cmStockNameIssue;
        private DataGridViewTextBoxColumn clmQuantityIssue;
        private DataGridViewTextBoxColumn clmIssue;
        private DataGridViewTextBoxColumn clmResolutionDate;
    }
}