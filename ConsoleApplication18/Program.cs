using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            /* IsInteger
            Create a function that tells if a string is an integer number. It should be used like this:
            if (IsNumber ("1234"))
            System.Console.WriteLine ("It is a numerical value"); */

            Console.WriteLine("Enter a number to check if its an integer number: ");
            string str = Console.ReadLine();
            if (isNumber(str) == true)
            {
                Console.WriteLine("It is a numerical value.");
            }
            else
            {
                Console.WriteLine("It is not a numerical value");
            }
        }

        public static bool isNumber(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] < '0') || (text[i] > '9'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
