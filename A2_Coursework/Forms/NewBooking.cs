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
        bool KitchenApp = false;
        bool DeepClean = false;
        bool Furniture = false;



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

        private void AdjustDataGridViewSize()
        {

            DataGridCustomers.DefaultCellStyle.ForeColor = Color.Black; // Text color
            DataGridCustomers.DefaultCellStyle.Font = new Font("Arial", 15); // Font and size
            int totalHeight = DataGridCustomers.ColumnHeadersHeight;

            // Calculate total height
            foreach (DataGridViewRow row in DataGridCustomers.Rows)
            {
                totalHeight += row.Height;
            }

            int totalWidth = 0;

            // Calculate total width
            foreach (DataGridViewColumn column in DataGridCustomers.Columns)
            {
                totalWidth += column.Width;
            }

            // Optionally add padding for borders
            totalHeight += 2;
            totalWidth += 2;

            // Set the DataGridView size
            DataGridCustomers.Size = new Size(
                Math.Min(totalWidth, this.ClientSize.Width - 20),  // Max width to fit form
                Math.Min(totalHeight, this.ClientSize.Height - 50) // Max height to fit form
            );
        }
        private void StyleDataGrid()
        {
            DataGridCustomers.DefaultCellStyle.ForeColor = Color.Black; // Text color
            DataGridCustomers.DefaultCellStyle.Font = new Font("Arial", 15); // Font and size

        }
        private void NewBooking_Load(object sender, EventArgs e)
        {
            AdjustDataGridViewSize();
            windows = false;
            Floors = false;
            Doors = false;
            Dusting = false;
            Bathroom = false;
            Carpet = false;
            Curtains = false;
            Vacuum = false;
            KitchenApp = false;
            DeepClean = false;
            Furniture = false;



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dateChecker();
            int id = 0;
            try
            {
                services.Clear();
                quantity.Clear();
                if (windows) { services.Add(1); quantity.Add(Convert.ToInt32(NumWindows.Value)); }
                if (Floors) { services.Add(2); quantity.Add(Convert.ToInt32(NumFloors.Value)); }
                if (Doors) { services.Add(3); quantity.Add(Convert.ToInt32(NumDoors.Value)); }
                if (Dusting) { services.Add(4); quantity.Add(Convert.ToInt32(NumDusting.Value)); }
                if (Bathroom) { services.Add(5); quantity.Add(Convert.ToInt32(NumBathroom.Value)); }
                if (Carpet) { services.Add(6); quantity.Add(Convert.ToInt32(NumCarpets.Value)); }
                if (Curtains) { services.Add(7); quantity.Add(Convert.ToInt32(NumCurtains.Value)); }
                if (Vacuum) { services.Add(8); quantity.Add(Convert.ToInt32(NumFurniture.Value)); }
                if (KitchenApp) { services.Add(2005); quantity.Add(Convert.ToInt32(NumKitchenApp.Value)); }
                if (DeepClean) { services.Add(2006); quantity.Add(Convert.ToInt32(numUpDownDeepclean.Value)); }
                if (Furniture) { services.Add(2007); quantity.Add(Convert.ToInt32(NumFurniture.Value)); }

                string dateString = dtPickerDOB_.Value.ToString("yyyy-MM-dd");
                if (Validation.ValidGender(cmbGender_.Text))
                {
                    if ((Validation.isNullorEmpty(txtbFirstname_.Text) && (Validation.isNullorEmpty(txtbFirstname_.Text))
                   && (Validation.isNullorEmpty(txtbEmail_.Text)) && (Validation.isNullorEmpty(txtbAddressTwo_.Text)) && (Validation.isNullorEmpty(txtbAddressOne_.Text)
                   && (Validation.isNullorEmpty(dtPickerDOB_.Text)))))
                    {
                        if (!lblDateError.Visible)
                        {
                            if (!ExistingCustomer.Checked)
                            {
                                id = BookingDAL.NewCustomer(txtbFirstname_.Text, txtbSurname_.Text, dateString, cmbGender_.Text,
                     txtbAddressOne_.Text, txtbAddressTwo_.Text, txtbEmail_.Text);
                                MessageBox.Show("Customer Added");
                            }
                            else
                            {
                                id = Convert.ToInt32(txtbCustomerID.Text = DataGridCustomers.SelectedRows[0]
                 .Cells["clmCustomerID"].Value.ToString());
                            }


                            string theDate = BookingDate.Value.ToShortDateString();
                            if (BookingDAL.NewBooking(id, theDate, services, quantity))
                            {
                                MessageBox.Show("Booking confirmed");

                            }
                            else
                            {
                                MessageBox.Show("No availability for this date");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid booking date!");
                        }
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
                PopulateDataGrid();
                pnlDatabase.Visible = true;
                pnlAddCustomer.Visible = false;

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
                btnUnselect.Visible = true;

            }
            else
            {
                lblCustSelected.Visible = false;
                btnUnselect.Visible = false;

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

        private void dateChecker()
        {
            DateTime bookingDate = BookingDate.Value;
            DateTime minimumDate = DateTime.Now.AddDays(13);

            if (bookingDate < minimumDate)
            {
                lblDateError.Visible = true;
            }
            else
            {
                lblDateError.Visible = false;

            }
        }
        private void dtPickerDOB__ValueChanged(object sender, EventArgs e)
        {

        }

        private void BookingDate_ValueChanged(object sender, EventArgs e)
        {
            dateChecker();
        }

        private void btnViewPrice_Click(object sender, EventArgs e)
        {
            if (pnlPrices.Visible)
            {
                pnlPrices.Visible = false;

            }

            else
            {
                pnlPrices.Visible = true;
            }
        }

        private void btnKitchenApp_Click(object sender, EventArgs e)
        {
            if (btnKitchenApp.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnKitchenApp.Font = new Font(btnKitchenApp.Font.FontFamily, btnKitchenApp.Font.Size, FontStyle.Regular);
                KitchenApp = false;
            }
            else
            {
                btnKitchenApp.Font = new Font(btnKitchenApp.Font, FontStyle.Bold);
                KitchenApp = true;
            }
        }

        private void btndeepClean_Click(object sender, EventArgs e)
        {
            if (btndeepClean.Font.Style.HasFlag(FontStyle.Bold))
            {
                btndeepClean.Font = new Font(btndeepClean.Font.FontFamily, btndeepClean.Font.Size, FontStyle.Regular);
                DeepClean = false;
            }
            else
            {
                btndeepClean.Font = new Font(btndeepClean.Font, FontStyle.Bold);
                DeepClean = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnFurniture.Font.Style.HasFlag(FontStyle.Bold))
            {
                btnFurniture.Font = new Font(btnFurniture.Font.FontFamily, btnFurniture.Font.Size, FontStyle.Regular);
                Furniture = false;
            }
            else
            {
                btnFurniture.Font = new Font(btnFurniture.Font, FontStyle.Bold);
                Furniture = true;
            }
        }
    }
}
