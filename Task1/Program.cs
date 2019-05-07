using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Worker worker = new Worker("Ivan", 25, 1000);
            Worker worker2 = new Worker("Vasya", 26, 2000);

            Console.WriteLine(worker.Age + worker2.Age);
            Console.WriteLine(worker.Salary + worker2.Salary);
        }

        
    }
}
