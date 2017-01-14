using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Palindrome String: 
            Write a C# program to check if a string user entered is palindrome or not. */

            string reverse = "";

            Console.WriteLine("Enter String to Check if its a Palindrome: ");
            string str = Console.ReadLine();
            
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                reverse += str[i].ToString();
            }
            
            if (reverse == str) 
            {
                Console.WriteLine("The String is a Palindrome. \nEntered String Was {0} and reverse string is {1}.", str, reverse);
            }
            else
            {
                Console.WriteLine("The String is not a Palindrome. \nEntered String Was {0} and reverse string is {1}.", str, reverse);
            }
        }
    }
}
