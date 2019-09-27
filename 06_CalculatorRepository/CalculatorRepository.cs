using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_CalculatorRepository
{
    public class CalculatorRepository
    {
        public float SumTwoNumbers(float numOne, float numTwo)
        {
            float num = numOne + numTwo;
            Console.WriteLine("\n" + $"{numOne} + {numTwo} = {num}");
            return num;
        }

        public float SubtractTwoNumbers(float numOne, float numTwo)
        {
            float num = numOne - numTwo;
            Console.WriteLine("\n" + $"{numOne} - {numTwo} = {num}");
            return num;
        }

        public float MultiplyTwoNumbers(float numOne, float numTwo)
        {
            float num = numOne * numTwo;
            Console.WriteLine("\n" + $"{numOne} x {numTwo} = {num}");
            return num;
        }

        public float DivideTwoNumbers(float numOne, float numTwo)
        {
            float num = numOne / numTwo;
            Console.WriteLine("\n" + $"{numOne} / {numTwo} = {num}");
            return num;
        }

        public float ModuloTwoNumbers(float numOne, float numTwo)
        {
            float num = numOne % numTwo;
            Console.WriteLine("\n" + $"{numOne} % {numTwo} = {num}");
            return num;
        }
    }
}
