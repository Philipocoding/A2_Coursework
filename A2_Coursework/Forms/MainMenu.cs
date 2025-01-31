using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A2_Coursework
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            customiseDesign();
        }
        private void customiseDesign()
        {
            pnlMediaSubMenu.Visible = false;
            pnlMenuSubMenu.Visible = false;
            pnlAddDetails.Visible = false;
            pnlStock.Visible = false;
        }


        public void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void HideSubMenu()
        {
            if (pnlMenuSubMenu.Visible)
            {
                pnlMenuSubMenu.Visible = false;
            }
            if (pnlMediaSubMenu.Visible)
            {
                pnlMediaSubMenu.Visible = false;
            }
            if (pnlStock.Visible)
            {
                pnlStock.Visible = false;
            }
            if (pnlAddDetails.Visible)
            {
                pnlAddDetails.Visible = false;
            }
        }

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            // Close and dispose of the previous form if it exists
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Set the new active form
            activeForm = childForm;

            // Configure the new child form
            activeForm.Location = new System.Drawing.Point(0, 0); // Top-left corner
            activeForm.TopLevel = false; // Make it a non-top-level form
            activeForm.FormBorderStyle = FormBorderStyle.None; // Remove border
            activeForm.Dock = DockStyle.Fill; // Fill the parent container

            // Add the new form to the panel
            pnlChildForm.Controls.Clear(); // Clear previous controls
            pnlChildForm.Controls.Add(activeForm);

            // Bring it to the front and explicitly show it
            activeForm.BringToFront();
            activeForm.Show();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMediaSubMenu);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMenuSubMenu);

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            openChildForm(new NewBooking());
            //code
            HideSubMenu();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStaff());
            HideSubMenu();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new NewCustomer());
            HideSubMenu();
        }


        private void btnViewBOokings_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewBookings());
            HideSubMenu();
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewStaffMembers());
            HideSubMenu();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewCustomers());
            HideSubMenu();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            openChildForm(new BookingSchedules());
            HideSubMenu();
        }

        private void btnStockOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderStock());
            HideSubMenu();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewStockLevels());
            HideSubMenu();
        }



        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlAddDetails);

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlStock);

        }

        

        private void btnAdd_Customer_Click(object sender, EventArgs e)
        {
            openChildForm(new NewCustomer());
            HideSubMenu();
        }

        private void btnAdd_Staff_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStaff());
            HideSubMenu();
        }
    }
}
