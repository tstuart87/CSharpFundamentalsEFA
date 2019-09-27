using System;
using _06_CalculatorRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_CalculatorRepositoryTest
{
    [TestClass]
    public class CalculatorRepositoryTests
    {
        [TestMethod]
        public void Addition()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.SumTwoNumbers(6, 4);

            int expected = 10;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtraction()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.SubtractTwoNumbers(6, 4);

            int expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiplication()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.MultiplyTwoNumbers(6, 4);

            int expected = 24;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Division()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.DivideTwoNumbers(16, 4);

            int expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Modulo()
        {
            CalculatorRepository calcRepo = new CalculatorRepository();
            int actual = calcRepo.ModuloTwoNumbers(16, 4);

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}
