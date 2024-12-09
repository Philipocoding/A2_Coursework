using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace A2_Coursework
{
    public class ProjectDAL
    {
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Philip\\Desktop\\A2_Coursework\\A2_Coursework\\Database.mdf;Integrated Security=True";

        public static void Booking_Request(List<int> ServiceID)
        {
            int bookingID = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "SELECT TOP 1 BookingID FROM Booking ORDER BY BookingID DESC";

                    SqlCommand GetBookingID = new SqlCommand(sqlQuery, connection);
                    GetBookingID.Connection = connection;
                    bookingID = GetBookingID.ExecuteNonQuery();

                    SqlCommand NewBookingRequests = new SqlCommand();
                    NewBookingRequests.Connection = connection;

                    NewBookingRequests.CommandType = System.Data.CommandType.StoredProcedure;
                    NewBookingRequests.CommandText = "NewBookingRequests";

                    for (int i = 0; i < ServiceID.Count; i++)
                    {
                        NewBookingRequests.Parameters.Add(new SqlParameter("@BookingID", bookingID));
                        NewBookingRequests.Parameters.Add(new SqlParameter("@serviceID", ServiceID[i]));
                        NewBookingRequests.Parameters.Add(new SqlParameter("@Quantity", 1));
                    }

                    connection.Close();

                }
                catch (Exception ex)
                {

                }
            }
        }
        public static int  NewBooking(int CustomerID, string Date, List<int> ServiceID)
        {
            int rowsaffected = 0;
            Booking_Request(ServiceID);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand AddBooking = new SqlCommand();
                    AddBooking.Connection = connection;

                    AddBooking.CommandType = System.Data.CommandType.StoredProcedure;
                    AddBooking.CommandText = "NewBooking";
                    AddBooking.Parameters.Add(new SqlParameter("@BookingDate", Date));
                    AddBooking.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));
                    rowsaffected = AddBooking.ExecuteNonQuery();

                    connection.Close();
                   
                }
                catch (Exception ex)
                {

                }
                return rowsaffected;
            }
        }

        public static int NewCustomer(int CustomerID, string DOB, string fname, string sname, 
            string gender, string addressOne, string addressTwo, string email)
        {
            int rowsaffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand AddCustomer = new SqlCommand();
                    AddCustomer.Connection = connection;

                    AddCustomer.CommandType = System.Data.CommandType.StoredProcedure;
                    AddCustomer.CommandText = "NewBooking";
                    AddCustomer.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));
                    AddCustomer.Parameters.Add(new SqlParameter("@DOB", DOB));
                    AddCustomer.Parameters.Add(new SqlParameter("@fname", fname));
                    AddCustomer.Parameters.Add(new SqlParameter("@sname", sname));
                    AddCustomer.Parameters.Add(new SqlParameter("@gender", gender));
                    AddCustomer.Parameters.Add(new SqlParameter("@AddressOne", addressOne));
                    AddCustomer.Parameters.Add(new SqlParameter("@AddressTwo", addressTwo));
                    AddCustomer.Parameters.Add(new SqlParameter("@Email", email));

                    rowsaffected = AddCustomer.ExecuteNonQuery();

                    connection.Close();

                }
                catch (Exception ex)
                {

                }
                return rowsaffected;
            }
        }

        public static void Booking_Rquest(List<int> ServiceID)
        {
            int bookingID = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "SELECT TOP 1 BookingID FROM Booking ORDER BY BookingID DESC";

                    SqlCommand GetBookingID = new SqlCommand(sqlQuery, connection);
                    GetBookingID.Connection = connection;
                    bookingID = GetBookingID.ExecuteNonQuery();

                    SqlCommand NewBookingRequests = new SqlCommand();
                    NewBookingRequests.Connection = connection;

                    NewBookingRequests.CommandType = System.Data.CommandType.StoredProcedure;
                    NewBookingRequests.CommandText = "NewBookingRequests";

                    for (int i = 0; i < ServiceID.Count; i++)
                    {
                        NewBookingRequests.Parameters.Add(new SqlParameter("@BookingID", bookingID));
                        NewBookingRequests.Parameters.Add(new SqlParameter("@serviceID", ServiceID[i]));
                        NewBookingRequests.Parameters.Add(new SqlParameter("@Quantity", 1));
                    }

                    connection.Close();

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
