using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Transactions;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Numerics;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Reflection;

namespace A2_Coursework.Classes
{
    public static class BookingDAL
    {
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Philip\\Desktop\\A2_Coursework\\A2_Coursework\\Database.mdf;Integrated Security=True";

        public static List<int> GetMembersFromTeam(int teamNo)
        {
            List<int> staffMembers = new();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand GetTeamMembers = new SqlCommand();
                    GetTeamMembers.Connection = connection;

                    GetTeamMembers.CommandType = CommandType.StoredProcedure;
                    GetTeamMembers.CommandText = "GetMembersFromTeam";
                    GetTeamMembers.Parameters.Add(new SqlParameter("@TeamNo", teamNo));

                    using (SqlDataReader reader = GetTeamMembers.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staffMembers.Add(Convert.ToInt32(reader["StaffID"]));
                        }
                    }

                }
                catch (Exception ex)
                {

                }

                return staffMembers;
            }
        }
        public static void AssignBookingsToTeams(int bookingID, int teamNo)
        {
            List<int> staffMembers = GetMembersFromTeam(teamNo);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand AssignBookings = new SqlCommand();
                    AssignBookings.Connection = connection;

                    AssignBookings.CommandType = CommandType.StoredProcedure;
                    AssignBookings.CommandText = "GetBookingsByDate";
                    foreach(int id in staffMembers)
                    {
                        AssignBookings.Parameters.Add(new SqlParameter("@BookingID", bookingID));
                        AssignBookings.Parameters.Add(new SqlParameter("@StaffID", id));
                        AssignBookings.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        public static void UpdateBookingDate(int id, string bookingDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Customer customer = new();

                try
                {
                    connection.Open();

                    SqlCommand GetBookings = new SqlCommand();
                    GetBookings.Connection = connection;

                    GetBookings.CommandType = CommandType.StoredProcedure;
                    GetBookings.CommandText = "EditBookingDate";
                    GetBookings.Parameters.Add(new SqlParameter("@BookingID", id));
                    GetBookings.Parameters.Add(new SqlParameter("@Newdate", bookingDate));
                    GetBookings.ExecuteNonQuery();

                }
                catch (CustomException ex)
                {

                }
            }
        }
        public static Customer GetCustomer(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Customer customer = new();

                try
                {
                    connection.Open();

                    SqlCommand GetBookings = new SqlCommand();
                    GetBookings.Connection = connection;

                    GetBookings.CommandType = CommandType.StoredProcedure;
                    GetBookings.CommandText = "GetCustomer";
                    GetBookings.Parameters.Add(new SqlParameter("@CustomerID", id));

                    using (SqlDataReader reader = GetBookings.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customer.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            customer.Firstname = reader["Firstname"].ToString();
                            customer.Firstname = reader["Surname"].ToString();
                            customer.AddressOne = reader["AddressOne"].ToString();
                            customer.AddressTwo = reader["AddressTwo"].ToString();

                        }
                    }


                }
                catch (CustomException ex)
                {

                }

                return customer;
            }
        }
        public static (List<Customer> customerList, List<Booking> bookingList) GetBookingsByDate(string date)
        {
            
            List<Booking> bookingList = new List<Booking>();
            List<Customer> customerList = new();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand GetBookings = new SqlCommand();
                    GetBookings.Connection = connection;

                    GetBookings.CommandType = CommandType.StoredProcedure;
                    GetBookings.CommandText = "GetBookingsByDate";
                    GetBookings.Parameters.Add(new SqlParameter("@Date", date));

                    using (SqlDataReader reader = GetBookings.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Booking booking = new();
                            booking.BookingID = Convert.ToInt32(reader["BookingID"]);
                            booking.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                            booking.BookingDate = reader["BookingDate"].ToString();
                            bookingList.Add(booking);
                        }
                    }

                    foreach(Booking booking in bookingList)
                    {
                        Customer customer = new();
                        SqlCommand getCustomer = new SqlCommand();
                        getCustomer.Connection = connection;

                        getCustomer.CommandType = CommandType.StoredProcedure;
                        getCustomer.CommandText = "GetCustomer";
                        getCustomer.Parameters.Add(new SqlParameter("@CustomerID", booking.CustomerID));

                        using (SqlDataReader reader = getCustomer.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                customer.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                                customer.Firstname = reader["Forename"].ToString();
                                customer.Surname = reader["Surname"].ToString();
                                customer.AddressOne = reader["AddressOne"].ToString();
                                customer.AddressTwo = reader["AddressTwo"].ToString();
                                customerList.Add(customer);
                            }
                        }
                    }

                    
                }
                catch (CustomException ex)
                {

                }
                return (customerList, bookingList);

            }
        }
        public static int GetRequestNo(int bookingid, int serviceid)
        {
            int requestNo = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand AddRequest = new SqlCommand();
                    AddRequest.Connection = connection;

                    AddRequest.CommandType = CommandType.StoredProcedure;
                    AddRequest.CommandText = "GetRequestNo";
                    AddRequest.Parameters.Add(new SqlParameter("@ServiceID", serviceid));
                    AddRequest.Parameters.Add(new SqlParameter("@BookingID", bookingid));

                    using (SqlDataReader reader = AddRequest.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            requestNo = Convert.ToInt32(reader["RequestNo"]);
                        }
                    }
                }
                catch (CustomException ex)
                {

                }
                return requestNo;
            }
        }
        public static void addRequest(int serviceid, int bookingid, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand AddRequest = new SqlCommand();
                    AddRequest.Connection = connection;

                    AddRequest.CommandType = CommandType.StoredProcedure;
                    AddRequest.CommandText = "AddRequest";
                    AddRequest.Parameters.Add(new SqlParameter("@ServiceID", serviceid));
                    AddRequest.Parameters.Add(new SqlParameter("@BookingID", bookingid));
                    AddRequest.Parameters.Add(new SqlParameter("@Quantity", quantity));

                    AddRequest.ExecuteNonQuery();
                }
                catch(CustomException ex)
                {

                }
            }
        }
        public static (List<int> ServiceID, List<int> Quantity) RetrieveBookingRequestsbyID(int id)
        {
            List<int> serviceID = new List<int>();
            List<int> Quantity = new List<int>();
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand GetRequests = new SqlCommand();
                GetRequests.Connection = connection;
                GetRequests.CommandType = CommandType.StoredProcedure;
                GetRequests.CommandText = "RetrieveRequests";
                GetRequests.Parameters.Add(new SqlParameter("@BookingID", id));

                using (SqlDataReader reader = GetRequests.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        serviceID.Add(Convert.ToInt32(reader["ServiceID"]));
                        Quantity.Add(Convert.ToInt32(reader["Quantity"]));
                    }
                }
            }
            return(serviceID, Quantity);
        }
        public static void DeleteCustomer(int Custid)
        {
            using (SqlConnection connection = new(connectionString))
            {
                try
                {
              
                    List<Booking> bookings = Booking.GetBookings(Custid);
                    foreach(Booking reservation in bookings)
                    {
                        DeleteBooking(reservation.BookingID);
                    }


                    connection.Open();
                    SqlCommand DeleteCustomer = new();
                    DeleteCustomer.Connection = connection;
                    DeleteCustomer.CommandType = CommandType.StoredProcedure;
                    DeleteCustomer.CommandText = "DeleteCustomer";
                    DeleteCustomer.Parameters.Add(new SqlParameter("@CustomerID", Custid));
                    DeleteCustomer.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
            }
        }
        public static void EditCustomer(int customerID, string firstname, string surname, string dOB,
            string gender, string addressOne, string addressTwo, string email)
        {
            using (SqlConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand EditStaff = new();
                    EditStaff.Connection = connection;
                    EditStaff.CommandType = CommandType.StoredProcedure;
                    EditStaff.CommandText = "EditCustomer";
                    EditStaff.Parameters.Add(new SqlParameter("@CustomerID", customerID));
                    EditStaff.Parameters.Add(new SqlParameter("@Forename", firstname));

                    EditStaff.Parameters.Add(new SqlParameter("@Surname", surname));

                    EditStaff.Parameters.Add(new SqlParameter("@DOB", dOB));

                    EditStaff.Parameters.Add(new SqlParameter("@Gender", gender));

                    EditStaff.Parameters.Add(new SqlParameter("@AddressOne", addressOne));
                    EditStaff.Parameters.Add(new SqlParameter("@AddressTwo", addressTwo));
                    EditStaff.Parameters.Add(new SqlParameter("@Email", email));


                    EditStaff.ExecuteNonQuery();
                }
                catch (CustomException ex)
                {

                }
            }
        }
        public static void EditStaff(int id,string fname, string sname, int age, string gender,
            double rate,int teamNo)
        {
            using (SqlConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand EditStaff = new();
                    EditStaff.Connection = connection;
                    EditStaff.CommandType = CommandType.StoredProcedure;
                    EditStaff.CommandText = "EditStaffMember";
                    EditStaff.Parameters.Add(new SqlParameter("@StaffID", id));
                    EditStaff.Parameters.Add(new SqlParameter("@FirstName", fname));

                    EditStaff.Parameters.Add(new SqlParameter("@Surname", sname));

                    EditStaff.Parameters.Add(new SqlParameter("@Gender", gender));

                    EditStaff.Parameters.Add(new SqlParameter("@Age", age));

                    EditStaff.Parameters.Add(new SqlParameter("@HourlyRate", rate));

                    EditStaff.Parameters.Add(new SqlParameter("@TeamNo", teamNo));

                    EditStaff.ExecuteNonQuery();
                }
                catch (CustomException ex)
                {

                }
            }
        }
       public static void DeleteStaffMember(int id)
        {
            using(SqlConnection connection = new(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand deleteStaff = new();
                    deleteStaff.Connection = connection;
                    deleteStaff.CommandType = CommandType.StoredProcedure;
                    deleteStaff.CommandText = "DeleteStaffMember";
                    deleteStaff.Parameters.Add(new SqlParameter("@StaffID", 2));
                    deleteStaff.ExecuteNonQuery();
                }
                catch(CustomException ex)
                {

                }
            }
        }

        public static void DeleteBooking(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand DeleteRequests = new SqlCommand();
                    DeleteRequests.Connection = connection;

                    DeleteRequests.CommandType = CommandType.StoredProcedure;
                    DeleteRequests.CommandText = "DeleteBookingRequests";
                    DeleteRequests.Parameters.Add(new SqlParameter("@BookingID", id));


                    DeleteRequests.ExecuteNonQuery();
                    SqlCommand Delete = new SqlCommand();
                    Delete.Connection = connection;

                    Delete.CommandType = CommandType.StoredProcedure;
                    Delete.CommandText = "DeleteBooking";
                    Delete.Parameters.Add(new SqlParameter("@BookingID", id));


                    Delete.ExecuteNonQuery();

                    


                }
                catch (Exception ex)
                {

                }
            }

        }
        public static void NewStaffMember(string firstname, string surname, string gender, int age, float hourlyRate, int teamNo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand NewStaff = new SqlCommand();
                    NewStaff.Connection = connection;

                    NewStaff.CommandType = CommandType.StoredProcedure;
                    NewStaff.CommandText = "NewStaffMember";
                    NewStaff.Parameters.Add(new SqlParameter("@Firstname", firstname));
                    NewStaff.Parameters.Add(new SqlParameter("@Surname", surname));
                    NewStaff.Parameters.Add(new SqlParameter("@Gender", gender));
                    NewStaff.Parameters.Add(new SqlParameter("@Age", age));
                    NewStaff.Parameters.Add(new SqlParameter("@HourlyRate", hourlyRate));
                    NewStaff.Parameters.Add(new SqlParameter("@TeamNo", teamNo));

                    NewStaff.ExecuteNonQuery();

                }
                catch (Exception e)
                {

                }
            }
        }
        public static int NewBooking(int CustomerID, string Date, List<int> ServiceID, List<int> quantity)
        {
            int rowsaffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    

                    if (Booking.CheckAvailability(Date))
                    {
                        SqlCommand AddBooking = new SqlCommand();
                        AddBooking.Connection = connection;

                        AddBooking.CommandType = CommandType.StoredProcedure;
                        AddBooking.CommandText = "NewBooking";
                        AddBooking.Parameters.Add(new SqlParameter("@BookingDate", Date));
                        AddBooking.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));
                        rowsaffected = AddBooking.ExecuteNonQuery();

                        string sqlQuery = "SELECT BookingID FROM Booking ORDER BY BookingID DESC";
                        SqlCommand GetBookingID = new SqlCommand(sqlQuery, connection);
                        int bookingID = Convert.ToInt32(GetBookingID.ExecuteScalar());

                        
                        AssignBookingsToTeams(bookingID, Booking.getTeamNo());


                        SqlCommand NewBookingRequests = new SqlCommand();
                        NewBookingRequests.Connection = connection;

                        NewBookingRequests.CommandType = CommandType.StoredProcedure;
                        NewBookingRequests.CommandText = "NewBookingRequests";
                        for (int i = 0; i < ServiceID.Count; i++)
                        {
                            NewBookingRequests.Parameters.Clear();
                            NewBookingRequests.Parameters.Add(new SqlParameter("@BookingID", bookingID));
                            NewBookingRequests.Parameters.Add(new SqlParameter("@serviceID", ServiceID[i]));
                            NewBookingRequests.Parameters.Add(new SqlParameter("@Quantity", quantity[i]));
                            NewBookingRequests.ExecuteNonQuery();
                        }
                        connection.Close();
                    }

                  

                }
                catch (Exception ex)
                {

                }
                return rowsaffected;
            }
        }

        public static int NewCustomer(string fname, string sname, string DOB,
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

                    AddCustomer.CommandType = CommandType.StoredProcedure;
                    AddCustomer.CommandText = "AddCustomer";
                    AddCustomer.Parameters.Add(new SqlParameter("@DOB", DOB));
                    AddCustomer.Parameters.Add(new SqlParameter("@Forename", fname));
                    AddCustomer.Parameters.Add(new SqlParameter("@Surname", sname));
                    AddCustomer.Parameters.Add(new SqlParameter("@Gender", gender));
                    AddCustomer.Parameters.Add(new SqlParameter("@AddressOne", addressOne));
                    AddCustomer.Parameters.Add(new SqlParameter("@AddressTwo", addressTwo));
                    AddCustomer.Parameters.Add(new SqlParameter("@Email", email));

                    AddCustomer.ExecuteNonQuery();

                    SqlCommand getID = new SqlCommand();
                    getID.Connection = connection;

                    getID.CommandType = CommandType.StoredProcedure;
                    getID.CommandText = "GetLastCustomer";
                    rowsaffected = Convert.ToInt32(getID.ExecuteScalar());

                    connection.Close();


                }
                catch (Exception ex)
                {

                }
                return rowsaffected;
            }
        }


    }
}
