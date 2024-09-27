using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_01
{
    internal class datatypeString
    {
        static void Main(string[] args)
        {
            //Declare a variable of data type string with name empName
            string empName;
            // Assign the value "Pranisha" to the empName variable
            empName = "Pranisha";
            //print the value of empID with message
            Console.WriteLine($"Entered number is :- {empName}");
            //// Wait for the user to press a key before closing the console window
            Console.ReadKey();
        }
    }
}
