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

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            Task6();
            Console.ReadKey();
        }

        /* public static decimal PerformCalculation(int r)
         {
             const decimal Pi = 3.14m;

             decimal square = Pi * r * r;

             return square;
         }  */

        public static void Task1()
            {
               
                int sec = 8000;
                int hour = sec / 3600;
                Console.WriteLine(hour);
            }
        public static void Task2()
        {
            int a = 12;
            int b = 16;
            int c = 35;

            if ((a <= b && b <= c) && a < c)
            {
                Console.WriteLine("Number b between a and c");
            }
            else
                Console.WriteLine("Condition is false");
        }

        public static void Task3()
        {
            Console.WriteLine("Enter the number");
            string numberForLength = Console.ReadLine();
            int number = Convert.ToInt32(numberForLength);
            int lenght = numberForLength.Length;
            if (lenght == 3)
            {
                if (number % 2 != 0)
                    Console.WriteLine("number!");
                else
                    Console.WriteLine("Condition false");
            }
            else
                Console.WriteLine("Condition false");
        }

        public static void Task4()
        {
            int x = 10;
            int y = 12;
            int z = 3;

            x += y - x++ * z;
            Console.WriteLine(x);
            z = --x - y * 5;
            Console.WriteLine(z);
            y /= x + 5 % z;
            Console.WriteLine(y);
            z = x++ + y * 5;
            Console.WriteLine(z);
            x = y - x++ * z;
            Console.WriteLine(x);
        }

        public static void Task5()
        {
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want to do? /n If you want multiply enter * /n If you want add enter + /n If you want devide enter / /n If you want subtract enter - /n");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;
                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;
                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;
                case "/":
                    if (secondNumber == 0)
                        Console.WriteLine("You can't devide to 0!!!");
                    else
                        Console.WriteLine(firstNumber / secondNumber);
                    break;
            }
        }
            public static void Task6()
            {
            Console.WriteLine("Enter number between 0...100");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0 || number > 100)
                Console.WriteLine("Error! Enter number in correct range");
            if (number > 0 && number <=14)
                Console.WriteLine("number located between [0 - 14]");
            if (number > 15 && number <= 35)
                Console.WriteLine("number located between [15 - 35]");
            if (number > 36 && number < 50)
                Console.WriteLine("number located between [36 - 50]");
            if (number == 50)
                Console.WriteLine("number located between [36 - 50] and [50 - 100]");
            if (number > 51 && number <= 100)
                Console.WriteLine("number located between [50 - 100]");
        }
        
    }
}
