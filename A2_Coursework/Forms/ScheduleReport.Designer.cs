namespace A2_Coursework.Properties
{
    partial class ScheduleReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleReport));
            label2 = new Label();
            DtPicker = new DateTimePicker();
            label1 = new Label();
            btnWcThree = new Button();
            btnWcFour = new Button();
            btnWCTwo = new Button();
            btnWcOne = new Button();
            panel1 = new Panel();
            btnSelect = new Button();
            label3 = new Label();
            btnLeft = new Button();
            btnRight = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewControl1 = new PrintPreviewControl();
            panel2 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold);
            label2.Location = new Point(431, 9);
            label2.Name = "label2";
            label2.Size = new Size(348, 65);
            label2.TabIndex = 35;
            label2.Text = "View Schedule";
            // 
            // DtPicker
            // 
            DtPicker.CalendarFont = new Font("Segoe UI", 21F);
            DtPicker.Font = new Font("Microsoft Sans Serif", 20F);
            DtPicker.Location = new Point(242, 182);
            DtPicker.Name = "DtPicker";
            DtPicker.Size = new Size(268, 38);
            DtPicker.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(294, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 40;
            label1.Text = "View by week";
            // 
            // btnWcThree
            // 
            btnWcThree.BackColor = Color.FromArgb(50, 55, 59);
            btnWcThree.FlatAppearance.BorderSize = 0;
            btnWcThree.FlatStyle = FlatStyle.Flat;
            btnWcThree.Font = new Font("Segoe UI", 20F);
            btnWcThree.ForeColor = Color.White;
            btnWcThree.Location = new Point(385, 41);
            btnWcThree.Name = "btnWcThree";
            btnWcThree.Size = new Size(171, 47);
            btnWcThree.TabIndex = 39;
            btnWcThree.Text = "Postpone";
            btnWcThree.UseVisualStyleBackColor = false;
            btnWcThree.Click += btnWcThree_Click;
            // 
            // btnWcFour
            // 
            btnWcFour.BackColor = Color.FromArgb(50, 55, 59);
            btnWcFour.FlatAppearance.BorderSize = 0;
            btnWcFour.FlatStyle = FlatStyle.Flat;
            btnWcFour.Font = new Font("Segoe UI", 20F);
            btnWcFour.ForeColor = Color.White;
            btnWcFour.Location = new Point(562, 41);
            btnWcFour.Name = "btnWcFour";
            btnWcFour.Size = new Size(171, 47);
            btnWcFour.TabIndex = 38;
            btnWcFour.Text = "Postpone";
            btnWcFour.UseVisualStyleBackColor = false;
            btnWcFour.Click += btnWcFour_Click;
            // 
            // btnWCTwo
            // 
            btnWCTwo.BackColor = Color.FromArgb(50, 55, 59);
            btnWCTwo.FlatAppearance.BorderSize = 0;
            btnWCTwo.FlatStyle = FlatStyle.Flat;
            btnWCTwo.Font = new Font("Segoe UI", 20F);
            btnWCTwo.ForeColor = Color.White;
            btnWCTwo.Location = new Point(208, 41);
            btnWCTwo.Name = "btnWCTwo";
            btnWCTwo.Size = new Size(171, 47);
            btnWCTwo.TabIndex = 37;
            btnWCTwo.Text = "Postpone";
            btnWCTwo.UseVisualStyleBackColor = false;
            btnWCTwo.Click += btnWCTwo_Click;
            // 
            // btnWcOne
            // 
            btnWcOne.BackColor = Color.FromArgb(50, 55, 59);
            btnWcOne.FlatAppearance.BorderSize = 0;
            btnWcOne.FlatStyle = FlatStyle.Flat;
            btnWcOne.Font = new Font("Segoe UI", 20F);
            btnWcOne.ForeColor = Color.White;
            btnWcOne.Location = new Point(31, 41);
            btnWcOne.Name = "btnWcOne";
            btnWcOne.Size = new Size(171, 47);
            btnWcOne.TabIndex = 36;
            btnWcOne.Text = "Postpone";
            btnWcOne.UseVisualStyleBackColor = false;
            btnWcOne.Click += btnWcOne_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnWcThree);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLeft);
            panel1.Controls.Add(btnWcOne);
            panel1.Controls.Add(btnRight);
            panel1.Controls.Add(btnWCTwo);
            panel1.Controls.Add(DtPicker);
            panel1.Controls.Add(btnWcFour);
            panel1.Location = new Point(223, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 312);
            panel1.TabIndex = 41;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(50, 55, 59);
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 20F);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(285, 226);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(171, 47);
            btnSelect.TabIndex = 42;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(260, 131);
            label3.Name = "label3";
            label3.Size = new Size(240, 37);
            label3.TabIndex = 41;
            label3.Text = "Select custom date";
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.FromArgb(50, 55, 59);
            btnLeft.FlatAppearance.BorderSize = 0;
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Font = new Font("Segoe UI", 20F);
            btnLeft.ForeColor = Color.White;
            btnLeft.Location = new Point(190, 182);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(46, 38);
            btnLeft.TabIndex = 34;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.FromArgb(50, 55, 59);
            btnRight.FlatAppearance.BorderSize = 0;
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Font = new Font("Segoe UI", 20F);
            btnRight.ForeColor = Color.White;
            btnRight.Location = new Point(516, 182);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(46, 38);
            btnRight.TabIndex = 33;
            btnRight.Text = ">\r\n.";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
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
            // printPreviewControl1
            // 
            printPreviewControl1.BackColor = Color.FromArgb(109, 132, 156);
            printPreviewControl1.Location = new Point(154, 3);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(641, 478);
            printPreviewControl1.TabIndex = 43;
            // 
            // panel2
            // 
            panel2.Controls.Add(printPreviewControl1);
            panel2.Location = new Point(129, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 523);
            panel2.TabIndex = 44;
            // 
            // panel3
            // 
            panel3.Location = new Point(96, 895);
            panel3.Name = "panel3";
            panel3.Size = new Size(27, 168);
            panel3.TabIndex = 43;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1249, 121);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(197, 33);
            flowLayoutPanel1.TabIndex = 45;
            // 
            // ScheduleReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(109, 132, 156);
            ClientSize = new Size(1329, 955);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScheduleReport";
            Text = "ScheduleReport";
            Load += ScheduleReport_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DateTimePicker DtPicker;
        private Label label1;
        private Button btnWcThree;
        private Button btnWcFour;
        private Button btnWCTwo;
        private Button btnWcOne;
        private Panel panel1;
        private Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnSelect;
        private PrintPreviewControl printPreviewControl1;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnLeft;
        private Button btnRight;
    }
}