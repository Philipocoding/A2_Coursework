using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Stock stock = new();
                try
                {
                    connection.Open();

                    SqlCommand GetOrder = new SqlCommand();
                    GetOrder.Connection = connection;

                    GetOrder.CommandType = CommandType.StoredProcedure;
                    GetOrder.CommandText = "GetStockReorder";
                    GetOrder.Parameters.Add(new SqlParameter("@BookingDate", bookingDate));

                    using (SqlDataReader reader = GetOrder.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            stock.StockID = Convert.ToInt32(reader["CustomerID"]);
                            stock.StockName = reader["Firstname"].ToString();
                            stock.Quantity = Convert.ToInt32(reader["Surname"].ToString());
                            stock.Cost = Convert.ToDouble(reader["Cost"].ToString());

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
