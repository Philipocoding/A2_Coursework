using A2_Coursework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Coursework.Properties
{
    public partial class ScheduleReport : Form
    {
        List<Booking> bookings = new();
        List<Customer> customers = new();
        bool CustomDay = false;
        public ScheduleReport()
        {
            InitializeComponent();
        }
        Bitmap BitmaptoPrint;
        private void CaptureFormShot()
        {
            BitmaptoPrint = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(BitmaptoPrint, new Rectangle(0, 0, this.Width, this.Height));

            // Draw additional elements directly onto the bitmap
            using (Graphics g = Graphics.FromImage(BitmaptoPrint))
            {
                g.DrawLine(new Pen(Color.Green, 2), new Point(10, 10), new Point(200, 10));
            }
        }
        
        private void getData(string date)
        {
            var result = BookingDAL.GetBookingsByDate(date);

            customers = result.customerList;
            bookings = result.bookingList;

        }
        private void DayOne()
        {
            getData(DtPicker.Value.ToString("dd/MM/yyyy"));
        }
        private void DayTwo()
        {
            getData(DtPicker.Value.AddDays(1).ToString("dd/MM/yyyy"));
        }
        private void DayThree()
        {
            getData(DtPicker.Value.AddDays(2).ToString("dd/MM/yyyy"));
        }
        private void DayFour()
        {
            getData(DtPicker.Value.AddDays(3).ToString("dd/MM/yyyy"));
        }
        private void DayFive()
        {
            getData(DtPicker.Value.AddDays(4).ToString("dd/MM/yyyy"));
        }
        private void btnWCTwo_Click(object sender, EventArgs e)
        {
            CustomDay = false;
            pnlHide.Visible = false;

            DtPicker.Text = btnWCTwo.Text;
            CallPrint();

        }

        private void btnWcThree_Click(object sender, EventArgs e)
        {
            pnlHide.Visible = false;

            CustomDay = false;
            DtPicker.Text = btnWcThree.Text;
            CallPrint();

        }

        private void btnWcFour_Click(object sender, EventArgs e)
        {
            pnlHide.Visible = false;

            CustomDay = false;
            DtPicker.Text = btnWcFour.Text;
            CallPrint();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            pnlHide.Visible = false;

            CallPrint();
            CustomDay = true;
        }
        private void CallPrint()
        {
            printDocument1.PrintPage -= printDocument1_PrintPage;
            printDocument1.PrintPage += printDocument1_PrintPage;

            printPreviewControl1.Document = printDocument1;
            printPreviewControl1.Zoom = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            System.Drawing.Font subTitleFont = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            System.Drawing.Font contentFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.Brush textBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            float yPosition = 50;
            float xMargin = 50;

            System.Drawing.Image logo = Properties.Resources.LogoTransparent__1_;
            if (logo != null)
            {
                e.Graphics.DrawImage(logo, xMargin, yPosition, 120, 80);
                yPosition += 100;
            }
            e.Graphics.DrawString("Booking Report", titleFont, textBrush, xMargin + 20, yPosition);
            yPosition += 40;

            Pen linePen = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(linePen, xMargin, yPosition, 750, yPosition);
            yPosition += 20;

            e.Graphics.DrawString("Booking ID", headerFont, textBrush, xMargin + 20, yPosition);
            e.Graphics.DrawString("Date", headerFont, textBrush, xMargin + 120, yPosition);
            e.Graphics.DrawString("Customer ID", headerFont, textBrush, xMargin + 250, yPosition);
            e.Graphics.DrawString("First Name", headerFont, textBrush, xMargin + 350, yPosition);
            e.Graphics.DrawString("Surname", headerFont, textBrush, xMargin + 470, yPosition);

            yPosition += 25; // Move to the next row after the headers


            e.Graphics.DrawLine(linePen, xMargin, yPosition, 750, yPosition);
            yPosition += 15;

            void PrintBookings()
            {
                for (int i = 0; i < bookings.Count; i++)
                {
                    e.Graphics.DrawString(bookings[i].BookingID.ToString(), contentFont, textBrush, xMargin + 20, yPosition);
                    e.Graphics.DrawString(bookings[i].BookingDate.ToString(), contentFont, textBrush, xMargin + 120, yPosition);
                    e.Graphics.DrawString(customers[i].CustomerID.ToString(), contentFont, textBrush, xMargin + 250, yPosition);
                    e.Graphics.DrawString(customers[i].Firstname, contentFont, textBrush, xMargin + 350, yPosition);
                    e.Graphics.DrawString(customers[i].Surname, contentFont, textBrush, xMargin + 470, yPosition);

                    yPosition += 20; // Move to the next row
                }
               
            }


            // Call methods for each day and print bookings
            DayOne();
            PrintBookings();
            // Print bookings for remaining days
            if (!CustomDay)
            {
                DayTwo(); PrintBookings();
                DayThree(); PrintBookings();
                DayFour(); PrintBookings();
                DayFive(); PrintBookings();
            }


            yPosition += 10;

            // Draw closing line
            e.Graphics.DrawLine(linePen, xMargin, yPosition, 750, yPosition);
            yPosition += 10;

            // Print closing message
            e.Graphics.DrawString("Thank you for choosing Movers!", subTitleFont, textBrush, xMargin, yPosition);
            yPosition += 40;

            // Print footer
            string footerText = $"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm}";
            e.Graphics.DrawString(footerText, contentFont, textBrush, xMargin, yPosition);



        }

        private void ScheduleReport_Load(object sender, EventArgs e)
        {
            CustomDay = false;
            btnWcOne.Text = Booking.GetUpcomingMonday(DtPicker.Value);
            btnWCTwo.Text = Booking.GetUpcomingMonday(DtPicker.Value.AddDays(7));
            btnWcThree.Text = Booking.GetUpcomingMonday(DtPicker.Value.AddDays(14));
            btnWcFour.Text = Booking.GetUpcomingMonday(DtPicker.Value.AddDays(21));
            printPreviewControl1.MouseWheel += printPreviewControl1_MouseWheel;

        }

        private void printPreviewControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                // Scroll Up (Previous Page)
                if (printPreviewControl1.StartPage > 0)
                    printPreviewControl1.StartPage--;
            }
            else
            {
                // Scroll Down (Next Page)
                printPreviewControl1.StartPage++;
            }
        }



        private void btnWcOne_Click(object sender, EventArgs e)
        {
            pnlHide.Visible = false;
            CustomDay = false;
            DtPicker.Text = btnWcOne.Text;
            CallPrint();

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DtPicker.Value.AddDays(-1);


        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            DtPicker.Value = DtPicker.Value.AddDays(1);
        }

    }
}
