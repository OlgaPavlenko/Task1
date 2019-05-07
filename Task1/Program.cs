using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Inher;

namespace Task1.Inher
{
    class Program
    {
        static void Main()
        {
            //Employee worker = new Employee("Ivan", 25, 1000);
            //Employee worker2 = new Employee("Vasya", 26, 2000);

            //Console.WriteLine(worker.Age + worker2.Age);
            //Console.WriteLine(worker.Salary + worker2.Salary);

            Driver driver = new Driver(12, Category.A, "Ivan", 25, 1000);
            Console.WriteLine(driver.Stage);
        }

        
    }
}
