using _06_CalculatorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CalculatorRepositoryConsole
{
    internal class ProgramUI
    {
        CalculatorRepository _calcRepo = new CalculatorRepository();
        
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            Console.WriteLine("Enter the number of the menu item that you would like to use:\n\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n" +
                "5. Find Remainder\n" +
                "6. Exit Program");

            string userInput = (Console.ReadLine());

            switch (userInput)
            {
                case "1":
                    Sum();
                    break;
                case "2":
                    Subtract();
                    break;
                case "3":
                    Multiply();
                    break;
                case "4":
                    Divide();
                    break;
                case "5":
                    Modulo();
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("See ya later...Press any key to EXIT.");
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Not an option...Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    RunMenu();
                    break;
            }
        }

        public void Sum()
        {
            Console.WriteLine("\nWhat is your first number?\n");
            string inputOneStr = Console.ReadLine();
            float numOne = float.Parse(inputOneStr);

            Console.WriteLine("\nWhat is the second number?\n");
            string inputTwoStr = Console.ReadLine();
            float numTwo = float.Parse(inputTwoStr);

            _calcRepo.SumTwoNumbers(numOne, numTwo);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            RunMenu();
        }

        public void Subtract()
        {
            Console.WriteLine("\nWhat is your first number?\n");
            string inputOneStr = Console.ReadLine();
            float numOne = float.Parse(inputOneStr);

            Console.WriteLine("\nWhat is the second number?\n");
            string inputTwoStr = Console.ReadLine();
            float numTwo = float.Parse(inputTwoStr);

            _calcRepo.SubtractTwoNumbers(numOne, numTwo);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            RunMenu();
        }

        public void Multiply()
        {
            Console.WriteLine("\nWhat is your first number?\n");
            string inputOneStr = Console.ReadLine();
            float numOne = float.Parse(inputOneStr);

            Console.WriteLine("\nWhat is the second number?\n");
            string inputTwoStr = Console.ReadLine();
            float numTwo = float.Parse(inputTwoStr);

            _calcRepo.MultiplyTwoNumbers(numOne, numTwo);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            RunMenu();
        }

        public void Divide()
        {
            Console.WriteLine("\nWhat is your first number?\n");
            string inputOneStr = Console.ReadLine();
            float numOne = float.Parse(inputOneStr);

            Console.WriteLine("\nWhat is the second number?\n");
            string inputTwoStr = Console.ReadLine();
            float numTwo = float.Parse(inputTwoStr);

            _calcRepo.DivideTwoNumbers(numOne, numTwo);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            RunMenu();
        }

        public void Modulo()
        {
            Console.WriteLine("\nWhat is your first number?\n");
            string inputOneStr = Console.ReadLine();
            float numOne = float.Parse(inputOneStr);

            Console.WriteLine("\nWhat is the second number?\n");
            string inputTwoStr = Console.ReadLine();
            float numTwo = float.Parse(inputTwoStr);

            _calcRepo.ModuloTwoNumbers(numOne, numTwo);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            RunMenu();
        }
    }
}
