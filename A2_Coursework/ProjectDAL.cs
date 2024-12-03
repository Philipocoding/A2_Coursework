using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace A2_Coursework
{
    public class ProjectDAL
    {
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Philip\\Desktop\\A2_Coursework\\A2_Coursework\\Database.mdf;Integrated Security=True";
        

        public static int  NewBooking(string CustomerID, string Date, List<int> ServiceID)
        {
            int rowsaffected = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand AddBooking = new SqlCommand();
                    AddBooking.Connection = connection;

                    AddBooking.CommandType = System.Data.CommandType.StoredProcedure;
                    AddBooking.CommandText = "NewBooking";

                    AddBooking.Parameters.Add(new SqlParameter("@Date", Date));
                    AddBooking.Parameters.Add(new SqlParameter("@ServiceID", ServiceID));
                    rowsaffected = AddBooking.ExecuteNonQuery();

                    SqlCommand BookingRequests = new SqlCommand();
                    BookingRequests.Connection = connection;
                    BookingRequests.CommandType = System.Data.CommandType.StoredProcedure;

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
