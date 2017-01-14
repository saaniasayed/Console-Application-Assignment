using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Input several numbers and stop when user enters “end”
            Create a C# program which asks the user for several numbers (until he enters "end" and displays
            their sum). When the execution is going to end, it must display all the numbers entered, and
            the sum again, as follows:
            Enter a number: 5
            Sum = 5
            Enter a number: 3
            Sum = 8
            Enter a number: end
            The numbers are: 5 3
            The sum is: 8
             */

            int[] num = new int[1000];
            int sum = 0, intValue = 0;
            string inValue = "";

            Console.WriteLine("Enter Several Number and to Stop Type 'end'");

            Console.WriteLine("Enter a number: ");
            inValue = Console.ReadLine();

            while (inValue != "end")
            {
                intValue = int.Parse(inValue);
                sum += intValue;
                Console.WriteLine("Sum: {0}", sum);
                Console.WriteLine("Enter a number: ");
                inValue = Console.ReadLine();
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}

