using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            int number = 1234;

            bool on = true;
            bool off = true;

            decimal hello = 4367283.7843m;
            float anotherDecimal = 132564.73672f;
            double anotherBigDecimal = 4356234.36743d;

            int minInt = -2147483648;
            int maxInt = 2147483647;
            short minShort = -32768;
            short maxShort = 32767;
            long minLong = -9223372036854775808;
            long maxLong = 9223372036854775807;
            uint minUint = 0;
            uint maxUint = 4294967295;

            char letter = 't';

        }

        [TestMethod]
        public void Operators()
        {
            // arithmetic operators + - / % * 

            int numberOne = 3;
            int numberTwo = 5;

            int sum = numberOne + numberTwo;
            Console.WriteLine(sum);

            int diff = numberOne - numberTwo;
            Console.WriteLine(diff);

            int product = numberOne * numberTwo;
            Console.WriteLine(product);

            int modulo = numberOne % numberTwo;
            Console.WriteLine(modulo);

            float division = numberOne / numberTwo;
            Console.WriteLine(division);

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string firstName = "Trevor";
            string lastName = "Stuart";

            // Concatenation 
            string concat = firstName + " " + lastName;
            Console.WriteLine(concat);

            // Composite Formatting
            string composite = string.Format("Hello, my name is {0} {1}", firstName, lastName);
            Console.WriteLine(composite);

            // String Interpolation
            string interpolation = $"{firstName} {lastName}";
            Console.WriteLine(interpolation);

            // Classes

            // Struct - small collections of value types that are related to eachother.

            // Collections

            List<string> myList = new List<string>();
            myList.Add("Hellow World");

            Queue<string> myQueue = new Queue<string>(0);
            myQueue.Enqueue("Hello World");

            Dictionary<int, string> myDict = new Dictionary<int, string>();

            Stack<int> newStack = new Stack<int>();

            string banana = "Fruit";
            string[] stringArray = { "banana", "orange", "tomato", "apple" };
        }
    }
}
