namespace GenericList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenericListClass
    {
        public static void Main()
        {
            Student pesho = new Student("pesho", 9876);
            Student misho = new Student("misho", 8765);
            Student gosho = new Student("gosho", 7654);
            Student dimo = new Student("dimo", 6543);
            Student bobo = new Student("bobo", 5432);
            Student dancho = new Student("dancho", 4321);

            GenericList<Student> students = new GenericList<Student>();

            students.Add(pesho);
            students.Add(misho);

            Console.WriteLine(students);

            Console.WriteLine(students[1]);
            Console.WriteLine(students.Size);
            Console.WriteLine(students.Capacity);


        }
    }
}
