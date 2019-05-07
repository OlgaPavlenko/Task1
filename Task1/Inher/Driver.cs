using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Inher
{
    class Driver : Worker
    {
        private int stage;
        private Category category;

        public int Stage
        {
            get
            {
                return stage;
            }
            set
            {
                stage = value;
            }
        }

        public Driver(int stage, Category category, string name, int age, decimal salary)
            : base(name, age, salary)
        {
            Stage = stage;
            this.category = category;

        }
    }

    public enum Category
    {
        A,
        B,
        C
    }
}
