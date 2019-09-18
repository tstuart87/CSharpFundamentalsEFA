using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            // if _ else if _ else
            int age = 14;

            if (age >= 21)
            {
                Console.WriteLine("You can drink");
            }
            else if (age < 21)
            {
                Console.WriteLine("Sorry");
                age += 4;
            }
            else
            {
                Console.WriteLine("This is default.");
            }

            if (age == 18)
            {
                Console.WriteLine("You wrote me out. YAY.");
            }

            decimal bankAccount = 1.01m;

            if (bankAccount > 5)
            {
                Console.WriteLine("You need more money.");
            }
            else if (bankAccount >= 5 && bankAccount < 100)
            {
                Console.WriteLine("Moving up in the world.");
            }
            else if (bankAccount == 100 || bankAccount == 4)
            {
                Console.WriteLine("Woah.");
            }
            else
            {
                Console.WriteLine("Cool.");
            }

                //  --&& AND --||OR __ <= >= < > !=
        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 18;

            switch (age)
            {
                case 1:
                    //The code we want to execute goes here.
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Happy Birthday");
                    break;
                case 5:
                    break;
                default:
                    // this happens when none of the cases are met.
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 55;

            // (condition) ? does this if true : does this if false;
            // () ? true : false;

            bool isAdult = age >= 18 ? true : false;
        }
    }
}
