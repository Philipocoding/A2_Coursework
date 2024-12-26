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
        public string BookingDate { get; set; }

        public Booking() { }
        public Booking(int bookingID, int customerID, string date)
        {
            BookingID = bookingID;
            CustomerID = customerID;
            BookingDate = date;
        }
        public static List<Booking> populateDataGrid()
        {
            List<Booking> bookings = new List<Booking>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ProjectDAL.connectionString))
                {
                    connection.Open();

                    SqlCommand GetBookings = new SqlCommand();

                    GetBookings.Connection = connection;
                    GetBookings.CommandType = System.Data.CommandType.StoredProcedure;
                    GetBookings.CommandText = "RetrieveBookings";

                    using (SqlDataReader reader = GetBookings.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booking booking = new Booking();

                            booking.BookingID = Convert.ToInt32(reader["BookingID"]);
                            booking.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            booking.BookingDate = reader["BookingDate"].ToString();
                            bookings.Add(booking);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return bookings;
        }
    }
}
