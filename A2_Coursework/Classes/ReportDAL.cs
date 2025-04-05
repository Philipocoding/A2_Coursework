using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Configuration;

namespace A2_Coursework.Classes
{
    internal class ReportDAL
    {

        //public static string connectionString = string.Format(
        // ConfigurationManager.ConnectionStrings["CourseWorkConnectionString"].ConnectionStringDirectory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.FullName);
        public static string connectionString = string.Format(
        ConfigurationManager.
        ConnectionStrings["CourseWorkConnectionString"].
        ConnectionString,
        Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)!.Parent!.Parent!.Parent!.Parent!.FullName);
        /// </summary>
        /// <param name="CustomerID"></param>
        /// <returns></returns>
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
                            if (bookingIds.Add(bookingId))
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
                if (booking.BookingDate.Length >= 7) 
                {
                    int month = Convert.ToInt32(booking.BookingDate.Substring(3, 2));
                    months.Add(month);
                }
            }
            int mostFrequent = months
        .GroupBy(month => month) 
        .OrderByDescending(group => group.Count()) 
        .First()
        .Key; 
            int LeastFrequent = months
        .GroupBy(month => month)
        .OrderByDescending(group => group.Count())
        .Last() 
        .Key;


            return (mostFrequent,LeastFrequent);


        }
    }
}
