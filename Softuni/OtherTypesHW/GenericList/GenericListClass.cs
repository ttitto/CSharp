namespace GenericList
{
    using System;

    public class GenericListClass
    {
        public static void Main()
        {
            // Version attibute display
            var customAttributes = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute), true);
            Console.WriteLine("This GenericList<T> class's version is {0}", customAttributes[0]);

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

            students.Add(gosho);
            students.Add(bobo);
            Console.WriteLine(students.Size);
            Console.WriteLine(students.Capacity);
            Console.WriteLine(students);

            students.Insert(dancho, 2);
            Console.WriteLine(students);

            students.Remove(3);
            Console.WriteLine(students);

            Console.WriteLine(students.IndexOf(gosho));
            Console.WriteLine(students.IndexOf(dancho));

            Console.WriteLine(students.Contains(gosho));
            Console.WriteLine(students.Contains(dancho));

            Console.WriteLine(students.Min<Student>());
            Console.WriteLine(students.Max<Student>());
        }
    }
}
