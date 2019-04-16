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
            //Console.WriteLine("Add Radius");

            //string radiusString = Console.ReadLine();
            //int.TryParse(radiusString, out int radius);

            //Console.WriteLine($"The square of the round {Program.PerformCalculation(15)}");
            //UnpackingArray();
            Goods();
            Console.ReadKey();
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;

            decimal square = Pi * r * r;

            return square;
        }

        public static void UnpackingArray()
        {
            int[] array = {0, 2, 3, 5, 6 };
            string[] resArray = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i]; j++)
                {
                    string nuls = string.Empty;
                    string ones = string.Empty;

                    if (array[0] == 0 && i == 0)
                    {
                        continue;
                    }
                    {
                        if (i % 2 == 0)
                        {
                            nuls += "0";
                            Console.Write(nuls);
                            continue;
                        }

                        if (i % 2 != 0)
                        {
                                ones += "1";
                                Console.Write(ones);
                                continue;
                        }
                    }
                }
            }
        }

        public static void Goods()
        {
            string[] goods = { "pears", "apples", "cucumbers", "tomatoes", "dill", "parsley", "chicken", "cheese", "butter", "milk" };
            decimal[] prices = { 40.50M, 31.20M, 21.80M, 35M, 150M, 145M, 200M, 400M, 81.40M, 53.35M};
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            


            for (int i = 0; i < goods.Length; i++)
            {
                    Console.WriteLine("{0} {1} - {2}", numbers[i], goods[i], prices[i] + "uah");
            }

           // Console.WriteLine("Choose number of good that you want to buy (from 1 to 10):");
            //string choise = Console.ReadLine();
            //Console.WriteLine("Enter quantity that you want:");
            //double price = Convert.ToDouble(Console.ReadLine());

           
        }
    }
}

