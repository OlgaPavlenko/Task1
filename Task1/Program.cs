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
            //MaxNumber();
            //Factorial();
            //WorkWithNumber();
            //Delivery();
            //Average();
            //WithoutMulti();
            //Squares();
            //Reverse();
            //NumberParse();
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

        public static void BetweenAB()
        {
            Console.WriteLine("Enter number A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number B, B > A:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a < b)
            {
                for (int i = ++a; i < b; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of numbers between A and B is: {sum}");

                for (int i = ++a; i < b; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine($"Odds: {i}");
                    }
                }
            }
            else
            {
                Console.WriteLine("B shoud be more than A!");
            }
        }

        public static void NaturalNumber()
        {
            Console.WriteLine("Enter naturale number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int forEvenNumber = 0;
            int count = 0;
            while (number > 0)
            {
                forEvenNumber = number % 10;
                if (forEvenNumber % 2 == 0)
                {
                    count++;
                }
                number /= 10;
            }
            Console.WriteLine($"The number of even number is: {count}");
        }

        public static void Extent()
        {
            Console.WriteLine("Enter naturale number:");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter extent of number:");
            int extent = Convert.ToInt32(Console.ReadLine());
            double res = 1;
            if (extent > 0)
            {
                for (int i = 1; i <= extent; i++)
                {
                    res *= number;
                }
            }
            else if (extent < 0)
            {
                res = 1 / (number * number);
            }
            Console.WriteLine(res);
        }


        static void Factorial()
        {
            Console.WriteLine("Enter a number for calculate factorial:");
            int fakt0rial = Convert.ToInt32(Console.ReadLine());

            if (fakt0rial == 0)
            {
                Console.WriteLine("Factorial 0 = 1");
            }
            else
            {
                for (int i = fakt0rial - 1; i > 1; i--)
                {
                    fakt0rial *= i;
                }
                Console.WriteLine($"Factorial {fakt0rial}");
            }
            Console.Read();
        }

        static void WorkWithNumber()
        {
            Console.WriteLine("Enter the number you want to check: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] numbersForDevide = { 2, 5, 3, 6, 9 };
            int counter = 0;
            bool check = true;
            if (number > 0)
            {
                Console.WriteLine("number is positive");

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        counter++;
                    }
                    if (counter > 2)
                    {
                        check = false;
                        continue;
                    }
                }
                if (check == true)
                {
                    Console.WriteLine("Number is prime");
                }
                else
                {
                    Console.WriteLine("Number isn't prime");
                }
                for (int k = 0; k < numbersForDevide.Length; k++)
                {
                    if (number % numbersForDevide[k] == 0)
                    {
                        Console.WriteLine($"Number number is devided by: {numbersForDevide[k]}");
                    }
                }
            }
            if (number < 0)
            {
                Console.WriteLine("number is negative");
            }
            if (number == 0)
            {
                Console.WriteLine("You entered 0");
            }

        }

        public static void Delivery()
        {
            Console.WriteLine("Enter number of clients you want to deliver goods: ");
            int numberOfClients = Convert.ToInt32(Console.ReadLine());
            if (numberOfClients <= 0)
            {
                Console.WriteLine("you haven't clients");
                return;
            }
            int i = 1;
            long fNumberOfClients = 1;
            do
            {
                fNumberOfClients *= i;
                i++;
            }
            while (i <= numberOfClients);
            Console.WriteLine($"There are {fNumberOfClients} possible routes");
        }

        public static void Average()
        {
            Console.WriteLine("Enter number min number of range: ");
            int minNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number max number of range: ");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            double avarage = 0;

            for (int i = minNumber; i <= maxNumber; i++)
            {
                sum += i;
                counter++;
            }
            avarage = sum / counter;
            Console.WriteLine($"Avarage of range is: {avarage}");
        }

        public static void WithoutMulti()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int multi = 0;

            if (secondNumber < 0)
            {
                secondNumber = -secondNumber;

                for (int i = 0; i < secondNumber; i++)
                {
                    multi += firstNumber;
                }
                Console.WriteLine(-multi);
            }
            else
            {
                for (int i = 0; i < secondNumber; i++)
                {
                    multi += firstNumber;
                }
                Console.WriteLine(multi);
            }
        }

        public static void Squares()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int square = 1;

            for (int i = 1; i < number; i++)
            {
                square = i * i;
                if (square <= number)
                {
                    Console.WriteLine(square);
                }
            }
        }

        public static void Reverse()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int renumber = 0;

            while (number > 0)
            {
                renumber *= 10;
                renumber += number % 10;
                number /= 10;
            }
            Console.Write($"New number is: {renumber} \n");
        }

        public static void NumberParse()
        {
            Console.WriteLine("Enter the number: ");
            string stringNumber = Console.ReadLine();
            int number = Convert.ToInt32(stringNumber);
            int[] numbers = new int[stringNumber.Length];
            int renumber = 0;

            for (int i = 0; i < stringNumber.Length; i++)
            {
                renumber = number % 10;
                number /= 10;
                numbers[i] = renumber;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void MaxNumber()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int renumber = 0;
            int max = 0;
            while (number > 0)
            {
                renumber = number % 10;
                number /= 10;
                if (max < renumber)
                {
                    max = renumber;
                }
            }
            Console.WriteLine($"Max number is: {max}");
        }

    }
}
