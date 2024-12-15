using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void showSubMenu(Panel subMenu)
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

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            activeForm = childForm;
            activeForm.Location = new System.Drawing.Point(0, 0);
            activeForm.Enabled = true;
            activeForm.Visible = true;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(activeForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
    }
}
