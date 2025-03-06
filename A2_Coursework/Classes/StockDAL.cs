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
    public class StockDAL
    {
        public static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Philip\\Desktop\\A2_Coursework\\A2_Coursework\\Database.mdf;Integrated Security=True";


        public static void StockIssueResolved(int id, string date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand IssueResolved = new SqlCommand();
                    IssueResolved.Connection = connection;

                    IssueResolved.CommandType = CommandType.StoredProcedure;
                    IssueResolved.CommandText = "StockIssueResolved";
                    IssueResolved.Parameters.Add(new SqlParameter("@StockID", id));
                    IssueResolved.Parameters.Add(new SqlParameter("@SolutionDate", date));
                    IssueResolved.ExecuteNonQuery();
                }
                catch (CustomException ex)
                {

                }
            }
        }

        public static void StockIssue(int id, int quantity, int IssueTypeID, string solutionDate)
        {
            if(IssueTypeID == 0)
            {
                throw new CustomException("Not a valid type of issue");
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand ReportIssue = new SqlCommand();
                    ReportIssue.Connection = connection;

                    ReportIssue.CommandType = CommandType.StoredProcedure;
                    ReportIssue.CommandText = "ReportStockIssue";
                    ReportIssue.Parameters.Add(new SqlParameter("@StockID", id));
                    ReportIssue.Parameters.Add(new SqlParameter("@Quantity", quantity));
                    ReportIssue.Parameters.Add(new SqlParameter("@IssueTypeID", IssueTypeID));
                    ReportIssue.Parameters.Add(new SqlParameter("@SolutionDate", solutionDate));


                    ReportIssue.ExecuteNonQuery();
                }
                catch (CustomException ex)
                {

                }
            }
        }
        public static List<Stock> GetStockOrder(string bookingDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List <Stock> stockList = new();
                try
                {
                    connection.Open();

                    SqlCommand GetOrder = new SqlCommand();
                    GetOrder.Connection = connection;

                    GetOrder.CommandType = CommandType.StoredProcedure;
                    GetOrder.CommandText = "GetStockOrder";
                    GetOrder.Parameters.Add(new SqlParameter("@orderdate", bookingDate));

                    using (SqlDataReader reader = GetOrder.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Stock stock = new();
                            stock.StockID = Convert.ToInt32(reader["StockID"]);
                            stock.Quantity = Convert.ToInt32(reader["Quantity"].ToString());
                            stock.OrderDate = reader["OrderDate"].ToString();

                           stockList.Add(stock);
                        }
                    }
                }
                catch (CustomException ex)
                {

                }

                return stockList;
            }
        }

        public static void DeleteStockOrder(int id, string orderDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand DeleteOrder = new SqlCommand();
                    DeleteOrder.Connection = connection;

                    DeleteOrder.CommandType = CommandType.StoredProcedure;
                    DeleteOrder.CommandText = "DeleteStockOrder";
                    DeleteOrder.Parameters.Add(new SqlParameter("@StockID", id));
                    DeleteOrder.Parameters.Add(new SqlParameter("@OrderDate", orderDate));
                    DeleteOrder.ExecuteNonQuery();

                }
                catch (CustomException ex)
                {

                }
            }
        }
        public static List<Stock> GetAllOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Stock> stockList = new();
                try
                {
                    connection.Open();

                    SqlCommand GetInfo = new SqlCommand();
                    GetInfo.Connection = connection;

                    GetInfo.CommandType = CommandType.StoredProcedure;
                    GetInfo.CommandText = "GetAllStockOrder";

                    using (SqlDataReader reader = GetInfo.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Stock stock = new();

                            stock.StockID = Convert.ToInt32(reader["StockID"]);
                            stock.Quantity = Convert.ToInt32(reader["Quantity"]);
                            stock.OrderDate = reader["OrderDate"].ToString();
                            stock.OrderReceived = Convert.ToInt32(reader["OrderReceived"]);


                            stockList.Add(stock);
                        }
                    }
                }
                catch (CustomException ex)
                {

                }
                return stockList;
            }
        }

        [Obsolete]
        public static void AddStock()
        {

            DateTime today = DateTime.Now.AddDays(-1);
            List<Stock> allorders = StockDAL.GetAllOrders();
            foreach (Stock item in allorders)
            {
                DateTime itemDate = DateTime.Parse(item.OrderDate);
                if (itemDate.Date == today.Date)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            SqlCommand AddMoreStock = new SqlCommand();
                            AddMoreStock.Connection = connection;

                            AddMoreStock.CommandType = CommandType.StoredProcedure;
                            AddMoreStock.CommandText = "AddStock";
                            AddMoreStock.Parameters.Add(new SqlParameter("@StockID", item.StockID));
                            AddMoreStock.Parameters.Add(new SqlParameter("@Quantity", item.Quantity));

                            AddMoreStock.ExecuteNonQuery();
                        }
                        catch (CustomException ex)
                        {

                        }
                    }
                }
            }
            
        }
        public static void MarkOrderAsReceived(int id, string date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand MarkReceived = new SqlCommand();
                    MarkReceived.Connection = connection;

                    MarkReceived.CommandType = CommandType.StoredProcedure;
                    MarkReceived.CommandText = "MarkOrderAsReceived";
                    MarkReceived.Parameters.Add(new SqlParameter("@StockID", id));
                    MarkReceived.Parameters.Add(new SqlParameter("@OrderDate", date));
                    MarkReceived.ExecuteNonQuery();
                }
                catch (CustomException ex)
                {

                }
            }
        }

        public static void MarkOrderAsReceived(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand MarkReceived = new SqlCommand();
                    MarkReceived.Connection = connection;

                    MarkReceived.CommandType = CommandType.StoredProcedure;
                    MarkReceived.CommandText = "IssueResolved";
                    MarkReceived.Parameters.Add(new SqlParameter("@StockID", id));
                    MarkReceived.ExecuteNonQuery();
                }
                catch (CustomException ex)
                {

                }
            }
        }
        public static void AddStock(int id, int quantity)//, string date)
        {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            SqlCommand AddMoreStock = new SqlCommand();
                            AddMoreStock.Connection = connection;

                            AddMoreStock.CommandType = CommandType.StoredProcedure;
                            AddMoreStock.CommandText = "AddStock";
                            AddMoreStock.Parameters.Add(new SqlParameter("@StockID", id));
                            AddMoreStock.Parameters.Add(new SqlParameter("@Quantity", quantity));
                           // AddMoreStock.Parameters.Add(new SqlParameter("@OrderDate", date));


                            AddMoreStock.ExecuteNonQuery();
                        }
                        catch (CustomException ex)
                        {

                        }
                    }
        }
        public static double GetStockPrice(int id)
        {
            Stock stock = new();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                        connection.Open();

                        SqlCommand GetOrder = new SqlCommand();
                        GetOrder.Connection = connection;

                        GetOrder.CommandType = CommandType.StoredProcedure;
                        GetOrder.CommandText = "GetStockPrice";
                        GetOrder.Parameters.Add(new SqlParameter("@StockID", id));

                        using (SqlDataReader reader = GetOrder.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                stock.Cost = Convert.ToDouble(reader["Cost"]);
                            }
                        }


                }
                catch (CustomException ex)
                {

                }
                return stock.Cost;


                
            }

        }

        public static void AddStockOrder(int id, int quantity, string orderDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand GetOrder = new SqlCommand();
                    GetOrder.Connection = connection;

                    GetOrder.CommandType = CommandType.StoredProcedure;
                    GetOrder.CommandText = "AddStockOrder";
                    GetOrder.Parameters.Add(new SqlParameter("@StockID", id));
                    GetOrder.Parameters.Add(new SqlParameter("@Quantity", quantity));
                    GetOrder.Parameters.Add(new SqlParameter("@OrderDate", orderDate));
                    GetOrder.ExecuteNonQuery();

                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new CustomException("An order for this item on this date exists!! " +
                        "item already exists! Edit the existing order");
                }

            }
        }

        public static List<Stock> GetEquipmentInfo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Stock> stockList = new();
                try
                {
                    connection.Open();

                    SqlCommand GetInfo = new SqlCommand();
                    GetInfo.Connection = connection;

                    GetInfo.CommandType = CommandType.StoredProcedure;
                    GetInfo.CommandText = "GetStockInfo";

                    using (SqlDataReader reader = GetInfo.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Stock stock = new();

                            stock.StockID = Convert.ToInt32(reader["StockID"]);
                            stock.StockName = reader["StockName"].ToString();
                            stock.Quantity = Convert.ToInt32(reader["Quantity"]);
                            stock.Cost = Convert.ToDouble(reader["Cost"]);

                            stockList.Add(stock);
                        }
                    }


                }
                catch (CustomException ex)
                {

                }

                return stockList;
            }
        }
    }
}
