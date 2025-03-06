using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Coursework.Classes
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }

        public Service() { }
        public Service(int serviceID, string serviceName, double cost, int quantity)
        {
            ServiceID = serviceID;
            ServiceName = serviceName;
            Cost = cost;
            Quantity = quantity;
        }

        public double GetCost(int id)
        {
            switch (id)
            {
                case 1:
                    return 5;
                case 2:
                    return 10;
                case 3:
                    return 5;
                case 4:
                    return 5;
                case 5:
                    return 10;
                case 6:
                    return 5;
                case 7:
                    return 7;
                case 8:
                    return 6;
                case 2005:
                    return 25;
                case 2006:
                    return 25;
                case 2007:
                    return 25;
            }
            return 0;
        }
    }
}
