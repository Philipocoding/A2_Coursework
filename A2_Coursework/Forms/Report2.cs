using A2_Coursework.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Coursework
{
    public partial class Report2 : Form
    {
        public Report2()
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
        void StyleDataGridView()
        {
            foreach (DataGridViewColumn col in DataGridCustomers.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            DataGridCustomers.BorderStyle = BorderStyle.Fixed3D;
            DataGridCustomers.BackgroundColor = Color.White;
            DataGridCustomers.GridColor = Color.LightGray;
            DataGridCustomers.EnableHeadersVisualStyles = false;
            DataGridCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            DataGridCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            DataGridCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridCustomers.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 4, 6, 4);
            DataGridCustomers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11);
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

        private void PopulateDataGrid()
        {
            DataGridCustomers.Rows.Clear();
            List<Customer> customerList = Customer.populateDataGrid();
            foreach (Customer customer in customerList)
            {
                DataGridCustomers.Rows.Add(customer.CustomerID, customer.Firstname, customer.Surname);
            }
        }
        private void Report2_Load(object sender, EventArgs e)
        {
            PopulateDataGrid();
            StyleDataGridView();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridCustomers.SelectedRows[0].Cells[0].Value is null)
                {
                    throw new CustomException("Select a record with data");
                }
                else
                {
                    if (DataGridCustomers.SelectedRows.Count != 1)
                    {
                        MessageBox.Show("Select one record to view report!");
                    }
                    else
                    {
                        int customerID = Convert.ToInt32(DataGridCustomers.SelectedRows[0].Cells[0].Value);
                        List<Booking> bookings = ReportDAL.GetCustomerAnalysis(customerID).Item2;
                        Customer customer = ReportDAL.GetCustomerAnalysis(customerID).Item1;

                        if (bookings.Count == 0)
                        {
                            MessageBox.Show("This customer currently has no bookings");
                        }
                        else
                        {
                            CaptureFormShot();

                            printDocument1.PrintPage -= printDocument1_PrintPage;
                            printDocument1.PrintPage += printDocument1_PrintPage;

                            printPreviewControl1.Document = printDocument1;
                            printPreviewControl1.Zoom = 1;
                        }

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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define fonts for better hierarchy
            System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 18, System.Drawing.FontStyle.Bold);
            System.Drawing.Font subTitleFont = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            System.Drawing.Font contentFont = new System.Drawing.Font("Arial", 11);
            System.Drawing.Font tableHeaderFont = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            System.Drawing.Brush textBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            float yPosition = 50;
            float xMargin = 50;
            int customerID = Convert.ToInt32(DataGridCustomers.SelectedRows[0].Cells[0].Value);
            List<Booking> bookings = ReportDAL.GetCustomerAnalysis(customerID).Item2;
            Customer customer = ReportDAL.GetCustomerAnalysis(customerID).Item1;
            List<Service> services = ReportDAL.GetCustomerAnalysis(customerID).Item3;

            
            System.Drawing.Image logo = Properties.Resources.LogoTransparent__1_;
            if (logo != null)
            {
                e.Graphics.DrawImage(logo, xMargin, yPosition, 120, 80);
                yPosition += 100;
            }
            // Draw Title
            e.Graphics.DrawString("Customer Details", titleFont, textBrush, xMargin, yPosition);
            yPosition += 40;

            // Customer Info
            e.Graphics.DrawString($"Customer ID: {customer.CustomerID}", contentFont, textBrush, xMargin, yPosition);
            yPosition += 25;
            e.Graphics.DrawString($"First Name: {customer.Firstname}", contentFont, textBrush, xMargin, yPosition);
            yPosition += 25;
            e.Graphics.DrawString($"Surname: {customer.Surname}", contentFont, textBrush, xMargin, yPosition);
            yPosition += 25;
            e.Graphics.DrawString($"Email: {customer.Email}", contentFont, textBrush, xMargin, yPosition);
            yPosition += 25;
            e.Graphics.DrawString($"Address: {customer.AddressOne} {customer.AddressTwo}", contentFont, textBrush, xMargin, yPosition);
            yPosition += 30;

            Pen linePen = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(linePen, xMargin, yPosition, 750, yPosition);
            yPosition += 30;

            e.Graphics.DrawString("Bookings", titleFont, textBrush, xMargin, yPosition);
            yPosition += 35;

            foreach (Booking booking in bookings)
            {
                yPosition += 10;

                e.Graphics.DrawString("Booking Details", subTitleFont, textBrush, xMargin, yPosition);
                yPosition += 30;

                e.Graphics.DrawString($"Booking ID: {booking.BookingID}", contentFont, textBrush, xMargin, yPosition);
                yPosition += 25;
                e.Graphics.DrawString($"Booking Date: {booking.BookingDate}", contentFont, textBrush, xMargin, yPosition);
                yPosition += 30;

                yPosition += 25;

                float xService = xMargin;
                float xQuantity = xService + 250; 
                float rowHeight = 25;

                e.Graphics.DrawString("Service", tableHeaderFont, textBrush, xService, yPosition);
                e.Graphics.DrawString("Quantity", tableHeaderFont, textBrush, xQuantity, yPosition);
                yPosition += rowHeight;

                e.Graphics.DrawLine(linePen, xService, yPosition, xQuantity + 100, yPosition);
                yPosition += rowHeight;

                // Table Data
                foreach (Service service in services)
                {
                    e.Graphics.DrawString(service.ServiceName, contentFont, textBrush, xService, yPosition);
                    e.Graphics.DrawString(service.Quantity.ToString(), contentFont, textBrush, xQuantity, yPosition);
                    yPosition += rowHeight;
                }

                // **Draw a separator line between different bookings**
                yPosition += 20;
                e.Graphics.DrawLine(linePen, xMargin, yPosition, 750, yPosition);
                yPosition += 30;
            }

            e.Graphics.DrawString("Thank you for choosing Movers!", subTitleFont, textBrush, xMargin, yPosition);
            yPosition += 30;

            string footerText = "Generated on: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            e.Graphics.DrawString(footerText, contentFont, textBrush, xMargin, yPosition);

            pnlDataGrid.Location = new Point(63, 106);
            pnlDataGrid.SendToBack();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}