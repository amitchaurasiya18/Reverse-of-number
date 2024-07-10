using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to reverse : ");
            int inputNumber = int.Parse(Console.ReadLine());

            int copyOfNumber = inputNumber;
            int reversedNumber = 0;
            int remainder;

            while (inputNumber > 0)
            {
                remainder = inputNumber % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                inputNumber = inputNumber / 10;
            }

            Console.WriteLine("Original Number : " + copyOfNumber);
            Console.WriteLine("Reversed Number : " + reversedNumber);
        }
    }
}

