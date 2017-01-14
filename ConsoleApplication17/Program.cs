using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Factorial:
            The factorial of a number is expressed as follows:
            n! = n · (n-1) · (n-2) · (n-3) · ... · 3 · 2 · 1
            For example,
            6! = 6·5·4·3·2·1
            Create a recursive function to calculate the factorial of the number specified as parameter:
            Console.Write ( Factorial (6) );
            would display 720. */

            Console.WriteLine("Enter Any Number to Calculate The Factorial: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of number {0} is {1}", n, Factorial(n));
        }

        public static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return (number * Factorial(number - 1));
            }
        }
    }
}
