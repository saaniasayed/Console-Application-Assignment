using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# Program to implement the Foobar game. */

            Console.WriteLine("How many items do you want to see? ");
            int items = int.Parse(Console.ReadLine());

            int i = 1;

            Console.WriteLine("Foobar Game");
            Console.WriteLine("***********");
            while (i <= items)
            {
                if (((i % 5) == 0) && ((i % 3) == 0))
                {
                    Console.Write("foobar \n");
                }
                else if ((i % 3) == 0)
                {
                    Console.Write("foo \n");
                }
                else if ((i % 5) == 0)
                {
                    Console.Write("bar \n");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
