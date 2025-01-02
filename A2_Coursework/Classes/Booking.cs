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
        public static Dictionary<int, string> BookingRequests = new Dictionary<int, string>();

        


        public Booking() { }
        public Booking(int bookingID, int customerID, string date)
        {
            BookingID = bookingID;
            CustomerID = customerID;
            BookingDate = date;
        }
        public static void PopulateDictionary()
        {
            BookingRequests[1] = "Windows";
            BookingRequests[2] = "Floors";
            BookingRequests[3] = "Doors";
            BookingRequests[4] = "Dusting";
            BookingRequests[5] = "Bathroom";
            BookingRequests[6] = "Carpets";
            BookingRequests[7] = "Curtains";
            BookingRequests[8] = "Vacuum";

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
        public static List<Booking> GetBookings(int id)
        {
            List<Booking> bookings = new List<Booking>();
            try
            {
                using (SqlConnection connection = new(ProjectDAL.connectionString))
                {
                    connection.Open();
                    SqlCommand getBookings = new();
                    getBookings.Connection = connection;
                    getBookings.CommandType = CommandType.StoredProcedure;
                    getBookings.CommandText = "BookingsByID";
                    getBookings.Parameters.Add(new SqlParameter("@CustomerID", id));

                    using (SqlDataReader reader = getBookings.ExecuteReader())
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
            catch (CustomException ex)
            {

            }
            return bookings;

        }

        public static List<Booking> GetBookings(string date)
        {
            List<Booking> bookings = new List<Booking>();
            try
            {
                using (SqlConnection connection = new(ProjectDAL.connectionString))
                {
                    connection.Open();
                    SqlCommand getBookings = new();
                    getBookings.Connection = connection;
                    getBookings.CommandType = CommandType.StoredProcedure;
                    getBookings.CommandText = "BookingsByDate";
                    getBookings.Parameters.Add(new SqlParameter("@Date", date));

                    using (SqlDataReader reader = getBookings.ExecuteReader())
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
            catch (CustomException ex)
            {

            }
            return bookings;

        }
        public static List<Booking> GetBookings(string date, int id)
        {
            List<Booking> bookings = new List<Booking>();
            try
            {
                using (SqlConnection connection = new(ProjectDAL.connectionString))
                {
                    connection.Open();
                    SqlCommand getBookings = new();
                    getBookings.Connection = connection;
                    getBookings.CommandType = CommandType.StoredProcedure;
                    getBookings.CommandText = "BookingsBy_Date_ID";
                    getBookings.Parameters.Add(new SqlParameter("@Date", date));
                    getBookings.Parameters.Add(new SqlParameter("@CustomerID", id));


                    using (SqlDataReader reader = getBookings.ExecuteReader())
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
            catch (CustomException ex)
            {

            }
            return bookings;

        }
    }
}
