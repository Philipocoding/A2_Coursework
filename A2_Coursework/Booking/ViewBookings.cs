using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        public ViewBookings()
        {
            InitializeComponent();
        }

        private void ViewBookings_Load(object sender, EventArgs e)
        {
            txtbBookingID.ReadOnly = true;
            txtbCustID.ReadOnly = true;
            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            BookingTable.Rows.Clear();
            List<Booking> allbookings = new();
            allbookings = Booking.populateDataGrid();
            foreach (Booking booking in allbookings)
            {
                BookingTable.Rows.Add(booking.BookingID, booking.CustomerID, booking.BookingDate);
            }
        }


        private void BookingTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((BookingTable.SelectedRows.Count > 0) && (BookingTable.SelectedRows.Count < 2))
            {
                txtbBookingID.Text = BookingTable.SelectedRows[0].Cells[0].Value.ToString();
                txtbCustID.Text = BookingTable.SelectedRows[0].Cells[1].Value.ToString();
                txtbID.Text = BookingTable.SelectedRows[0].Cells[0].Value.ToString();
                Customer customer = Customer.GetCustomer(Convert.ToInt32(txtbCustID.Text));
                txtbEmail.Text = customer.Email;
                txtbFirstname.Text = customer.Firstname;
                txtbSurname.Text = customer.Surname;


                var result = ProjectDAL.RetrieveBookingRequestsbyID(Convert.ToInt32(txtbBookingID.Text));

                List<int> ServiceID = result.ServiceID;
                List<int> Quantity = result.Quantity;
                List<string> services = new();


                foreach (int id in ServiceID)
                {
                    if (Booking.BookingRequests.ContainsKey(id))
                    {
                        services.Add(Booking.BookingRequests[id]);
                    }
                }
                listbServices.Items.Clear();
                listbServices.Items.AddRange(services.ToArray());
                listbQuantity.Items.Clear();
                foreach (var quantity in Quantity)
                {
                    listbQuantity.Items.Add(quantity);
                }

            }
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
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            BookingTable.Rows.Clear();
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
                    BookingTable.Rows.Add(booking.BookingID, booking.CustomerID, booking.BookingDate);
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
                    BookingTable.Rows.Add(booking.BookingID, booking.CustomerID, booking.BookingDate);
                }
            }

            if (cbIgnoreID.Checked)
            {
                Filteredbookings = Booking.GetBookings(date);
                foreach (Booking booking in Filteredbookings)
                {
                    BookingTable.Rows.Add(booking.BookingID, booking.CustomerID, booking.BookingDate);
                }
            }

            date = dtPicker.Value.ToString("dd/MM/yyyy");


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if ((BookingTable.SelectedRows.Count > 0) && (BookingTable.SelectedRows.Count < 2))
            {
                ProjectDAL.DeleteBooking(Convert.ToInt32(BookingTable.SelectedRows[0].Cells[0].Value));
                PopulateDataGrid();
            }
        }

        private void listbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listbQuantity.SelectedIndex;
            if (selectedIndex != -1)
            {
                string selectedValue = listbQuantity.Items[selectedIndex].ToString();
                //cmbEditQuantity.Text = selectedValue;

                string value = listbServices.Items[selectedIndex].ToString();
                txtbService.Text = value;

                listbServices.ClearSelected();
                //listbServices.SetSelected(selectedIndex, true);


            }
        }

        private void listbServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listbServices.SelectedIndex;
            if (selectedIndex != -1)
            {
                string selectedValue = listbServices.Items[selectedIndex].ToString();
                txtbService.Text = selectedValue;

                string value = listbQuantity.Items[selectedIndex].ToString();
                cmbEditQuantity.Text = value;

                listbQuantity.ClearSelected();
               //listbQuantity.SetSelected(selectedIndex, true);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int bookingId = 0;
            int quantity = 0; 
            int requestNo = 0;
            try
            {
                bookingId = Convert.ToInt32(txtbBookingID.Text);
                quantity = Convert.ToInt32(Convert.ToInt32(cmbEditQuantity.Text));
                requestNo = ProjectDAL.GetRequestNo(bookingId,
                Booking.Booking_Requests[txtbService.Text]);
            }
            catch(CustomException ex)
            {
                MessageBox.Show("Invalid details entered");
            }
            


            Booking.editRequest(requestNo, bookingId, Booking.Booking_Requests[txtbService.Text]
                , quantity);
            MessageBox.Show("Request updated!");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var key in Booking.Booking_Requests.Keys)
            {
                if(key.ToLower() == cmbService.Text.ToLower())
                {
                    if(Validation.ValidService(cmbService.Text))
                    {
                        ProjectDAL.addRequest(Booking.Booking_Requests[key], Convert.ToInt32(txtbBookingID.Text),
                       Convert.ToInt32(cmbQuantity.Text));
                        PopulateDataGrid();
                        MessageBox.Show("Service added!");
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid Service");
                    }
                   
                }
            }

        }
    }
}
