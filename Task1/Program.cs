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
            UnpackingArray();
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
    }
}

