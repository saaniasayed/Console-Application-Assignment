using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write A C# program that will read three types of scores (quiz score, mid-term score and final score)
            and determine the grade based on the following rules:
            - if the average score = 90% : then display grade-A
            - if the average score >= 70% and <90% : then display grade-B
            - if the average score >= 50% and <70% : then display grade-C
            - if the average score < 50% : then display grade-F */

            float quizScore, midTermScore, FinalScore, averageScore;

            Console.WriteLine("Please Enter Your Quiz Score: ");
            quizScore = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Your Mid Term Score: ");
            midTermScore = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Your Final Score: ");
            FinalScore = float.Parse(Console.ReadLine());

            averageScore = (quizScore + midTermScore + FinalScore) / 3;

            if (averageScore >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (averageScore >= 70 && averageScore < 90)
            {
                Console.WriteLine("Grade B");
            }
            else if (averageScore >= 50 && averageScore < 70)
            {
                Console.WriteLine("Grade C");
            }
            else if (averageScore < 50)
            {
                Console.WriteLine("Grade F");
            }
        }
    }
}
