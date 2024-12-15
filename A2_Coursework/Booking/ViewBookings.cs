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
            //BookingTable.Columns[0].HeaderText = "BookingID";
            BookingTable.DataSource = Booking.populateDataGrid("h");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((BookingTable.SelectedRows.Count > 0) && (BookingTable.SelectedRows.Count < 2))
            {
                ProjectDAL.DeleteBooking(Convert.ToInt32(BookingTable.SelectedRows[0].Cells[0].Value));
                BookingTable.DataSource = Booking.populateDataGrid("h");
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
