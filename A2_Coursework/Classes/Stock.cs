using System;
using System.Collections.Generic;
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
        public Stock() { }
        public static Dictionary<int, Stock> StockIds = new Dictionary<int, Stock>();
        public static Dictionary<string, Stock> StockIDs = new Dictionary<string, Stock>();


        public Stock(int stockID, string stockNmae, int quantity, double cost)
        {
            StockID = stockID;
            StockName = stockNmae;
            Quantity = quantity;
            Cost = cost;
        }

        public Stock(int stockID, int quantity,string orderdate)
        {
            StockID = stockID;
            Quantity = quantity;
            OrderDate = orderdate;
        }
    }
}
