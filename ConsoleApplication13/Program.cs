using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Two Dimensional Array:
            Write a C# program to ask the user for marks for 20 pupils (2 groups of 10, using a
            two-dimensional array), and display the average for each group. */


            float[,] pupils = new float[10, 10];
            float sum = 0.0f, average = 0.0f;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter Marks of Pupils {0} of Group {1}: ", j + 1, i + 1);
                    pupils[i, j] = Convert.ToSingle(Console.ReadLine());
                    sum = sum + pupils[i, j];
                }
                average = sum/2;
                Console.WriteLine("The Average of Pupil is: {0}", average);
            }
        }
    }
}