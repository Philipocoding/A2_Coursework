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
            pnlMenuSubMenu = new Panel();
            button8 = new Button();
            btnViewCustomers = new Button();
            btnViewStaff = new Button();
            btnMenu = new Button();
            pnlMediaSubMenu = new Panel();
            btnViewBOokings = new Button();
            btnAddCustomer = new Button();
            btnAddStaff = new Button();
            btnBooking = new Button();
            btnMedia = new Button();
            pnlLogo = new Panel();
            pnlChildForm = new FlowLayoutPanel();
            panel1.SuspendLayout();
            pnlMenuSubMenu.SuspendLayout();
            pnlMediaSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(pnlMenuSubMenu);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(pnlMediaSubMenu);
            panel1.Controls.Add(btnMedia);
            panel1.Controls.Add(pnlLogo);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 795);
            panel1.TabIndex = 0;
            // 
            // pnlMenuSubMenu
            // 
            pnlMenuSubMenu.BackColor = SystemColors.ControlLight;
            pnlMenuSubMenu.Controls.Add(button8);
            pnlMenuSubMenu.Controls.Add(btnViewCustomers);
            pnlMenuSubMenu.Controls.Add(btnViewStaff);
            pnlMenuSubMenu.Dock = DockStyle.Top;
            pnlMenuSubMenu.Location = new Point(0, 375);
            pnlMenuSubMenu.Name = "pnlMenuSubMenu";
            pnlMenuSubMenu.Size = new Size(200, 170);
            pnlMenuSubMenu.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLightLight;
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.Black;
            button8.Location = new Point(0, 90);
            button8.Name = "button8";
            button8.Padding = new Padding(35, 0, 0, 0);
            button8.Size = new Size(200, 45);
            button8.TabIndex = 2;
            button8.Text = "button8";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // btnViewCustomers
            // 
            btnViewCustomers.BackColor = SystemColors.ControlLightLight;
            btnViewCustomers.Dock = DockStyle.Top;
            btnViewCustomers.FlatAppearance.BorderSize = 0;
            btnViewCustomers.FlatStyle = FlatStyle.Flat;
            btnViewCustomers.ForeColor = Color.Black;
            btnViewCustomers.Location = new Point(0, 45);
            btnViewCustomers.Name = "btnViewCustomers";
            btnViewCustomers.Padding = new Padding(35, 0, 0, 0);
            btnViewCustomers.Size = new Size(200, 45);
            btnViewCustomers.TabIndex = 1;
            btnViewCustomers.Text = "View Customers";
            btnViewCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnViewCustomers.UseVisualStyleBackColor = false;
            btnViewCustomers.Click += btnViewCustomers_Click;
            // 
            // btnViewStaff
            // 
            btnViewStaff.BackColor = SystemColors.ControlLightLight;
            btnViewStaff.Dock = DockStyle.Top;
            btnViewStaff.FlatAppearance.BorderSize = 0;
            btnViewStaff.FlatStyle = FlatStyle.Flat;
            btnViewStaff.ForeColor = Color.Black;
            btnViewStaff.Location = new Point(0, 0);
            btnViewStaff.Name = "btnViewStaff";
            btnViewStaff.Padding = new Padding(35, 0, 0, 0);
            btnViewStaff.Size = new Size(200, 45);
            btnViewStaff.TabIndex = 0;
            btnViewStaff.Text = "View Staff";
            btnViewStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnViewStaff.UseVisualStyleBackColor = false;
            btnViewStaff.Click += btnViewStaff_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Coral;
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(0, 330);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(15, 0, 0, 0);
            btnMenu.Size = new Size(200, 45);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "Menu";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnlMediaSubMenu
            // 
            pnlMediaSubMenu.BackColor = SystemColors.ControlLight;
            pnlMediaSubMenu.Controls.Add(btnViewBOokings);
            pnlMediaSubMenu.Controls.Add(btnAddCustomer);
            pnlMediaSubMenu.Controls.Add(btnAddStaff);
            pnlMediaSubMenu.Controls.Add(btnBooking);
            pnlMediaSubMenu.Dock = DockStyle.Top;
            pnlMediaSubMenu.ForeColor = Color.Black;
            pnlMediaSubMenu.Location = new Point(0, 145);
            pnlMediaSubMenu.Name = "pnlMediaSubMenu";
            pnlMediaSubMenu.Size = new Size(200, 185);
            pnlMediaSubMenu.TabIndex = 0;
            // 
            // btnViewBOokings
            // 
            btnViewBOokings.BackColor = SystemColors.ControlLight;
            btnViewBOokings.Dock = DockStyle.Top;
            btnViewBOokings.FlatAppearance.BorderSize = 0;
            btnViewBOokings.FlatStyle = FlatStyle.Flat;
            btnViewBOokings.Location = new Point(0, 135);
            btnViewBOokings.Name = "btnViewBOokings";
            btnViewBOokings.Padding = new Padding(25, 0, 0, 0);
            btnViewBOokings.Size = new Size(200, 45);
            btnViewBOokings.TabIndex = 5;
            btnViewBOokings.Text = "View Bookings";
            btnViewBOokings.TextAlign = ContentAlignment.MiddleLeft;
            btnViewBOokings.UseVisualStyleBackColor = false;
            btnViewBOokings.Click += btnViewBOokings_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = SystemColors.ControlLight;
            btnAddCustomer.Dock = DockStyle.Top;
            btnAddCustomer.FlatAppearance.BorderSize = 0;
            btnAddCustomer.FlatStyle = FlatStyle.Flat;
            btnAddCustomer.Location = new Point(0, 90);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Padding = new Padding(25, 0, 0, 0);
            btnAddCustomer.Size = new Size(200, 45);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Add customer";
            btnAddCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnCustomer_Click;
            // 
            // btnAddStaff
            // 
            btnAddStaff.BackColor = SystemColors.ControlLight;
            btnAddStaff.Dock = DockStyle.Top;
            btnAddStaff.FlatAppearance.BorderSize = 0;
            btnAddStaff.FlatStyle = FlatStyle.Flat;
            btnAddStaff.Location = new Point(0, 45);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Padding = new Padding(25, 0, 0, 0);
            btnAddStaff.Size = new Size(200, 45);
            btnAddStaff.TabIndex = 3;
            btnAddStaff.Text = "Add staff";
            btnAddStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnAddStaff.UseVisualStyleBackColor = false;
            btnAddStaff.Click += btnAddStaff_Click;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = SystemColors.ControlLight;
            btnBooking.Dock = DockStyle.Top;
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Location = new Point(0, 0);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(25, 0, 0, 0);
            btnBooking.Size = new Size(200, 45);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "New Booking";
            btnBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnBooking.UseVisualStyleBackColor = false;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnMedia
            // 
            btnMedia.BackColor = Color.Coral;
            btnMedia.Dock = DockStyle.Top;
            btnMedia.FlatAppearance.BorderSize = 0;
            btnMedia.FlatStyle = FlatStyle.Flat;
            btnMedia.ForeColor = Color.Black;
            btnMedia.Location = new Point(0, 100);
            btnMedia.Name = "btnMedia";
            btnMedia.Padding = new Padding(15, 0, 0, 0);
            btnMedia.Size = new Size(200, 45);
            btnMedia.TabIndex = 1;
            btnMedia.Text = "Home";
            btnMedia.TextAlign = ContentAlignment.MiddleLeft;
            btnMedia.UseVisualStyleBackColor = false;
            btnMedia.Click += btnMedia_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = SystemColors.ControlDarkDark;
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(200, 100);
            pnlLogo.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            pnlChildForm.BackColor = SystemColors.ControlDark;
            pnlChildForm.Dock = DockStyle.Fill;
            pnlChildForm.Location = new Point(200, 0);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(1213, 795);
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
            pnlMenuSubMenu.ResumeLayout(false);
            pnlMediaSubMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMedia;
        private Panel pnlLogo;
        private Panel pnlMediaSubMenu;
        private Button btnMenu;
        private Button btnViewBOokings;
        private Button btnAddCustomer;
        private Button btnAddStaff;
        private Button btnBooking;
        private Panel pnlMenuSubMenu;
        private Button btnViewStaff;
        private Button button8;
        private Button btnViewCustomers;
        private FlowLayoutPanel pnlChildForm;
    }
}