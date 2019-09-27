using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class Methods
    {
        [TestMethod]
        public void MethodExamples()
        {
            // + = - / * %

            int sum = 2 + 2;
            int subtraction = 2 - 2;
            int multiplication = 2 * 2;
            int remainder = 2 % 2;
            int divide = 2 / 2;

            int expectedOne = 8;
            int actualOne = AddTwoNumbers(sum, multiplication);
            Assert.AreEqual(expectedOne, actualOne);

            int expectedTwo = 1;
            int actualTwo = SubtractTwoNumbers(divide, remainder);
            Assert.AreEqual(expectedTwo, actualTwo);

            int expectedThree = 16;
            int actualThree = MultiplyTwoNumbers(multiplication, sum);
            Assert.AreEqual(expectedThree, actualThree);

            int expectedFour = 1;
            int actualFour = DivideTwoNumbers(multiplication, sum);
            Assert.AreEqual(expectedFour, actualFour);

            int expectedFive = 0;
            int actualFive = ModuloTwoNumbers(multiplication, sum);
            Assert.AreEqual(expectedFive, actualFive);
        }

        //1=access modifier  2=return type  3=method name  4=parentheses(parameters)

        //1    //2      //3               //4
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public int SubtractTwoNumbers(int numOne, int numTwo)
        {
            int diff = numOne - numTwo;
            return diff;
        }

        public int MultiplyTwoNumbers(int numOne, int numTwo)
        {
            int prod = numOne * numTwo;
            return prod;
        }

        public int DivideTwoNumbers(int numOne, int numTwo)
        {
            int div = numOne / numTwo;
            return div;
        }

        public int ModuloTwoNumbers(int numOne, int numTwo)
        {
            int remainder = numOne % numTwo;
            return remainder;
        }
    }
}
