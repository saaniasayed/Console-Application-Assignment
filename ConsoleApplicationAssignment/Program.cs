using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write C# code to declare a variable to store the age of a person.
            Then the output of the program is as an example shown below:
            You are 20 years old.*/
            
            Console.WriteLine("Please Enter Your Age!");
            var age = Console.ReadLine();
            Console.WriteLine("You are " + age + " years old");
        }
    }
}
