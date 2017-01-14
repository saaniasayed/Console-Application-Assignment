using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Display Even Numbers:
            Write a C# program to ask the user for 10 integer numbers and display the even ones.*/

            int[] num = new int[10];
            
            Console.WriteLine("Enter Any 10 Numbers: ");
            
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Even Numbers are: ");

            for (int i = 0; i < num.Length; i++)
            {
                if ((num[i] % 2) == 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}
