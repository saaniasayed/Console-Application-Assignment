using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write C# code to prompt a user to enter an integer value.
            The value is stored in a variable called a. 
            Then the program will show the output as seen below:
            The value of a is 10.
            ................................
            The value of ++a is 11.
            The value of a is 11.
            The value of a++ is 11.
            The value of a is 12.
            The value of --a is 11.
            The value of a is 11.
            The value of a-- is 11.
            The value of a is 10.
             */

            int a;

            Console.WriteLine("Please Enter A Value: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("The value of a is " + a);
            Console.WriteLine("................................");
            Console.WriteLine("The value of ++a is " + (++a));
            Console.WriteLine("The value of a is " + a);
            Console.WriteLine("The value of a++ is " + (a++));
            Console.WriteLine("The value of a is " + a);
            Console.WriteLine("The value of --a is " + (--a));
            Console.WriteLine("The value of a is " + a);
            Console.WriteLine("The value of a-- is " + (a--));
            Console.WriteLine("The value of a is " + a);
        }
    }
}
