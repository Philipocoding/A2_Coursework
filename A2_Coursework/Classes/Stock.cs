using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Coursework.Classes
{
    public class Stock
    {
        public int StockID { get; set; }
        public string StockName { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public string OrderDate { get; set; }
        public int OrderReceived { get; set; }
        public string SolutionDate { get; set; }
        public string IssueID { get; set; }
        public int IssueResolved { get; set; }
        public int ReorderValue { get; set; }
        public int ReorderQuantity {  get; set; }



        public Stock() { }
        public static Dictionary<int, Stock> StockIds = new Dictionary<int, Stock>();
        public static Dictionary<string, Stock> StockIDs = new Dictionary<string, Stock>();
        public static List<int> StockForService = new();

        public Stock(int stockID, string stockNmae, int quantity, double cost)
        {
            StockID = stockID;
            StockName = stockNmae;
            Quantity = quantity;
            Cost = cost;
        }

        public Stock(int stockID, int quantity, string orderdate)
        {
            StockID = stockID;
            Quantity = quantity;
            OrderDate = orderdate;
        }
        public static int GetIssueID(string issue)
        {

            switch (issue)
            {
                case "Broken":
                    return 1;
                case "Cracked":
                    return 2;
                case "Won't turn on":
                    return 3;
                case"Wrong item":
                    return 4;
                case"Poor quality":
                    return 5;
            }
            return 0;
        }
        public static string GetIssueID(int issueID)
        {

            switch (issueID)
            {
                case 1:
                    return "Broken";
                case 2:
                    return "Cracked";
                case 3:
                    return "Won't turn on";
                case 4:
                    return "Wrong item";
                case 5:
                    return "Poor quality";
            }
            return "";
        }

      
        public static void PopulateList()
        {
            StockForService.Add(2);
            StockForService.Add(2);
            StockForService.Add(1);
            StockForService.Add(1);
            StockForService.Add(3);
            StockForService.Add(2);
            StockForService.Add(1);
            StockForService.Add(1);
            StockForService.Add(5);
            StockForService.Add(4);
            StockForService.Add(3);


        }

        public static List<int> QuantityNeeded(List<int> serviceID)
        {
            List<int> quantity = new();
            for(int i = 0; i<serviceID.Count; i++)
            {
                for(int ii = 0; i < StockForService.Count; ii++)
                {
                    if (serviceID[i] == serviceID[ii])
                    {
                        quantity.Add(StockForService[ii]);
                    }
                }
            }
            return quantity;
        }
        
        public static List<Stock> RetrieveStockIssues()
        {
            List<Stock> StockIssues = new List<Stock>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ReportDAL.connectionString))
                {
                    connection.Open();

                    SqlCommand GetStockIssues = new SqlCommand();

                    GetStockIssues.Connection = connection;
                    GetStockIssues.CommandType = System.Data.CommandType.StoredProcedure;
                    GetStockIssues.CommandText = "RetrieveStockIssues";

                    using (SqlDataReader reader = GetStockIssues.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Stock stock = new Stock();

                            stock.StockID = Convert.ToInt32(reader["StockID"]);
                            stock.Quantity = Convert.ToInt32(reader["Quantity"]);
                            stock.IssueID = reader["IssueTypeID"].ToString();
                            stock.SolutionDate = reader["SolutionDate"].ToString();
                            stock.StockName = StockIds[stock.StockID].StockName.ToString();
                            stock.IssueResolved = Convert.ToInt32(reader["IssueResolved"]);


                            StockIssues.Add(stock);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return StockIssues;
        }
        
    }
}
