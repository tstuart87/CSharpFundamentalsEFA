using System;
using System.Collections.Generic;
using _08_BakerStreetRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_BakerStreetBakeryReposityory_Tests
{
    [TestClass]
    public class BakerStreetBakeryTests
    {
        [TestMethod]
        public void CreateProductObject()
        {
            Product productOne = new Product();

            productOne.ProductName = "Croissant";
            string expected = "Croissant";

            Assert.AreEqual(expected, productOne.ProductName);
        }

        [TestMethod]
        public void AddToList_CheckSizeOfList()
        {
            ProductRepository productRepo = new ProductRepository();
            List<Product> orderList = productRepo.GetTheList();

            Product productOne = new Product("apple", "Trevor");
            Product productTwo = new Product("cherry", "Steve");

            int expected = 2;

            productRepo.AddToList(productOne);
            productRepo.AddToList(productTwo);

            int actual = orderList.Count;

            Assert.AreEqual(expected, actual);
        }    

        [TestMethod]
        public void RemoveFromList_CheckSizeOfList()
        {
            ProductRepository productRepo = new ProductRepository();
            List<Product> orderList = productRepo.GetTheList();

            Product productOne = new Product("apple", "Trevor");
            Product productTwo = new Product("cherry", "Steve");
            Product productThree = new Product("chocolate", "Jeff");

            int expected = 2;

            productRepo.AddToList(productOne);
            productRepo.AddToList(productTwo);
            productRepo.AddToList(productThree);
            productThree.ProductID = 1;
            productRepo.RemoveFromList(1);

            int actual = orderList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateCost_MakeSureItsEqualsExpectedCost()
        {
            ProductRepository productRepo = new ProductRepository();
            List<Product> orderList = productRepo.GetTheList();

            Product productOne = new Product();
            productOne.OrderBatchSize = 3;
            productOne.Type = BakeType.Cake;

            productRepo.CalculateInitialCost(productOne);

            decimal actual = productOne.OrderCost;
            decimal expected = 6100.0m;

            Assert.AreEqual(expected, actual);
        }
    }
}
