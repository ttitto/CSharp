using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string fName, string lName, string studentNumber, float averageGrade, int age = 0)
            : base(fName, lName, studentNumber, averageGrade, age) { }
    }
}
