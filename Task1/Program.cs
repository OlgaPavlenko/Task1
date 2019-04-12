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
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //BetweenAB();
            //NaturalNumber();
            //Extent();
            MaxNumber();
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
            if (number > 0 && number <= 14)
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

        public static void Task7()
        {
            Console.WriteLine("What word do you want to translate? зима, весна, лето, осень, снег, дождь, солнце, тучи, ветер, гроза");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "зима":
                    Console.WriteLine("зима - winter");
                    break;
                case "весна":
                    Console.WriteLine("весна - spring");
                    break;
                case "лето":
                    Console.WriteLine("лето - summer");
                    break;
                case "осень":
                    Console.WriteLine("осень - autumn");
                    break;
                case "снег":
                    Console.WriteLine("снег - snow");
                    break;
                case "дождь":
                    Console.WriteLine("дождь - rain");
                    break;
                case "солнце":
                    Console.WriteLine("солнце - sun");
                    break;
                case "тучи":
                    Console.WriteLine("тучи - clouds");
                    break;
                case "ветер":
                    Console.WriteLine("ветер - wind");
                    break;
                case "гроза":
                    Console.WriteLine("гроза - thunderstorm");
                    break;

                default:
                    Console.WriteLine("you shoud enter excisting word!");
                    break;
            }
        }

        public static void Task8()
        {
            Console.WriteLine("Enter long service: ");
            double longService = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            if (longService > 0 && longService < 5)
            {
                double premium = salary * 0.1;
                Console.WriteLine($"Salary is: {salary} long service is: {longService} premium is: {premium} total: {salary + premium}");
            }
            if (longService > 4 && longService < 10)
            {
                double premium = salary * 0.15;
                Console.WriteLine($"Salary is: {salary} long service is: {longService} premium is: {premium} total: {salary + premium}");
            }
            if (longService > 9 && longService < 16)
            {
                double premium = salary * 0.25;
                Console.WriteLine($"Salary is: {salary} long service is: {longService} premium is: {premium} total: {salary + premium}");
            }
            if (longService > 15 && longService < 21)
            {
                double premium = salary * 0.35;
                Console.WriteLine($"Salary is: {salary} long service is: {longService} premium is: {premium} total: {salary + premium}");
            }
            if (longService > 20 && longService < 26)
            {
                double premium = salary * 0.45;
                Console.WriteLine($"Salary is: {salary} long service is: {longService} premium is: {premium} total: {salary + premium}");
            }
            if (longService > 25)
            {
                double premium = salary * 0.5;
                Console.WriteLine($"Salary is: {salary} long service is: {longService} premium is: {premium} total: {salary + premium}");
            }
        }

        public static void Task9()
        {
            while (true)
            {
                Console.WriteLine("Enter first number");
                if (!Int32.TryParse(Console.ReadLine(), out int firstNumber))
                {
                    Console.WriteLine("yOU ENTERED INCORRECt value!");
                    continue;
                }
                
                Console.WriteLine("Enter second number");
                if (!Int32.TryParse(Console.ReadLine(), out int secondNumber))
                {
                    Console.WriteLine("yOU ENTERED INCORRECt value!");
                    continue;
                }

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
                    default:
                        Console.WriteLine("Entered incorrect operation!");
                        continue;
                }
                Console.WriteLine("If you want break enter E");
                string choiseExit = Console.ReadLine();
                if (choiseExit == "E")
                {
                    break;
                }

            }
        }

       