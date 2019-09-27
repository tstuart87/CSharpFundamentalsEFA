using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BakerStreetRepository
{
    public class ProductRepository
    {
        List<Product> _productList = new List<Product>();

        public void AddToList(Product content)
        {
            _productList.Add(content);
        }

        public List<Product> GetTheList()
        {
            return _productList;
        }

        public void RemoveFromList(int order)
        {
            foreach (Product x in _productList)
            {
                if (x.ProductID == order)
                {
                    _productList.Remove(x);
                    break;
                }
            }
        }

        public void PrintList()
        {
            foreach(Product x in _productList)
            {
                Console.WriteLine($"Customer: {x.CustomerName}\n" +
                    $"Order: {x.ProductName}\n" +
                    $"Type: {x.Type}\n" +
                    $"Batch Size: {x.OrderBatchSize}\n" +
                    $"Cost: ${x.OrderCost}\n" +
                    $"Order ID: {x.ProductID}\n");
            }
        }

        public void CalculateInitialCost(Product productOrder)
        {
            if (productOrder.Type == BakeType.Bread)
            {
                productOrder.OrderCost = 500.01m * productOrder.OrderBatchSize;
                productOrder.OrderCost += 100.00m;
            }
            else if (productOrder.Type == BakeType.Cake)
            {
                productOrder.OrderCost = 2000.00m * productOrder.OrderBatchSize;
                productOrder.OrderCost += 100.00m;
            }
            else if (productOrder.Type == BakeType.Pastry)
            {
                productOrder.OrderCost = 200.10m * productOrder.OrderBatchSize;
                productOrder.OrderCost += 100.00m;
            }
            else if (productOrder.Type == BakeType.Pie)
            {
                productOrder.OrderCost = 851.50m * productOrder.OrderBatchSize;
                productOrder.OrderCost += 100.00m;
            }
            else
            {
                productOrder.OrderCost += 100.00m;
            }
        }

        public void SeedList()
        {
            Product contentOne = new Product(BakeType.Cake, "banana", "GORDO", 3, 6100.00m, 998);
            Product contentTwo = new Product(BakeType.Cake, "chocolate", "EMILY", 1, 2100.00m, 999);
            Product contentThree = new Product(BakeType.Cake, "angel food", "TONY", 4, 8100.00m, 1000);

            _productList.Add(contentOne);
            _productList.Add(contentTwo);
            _productList.Add(contentThree);
        }

    }
}
