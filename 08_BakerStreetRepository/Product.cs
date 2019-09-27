using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BakerStreetRepository
{
    public enum BakeType { Bread = 1, Cake, Pastry, Pie}
    public class Product
    {
        public Product()
        {

        }

        public Product(string productName, string customerName)
        {
            ProductName = productName;
            CustomerName = customerName;
        }

        public Product(BakeType type, string productName, string customerName, int orderBatchSize, decimal orderCost, int productID)
        {
            Type = type;
            ProductName = productName;
            CustomerName = customerName;
            OrderBatchSize = orderBatchSize;
            OrderCost = orderCost;
            ProductID = productID;
        }

        public BakeType Type { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public int OrderBatchSize { get; set; }
        public decimal OrderCost { get; set; }
        public int ProductID { get; set; }
    }
}
