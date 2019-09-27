using _08_BakerStreetRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_BakerStreetBakeryRepository_Console
{
    internal class ProgramUI
    {
        ProductRepository _productRepo = new ProductRepository();
        int orderCount = 1000;

        public void Run()
        {
            _productRepo.SeedList();
            RunMenu();
        }

        public void RunMenu()
        {
            Console.WriteLine("Main Menu - Choose Number:\n" +
                "1. Take an Order\n" +
                "2. Delete an Order\n" +
                "3. View today's Orders\n" +
                "4. Edit an Order\n" +
                "5. Exit Program\n");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    TakeAnOrder();
                    break;
                case "2":
                    DeleteAnOrder();
                    break;
                case "3":
                    ViewTodaysOrders();
                    break;
                case "4":
                    EditAnOrder();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Press any key to EXIT.");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    RunMenu();
                    break;
            }
        }

        public void TakeAnOrder()
        {
            Console.Clear();
            Console.WriteLine("Customer's Name:\n");
            string name = Console.ReadLine();
            name = name.ToUpper();
            Console.Clear();
            Console.WriteLine("What does the customer want:\n");
            string productName = Console.ReadLine();
            productName = productName.ToLower();

            Product productOne = new Product(productName, name);

            Console.Clear();
            Console.WriteLine("Choose number for Product Type:\n" +
                "1. Bread\n" +
                "2. Cake\n" +
                "3. Pastry\n" +
                "4. Pie\n");
            string bakeTypeStr = Console.ReadLine();
            switch (bakeTypeStr)
            {
                case "1":
                    productOne.Type = BakeType.Bread;
                    break;
                case "2":
                    productOne.Type = BakeType.Cake;
                    break;
                case "3":
                    productOne.Type = BakeType.Pastry;
                    break;
                case "4":
                    productOne.Type = BakeType.Pie;
                    break;
                default:
                    Console.WriteLine($"\nNot an option, {name}. Press any key to try again.");
                    Console.ReadKey();
                    TakeAnOrder();
                    break;
            }

            Console.Clear();
            Console.WriteLine("How many does the customer want?\n");
            string orderBatchSizeStr = Console.ReadLine();
            int orderBatchSize = int.Parse(orderBatchSizeStr);
            productOne.OrderBatchSize = orderBatchSize;

            _productRepo.CalculateInitialCost(productOne);
            decimal cost = productOne.OrderCost;

            string costStr = string.Format("{0:f2}", cost);

            Console.Clear();

            Console.WriteLine("Cost of Order:\n\n" + $"${costStr}\n\n" +
                $"Press any key to continue.");

            //Console.WriteLine("Cost of Order:\n\n" + $"${cost}\n\n" +
            //    $"Press any key to continue.");

            Console.ReadKey();

            productOne.ProductID = orderCount + 1;
            _productRepo.AddToList(productOne);
            Console.Clear();
            orderCount += 1;
            RunMenu();
        }

        public void DeleteAnOrder()
        {
            Console.Clear();
            _productRepo.PrintList();
            Console.WriteLine("\nWhich 'Order ID' would you like to delete?\n");
            string input = Console.ReadLine();
            int order = int.Parse(input);

            _productRepo.RemoveFromList(order);

            Console.Clear();
            Console.WriteLine("Item has been removed. Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            RunMenu();
        }

        public void ViewTodaysOrders()
        {
            Console.Clear();
            Console.WriteLine("Today's Orders:\n\n");

            _productRepo.PrintList();

            List<Product> list = _productRepo.GetTheList();
            int numberOfSales = list.Count;

            Console.WriteLine("Total number of Sales for the day: " + $"{ numberOfSales}\n");

            decimal cost = 0.00m;

            foreach (Product x in list)
            {
                cost += x.OrderCost;
            }

            string costStr = string.Format("{0:f2}", cost);

            Console.WriteLine("Total revenue for the day: " + $"${costStr}\n");

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
            RunMenu();
        }

        public void EditAnOrder()
        {
            List<Product> list = new List<Product>();
            list = _productRepo.GetTheList();

            Console.Clear();
            _productRepo.PrintList();
            Console.WriteLine("\nWhich order would you like to edit? Select using Order ID.\n");
            string orderIDStr = Console.ReadLine();

            if (orderIDStr.All(char.IsDigit))
            {
                int orderIDint = int.Parse(orderIDStr);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nah.");
                Console.ReadKey();
                Console.Clear();
                RunMenu();
            }

            int orderID = int.Parse(orderIDStr);

            Console.Clear();
            Console.WriteLine("Enter number of field you would like to edit.\n" +
                "1. Type\n" +
                "2. Product Name\n" +
                "3. Customer Name\n" +
                "4. Batch Size\n" +
                "5. Order Cost\n");

            string field = Console.ReadLine();

            switch (field)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("What should the new Type be? Enter the number.\n" +
                        "1. Bread\n" +
                        "2. Cake\n" +
                        "3. Pastry\n" +
                        "4. Pie\n");
                    string type = Console.ReadLine();
                    switch (type)
                    {
                        case "1":
                            foreach (Product x in list)
                            {
                                if (x.ProductID == orderID)
                                {
                                    x.Type = BakeType.Bread;
                                }
                            }
                            break;
                        case "2":
                            foreach (Product x in list)
                            {
                                if (x.ProductID == orderID)
                                {
                                    x.Type = BakeType.Cake;
                                }
                            }
                            break;
                        case "3":
                            foreach (Product x in list)
                            {
                                if (x.ProductID == orderID)
                                {
                                    x.Type = BakeType.Pastry;
                                }
                            }
                            break;
                        case "4":
                            foreach (Product x in list)
                            {
                                if (x.ProductID == orderID)
                                {
                                    x.Type = BakeType.Pie;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("What would you like to change the Product Name to?");
                    string newProdName = Console.ReadLine().ToLower();
                    foreach (Product x in list)
                    {
                        if (x.ProductID == orderID)
                        {
                            x.ProductName = newProdName;
                        }
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("What should the customer's name be changed to?");
                    string newName = Console.ReadLine().ToUpper();
                    foreach (Product x in list)
                    {
                        if (x.ProductID == orderID)
                        {
                            x.CustomerName = newName;
                        }
                    }
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Enter new Order Batch Size:");
                    int newOrderBatchSize = int.Parse(Console.ReadLine());
                    foreach (Product x in list)
                    {
                        if (x.ProductID == orderID)
                        {
                            x.OrderBatchSize = newOrderBatchSize;
                        }
                    }
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Enter the number to the corresponding discount:\n" +
                        "1. 25%\n" +
                        "2. 50%\n" +
                        "3. 75%\n");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            foreach (Product x in list)
                            {
                                if (x.ProductID == orderID)
                                {
                                    x.OrderCost *= 0.25m;
                                }
                            }
                            break;
                        case "2":
                            foreach (Product x in list)
                            {
                                if (x.ProductID == orderID)
                                {
                                    x.OrderCost *= 0.50m;
                                }
                            }
                            break;
                        case "3":
                            foreach (Product x in list)
                            {
                                if (x.ProductID == orderID)
                                {
                                    x.OrderCost *= 0.75m;
                                }
                            }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Nah.");
                            Console.ReadKey();
                            RunMenu();
                            break;
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Nah.");
                    Console.ReadKey();
                    RunMenu();
                    break;
            }
            Console.Clear();
            Console.WriteLine("Field has been edited. Press any key to continue.\n\n");
            _productRepo.PrintList();
            Console.ReadKey();
            Console.Clear();
            RunMenu();
        }
    }
}
