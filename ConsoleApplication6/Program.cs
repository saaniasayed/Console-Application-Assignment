using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to detect key presses.
            If the user pressed number keys (from 0 to 9), the program will display the number that is pressed,
            otherwise the program will show "Not allowed" */

            char key;
            Console.WriteLine("Please Press A Key: ");
            key = char.Parse(Console.ReadLine());

            switch(key)
            {
                case '0': Console.WriteLine("You Pressed 0 Key");
                    break;
                case '1': Console.WriteLine("You Pressed 1 Key");
                    break;
                case '2': Console.WriteLine("You Pressed 2 Key");
                    break;
                case '3': Console.WriteLine("You Pressed 3 Key");
                    break;
                case '4': Console.WriteLine("You Pressed 4 Key");
                    break;
                case '5': Console.WriteLine("You Pressed 5 Key");
                    break;
                case '6': Console.WriteLine("You Pressed 6 Key");
                    break;
                case '7': Console.WriteLine("You Pressed 7 Key");
                    break;
                case '8': Console.WriteLine("You Pressed 8 Key");
                    break;
                case '9': Console.WriteLine("You Pressed 9 Key");
                    break;
                default: Console.WriteLine("Not Allowed");
                    break;
            }
        }
    }
}
