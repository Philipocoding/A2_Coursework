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
        public Stock() { }
        public static Dictionary<int, string> BookingRequests = new Dictionary<int, string>();

        public Stock(int stockID, string stockNmae, int quantity, double cost)
        {
            StockID = stockID;
            StockName = stockNmae;
            Quantity = quantity;
            Cost = cost;
        }
    }
}
