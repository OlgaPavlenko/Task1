﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Add Radius");

             string radiusString = Console.ReadLine();
             int.TryParse(radiusString, out int radius);

             Console.WriteLine($"The square of the round {Program.PerformCalculation(15)}");*/

            //HT1_1();
            HT1_2();
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;

            decimal square = Pi * r * r;

            return square;
        }

        public static void HT1_1()
        {
            int x1 = 5;
            Console.WriteLine(x1);
        }

        public static void HT1_2()
        {
            Console.WriteLine("Enter your name: ");
            string str1 = Console.ReadLine();
            string str2 = "Hi, " + str1;
            Console.WriteLine(str2);

        }
    }
}
