using A2_Coursework.Properties;
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
            pnlBookingSubMenu.Visible = false;
            pnlBookingSubMenu.Visible = false;
            pnlSTaffSubMenu.Visible = false;
            pnlStockSubMenu.Visible = false;
            pnlCustomerSUbMenu.Visible = false;
            pnlReportSubMenu.Visible = false;
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
            if (pnlBookingSubMenu.Visible)
            {
                pnlBookingSubMenu.Visible = false;
            }
            if (pnlBookingSubMenu.Visible)
            {
                pnlBookingSubMenu.Visible = false;
            }
            if (pnlStockSubMenu.Visible)
            {
                pnlStockSubMenu.Visible = false;
            }
            if (pnlSTaffSubMenu.Visible)
            {
                pnlSTaffSubMenu.Visible = false;
            }
            if (pnlReportSubMenu.Visible)
            {
                pnlReportSubMenu.Visible = false;
            }
            if (pnlCustomerSUbMenu.Visible)
            {
                pnlCustomerSUbMenu.Visible = false;
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

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            openChildForm(new NewBooking());
            HideSubMenu();
        }

        private void btnViewBooking_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewBookings());
            HideSubMenu();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new Home());
            HideSubMenu();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlStockSubMenu);
        }

        private void btnOrderNewSTock_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderStock());
            HideSubMenu();
        }

        private void btnManageSTock_Click(object sender, EventArgs e)
        {
            openChildForm(new StockIssues());
            HideSubMenu();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSTaffSubMenu);
        }

        private void btnAddSTaff_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStaff());
            HideSubMenu();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewStaffMembers());
            HideSubMenu();
        }



        private void btnManageCUstomer_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewCustomers());
            HideSubMenu();
        }

        private void btnAddCustoemr_Click(object sender, EventArgs e)
        {
            openChildForm(new NewCustomer());
            HideSubMenu();

        }

        private void btnReportOne_Click(object sender, EventArgs e)
        {
            openChildForm(new Report1());
            HideSubMenu();
        }

        private void btnReportTwo_Click(object sender, EventArgs e)
        {
            openChildForm(new Report2());
            HideSubMenu();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCustomerSUbMenu);
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlBookingSubMenu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlReportSubMenu);
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            openChildForm(new Home());
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            openChildForm(new ScheduleReport());
            HideSubMenu();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void btnStockLevels_Click(object sender, EventArgs e)
        {
            openChildForm(new ViewStockLevels());
            HideSubMenu();
        }
    }
}
