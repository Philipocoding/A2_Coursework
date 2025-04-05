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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        int windows = 0;
        int Floors = 0;
        int Doors = 0;
        int Dusting = 0;
        int Bathroom = 0;
        int Carpet = 0;
        int Curtains = 0;
        int Vacuum = 0;
        int KitchenApp = 0;
        int DeepClean = 0;
        int Furniture = 0;

        void StyleDataGridView()
        {
            foreach (DataGridViewColumn col in DataGridCustomers.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridCustomers.BorderStyle = BorderStyle.None;
            DataGridCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 222);
            DataGridCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridCustomers.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            DataGridCustomers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DataGridCustomers.BackgroundColor = Color.FromArgb(11, 57, 102);
            DataGridCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridCustomers.EnableHeadersVisualStyles = false;
            DataGridCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 13);
            DataGridCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 57, 102);
            DataGridCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }



        private void btnRoomVacuum_Click(object sender, EventArgs e)
        {

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
        void StyleDatagridview()
        {
            foreach (DataGridViewColumn col in DataGridCustomers.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            DataGridCustomers.BorderStyle = BorderStyle.Fixed3D;
            DataGridCustomers.BackgroundColor = Color.White;
            DataGridCustomers.GridColor = Color.LightGray;
            DataGridCustomers.EnableHeadersVisualStyles = false;
            DataGridCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            DataGridCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            DataGridCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            DataGridCustomers.DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            DataGridCustomers.DefaultCellStyle.BackColor = Color.White;
            DataGridCustomers.DefaultCellStyle.ForeColor = Color.Black;
            DataGridCustomers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            DataGridCustomers.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            DataGridCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridCustomers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridCustomers.RowHeadersVisible = true;
            DataGridCustomers.RowHeadersWidth = 30;


        }
        private void NewBooking_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            PopulateDataGrid();
            AdjustDataGridViewSize();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool serviceAdded = false;
            dateChecker();
            int id = 0;
            try
            {
                services.Clear();
                quantity.Clear();
                if (windows > 0) { services.Add(1); quantity.Add(Convert.ToInt32(lblQtyOne.Text)); serviceAdded = true; }
                if (Floors > 0) { services.Add(2); quantity.Add(Convert.ToInt32(lblQtyTwo.Text)); serviceAdded = true; }
                if (Doors > 0) { services.Add(3); quantity.Add(Convert.ToInt32(lblQtyThree.Text)); serviceAdded = true; }
                if (Dusting > 0) { services.Add(4); quantity.Add(Convert.ToInt32(lblQtyFour.Text)); serviceAdded = true; }
                if (Bathroom > 0) { services.Add(5); quantity.Add(Convert.ToInt32(lblQtyFive.Text)); serviceAdded = true; }
                if (Carpet > 0) { services.Add(6); quantity.Add(Convert.ToInt32(lblQtySix.Text)); serviceAdded = true; }
                if (Curtains > 0) { services.Add(7); quantity.Add(Convert.ToInt32(lblQtySeven.Text)); serviceAdded = true; }
                if (KitchenApp > 0) { services.Add(2005); quantity.Add(Convert.ToInt32(lblQtySeven.Text)); serviceAdded = true; }
                if (DeepClean > 0) { services.Add(2006); quantity.Add(Convert.ToInt32(lblQtyNine.Text)); serviceAdded = true; }
                if (Furniture > 0) { services.Add(2007); quantity.Add(Convert.ToInt32(lblQtyTen.Text)); serviceAdded = true; }

                string dateString = "";
                if (dtPickerDOB_.Value.AddYears(18) >= DateTime.Now)
                {
                    throw new CustomException("Customer must be 18 years of age or older");
                }
                else
                {
                    dateString =  dtPickerDOB_.Value.ToString("yyyy/MM/dd");
                    if (Validation.ValidGender(cmbGender_.Text))
                    {
                        if ((Validation.isNullorEmpty(txtbFirstname_.Text) && (Validation.isNullorEmpty(txtbFirstname_.Text))
                       && (Validation.isNullorEmpty(txtbEmail_.Text)) && (Validation.isNullorEmpty(txtbAddressTwo_.Text)) && (Validation.isNullorEmpty(txtbAddressOne_.Text)
                       && (Validation.isNullorEmpty(dtPickerDOB_.Text)))))
                        {
                            if (Validation.IsValidEmail(txtbEmail_.Text))
                            {
                                if (serviceAdded)
                                {
                                    if (!lblDateError.Visible)
                                    {
                                        if (!ExistingCustomer.Checked)
                                        {
                                            id = BookingDAL.NewCustomer(txtbFirstname_.Text, txtbSurname_.Text, dateString, cmbGender_.Text.ToLower(),
                                 txtbAddressOne_.Text, txtbAddressTwo_.Text, txtbEmail_.Text);
                                            MessageBox.Show("Customer Added");
                                        }
                                        else
                                        {
                                            id = Convert.ToInt32(txtbCustomerID.Text = DataGridCustomers.SelectedRows[0]
                             .Cells["clmCustomerID"].Value.ToString());
                                        }


                                        string theDate = BookingDate.Value.ToShortDateString();
                                        if (services.Count < 1)
                                        {
                                            throw new CustomException("A booking must contain services!");
                                        }
                                        else
                                        {
                                            if (BookingDAL.NewBooking(id, theDate, services, quantity))
                                            {
                                                MessageBox.Show("Booking confirmed");
                                                pnlDatabase.Visible = false;
                                                pnlAddCustomer.Visible = true;
                                                pnlBookingDetails.Visible = false;
                                                ExistingCustomer.Checked = false;
                                                txtbFirstname_.Text = "";
                                                txtbSurname_.Text= "";
                                                txtbEmail_.Text = "";
                                                txtbCustomerID.Text = "";
                                                txtbAddressTwo_.Text = "";
                                                txtbAddressOne_.Text = "";
                                                dtPickerDOB_.Text = "";
                                                btnNext.Visible = true;
                                                lblCustSelected.Visible = false;
                                                trackBar1.Value = 0; lblQtyOne.Text = "0"; lblQtyTwo.Text = "0";
                                                trackBar2.Value = 0;lblQuantySIX.Text = "0";
                                                trackBar3.Value = 0;lblQtyFour.Text = "0";
                                                trackBar4.Value = 0;lblQtyFive.Text = "0";
                                                trackBar5.Value = 0;lblQtyThree.Text = "0";
                                                trackBar6.Value = 0;lblQtySeven.Text = "0";
                                                trackBar7.Value = 0;
                                                trackBar8.Value = 0;lblQtyEight.Text = "0";
                                                trackBar9.Value = 0;lblQtyNine.Text = "0";
                                                trackBar10.Value = 0;lblQtyTen.Text = "0";


                                            }
                                            else
                                            {
                                                MessageBox.Show("No availability for this date");
                                            }
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid booking date!");
                                    }

                                }
                                else
                                {
                                    throw new CustomException("Select a service!");
                                }
                            }
                            else
                            {
                                throw new CustomException("Not a valid email");
                            }
                           
                        
                        }
                        else
                        {

                            MessageBox.Show("Ensure all fields are completed");
                        }
                    }
                    else
                    {
                        throw new CustomException("Invalid Gender");
                    }
                }
                //else
                //{
                //    MessageBox.Show("Customer details invalid");
                //}
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred!");

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
                pnlCustomerDetails.Visible = true;
                DataGridCustomers.Visible = true;
                // pnlBookingDetails.Visible = false;
                pnlAddCustomer.Visible = false;

            }
            else
            {
                pnlAddCustomer.Visible = true;
                DataGridCustomers.Visible = false;
                // pnlBookingDetails.Visible = true;
                pnlAddCustomer.Visible = true;

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
                //pnlCustomerDetails.Visible = false;
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
                    pnlAddCustomer.Visible = false;

                }
                else
                {
                    pnlDatabase.Visible = false;
                    pnlAddCustomer.Visible = true;

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

        private void trackBar5_Scroll(object sender, EventArgs e)
        {

            Floors = trackBar5.Value;
            lblQtyTwo.Text = trackBar5.Value.ToString();
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            lblQtyFour.Text = trackBar7.Value.ToString();
            Dusting = trackBar7.Value;

        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            KitchenApp = trackBar8.Value;
            lblQtyFive.Text = trackBar8.Value.ToString();

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            Bathroom = trackBar4.Value;
            lblQuantySIX.Text = trackBar4.Value.ToString();

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Carpet = trackBar3.Value;
            lblQtySeven.Text = trackBar3.Value.ToString();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Curtains = trackBar1.Value;
            lblQtyEight.Text = trackBar1.Value.ToString();

        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            Furniture = trackBar9.Value;
            lblQtyNine.Text = trackBar9.Value.ToString();

        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            DeepClean = trackBar10.Value;
            lblQtyTen.Text = trackBar10.Value.ToString();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            lblQtyOne.Text = trackBar2.Value.ToString();
            windows = trackBar2.Value;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            Doors = trackBar6.Value;
            lblQtyThree.Text = trackBar6.Value.ToString();
        }
        private void Visibility()
        {
            InfoOne.Visible = false;
            InfoTwo.Visible = false;
            InfoThree.Visible = false;
            InfoFOur.Visible = false;
            InfoFive.Visible = false;
            InfoSix.Visible = false;
            InfoSeven.Visible = false;
            InfoEight.Visible = false;
            InfoNine.Visible = false;
            InfoTen.Visible = false;
        }
        private void pcbInfoOne_Click(object sender, EventArgs e)
        {
            if (InfoOne.Visible)
            {
                InfoOne.Visible = false;

            }
            else
            {
                Visibility();
                InfoOne.Visible = true;

            }
        }

        private void pcbInfoTwo_Click(object sender, EventArgs e)
        {
            if (InfoTwo.Visible)
            {
                InfoTwo.Visible = false;

            }
            else
            {
                Visibility();

                InfoTwo.Visible = true;

            }
        }

        private void pcbInfoThree_Click(object sender, EventArgs e)
        {
            if (InfoThree.Visible)
            {
                Visibility();
                InfoThree.Visible = false;

            }
            else
            {
                Visibility();

                InfoThree.Visible = true;

            }
        }

        private void pcbInfoFour_Click(object sender, EventArgs e)
        {
            if (InfoFOur.Visible)
            {
                Visibility();
                InfoFOur.Visible = false;

            }
            else
            {
                Visibility();

                InfoFOur.Visible = true;

            }
        }

        private void pcbInfoFive_Click(object sender, EventArgs e)
        {
            if (InfoFive.Visible)
            {
                InfoFive.Visible = false;

            }
            else
            {
                Visibility();

                InfoFive.Visible = true;

            }
        }

        private void pcbInfoSix_Click(object sender, EventArgs e)
        {
            if (InfoSix.Visible)
            {
                InfoSix.Visible = false;

            }
            else
            {
                Visibility();

                InfoSix.Visible = true;

            }
        }

        private void pcbInfoSeven_Click(object sender, EventArgs e)
        {
            if (InfoSeven.Visible)
            {
                InfoSeven.Visible = false;

            }
            else
            {
                Visibility();

                InfoSeven.Visible = true;

            }
        }

        private void pcbInfoEight_Click(object sender, EventArgs e)
        {
            if (InfoEight.Visible)
            {
                InfoEight.Visible = false;

            }
            else
            {
                Visibility();

                InfoEight.Visible = true;

            }
        }

        private void pcbInfoNine_Click(object sender, EventArgs e)
        {
            if (InfoNine.Visible)
            {
                InfoNine.Visible = false;

            }
            else
            {
                Visibility();

                InfoNine.Visible = true;

            }
        }

        private void pcbInfoTen_Click(object sender, EventArgs e)
        {
            if (InfoTen.Visible)
            {
                InfoTen.Visible = false;

            }
            else
            {
                Visibility();

                InfoTen.Visible = true;

            }
        }
    }
}
