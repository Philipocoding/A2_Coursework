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
        //public static Dictionary<int, int> StockForService = new Dictionary<int, int>();
        public static List<int> StockForService = new();

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
