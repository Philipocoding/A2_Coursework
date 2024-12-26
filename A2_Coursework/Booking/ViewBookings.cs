using System;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((BookingTable.SelectedRows.Count > 0) && (BookingTable.SelectedRows.Count < 2))
            {
                ProjectDAL.DeleteBooking(Convert.ToInt32(BookingTable.SelectedRows[0].Cells[0].Value));
                PopulateDataGrid();
            }
        }

        private void BookingTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((BookingTable.SelectedRows.Count > 0)&& (BookingTable.SelectedRows.Count < 2)){

                txtbID.Text = BookingTable.SelectedRows[0].Cells[0].Value.ToString();
            }
        }
    }
}
