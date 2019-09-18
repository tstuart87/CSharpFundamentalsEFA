using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void ForLoop()
        {
            int studentCount = 13;

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = studentCount - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void WhileLoop()
        {
            int number = 5;
            while (number != 6)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            List<string> students = new List<string>();

            students.Add("Trevor");
            students.Add("Jeff");
            students.Add("Gordon");
            students.Add("Tony");
            students.Add("Emily");

            foreach(string studentName in students)
            {
                Console.WriteLine(studentName);
            }

            string mountainName = "Mauna Kea";

            foreach (char letter in mountainName)
            {
                if (letter == 'a')
                {
                    Console.WriteLine(letter);
                }
            }
        }
    }
}
