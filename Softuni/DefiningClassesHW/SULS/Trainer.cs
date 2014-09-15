using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    public abstract class Trainer : Person
    {
        public Trainer(string fName, string lName, int age = 0) : base(fName, lName, age) { }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course {0} created", courseName);
        }
    }
}
