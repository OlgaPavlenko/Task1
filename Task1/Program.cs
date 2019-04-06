using System;
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
            Task4();
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

    }
}
