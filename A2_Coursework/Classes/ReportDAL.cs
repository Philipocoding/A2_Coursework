using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A2_Coursework.Classes
{
    internal class ReportDAL
    {
        //        Data to Include:

        //Customer name/ID.

        //Number of bookings per customer.

        //Total spending per customer.

        //Frequency of bookings (e.g., weekly, monthly).
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Philip\\Desktop\\A2_Coursework\\A2_Coursework\\Database.mdf;Integrated Security=True";
        public static (Customer,List<Booking>, List<Service>) GetCustomerAnalysis(int CustomerID)
        {
            List<Booking> bookings = new();
            Customer customer = new();
            List<Service> services = new();
            HashSet<int> bookingIds = new(); 


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand GetData = new SqlCommand();
                    GetData.Connection = connection;

                    GetData.CommandType = CommandType.StoredProcedure;
                    GetData.CommandText = "GetCustomerAnalysis";
                    GetData.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));

                    using (SqlDataReader reader = GetData.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Service service = new();
                            Booking booking = new();

                            customer.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            customer.Firstname = reader["Forename"].ToString();
                            customer.Surname = reader["Surname"].ToString();
                            customer.DOB = reader["DOB"].ToString();
                            customer.Gender = reader["Gender"].ToString();
                            customer.AddressOne = reader["AddressOne"].ToString();
                            customer.AddressTwo = reader["AddressTwo"].ToString();
                            customer.Email = reader["Email"].ToString();

                            int bookingId = Convert.ToInt32(reader["BookingID"]);
                            if (bookingIds.Add(bookingId)) // Adds only if not already in HashSet
                            {
                                bookings.Add(new Booking
                                {
                                    BookingID = bookingId,
                                    BookingDate = reader["BookingDate"].ToString()
                                });
                            }


                            service.ServiceID = Convert.ToInt32(reader["ServiceID"]);
                            service.Quantity = Convert.ToInt32(reader["Quantity"]);
                            service.ServiceName = Booking.BookingRequests[service.ServiceID];
                            service.BookingID = Convert.ToInt32(reader["BookingID"]);
                            services.Add(service);
                        }
                    }
                }
                catch (Exception ex)
                {

                }

                return (customer, bookings,services);
            }
        }

        public static (int,int) GetMonthAnalysis()
        {
            List<Booking> bookings = Booking.populateDataGrid();
            List<int> months = new();
            foreach (Booking booking in bookings)
            {
                if (booking.BookingDate.Length >= 7) // Ensure the format is correct
                {
                    int month = Convert.ToInt32(booking.BookingDate.Substring(3, 2)); // Extract MM
                    months.Add(month);
                }
            }
            int mostFrequent = months
        .GroupBy(month => month) // Group by month
        .OrderByDescending(group => group.Count()) // Order by frequency
        .First() // Get the group with the highest frequency
        .Key; // Get the month value
            int LeastFrequent = months
        .GroupBy(month => month) // Group by month
        .OrderByDescending(group => group.Count()) // Order by frequency
        .Last() // Get the group with the lowest  frequency
        .Key;


            return (mostFrequent,LeastFrequent);


        }
    }
}
