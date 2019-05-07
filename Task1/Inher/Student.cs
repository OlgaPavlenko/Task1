using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1.Inher
{
    class Student : User
    {
        private int stipendiya;
        private string course;

        public int Stipendiya
        {
            get
            {
                return stipendiya;
            }
            set
            {
                stipendiya = value;
            }
        }

        public string Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }
        public Student(int stipendiya, string course, string name, int age)
           : base(name, age)
        {
            Stipendiya = stipendiya;
            Course = course;
        }
    }
}
