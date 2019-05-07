using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Worker
    {
        public string Name { get; set; }
        private int age;
        public decimal Salary { get; set; }

        public int Age
        {
            get
            {
                    return age;
            }
            set
            {
                if (age > 0 || age < 100)
                {
                    age = value;
                }
            }
        }

        public Worker(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
