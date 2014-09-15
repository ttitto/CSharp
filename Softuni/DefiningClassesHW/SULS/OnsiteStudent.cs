using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    class OnsiteStudent : CurrentStudent
    {
        private int visitsNumber;

        public int VisitsNumber
        {
            get { return visitsNumber; }
            set
            {
                if (value < 0) throw new ArgumentException("Visits number can not be negative!");
                visitsNumber = value;
            }
        }

        public OnsiteStudent(string fName, string lName, string studentNumber, float averageGrade, int age = 0, int visitsNumber = 0)
            : base(fName, lName, studentNumber, averageGrade, age)
        {
            this.VisitsNumber = visitsNumber;
        }
    }
}
