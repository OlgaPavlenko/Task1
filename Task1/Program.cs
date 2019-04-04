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

            //HT1_1();
            //HT1_2();
            //HT1_3();
            //HT1_4();
            //HT1_5();
            //HT1_6();
            HT1_7();

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
        public static void HT1_3()
        {
            var v1 = 'v';
            v1 = 'n';
            Console.WriteLine(v1);

        }

        public static void HT1_4()
        {
            Console.WriteLine("Enter the lenght of square: ");
            int lengthSquare = Convert.ToInt32(Console.ReadLine());
            double p = 4 * lengthSquare;
            Console.WriteLine($"Perimetr is: {p} ");
        }

        public static void HT1_5()
        {
            Console.WriteLine("Enter the radius of first circle: ");
            double radius1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the radius of second circle: ");
            double radius2 = Convert.ToDouble(Console.ReadLine());

            const double Pi = 3.14;
            double s1 = Pi * radius1 * radius1;
            double s2 = Pi * radius2 * radius2;
            double s3 = s1 - s2;
            Console.WriteLine($"S1: {s1},  S2: {s2},  S3: {s3}");
        }

        public static void HT1_6()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int dicker = number / 10;
            int unit = number % 10;

            Console.WriteLine($"The nuber consist of {dicker} dickers and {unit} units");
        }

        public static void HT1_7()
        {
            int number1 = 213546;
            int number2 = 22230;
            long number3 = number1 + number2;
            Console.WriteLine(number3);
        }
    }
}
