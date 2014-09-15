using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string fName, string lName, int age = 0)
            : base(fName, lName, age) { }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("Course {0} deleted", courseName);
        }
    }
}
