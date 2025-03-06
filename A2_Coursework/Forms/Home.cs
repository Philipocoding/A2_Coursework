using A2_Coursework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Coursework
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Year()
        {
            string year = DateTime.Now.Year.ToString();

            List<Booking> Yearbookings = Booking.GetBookingsByYear(year);

            lblYear.Text = Yearbookings.Count.ToString();

            double revenue = 0;
            double profit = 0;
            foreach (Booking booking in Yearbookings)
            {
                revenue = revenue + BookingDAL.GetBookingCost(booking.BookingID, 4);
                profit = profit + BookingDAL.GetBookingProfit(booking.BookingID, 4);
            }
            lblYearRevenue.Text = revenue.ToString();
            lblProfitYear.Text = profit.ToString();
        }
        private void Month()
        {
            int month = DateTime.Now.Month;
            List<Booking> Monthbookings = Booking.GetBookingsByMonth(month);
            lblMonth.Text = Monthbookings.Count.ToString();


            double revenue = 0;
            foreach (Booking booking in Monthbookings)
            {
                revenue = revenue + BookingDAL.GetBookingCost(booking.BookingID, 4);
            }
            lblRevenueMonth.Text = revenue.ToString();

    

            int monthPopular = ReportDAL.GetMonthAnalysis().Item1;
            int leastPopular = ReportDAL.GetMonthAnalysis().Item2;
            lblBusyMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthPopular); 
            lblLeastMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(leastPopular);

        }
        private void Week()
        {
            DateTime WC = Booking.GetPastMonday(DateTime.Now);
            DateTime Weekend = WC.AddDays(6);


            List<Booking> weekBookings = Booking.GetBookingsByWeek(WC, Weekend);

            lblWeek.Text = weekBookings.Count.ToString();

            double revenue = 0;

            foreach (Booking booking in weekBookings)
            {
                revenue = revenue + BookingDAL.GetBookingCost(booking.BookingID, 4);
            }
            lblWeekRevenue.Text = revenue.ToString();


        }
        private void Home_Load(object sender, EventArgs e)
        {
            

            Year();
            Month();
            List<Staff> staff = Staff.populateDataGrid();
            lblStaff.Text = staff.Count.ToString();

            List<Customer> customer = Customer.populateDataGrid();
            lblCustomers.Text = customer.Count.ToString();


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
