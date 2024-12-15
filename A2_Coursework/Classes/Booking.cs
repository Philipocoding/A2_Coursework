using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Coursework.Classes
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public string Date { get; set; }

        public Booking() { }
        public Booking(int bookingID, int customerID, string date)
        {
            BookingID = bookingID;
            CustomerID = customerID;
            Date = date;
        }
        public static DataTable populateDataGrid(string query)
        {
            query = "SELECT * FROM Booking";
            DataTable datatable = new();

            try
            {
                using (SqlConnection connection = new SqlConnection(ProjectDAL.connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return datatable;

        }

    }
}
