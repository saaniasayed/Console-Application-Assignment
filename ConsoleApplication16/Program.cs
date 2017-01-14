using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Recursive Palindrome:
            Create a recursive function to say whether a string is symmetric (a palindrome).
            For example, "RADAR" is a palindrome. */

            Console.WriteLine("Enter a string to check if its a palindrome: ");
            string str = Console.ReadLine();
            if (isPalindrome(str) == true)
            {
                Console.WriteLine("Given string is a palindrome");
            }
            else
            {
                Console.WriteLine("Given string is not a palindrome");
            }
        }

        public static bool isPalindrome(string str)
        {
            str = str.ToUpper();
            int end = str.Length - 1;
            for (int begin = 0; begin < end; begin++)
            {
                if (str[begin] != str[end])
                {
                    return false;
                }
                else
                {
                    end--;
                }
            }
            return true;
        }
    }
}
