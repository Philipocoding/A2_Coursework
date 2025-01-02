using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2_Coursework.Classes;

namespace A2_Coursework
{
    public partial class NewBooking : Form
    {
        public NewBooking()
        {
            InitializeComponent();
        }
        List<int> services = new List<int>();
        List<int> quantity = new List<int>();
        bool windows = false;
        bool Floors = false;
        bool Doors = false;
        bool Dusting = false;
        bool Bathroom = false;
        bool Carpet = false;
        bool Curtains = false;
        bool Vacuum = false;

        private void btnWindows_Click(object sender, EventArgs e)
        {
            if (btnWindows.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnWindows.Font = new Font(btnWindows.Font.FontFamily, btnWindows.Font.Size, FontStyle.Regular);
                windows = false;
            }
            else
            {
                btnWindows.Font = new Font(btnWindows.Font, FontStyle.Bold);
                windows = true;
            }

        }

        private void btnFloors_Click(object sender, EventArgs e)
        {
            if (btnFloors.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnFloors.Font = new Font(btnFloors.Font.FontFamily, btnFloors.Font.Size, FontStyle.Regular);
                Floors = false;
            }
            else
            {
                btnFloors.Font = new Font(btnFloors.Font, FontStyle.Bold);
                Floors = true;
            }
        }

        private void btnDoors_Click(object sender, EventArgs e)
        {
            if (btnDoors.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnDoors.Font = new Font(btnDoors.Font.FontFamily, btnDoors.Font.Size, FontStyle.Regular);
                Doors = false;
            }
            else
            {
                btnDoors.Font = new Font(btnDoors.Font, FontStyle.Bold);
                Doors = true;
            }
        }

        private void btnDusting_Click(object sender, EventArgs e)
        {
            if (btnDusting.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnDusting.Font = new Font(btnDusting.Font.FontFamily, btnDusting.Font.Size, FontStyle.Regular);
                Dusting = false;
            }
            else
            {
                btnDusting.Font = new Font(btnDusting.Font, FontStyle.Bold);
                Dusting = true;
            }
        }

        private void btnBathrooms_Click(object sender, EventArgs e)
        {
            if (btnBathrooms.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnBathrooms.Font = new Font(btnBathrooms.Font.FontFamily, btnBathrooms.Font.Size, FontStyle.Regular);
                Bathroom = false;
            }
            else
            {
                btnBathrooms.Font = new Font(btnBathrooms.Font, FontStyle.Bold);
                Bathroom = true;
            }
        }

        private void btnVacuuming_Click(object sender, EventArgs e)
        {
            if (btnCarpets.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnCarpets.Font = new Font(btnCarpets.Font.FontFamily, btnCarpets.Font.Size, FontStyle.Regular);
                Carpet = false;
            }
            else
            {
                btnCarpets.Font = new Font(btnCarpets.Font, FontStyle.Bold);
                Carpet = true;
            }
        }

        private void btnCurtains_Click(object sender, EventArgs e)
        {
            if (btnCurtains.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnCurtains.Font = new Font(btnCurtains.Font.FontFamily, btnCarpets.Font.Size, FontStyle.Regular);
                Curtains = false;
            }
            else
            {
                btnCurtains.Font = new Font(btnCurtains.Font, FontStyle.Bold);
                Curtains = true;
            }
        }

        private void btnRoomVacuum_Click(object sender, EventArgs e)
        {
            if (btnRoomVacuum.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnRoomVacuum.Font = new Font(btnRoomVacuum.Font.FontFamily, btnRoomVacuum.Font.Size, FontStyle.Regular);
                Vacuum = false;
            }
            else
            {
                btnRoomVacuum.Font = new Font(btnRoomVacuum.Font, FontStyle.Bold);
                Vacuum = true;
            }
        }



        private void NewBooking_Load(object sender, EventArgs e)
        {
            windows = false;
            Floors = false;
            Doors = false;
            Dusting = false;
            Bathroom = false;
            Carpet = false;
            Curtains = false;
            Vacuum = false;
        }

        private void lblWindowPlus_Click(object sender, EventArgs e)
        {
            lblWIndows.Text = (Convert.ToInt32(lblWIndows.Text) + 1).ToString();
        }

        private void lblWIndowsMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblVacuum.Text) > 0)
            {
                lblWIndows.Text = (Convert.ToInt32(lblWIndows.Text) - 1).ToString();
            }
        }

        private void lblFloorPlus_Click(object sender, EventArgs e)
        {
            lblFloors.Text = (Convert.ToInt32(lblFloors.Text) + 1).ToString();
        }

        private void lblFloorMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblVacuum.Text) > 0)
            {
                lblFloors.Text = (Convert.ToInt32(lblFloors.Text) - 1).ToString();
            }

        }

        private void lblDoorPlus_Click(object sender, EventArgs e)
        {
            lblDoors.Text = (Convert.ToInt32(lblDoors.Text) + 1).ToString();
        }

        private void lblDoorMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblVacuum.Text) > 0)
            {
                lblDoors.Text = (Convert.ToInt32(lblDoors.Text) - 1).ToString();
            }

        }

        private void lblDustPlus_Click(object sender, EventArgs e)
        {
            lblDusting.Text = (Convert.ToInt32(lblDusting.Text) + 1).ToString();
        }

        private void lblDustMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblVacuum.Text) > 0)
            {
                lblDusting.Text = (Convert.ToInt32(lblDusting.Text) - 1).ToString();
            }

        }

        private void lblBathroomPlus_Click(object sender, EventArgs e)
        {
            lblBathrooms.Text = (Convert.ToInt32(lblBathrooms.Text) + 1).ToString();
        }

        private void lblBathroomMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblVacuum.Text) > 0)
            {
                lblBathrooms.Text = (Convert.ToInt32(lblBathrooms.Text) - 1).ToString();
            }

        }

        private void lblCarpetsPlus_Click(object sender, EventArgs e)
        {
            lblCarpets.Text = (Convert.ToInt32(lblCarpets.Text) + 1).ToString();
        }

        private void lblCarpetsMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblVacuum.Text) > 0)
            {
                lblCarpets.Text = (Convert.ToInt32(lblCarpets.Text) - 1).ToString();
            }
        }

        private void lblCurtainsPlus_Click(object sender, EventArgs e)
        {
            lblCurtains.Text = (Convert.ToInt32(lblCurtains.Text) + 1).ToString();
        }

        private void lblCurtainsMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblVacuum.Text) > 0)
            {
                lblCurtains.Text = (Convert.ToInt32(lblCurtains.Text) - 1).ToString();
            }
        }

        private void lblVacuumPlus_Click(object sender, EventArgs e)
        {
            lblVacuum.Text = (Convert.ToInt32(lblVacuum.Text) + 1).ToString();
        }

        private void lblVacuumMinus_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblVacuum.Text) > 0)
            {
                lblVacuum.Text = (Convert.ToInt32(lblVacuum.Text) - 1).ToString();
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                services.Clear();
                quantity.Clear();
                if (windows) { services.Add(1); quantity.Add(Convert.ToInt32(lblWIndows.Text)); }
                if (Floors) { services.Add(2); quantity.Add(Convert.ToInt32(lblFloors.Text)); }
                if (Doors) { services.Add(3); quantity.Add(Convert.ToInt32(lblDoors.Text)); }
                if (Dusting) { services.Add(4); quantity.Add(Convert.ToInt32(lblDusting.Text)); }
                if (Bathroom) { services.Add(5); quantity.Add(Convert.ToInt32(lblBathrooms.Text)); }
                if (Carpet) { services.Add(6); quantity.Add(Convert.ToInt32(lblCarpets.Text)); }
                if (Curtains) { services.Add(7); quantity.Add(Convert.ToInt32(lblCurtains.Text)); }
                if (Vacuum) { services.Add(8); quantity.Add(Convert.ToInt32(lblVacuum.Text)); }

                string dateString = dtPickerDOB_.Value.ToString("yyyy-MM-dd");
                if (Validation.ValidGender(cmbGender_.Text))
                {
                    if ((!Validation.isNullorEmpty(txtbFirstname_.Text) && (!Validation.isNullorEmpty(txtbFirstname_.Text))
                   && (!Validation.isNullorEmpty(txtbEmail_.Text)) && (!Validation.isNullorEmpty(txtbAddressTwo_.Text)) && (!Validation.isNullorEmpty(txtbAddressOne_.Text)
                   && (!Validation.isNullorEmpty(cmbGender_.Text)) && (!Validation.isNullorEmpty(dtPickerDOB_.Text)))))
                    {
                        id = ProjectDAL.NewCustomer(txtbFirstname_.Text, txtbSurname_.Text, dateString, cmbGender_.Text,
                       txtbAddressOne_.Text, txtbAddressTwo_.Text, txtbEmail_.Text);
                        MessageBox.Show("Customer Added");

                        string theDate = BookingDate.Value.ToShortDateString();
                        ProjectDAL.NewBooking(id, theDate, services, quantity);
                        MessageBox.Show("Booking confirmed");
                    }
                    else
                    {

                        MessageBox.Show("Ensure all fields are completed");
                    }
                   
                    
                }
                else
                {
                    MessageBox.Show("Enter valid gender");
                }

                
            }
            catch (Exception ex)
            {

            }

        }
        private void PopulateDataGrid()
        {
            DataGridCustomers.Rows.Clear();
            List<Customer> allCustomers = new();
            allCustomers = Customer.populateDataGrid();
            foreach (Customer customer in allCustomers)
            {
                DataGridCustomers.Rows.Add(customer.CustomerID, customer.Firstname, customer.Surname, customer.DOB
                    , customer.Gender, customer.AddressOne, customer.AddressTwo, customer.Email);
            }
        }
        private void ExistingCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (ExistingCustomer.Checked)
            {
                pnlAddCustomer.Visible = false;
                pnlDatabase.Visible = true;
                PopulateDataGrid();
            }
            else
            {
                pnlAddCustomer.Visible = true;
                pnlDatabase.Visible = false;
                txtbFirstname_.Text = "";
                txtbSurname_.Text = "";
                txtbEmail_.Text = "";
                txtbAddressOne_.Text = "";
                txtbAddressTwo_.Text = "";
                cmbGender_.Text = "";
                dtPickerDOB_.Text = "";
            }
        }

        private void DataGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtbCustomerID.Text = DataGridCustomers.SelectedRows[0]
                .Cells["clmCustomerID"].Value.ToString();
            txtbFirstname_.Text = DataGridCustomers.SelectedRows[0]
                .Cells["clmForename"].Value.ToString();
            txtbSurname_.Text = DataGridCustomers.SelectedRows[0]
                .Cells["clmSurname"].Value.ToString();
            dtPickerDOB_.Text = DataGridCustomers.SelectedRows[0]
                .Cells["clmDOB"].Value.ToString();
            cmbGender_.Text = DataGridCustomers.SelectedRows[0]
                .Cells["clmGender"].Value.ToString();
            txtbAddressOne_.Text = DataGridCustomers.SelectedRows[0]
                .Cells["clmAddressOne"].Value.ToString();
            txtbAddressTwo_.Text = DataGridCustomers.SelectedRows[0]
                .Cells["clmAddressTwo"].Value.ToString();
            txtbEmail_.Text = DataGridCustomers.SelectedRows[0]
                .Cells["clmEmail"].Value.ToString();

            if (DataGridCustomers.SelectedRows.Count > 0)
            {
                lblCustSelected.Visible = true;
            }
            else
            {
                lblCustSelected.Visible = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!pnlBookingDetails.Visible)
            {
                pnlAddCustomer.Visible = false;
                pnlDatabase.Visible = false;
                pnlBookingDetails.Visible = true;
                btnNext.Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (pnlBookingDetails.Visible)
            {
                btnNext.Visible = true;
                pnlAddCustomer.Visible = true;

                pnlBookingDetails.Visible = false;
                if (ExistingCustomer.Checked)
                {
                    pnlDatabase.Visible = true;
                }
                else
                {
                    pnlDatabase.Visible = false;
                }
            }
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridCustomers.Rows)
            {
                row.Selected = false;
                lblCustSelected.Visible = false;
            }
            txtbCustomerID.Text = "";

        }
    }
}
