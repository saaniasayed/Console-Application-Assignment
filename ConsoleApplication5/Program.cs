using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to convert temperatures from Celsius to Fahrenheit. */

            float celsius, fahrenheit;

            Console.WriteLine("Please Enter The Temperature in Celcuis: ");
            celsius = float.Parse(Console.ReadLine());

            fahrenheit = ((celsius * 9) / 5) + 32;

            Console.WriteLine("The Temperature in Fahrenheit is: " + fahrenheit);

        }


    }
}
