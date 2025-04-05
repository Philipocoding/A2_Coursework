using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2_Coursework.Classes;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A2_Coursework
{
    public partial class ViewBookings : Form
    {
        int selectedRowIndex = 0;
        List<Service> ServiceID = new();
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            txtbBookingID.ReadOnly = true;
            txtbCustID.ReadOnly = true;
            PopulateDataGrid();
            populateBookingInfo();

        }
        void StyleDataGridView()
        {
            foreach (DataGridViewColumn col in BookingTable.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            BookingTable.BorderStyle = BorderStyle.Fixed3D;
            BookingTable.BackgroundColor = Color.White;
            BookingTable.GridColor = Color.LightGray;
            BookingTable.EnableHeadersVisualStyles = false;
            BookingTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            BookingTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BookingTable.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Set column header background color and text color
            BookingTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            BookingTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            BookingTable.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);

            // Default cell styles
            BookingTable.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            BookingTable.DefaultCellStyle.BackColor = Color.White;
            BookingTable.DefaultCellStyle.ForeColor = Color.Black;
            BookingTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            BookingTable.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternating row colors
            BookingTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
            BookingTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Row headers settings
            BookingTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            BookingTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookingTable.RowHeadersVisible = true;
            BookingTable.RowHeadersWidth = 30;

            // Optional: Apply dynamic styling based on data
            foreach (DataGridViewRow row in BookingTable.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "Completed")
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void PopulateDataGrid()
        {
            BookingTable.Rows.Clear();
            List<Booking> allbookings = new();
            allbookings = Booking.populateDataGrid();
            foreach (Booking booking in allbookings)
            {
                BookingTable.Rows.Add(booking.BookingID, booking.CustomerID, booking.customer.Firstname,
                    booking.customer.Surname, booking.BookingDate);
            }
        }
        private void PopulateDataGrid(Booking booking)
        {
            BookingTable.Rows.Clear();
            BookingTable.Rows.Add(booking.BookingID, booking.CustomerID, booking.customer.Firstname,
                    booking.customer.Surname, booking.BookingDate);
        }

        private void populateBookingInfo()
        {


            listbQuantity.Items.Clear();
            listbServices.Items.Clear();
            cmbServiceDelete.Items.Clear();
            if ((BookingTable.SelectedRows.Count > 0) && (BookingTable.SelectedRows.Count < 2))
            {
                txtbBookingID.Text = BookingTable.SelectedRows[0].Cells[0].Value.ToString();
                txtbCustID.Text = BookingTable.SelectedRows[0].Cells[1].Value.ToString();
                Customer customer = Customer.GetCustomer(Convert.ToInt32(txtbCustID.Text));
                txtbEmail.Text = customer.Email;
                txtbFirstname.Text = customer.Firstname;
                txtbSurname.Text = customer.Surname;

                ServiceID.Clear();
                ServiceID = BookingDAL.RetrieveBookingRequestsbyID(Convert.ToInt32(txtbBookingID.Text));

                List<string> services = new();


                foreach (Service service in ServiceID)
                {
                    listbQuantity.Items.Add(service.Quantity);
                    if (Booking.BookingRequests.ContainsKey(service.ServiceID))
                    {
                        services.Add(Booking.BookingRequests[service.ServiceID]);
                    }
                }
                listbServices.Items.Clear();
                listbServices.Items.AddRange(services.ToArray());
                cmbServiceDelete.Items.AddRange(services.ToArray());

            }
        }
        private void populateBookingInfo(int index)
        {
            BookingTable.CurrentCell = BookingTable.Rows[index].Cells[0];

            listbQuantity.Items.Clear();
            listbServices.Items.Clear();
            if ((BookingTable.SelectedRows.Count > 0) && (BookingTable.SelectedRows.Count < 2))
            {
                txtbBookingID.Text = BookingTable.SelectedRows[0].Cells[0].Value.ToString();
                txtbCustID.Text = BookingTable.SelectedRows[0].Cells[1].Value.ToString();
                Customer customer = Customer.GetCustomer(Convert.ToInt32(txtbCustID.Text));
                txtbEmail.Text = customer.Email;
                txtbFirstname.Text = customer.Firstname;
                txtbSurname.Text = customer.Surname;

                ServiceID.Clear();
                ServiceID = BookingDAL.RetrieveBookingRequestsbyID(Convert.ToInt32(txtbBookingID.Text));

                List<string> services = new();


                foreach (Service service in ServiceID)
                {
                    listbQuantity.Items.Add(service.Quantity);
                    if (Booking.BookingRequests.ContainsKey(service.ServiceID))
                    {
                        services.Add(Booking.BookingRequests[service.ServiceID]);
                    }
                }
                listbServices.Items.Clear();
                listbServices.Items.AddRange(services.ToArray());
            }
        }
        private void BookingTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            populateBookingInfo();
        }

        private void pcbDate_Click(object sender, EventArgs e)
        {
            //pcbDate.Image = Properties.Resource.Tick;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            dtPicker.Value = dtPicker.Value.AddDays(1);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            dtPicker.Value = dtPicker.Value.AddDays(-1);
            pnlFilter.Visible = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                BookingTable.Rows.Clear();
                pnlFilter.Visible = false;
                string date = dtPicker.Value.ToString("dd/MM/yyyy");
                int id = 0;

                if (!string.IsNullOrEmpty(txtbCustomerID.Text))
                {
                    id = Convert.ToInt32(txtbCustomerID.Text);
                }
                List<Booking> Filteredbookings = new();
                if ((!cbDate.Checked) && (!cbIgnoreID.Checked))
                {
                    Filteredbookings = Booking.GetBookings(date, id);
                    foreach (Booking booking in Filteredbookings)
                    {
                        BookingTable.Rows.Add(booking.BookingID, booking.CustomerID, booking.customer.Firstname,
                         booking.customer.Surname, booking.BookingDate);
                    }
                }
                if ((cbDate.Checked) && (cbIgnoreID.Checked))
                {
                    MessageBox.Show("Enter valid filter options");
                }
                if (cbDate.Checked)
                {
                    List<Booking> bookings = Booking.GetBookings(id);
                    foreach (Booking booking in bookings)
                    {
                        BookingTable.Rows.Add(booking.BookingID, booking.CustomerID, booking.customer.Firstname,
                         booking.customer.Surname, booking.BookingDate);
                    }
                }

                if (cbIgnoreID.Checked)
                {
                    Filteredbookings = Booking.GetBookings(date);
                    foreach (Booking booking in Filteredbookings)
                    {
                        BookingTable.Rows.Add(booking.BookingID, booking.CustomerID, booking.customer.Firstname,
                         booking.customer.Surname, booking.BookingDate);
                    }
                }

                date = dtPicker.Value.ToString("dd/MM/yyyy");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invaid data entered!");
                PopulateDataGrid();
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                PopulateDataGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");
                PopulateDataGrid();

            }



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if ((BookingTable.SelectedRows.Count > 0) && (BookingTable.SelectedRows.Count < 2))
            {
                pnlFilter.Visible = false;
                pnlHideAddServices.Visible = false;
                BookingDAL.DeleteBooking(Convert.ToInt32(BookingTable.SelectedRows[0].Cells[0].Value));
                MessageBox.Show("Booking deleted!");
                PopulateDataGrid();
            }
            else
            {
                MessageBox.Show("Select a row!");
            }
        }

        private void listbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listbQuantity.SelectedIndex;
            if (selectedIndex != -1)
            {
                //  txtbService.Visible = true;
                // cmbEditQuantity.Visible = true;
                string selectedValue = listbQuantity.Items[selectedIndex].ToString();

                string value = listbServices.Items[selectedIndex].ToString();
                txtbService.Text = value;

                listbServices.ClearSelected();


            }
            else
            {
                // txtbService.Visible = false;
                // cmbEditQuantity.Visible = false;
            }
        }

        private void listbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listbServices.SelectedIndex;
            if (selectedIndex != -1)
            {
                // txtbService.Visible = true;
                // cmbEditQuantity.Visible = true;
                string selectedValue = listbServices.Items[selectedIndex].ToString();
                txtbService.Text = selectedValue;

                string value = listbQuantity.Items[selectedIndex].ToString();
                cmbEditQuantity.Text = value;

                listbQuantity.ClearSelected();

            }
            else
            {
                // cmbEditQuantity.Visible = false;
                // txtbService.Visible = false;
            }
        }

        private void save()
        {
            int bookingId = 0;
            int quantity = 0;
            int requestNo = 0;
            try
            {
                bookingId = Convert.ToInt32(txtbBookingID.Text);
                quantity = Convert.ToInt32(cmbEditQuantity.Text);
                if (quantity < 1)
                {
                    throw new CustomException("Invalid quantity!");
                }
                requestNo = BookingDAL.GetRequestNo(bookingId,
                Booking.Booking_Requests[txtbService.Text]);
                pnlHideAddServices.Visible = true;
                Booking.editRequest(requestNo, bookingId, Booking.Booking_Requests[txtbService.Text]
                , quantity);
                MessageBox.Show("Request updated!");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("No changes were applied");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            updateCUstomerDetails();
        }
        private void updateCUstomerDetails()
        {
            int bookingId = 0;
            int quantity = 0;
            int requestNo = 0;
            try
            {
                bookingId = Convert.ToInt32(txtbBookingID.Text);
                quantity = Convert.ToInt32(cmbEditQuantity.Text);
                if (quantity < 1)
                {
                    throw new CustomException("Invalid quantity!");
                }
                requestNo = BookingDAL.GetRequestNo(bookingId,
                Booking.Booking_Requests[txtbService.Text]);
                pnlHideAddServices.Visible = true;
                Booking.editRequest(requestNo, bookingId, Booking.Booking_Requests[txtbService.Text]
                , quantity);
                MessageBox.Show("Request updated!");
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("No changes were applied");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            selectedRowIndex = BookingTable.CurrentRow.Index;
            List<string> services = new();
            try
            {
                bool serviceExists = false;

                foreach (Service service in ServiceID)
                {
                    listbQuantity.Items.Add(service.Quantity);
                    if (Booking.BookingRequests.ContainsKey(service.ServiceID))
                    {
                        services.Add(Booking.BookingRequests[service.ServiceID]);
                    }
                }
                //foreach (var key in Booking.Booking_Requests.Keys)
                //{

                if (services.Contains(cmbService.Text))
                {
                    serviceExists = true;
                    //break;
                }

                // }

                if (serviceExists)
                {
                    int index = BookingTable.CurrentRow.Index;

                    populateBookingInfo(index);

                    throw new CustomException("This service already exists in the booking!");
                }
                else
                {
                    int quantity = Convert.ToInt32(cmbQuantity.Text);
                    if ((quantity < 1) || (quantity > 15))
                    {
                        throw new CustomException("Invalid quantity. Quantity must be between 1 and 15");
                    }
                    else
                    {
                        if (Validation.ValidService(cmbService.Text))
                        {
                            BookingDAL.addRequest(Booking.Booking_Requests[cmbService.Text], Convert.ToInt32(txtbBookingID.Text), quantity);
                            BookingTable.CurrentCell = BookingTable.Rows[selectedRowIndex].Cells[0];
                            int index = BookingTable.CurrentRow.Index;
                            PopulateDataGrid();
                            populateBookingInfo(index);

                            pnlHideAddServices.Visible = true;
                            MessageBox.Show("Service added!");

                        }
                        else
                        {
                            MessageBox.Show("Enter a valid Service");
                        }
                    }
                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");
            }


        }

        private void btnOpenFilter_Click(object sender, EventArgs e)
        {
            if (pnlFilter.Visible)
            {
                pnlFilter.Visible = false;
                pnlHideAddServices.Visible = false;

            }
            else
            {
                pnlFilter.Visible = true;
                pnlHideAddServices.Visible = false;


            }
        }

        private void BookingTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((pnlHideAddServices.Visible))
            {
                pnlFilter.Visible = false;
                pnlHideAddServices.Visible = false;

            }
            else
            {
                if ((BookingTable.SelectedRows.Count < 1))
                {
                    MessageBox.Show("Select a row");
                }
                else
                {
                    pnlHideAddServices.Visible = true;
                    pnlFilter.Visible = false;
                }
            }

        }

        private void btnSaveQuantity_Click(object sender, EventArgs e)
        {
            save();
            PopulateDataGrid();
            populateBookingInfo();
        }

        private void txtbService_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnServiceDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbServiceDelete.Items.Contains(cmbServiceDelete.Text))
                {
                    BookingDAL.DeleteBookingService(Convert.ToInt32(txtbBookingID.Text), Booking.Booking_Requests[cmbServiceDelete.Text]);
                    PopulateDataGrid();
                    populateBookingInfo();
                    cmbServiceDelete.Text = "Select a service";
                    MessageBox.Show("Service deleted");
                }
                else
                {
                    throw new CustomException("Select a service that exists in the booking");
                }
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");

            }

        }

        private void txtbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbSearch.Text == "Enter booking ID")
            {
                txtbSearch.Text = "";
            }
        }

        private void txtbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    int id = Convert.ToInt32(txtbSearch.Text);
                    PopulateDataGrid(BookingDAL.GetBooking(id));
                }
                catch (CustomException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred");
                    txtbSearch.Text = "Enter booking ID";

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtbSearch.Text);
                PopulateDataGrid(BookingDAL.GetBooking(id));
            }
            catch (CustomException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred");
                txtbSearch.Text = "Enter booking ID";

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateDataGrid();
            txtbSearch.Text = "Enter booking ID";
        }
    }
}
