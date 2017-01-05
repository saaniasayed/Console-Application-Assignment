using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program that prompts the user to input three integer values 
            and find the greatest value of the three values. */

            int num1 = 0, num2 = 0, num3 = 0;

            Console.WriteLine("Please Enter Any 3 Numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if((num1>num2)&&(num1>num3))
            {
                Console.WriteLine(num1 + " is the greatest!");
            }
            else if ((num2 > num3))
            {
                Console.WriteLine(num2 + " is the greatest!");
            }
            else
            {
                Console.WriteLine(num3 + " is the greatest!");
            }

        }
    }
}
