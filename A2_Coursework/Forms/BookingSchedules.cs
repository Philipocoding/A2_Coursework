using A2_Coursework.Classes;
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
    public partial class BookingSchedules : Form
    {
        List<Booking> bookings = new();
        List<Customer> customers = new();
        public BookingSchedules()
        {
            InitializeComponent();
        }

        private void updateDates()
        {
            lblDateOne.Text = DtPicker.Value.ToString("dd/MM/yyyy");
            lblDateTwo.Text = DtPicker.Value.AddDays(1).ToString("dd/MM/yyyy");
            lblDateThree.Text = DtPicker.Value.AddDays(2).ToString("dd/MM/yyyy");
            lblDateFour.Text = DtPicker.Value.AddDays(3).ToString("dd/MM/yyyy");
            lblDateFive.Text = DtPicker.Value.AddDays(4).ToString("dd/MM/yyyy");

        }
        private void DtPicker_ValueChanged(object sender, EventArgs e)
        {
            updateDates();
            PopulateDataGrid();
        }
        private void PopulateDataGrid()
        {
            getData(DtPicker.Value.AddDays(1).ToString("dd/MM/yyyy"));
            dataGridOne.Rows.Clear();
            List<Booking> allbookings = new();
            allbookings = Booking.populateDataGrid();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGridOne.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
            PopulateDataGridTwo();
            PopulateDataGridThree();
            PopulateDataGridFour();
            PopulateDataGridFive();
        }
        private void PopulateDataGridTwo()
        {
            getData(DtPicker.Value.AddDays(2).ToString("dd/MM/yyyy"));
            dataGrid2.Rows.Clear();
            List<Booking> allbookings = new();
            allbookings = Booking.populateDataGrid();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGrid2.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
        }
        private void PopulateDataGridThree()
        {
            getData(DtPicker.Value.AddDays(3).ToString("dd/MM/yyyy"));
            dataGrid3.Rows.Clear();
            List<Booking> allbookings = new();
            allbookings = Booking.populateDataGrid();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGrid3.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
        }
        private void PopulateDataGridFour()
        {
            getData(DtPicker.Value.AddDays(4).ToString("dd/MM/yyyy"));
            dataGrid4.Rows.Clear();
            List<Booking> allbookings = new();
            allbookings = Booking.populateDataGrid();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGrid4.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
        }
        private void PopulateDataGridFive()
        {
            getData(DtPicker.Value.AddDays(5).ToString("dd/MM/yyyy"));
            dataGrid5.Rows.Clear();
            List<Booking> allbookings = new();
            allbookings = Booking.populateDataGrid();
            for (int i = 0; i < bookings.Count; i++)
            {
                dataGrid5.Rows.Add(bookings[i].BookingID, customers[i].CustomerID, customers[i].Firstname, customers[i].Surname);
            }
        }
        private void BookingSchedules_Load(object sender, EventArgs e)
        {
            updateDates();
            btnWcOne.Text = GetUpcomingMonday(DtPicker.Value);
            btnWCTwo.Text = GetUpcomingMonday(DtPicker.Value.AddDays(7));
            btnWcThree.Text = GetUpcomingMonday(DtPicker.Value.AddDays(14));
            btnWcFour.Text = GetUpcomingMonday(DtPicker.Value.AddDays(21));

            PopulateDataGrid();
            for (int i = 0; i < bookings.Count; i++)
            {

            }
        }
        private string GetUpcomingMonday(DateTime startDate)
        {
            DateTime nextMonday = startDate.AddDays((8 - (int)startDate.DayOfWeek) % 7);
            return nextMonday.ToString("dd/MM/yyyy");
        }


        private void getData(string date)
        {
            var result = ProjectDAL.GetBookingsByDate(date);

            customers = result.customerList;
            bookings = result.bookingList;

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DtPicker.Value.AddDays(1);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DtPicker.Value.AddDays(-1);

        }

        private void btnPostpone_Click(object sender, EventArgs e)
        {
            pnlPostponeDetails.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlPostponeDetails.Visible = false;
           // if (DtPicker.)
                MessageBox.Show("Booking updated");
        }

        private void btnWcOne_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DateTime.Parse(btnWcOne.Text);
        }

        private void btnWCTwo_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DateTime.Parse(btnWCTwo.Text);

        }

        private void btnWcThree_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DateTime.Parse(btnWcThree.Text);

        }

        private void btnWcFour_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DateTime.Parse(btnWcFour.Text);

        }
    }
}
