using A2_Coursework.Classes;

using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace A2_Coursework
{
    public partial class Report1 : Form
    {
        public Report1()
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
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
                System.Drawing.Font subTitleFont = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
                System.Drawing.Font contentFont = new System.Drawing.Font("Arial", 10);
                System.Drawing.Brush textBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

                float yPosition = 50;
                float xMargin = 50;
                int bookingID = Convert.ToInt32(DataGridBookings.SelectedRows[0].Cells[0].Value);
                double cost = BookingDAL.GetBookingCost(bookingID, 4);
                List<Staff> staffList = BookingDAL.GetStaffForBooking(bookingID);
                List<Service> serviceList = BookingDAL.RetrieveBookingRequestsbyID(bookingID);

                List<int> StockUsed = new List<int>();
                List<int> IDList = new List<int>();

                foreach (Service service in serviceList)
                {
                    IDList.Add(service.ServiceID);
                }

                List<int> stockIDs = BookingDAL.GetStockID(IDList);
                List<int> uniqueStockIDs = stockIDs.Distinct().ToList();
                List<Stock> equipment = new List<Stock>();
                foreach (int id in uniqueStockIDs)
                {
                    if (Stock.StockIds.ContainsKey(id))
                    {
                        equipment.Add(Stock.StockIds[id]);
                    }
                }

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

                e.Graphics.DrawString("Booking ID: " + bookingID, subTitleFont, textBrush, xMargin, yPosition);
                yPosition += 25;
                e.Graphics.DrawString("Total Cost: £" + cost.ToString("F2"), contentFont, textBrush, xMargin, yPosition);
                yPosition += 25;
                e.Graphics.DrawString("Booking Date: " + DataGridBookings.SelectedRows[0].Cells[1].Value.ToString(), contentFont, textBrush, xMargin, yPosition);
                yPosition += 30;

                e.Graphics.DrawLine(linePen, xMargin, yPosition, 750, yPosition);
                yPosition += 20;

                e.Graphics.DrawString("Booking requests and quantity:", subTitleFont, textBrush, xMargin, yPosition);
                yPosition += 25;

                foreach (Service service in serviceList)
                {
                    e.Graphics.DrawString("- " + service.ServiceName + " - " + service.Quantity.ToString(), contentFont, textBrush, xMargin + 20, yPosition);
                    yPosition += 20;
                }

                yPosition += 30;

                e.Graphics.DrawLine(linePen, xMargin, yPosition, 750, yPosition);
                yPosition += 20;

                e.Graphics.DrawString("Assigned Staff:", subTitleFont, textBrush, xMargin, yPosition);
                yPosition += 25;

                foreach (Staff staff in staffList)
                {
                    e.Graphics.DrawString("- " + staff.StaffID + ": " + staff.Firstname + " " + staff.Surname, contentFont, textBrush, xMargin + 20, yPosition);
                    yPosition += 20;
                }

                yPosition += 30;

                e.Graphics.DrawLine(linePen, xMargin, yPosition, 750, yPosition);
                yPosition += 20;

                e.Graphics.DrawString("Equipment Required:", subTitleFont, textBrush, xMargin, yPosition);
                yPosition += 25;

                foreach (Stock stock in equipment)
                {
                    e.Graphics.DrawString("- " + stock.StockName, contentFont, textBrush, xMargin + 20, yPosition);
                    yPosition += 20;
                }

                yPosition += 40;

                e.Graphics.DrawLine(linePen, xMargin, yPosition, 750, yPosition);
                yPosition += 20;

                e.Graphics.DrawString("Thank you for choosing Movers!", subTitleFont, textBrush, xMargin, yPosition);
                yPosition += 40;

                string footerText = "Generated on: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                e.Graphics.DrawString(footerText, contentFont, textBrush, xMargin, yPosition);
                pnlDataGrid.Location = new Point(38, 120);
                pnlDataGrid.SendToBack();

            }
            catch (CustomException ex)
            {
                MessageBox.Show("Select a record with data!");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Select a record with data!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AN error occurred");
            }
            

        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridBookings.SelectedRows[0].Cells[0].Value is null)
                {
                    throw new CustomException("Select a record with data");
                }
                else
                {
                    if (DataGridBookings.SelectedRows.Count != 1)
                    {
                        MessageBox.Show("Select one record to view report!");
                    }
                    else
                    {
                        int bookingID = Convert.ToInt32(DataGridBookings.SelectedRows[0].Cells[0].Value);
                        double cost = BookingDAL.GetBookingCost(bookingID, 4);
                        List<Staff> staffList = BookingDAL.GetStaffForBooking(bookingID);
                        List<Service> serviceList = BookingDAL.RetrieveBookingRequestsbyID(bookingID);
                        CaptureFormShot();

                        printDocument1.PrintPage -= printDocument1_PrintPage; // Prevent duplicate event
                        printDocument1.PrintPage += printDocument1_PrintPage;

                        // Embed the preview inside the form instead of opening a dialog
                        printPreviewControl1.Document = printDocument1;
                        printPreviewControl1.Zoom = 1; // Adjust zoom level

                    }
                }
            }
            catch(CustomException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred");

            }


        }


        void StyleDataGridView()
            {
                foreach (DataGridViewColumn col in DataGridBookings.Columns)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                DataGridBookings.BorderStyle = BorderStyle.Fixed3D;
                DataGridBookings.BackgroundColor = Color.White;
                DataGridBookings.GridColor = Color.LightGray;
                DataGridBookings.EnableHeadersVisualStyles = false;
                DataGridBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                DataGridBookings.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGridBookings.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
                DataGridBookings.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
                DataGridBookings.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                DataGridBookings.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
                DataGridBookings.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11);
                DataGridBookings.DefaultCellStyle.BackColor = Color.White;
                DataGridBookings.DefaultCellStyle.ForeColor = Color.Black;
                DataGridBookings.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                DataGridBookings.DefaultCellStyle.SelectionForeColor = Color.White;
                DataGridBookings.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                DataGridBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                DataGridBookings.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                DataGridBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridBookings.RowHeadersVisible = true;
                DataGridBookings.RowHeadersWidth = 30;


            }
        
        private void PopulateDataGrid()
        {
            DataGridBookings.Rows.Clear();
            List<Booking> allbookings = new();
            allbookings = Booking.populateDataGrid();
            foreach (Booking booking in allbookings)
            {
                DataGridBookings.Rows.Add(booking.BookingID, booking.BookingDate, booking.CustomerID);
            }
        }
        private void PopulateDataGrid(DateTime date)
        {
            string adjustedDate = date.ToString("dd/MM/yyyy");
            DataGridBookings.Rows.Clear();
            List<Booking> allbookings = new();
            allbookings = Booking.GetBookings(adjustedDate);
            foreach (Booking booking in allbookings)
            {
                DataGridBookings.Rows.Add(booking.BookingID, booking.BookingDate, booking.CustomerID);
            }
        }
        private void Report1_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            PopulateDataGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateDataGrid();
        }
    }
}
