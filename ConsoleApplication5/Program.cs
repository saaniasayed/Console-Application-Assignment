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

            Console.WriteLine("Please Enter The Temperature in Celcuis: ");
            float celsius = float.Parse(Console.ReadLine());

            float fahrenheit = ((celsius * 9) / 5) + 32;

            Console.WriteLine("The Temperature in Fahrenheit is: " + fahrenheit);

        }


    }
}
