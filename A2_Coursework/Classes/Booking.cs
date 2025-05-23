﻿using System;
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
        public Customer customer = new();
        public static Dictionary<int, string> BookingRequests = new Dictionary<int, string>();
        public static Dictionary<string, int> Booking_Requests = new Dictionary<string, int>();
        static List<Booking> bookings = new();


        public Booking() { }
        public Booking(int bookingID, int customerID, string date)
        {
            BookingID = bookingID;
            CustomerID = customerID;
            BookingDate = date;
        }
        public static string GetUpcomingMonday(DateTime startDate)
        {
            DateTime nextMonday = startDate.AddDays((8 - (int)startDate.DayOfWeek) % 7);
            return nextMonday.ToString("dd/MM/yyyy");
        }
        public static DateTime GetPastMonday(DateTime startDate)
        {
            return startDate.AddDays((1 - (int)startDate.DayOfWeek) % 7);
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
            BookingRequests[2005] = "Kitchen Appliances";
            BookingRequests[2006] = "Deep Clean";
            BookingRequests[2007] = "Furniture";


        }
        public static void Populate_Dictionary()
        {
            Booking_Requests["Windows"] = 1;
            Booking_Requests["Floors"] = 2;
            Booking_Requests["Doors"] = 3;
            Booking_Requests["Dusting"] = 4;
            Booking_Requests["Bathroom"] = 5;
            Booking_Requests["Carpets"] = 6;
            Booking_Requests["Curtains"] = 7;
            Booking_Requests["Vacuum"] = 8;
            Booking_Requests["Kitchen Appliances"] = 2005;
            Booking_Requests["Deep Clean"] = 2006;
            Booking_Requests["Furniture"] = 2007;


        }
        public static int getTeamNo()
        {
            int num = bookings.Count;
            if((num == 1)||(num  == 4))
            {
                return 1;
            }
            if ((num == 2) || (num == 5))
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        public static bool CheckAvailability(string date)
        {
            var result = BookingDAL.GetBookingsByDate(date);
            bookings = result.bookingList;
            if (bookings.Count < 6)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void editRequest(int requestno,int bookingid, int serviceid, int quantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ReportDAL.connectionString))
                {
                    connection.Open();

                    SqlCommand editRequest = new SqlCommand();

                    editRequest.Connection = connection;
                    editRequest.CommandType = System.Data.CommandType.StoredProcedure;
                    editRequest.CommandText = "EditRequests";
                    editRequest.Parameters.Add(new SqlParameter("@RequestNo", requestno));
                    editRequest.Parameters.Add(new SqlParameter("@ServiceID", serviceid));
                    editRequest.Parameters.Add(new SqlParameter("@BookingID", bookingid));
                    editRequest.Parameters.Add(new SqlParameter("@Quantity", quantity));
                    editRequest.ExecuteNonQuery();
                }
            }
            catch (CustomException ex)
            {

            }
        }
        public static List<Booking> populateDataGrid()
        {
            List<Booking> bookings = new List<Booking>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ReportDAL.connectionString))
                {
                    connection.Open();

                    SqlCommand GetBookings = new SqlCommand();

                    GetBookings.Connection = connection;
                    GetBookings.CommandType = System.Data.CommandType.StoredProcedure;
                    GetBookings.CommandText = "GetBookingANDCustomer";

                    using (SqlDataReader reader = GetBookings.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booking booking = new Booking();

                            booking.BookingID = Convert.ToInt32(reader["BookingID"]);
                            booking.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            booking.BookingDate = reader["BookingDate"].ToString();
                            booking.customer.Firstname = reader["Forename"].ToString();
                            booking.customer.Surname = reader["Surname"].ToString();

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
                using (SqlConnection connection = new(ReportDAL.connectionString))
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
                            booking.customer.Firstname = reader["Forename"].ToString();
                            booking.customer.Surname = reader["Surname"].ToString();

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
                using (SqlConnection connection = new(ReportDAL.connectionString))
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
                            booking.customer.Firstname = reader["Forename"].ToString();
                            booking.customer.Surname = reader["Surname"].ToString();
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
                using (SqlConnection connection = new(ReportDAL.connectionString))
                {
                    connection.Open();
                    SqlCommand getBookings = new();
                    getBookings.Connection = connection;
                    getBookings.CommandType = CommandType.StoredProcedure;
                    getBookings.CommandText = "BookingsBy_Date_ID";
                    getBookings.Parameters.Add(new SqlParameter("@BookingDate", date));
                    getBookings.Parameters.Add(new SqlParameter("@CustomerID", id));


                    using (SqlDataReader reader = getBookings.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booking booking = new Booking();

                            booking.BookingID = Convert.ToInt32(reader["BookingID"]);
                            booking.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            booking.BookingDate = reader["BookingDate"].ToString();
                            booking.customer.Firstname = reader["Forename"].ToString();
                            booking.customer.Surname = reader["Surname"].ToString();

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

        public static List<Booking> GetBookingsByYear(string year)
        {
            List<Booking> bookings = new List<Booking>();
            try
            {
                using (SqlConnection connection = new(ReportDAL.connectionString))
                {
                    connection.Open();
                    SqlCommand getBookings = new();
                    getBookings.Connection = connection;
                    getBookings.CommandType = CommandType.StoredProcedure;
                    getBookings.CommandText = "BookingsByYear";
                    getBookings.Parameters.Add(new SqlParameter("@Year", year));


                    using (SqlDataReader reader = getBookings.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booking booking = new Booking();

                            booking.BookingID = Convert.ToInt32(reader["BookingID"]);
                            booking.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            booking.BookingDate = reader["BookingDate"].ToString();
                            booking.customer.Firstname = reader["Forename"].ToString();
                            booking.customer.Surname = reader["Surname"].ToString();

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
        public static List<Booking> GetBookingsByMonth(int month)
        {
            List<Booking> bookings = new List<Booking>();
            try
            {
                using (SqlConnection connection = new(ReportDAL.connectionString))
                {
                    connection.Open();
                    SqlCommand getBookings = new();
                    getBookings.Connection = connection;
                    getBookings.CommandType = CommandType.StoredProcedure;
                    getBookings.CommandText = "BookingsByMonth";
                    getBookings.Parameters.Add(new SqlParameter("@Month", month));


                    using (SqlDataReader reader = getBookings.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booking booking = new Booking();

                            booking.BookingID = Convert.ToInt32(reader["BookingID"]);
                            booking.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            booking.BookingDate = reader["BookingDate"].ToString();
                            booking.customer.Firstname = reader["Forename"].ToString();
                            booking.customer.Surname = reader["Surname"].ToString();

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

        public static List<Booking> GetBookingsByWeek(DateTime wc, DateTime weekend)
        {
            List<Booking> bookings = new List<Booking>();
            try
            {
                using (SqlConnection connection = new(ReportDAL.connectionString))
                {
                    connection.Open();
                    SqlCommand getBookings = new();
                    getBookings.Connection = connection;
                    getBookings.CommandType = CommandType.StoredProcedure;
                    getBookings.CommandText = "BookingsByWeek";
                    getBookings.Parameters.Add(new SqlParameter("@WC", wc.ToString("dd/MM/yyyy")));
                    getBookings.Parameters.Add(new SqlParameter("@Weekend", weekend.ToString("dd/MM/yyyy")));



                    using (SqlDataReader reader = getBookings.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booking booking = new Booking();

                            booking.BookingID = Convert.ToInt32(reader["BookingID"]);
                            booking.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            booking.BookingDate = reader["BookingDate"].ToString();
                            booking.customer.Firstname = reader["Forename"].ToString();
                            booking.customer.Surname = reader["Surname"].ToString();

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
