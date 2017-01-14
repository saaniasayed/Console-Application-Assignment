using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Reverse Array
            Create a program to ask the user for 5 numbers, store them in an array and show them in
            reverse order. */

            Console.WriteLine("Enter Any 5 Numbers: ");

            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Reversal of Array");
            Console.WriteLine("*****************");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }


            

        }
    }
}
