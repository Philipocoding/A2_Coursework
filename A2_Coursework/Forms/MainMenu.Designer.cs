namespace A2_Coursework
{
    partial class MainMenu
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
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pcbInfo = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlAddDetails = new Panel();
            btnAdd_Staff = new Button();
            btnAdd_Customer = new Button();
            btnAddDetails = new Button();
            pnlStock = new Panel();
            btnStockOrder = new Button();
            btnViewStock = new Button();
            btnStock = new Button();
            pnlMenuSubMenu = new Panel();
            btnViewCustomers = new Button();
            btnViewStaff = new Button();
            btnViewDetails = new Button();
            pnlMediaSubMenu = new Panel();
            btnViewBOokings = new Button();
            btnBooking = new Button();
            btnSchedule = new Button();
            btnBookings = new Button();
            pnlLogo = new Panel();
            pnlChildForm = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlAddDetails.SuspendLayout();
            pnlStock.SuspendLayout();
            pnlMenuSubMenu.SuspendLayout();
            pnlMediaSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(5, 32, 74);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pcbInfo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pnlAddDetails);
            panel1.Controls.Add(btnAddDetails);
            panel1.Controls.Add(pnlStock);
            panel1.Controls.Add(btnStock);
            panel1.Controls.Add(pnlMenuSubMenu);
            panel1.Controls.Add(btnViewDetails);
            panel1.Controls.Add(pnlMediaSubMenu);
            panel1.Controls.Add(btnBookings);
            panel1.Controls.Add(pnlLogo);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 795);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Location = new Point(181, 295);
            panel2.Name = "panel2";
            panel2.Size = new Size(32, 44);
            panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.add;
            pictureBox3.Location = new Point(3, 585);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pcbInfo
            // 
            pcbInfo.Image = Properties.Resources.about;
            pcbInfo.Location = new Point(3, 291);
            pcbInfo.Name = "pcbInfo";
            pcbInfo.Size = new Size(47, 48);
            pcbInfo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbInfo.TabIndex = 10;
            pcbInfo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Booking;
            pictureBox1.Location = new Point(3, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlAddDetails
            // 
            pnlAddDetails.BackColor = Color.FromArgb(60, 145, 230);
            pnlAddDetails.Controls.Add(btnAdd_Staff);
            pnlAddDetails.Controls.Add(btnAdd_Customer);
            pnlAddDetails.Dock = DockStyle.Top;
            pnlAddDetails.Location = new Point(0, 639);
            pnlAddDetails.Name = "pnlAddDetails";
            pnlAddDetails.Size = new Size(230, 93);
            pnlAddDetails.TabIndex = 9;
            // 
            // btnAdd_Staff
            // 
            btnAdd_Staff.BackColor = Color.FromArgb(60, 145, 230);
            btnAdd_Staff.Dock = DockStyle.Top;
            btnAdd_Staff.FlatAppearance.BorderSize = 0;
            btnAdd_Staff.FlatStyle = FlatStyle.Flat;
            btnAdd_Staff.Font = new Font("Segoe UI", 15F);
            btnAdd_Staff.ForeColor = Color.Black;
            btnAdd_Staff.Location = new Point(0, 45);
            btnAdd_Staff.Name = "btnAdd_Staff";
            btnAdd_Staff.Padding = new Padding(55, 0, 0, 0);
            btnAdd_Staff.Size = new Size(230, 45);
            btnAdd_Staff.TabIndex = 1;
            btnAdd_Staff.Text = "Add Staff";
            btnAdd_Staff.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd_Staff.UseVisualStyleBackColor = false;
            btnAdd_Staff.Click += btnAdd_Staff_Click;
            // 
            // btnAdd_Customer
            // 
            btnAdd_Customer.BackColor = Color.FromArgb(60, 145, 230);
            btnAdd_Customer.Dock = DockStyle.Top;
            btnAdd_Customer.FlatAppearance.BorderSize = 0;
            btnAdd_Customer.FlatStyle = FlatStyle.Flat;
            btnAdd_Customer.Font = new Font("Segoe UI", 15F);
            btnAdd_Customer.ForeColor = Color.Black;
            btnAdd_Customer.Location = new Point(0, 0);
            btnAdd_Customer.Name = "btnAdd_Customer";
            btnAdd_Customer.Padding = new Padding(55, 0, 0, 0);
            btnAdd_Customer.Size = new Size(230, 45);
            btnAdd_Customer.TabIndex = 0;
            btnAdd_Customer.Text = "Add Customer";
            btnAdd_Customer.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd_Customer.UseVisualStyleBackColor = false;
            btnAdd_Customer.Click += btnAdd_Customer_Click;
            // 
            // btnAddDetails
            // 
            btnAddDetails.BackColor = Color.FromArgb(5, 32, 74);
            btnAddDetails.Dock = DockStyle.Top;
            btnAddDetails.FlatAppearance.BorderSize = 0;
            btnAddDetails.FlatStyle = FlatStyle.Flat;
            btnAddDetails.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnAddDetails.ForeColor = Color.Transparent;
            btnAddDetails.Location = new Point(0, 583);
            btnAddDetails.Name = "btnAddDetails";
            btnAddDetails.Padding = new Padding(45, 0, 0, 0);
            btnAddDetails.Size = new Size(230, 56);
            btnAddDetails.TabIndex = 9;
            btnAddDetails.Text = "Add details";
            btnAddDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnAddDetails.UseVisualStyleBackColor = false;
            btnAddDetails.Click += btnAddDetails_Click;
            // 
            // pnlStock
            // 
            pnlStock.BackColor = Color.FromArgb(60, 145, 230);
            pnlStock.Controls.Add(btnStockOrder);
            pnlStock.Controls.Add(btnViewStock);
            pnlStock.Dock = DockStyle.Top;
            pnlStock.Location = new Point(0, 490);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new Size(230, 93);
            pnlStock.TabIndex = 8;
            // 
            // btnStockOrder
            // 
            btnStockOrder.BackColor = Color.FromArgb(60, 145, 230);
            btnStockOrder.Dock = DockStyle.Top;
            btnStockOrder.FlatAppearance.BorderSize = 0;
            btnStockOrder.FlatStyle = FlatStyle.Flat;
            btnStockOrder.Font = new Font("Segoe UI", 15F);
            btnStockOrder.ForeColor = Color.Black;
            btnStockOrder.Location = new Point(0, 45);
            btnStockOrder.Name = "btnStockOrder";
            btnStockOrder.Padding = new Padding(55, 0, 0, 0);
            btnStockOrder.Size = new Size(230, 45);
            btnStockOrder.TabIndex = 1;
            btnStockOrder.Text = "Order stock";
            btnStockOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnStockOrder.UseVisualStyleBackColor = false;
            btnStockOrder.Click += btnStockOrder_Click;
            // 
            // btnViewStock
            // 
            btnViewStock.BackColor = Color.FromArgb(60, 145, 230);
            btnViewStock.Dock = DockStyle.Top;
            btnViewStock.FlatAppearance.BorderSize = 0;
            btnViewStock.FlatStyle = FlatStyle.Flat;
            btnViewStock.Font = new Font("Segoe UI", 15F);
            btnViewStock.ForeColor = Color.Black;
            btnViewStock.Location = new Point(0, 0);
            btnViewStock.Name = "btnViewStock";
            btnViewStock.Padding = new Padding(55, 0, 0, 0);
            btnViewStock.Size = new Size(230, 45);
            btnViewStock.TabIndex = 0;
            btnViewStock.Text = "View stock";
            btnViewStock.TextAlign = ContentAlignment.MiddleLeft;
            btnViewStock.UseVisualStyleBackColor = false;
            btnViewStock.Click += btnViewStock_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(5, 32, 74);
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnStock.ForeColor = Color.Transparent;
            btnStock.Location = new Point(0, 434);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(45, 0, 0, 0);
            btnStock.Size = new Size(230, 56);
            btnStock.TabIndex = 7;
            btnStock.Text = "Stock";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // pnlMenuSubMenu
            // 
            pnlMenuSubMenu.BackColor = Color.FromArgb(60, 145, 230);
            pnlMenuSubMenu.Controls.Add(btnViewCustomers);
            pnlMenuSubMenu.Controls.Add(btnViewStaff);
            pnlMenuSubMenu.Dock = DockStyle.Top;
            pnlMenuSubMenu.Location = new Point(0, 345);
            pnlMenuSubMenu.Name = "pnlMenuSubMenu";
            pnlMenuSubMenu.Size = new Size(230, 89);
            pnlMenuSubMenu.TabIndex = 1;
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.BackColor = Color.FromArgb(60, 145, 230);
            btnViewCustomers.Dock = DockStyle.Top;
            btnViewCustomers.FlatAppearance.BorderSize = 0;
            btnViewCustomers.FlatStyle = FlatStyle.Flat;
            btnViewCustomers.Font = new Font("Segoe UI", 15F);
            btnViewCustomers.ForeColor = Color.Black;
            btnViewCustomers.Location = new Point(0, 45);
            btnViewCustomers.Name = "btnViewCustomers";
            btnViewCustomers.Padding = new Padding(55, 0, 0, 0);
            btnViewCustomers.Size = new Size(230, 45);
            btnViewCustomers.TabIndex = 1;
            btnViewCustomers.Text = "View Customers";
            btnViewCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnViewCustomers.UseVisualStyleBackColor = false;
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // btnViewStaff
            // 
            btnViewStaff.BackColor = Color.FromArgb(60, 145, 230);
            btnViewStaff.Dock = DockStyle.Top;
            btnViewStaff.FlatAppearance.BorderSize = 0;
            btnViewStaff.FlatStyle = FlatStyle.Flat;
            btnViewStaff.Font = new Font("Segoe UI", 15F);
            btnViewStaff.ForeColor = Color.Black;
            btnViewStaff.Location = new Point(0, 0);
            btnViewStaff.Name = "btnViewStaff";
            btnViewStaff.Padding = new Padding(55, 0, 0, 0);
            btnViewStaff.Size = new Size(230, 45);
            btnViewStaff.TabIndex = 0;
            btnViewStaff.Text = "View Staff";
            btnViewStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnViewStaff.UseVisualStyleBackColor = false;
            btnViewStaff.Click += btnViewStaff_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(5, 32, 74);
            btnViewDetails.Dock = DockStyle.Top;
            btnViewDetails.FlatAppearance.BorderSize = 0;
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnViewDetails.ForeColor = Color.Transparent;
            btnViewDetails.Location = new Point(0, 289);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Padding = new Padding(45, 0, 0, 0);
            btnViewDetails.Size = new Size(230, 56);
            btnViewDetails.TabIndex = 6;
            btnViewDetails.Text = "View details";
            btnViewDetails.TextAlign = ContentAlignment.MiddleLeft;
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnMenu_Click;
            // 
            // pnlMediaSubMenu
            // 
            pnlMediaSubMenu.BackColor = Color.FromArgb(60, 145, 230);
            pnlMediaSubMenu.Controls.Add(btnViewBOokings);
            pnlMediaSubMenu.Controls.Add(btnBooking);
            pnlMediaSubMenu.Controls.Add(btnSchedule);
            pnlMediaSubMenu.Dock = DockStyle.Top;
            pnlMediaSubMenu.ForeColor = Color.Black;
            pnlMediaSubMenu.Location = new Point(0, 156);
            pnlMediaSubMenu.Name = "pnlMediaSubMenu";
            pnlMediaSubMenu.Size = new Size(230, 133);
            pnlMediaSubMenu.TabIndex = 0;
            // 
            // btnViewBOokings
            // 
            btnViewBOokings.BackColor = Color.FromArgb(60, 145, 230);
            btnViewBOokings.Dock = DockStyle.Top;
            btnViewBOokings.FlatAppearance.BorderSize = 0;
            btnViewBOokings.FlatStyle = FlatStyle.Flat;
            btnViewBOokings.Font = new Font("Segoe UI", 15F);
            btnViewBOokings.Location = new Point(0, 45);
            btnViewBOokings.Name = "btnViewBOokings";
            btnViewBOokings.Padding = new Padding(55, 0, 0, 0);
            btnViewBOokings.Size = new Size(230, 45);
            btnViewBOokings.TabIndex = 5;
            btnViewBOokings.Text = "View Bookings";
            btnViewBOokings.TextAlign = ContentAlignment.MiddleLeft;
            btnViewBOokings.UseVisualStyleBackColor = false;
            btnViewBOokings.Click += btnViewBOokings_Click;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.FromArgb(60, 145, 230);
            btnBooking.Dock = DockStyle.Top;
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI", 15F);
            btnBooking.Location = new Point(0, 0);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(55, 0, 0, 0);
            btnBooking.Size = new Size(230, 45);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "New Booking";
            btnBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnBooking.UseVisualStyleBackColor = false;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.BackColor = Color.FromArgb(60, 145, 230);
            btnSchedule.Dock = DockStyle.Bottom;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 15F);
            btnSchedule.ForeColor = Color.Black;
            btnSchedule.Location = new Point(0, 88);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Padding = new Padding(55, 0, 0, 0);
            btnSchedule.Size = new Size(230, 45);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "View Schedule";
            btnSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnBookings
            // 
            btnBookings.BackColor = Color.FromArgb(5, 32, 74);
            btnBookings.Dock = DockStyle.Top;
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnBookings.ForeColor = Color.Transparent;
            btnBookings.Location = new Point(0, 100);
            btnBookings.Name = "btnBookings";
            btnBookings.Padding = new Padding(45, 0, 0, 0);
            btnBookings.Size = new Size(230, 56);
            btnBookings.TabIndex = 1;
            btnBookings.Text = "Bookings";
            btnBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnBookings.UseVisualStyleBackColor = false;
            btnBookings.Click += btnMedia_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(5, 32, 74);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.ForeColor = Color.FromArgb(11, 57, 72);
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(230, 100);
            pnlLogo.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            pnlChildForm.BackColor = Color.FromArgb(0, 32, 72);
            pnlChildForm.Dock = DockStyle.Fill;
            pnlChildForm.Location = new Point(230, 0);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(1183, 795);
            pnlChildForm.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 795);
            Controls.Add(pnlChildForm);
            Controls.Add(panel1);
            MinimumSize = new Size(1357, 804);
            Name = "MainMenu";
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlAddDetails.ResumeLayout(false);
            pnlStock.ResumeLayout(false);
            pnlMenuSubMenu.ResumeLayout(false);
            pnlMediaSubMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBookings;
        private Panel pnlLogo;
        private Panel pnlMediaSubMenu;
        private Button btnViewDetails;
        private Button btnViewBOokings;
        private Button btnAddCustomer;
        private Button btnAddStaff;
        private Button btnBooking;
        private Panel pnlMenuSubMenu;
        private Button btnViewStaff;
        private Button btnSchedule;
        private Button btnViewCustomers;
        private FlowLayoutPanel pnlChildForm;
        private Panel pnlStock;
        private Button btnStockOrder;
        private Button btnViewStock;
        private Button btnStock;
        private Panel pnlAddDetails;
        private Button button2;
        private Button btnAdd_Staff;
        private Button button4;
        private Button btnAdd_Customer;
        private Button btnAddDetails;
        private PictureBox pictureBox1;
        private PictureBox pcbInfo;
        private PictureBox pictureBox3;
        private Panel panel2;
    }
}