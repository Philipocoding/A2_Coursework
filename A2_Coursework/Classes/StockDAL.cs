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

        public static List<Stock> GetEquipmentInfo()//string bookingDate)
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
