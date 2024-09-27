using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_01
{
    internal class swapNumbers
    {
        //Write a program to swap 2 numbers
        static void Main(string[] args)
        {
            // Prompt the user to enter the first number
            Console.Write("Enter first number to swap: ");
            // Read and convert the first number from the user input
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.Write("Enter second number to swap: ");
            // Read and Convert the second number from the user input
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Use a temporary variable to swap the numbers
            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Output - Swapped numbers: " + num1 + "," + num2);
            // Wait for a key press to prevent the console from closing immediately
            Console.ReadKey();
        }
    }
}
