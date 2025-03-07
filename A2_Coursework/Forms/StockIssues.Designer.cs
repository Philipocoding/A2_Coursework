namespace A2_Coursework
{
    partial class StockIssues
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
            button1 = new Button();
            button2 = new Button();
            pnlReportIssue = new Panel();
            dtPickerSolutionDate = new DateTimePicker();
            label7 = new Label();
            btnConfirmIssue = new Button();
            label4 = new Label();
            cmbIsueDescription = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cmbQuantityIssue = new ComboBox();
            cmbStockIssue = new ComboBox();
            panel1 = new Panel();
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
            pnlReportIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridStockIssues).BeginInit();
            pnlIssueResolveConfirm.SuspendLayout();
            SuspendLayout();
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
            button2.Location = new Point(365, 474);
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
            pnlReportIssue.Location = new Point(254, 582);
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
            // panel1
            // 
            panel1.Location = new Point(1268, 863);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 221);
            panel1.TabIndex = 20;
            // 
            // DataGridStockIssues
            // 
            DataGridStockIssues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridStockIssues.Columns.AddRange(new DataGridViewColumn[] { clmStockIDIssue, cmStockNameIssue, clmQuantityIssue, clmIssue, clmResolutionDate });
            DataGridStockIssues.Location = new Point(351, 119);
            DataGridStockIssues.Name = "DataGridStockIssues";
            DataGridStockIssues.Size = new Size(633, 349);
            DataGridStockIssues.TabIndex = 11;
            // 
            // clmStockIDIssue
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmStockIDIssue.DefaultCellStyle = dataGridViewCellStyle1;
            clmStockIDIssue.HeaderText = "Stock ID";
            clmStockIDIssue.Name = "clmStockIDIssue";
            clmStockIDIssue.Width = 75;
            // 
            // cmStockNameIssue
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmStockNameIssue.DefaultCellStyle = dataGridViewCellStyle2;
            cmStockNameIssue.HeaderText = "Stock";
            cmStockNameIssue.Name = "cmStockNameIssue";
            cmStockNameIssue.Width = 160;
            // 
            // clmQuantityIssue
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmQuantityIssue.DefaultCellStyle = dataGridViewCellStyle3;
            clmQuantityIssue.HeaderText = "Quantity";
            clmQuantityIssue.Name = "clmQuantityIssue";
            // 
            // clmIssue
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmIssue.DefaultCellStyle = dataGridViewCellStyle4;
            clmIssue.HeaderText = "Issue";
            clmIssue.Name = "clmIssue";
            clmIssue.Width = 150;
            // 
            // clmResolutionDate
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clmResolutionDate.DefaultCellStyle = dataGridViewCellStyle5;
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
            STockIssueResolved.Location = new Point(682, 529);
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
            btnPendingIssues.Location = new Point(682, 474);
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
            btnIssueHistory.Location = new Point(365, 529);
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
            pnlIssueResolveConfirm.Location = new Point(691, 587);
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
            label9.Location = new Point(500, 9);
            label9.Name = "label9";
            label9.Size = new Size(294, 65);
            label9.TabIndex = 8;
            label9.Text = "Stock Issues";
            // 
            // StockIssues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1382, 898);
            Controls.Add(pnlIssueResolveConfirm);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(btnPendingIssues);
            Controls.Add(btnIssueHistory);
            Controls.Add(STockIssueResolved);
            Controls.Add(DataGridStockIssues);
            Controls.Add(pnlReportIssue);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockIssues";
            Text = "ViewStockLevels";
            Load += ViewStockLevels_Load;
            pnlReportIssue.ResumeLayout(false);
            pnlReportIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridStockIssues).EndInit();
            pnlIssueResolveConfirm.ResumeLayout(false);
            pnlIssueResolveConfirm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private DataGridViewTextBoxColumn clmStockIDIssue;
        private DataGridViewTextBoxColumn cmStockNameIssue;
        private DataGridViewTextBoxColumn clmQuantityIssue;
        private DataGridViewTextBoxColumn clmIssue;
        private DataGridViewTextBoxColumn clmResolutionDate;
    }
}