﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Max in Array:
             Create a function which returns the greatest value stored in an array of real
            numbers which is specified as parameter:
            float[] data = {1.5f, 0.7f, 8.0f};
            float max = Maximum(data); */

            float[] data = { 1.5f, 0.7f, 8.0f };
            float max = Maximum(data);
            Console.WriteLine("The Greatest Value in the array of real numbers is: " + max);
        }

        static float Maximum(float[] list)
        {
            float max = -99999999.00f;
            for (int i = 0; i < list.Length; i++)
            {
                if (i == 0)
                {
                    max = list[i];
                }
                else
                {
                    //max = max < list[i] ? list[i] : max;
                    if (max < list[i])
                    {
                        max = list[i];
                    }
                }
            }
            return max;
        }
    }
}
