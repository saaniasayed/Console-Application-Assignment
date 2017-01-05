using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to determine the ordinal of a number and display it on the screen.
             For Example: 1st, 2nd, 3rd. */

            Console.WriteLine("Please Enter A Number: ");
            int num = int.Parse(Console.ReadLine());

            int ordinal = num % 10;

            switch (ordinal)
            {
                case 1: Console.WriteLine("That's the " + num + "st number");
                    break;
                case 2: Console.WriteLine("That's the " + num + "nd number");
                    break;
                case 3: Console.WriteLine("That's the " + num + "rd number");
                    break;
                default: Console.WriteLine("That's the " + num + "th number");
                    break;
            }
        }
    }
}
