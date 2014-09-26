namespace StudentsClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestStudentsClass
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student(
                "Petar",
                "Petrov",
                23,
                "800014",
                "+359888456123",
                "alabala@dir.bg",
                2,
                "Plovdiv",
                new List<int>() { 2, 3, 4, 4, 6, 5, 6, 6 }));

            students.Add(new Student(
                "Emil",
                "Emilov",
                33,
                "850014",
                "+359 2555623",
                "alabala@abv.bg",
                1,
                "Plovdiv",
                new List<int>() { 6, 6, 6, 6, 6, 5, 6, 6 }));

            students.Add(new Student(
                "Zdravko",
                "Ivanov",
                17,
                "734015",
                "+35942456123",
                "zizo@dir.bg",
                2,
                "Sofia",
                new List<int>() { 2, 3, 4, 6, 6, 4, 5, 5, 5, 3, 2 }));

            students.Add(new Student(
                "Dinko",
                "Dinev",
                26,
                "023016",
                "+359888457873",
                "didi@softuni.bg",
                1,
                "Sofia",
                null));

            students.Add(new Student(
                "Samuil",
                "Asparuhov",
                19,
                "800014",
                "+359888456123",
                "alabala@dir.bg",
                2,
                "Sofia",
                new List<int>() { 2, 3, 4, 4, 6, 5, 6, 6 }));

            students.Add(new Student(
                "Gosho",
                "Peshev",
                33,
                "851014",
                "+359888555623",
                "alabala@abv.bg",
                1,
                "Ruse",
                new List<int>() { 6, 6, 6, 6, 6, 5, 6, 6 }));

            students.Add(new Student(
                "Damyan",
                "Damyanov",
                17,
                "734115",
                "+35942456123",
                "zizo@dir.bg",
                2,
                "Ruse",
                new List<int>() { 2, 3, 4, 6, 6, 4, 5, 5, 5, 3, 2 }));

            students.Add(new Student(
                "Tsonko",
                "Gochev",
                26,
                "023116",
                "+359888457873",
                "didi@softuni.bg",
                1,
                "Ruse",
                new List<int>() { 2, 3, 4, 2, 2, 2, 5, 6, 6 }));

            students.ForEach(st => Console.WriteLine(st.ToString()));

            // Task 4 - Print all students from group number 2. Use a LINQ query. Order the students by FirstName.
            var group2byFName = from st in students
                                where st.GroupNumber == 2
                                orderby st.FirstName
                                select st;

            Console.WriteLine("\nStudents from group 2 ordered by First Name: ");
            foreach (var item in group2byFName)
            {
                Console.WriteLine(item.ToString());
            }

            // Task 5 - Print all students whose first name is before their last name alphabetically
            var firstNameBeforeLName = from st in students
                                       where st.FirstName.CompareTo(st.LastName) < 0
                                       select st;

            Console.WriteLine("\nStudents whose first name is before their last name alphabetically: ");
            foreach (var item in firstNameBeforeLName)
            {
                Console.WriteLine(item.ToString());
            }

            /* Task 6 - Write a LINQ query that finds the first name and last name of all students with
             * age between 18 and 24. The query should return only the first name, last name and age.*/
            var byAge = from st in students
                        where st.Age <= 24 && st.Age >= 18
                        select new { st.FirstName, st.LastName, st.Age };

            Console.WriteLine("\nStudents with age between 18 and 24 years: ");
            foreach (var item in byAge)
            {
                Console.WriteLine("{0} {1}, age: {2}", item.FirstName, item.LastName, item.Age);
            }

            /* Task 7 - Using the extension methods OrderBy() and ThenBy() with lambda expressions
             * sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.*/
            var sortedStudents = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            var sortedStudentsLINQ = from stud in students
                                     orderby stud.FirstName descending, stud.LastName descending
                                     select stud;

            Console.WriteLine("\nStudents sorted descending by names: ");
            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item.ToString());
            }

            // Task 8 - Print all students that have email @abv.bg. Use LINQ.
            var withAbvEmail = from stud in students
                               where stud.Email.Contains("@abv.bg")
                               select stud;

            Console.WriteLine("\nStudents with email in abv.bg: ");
            foreach (var item in withAbvEmail)
            {
                Console.WriteLine(item.ToString());
            }

            // Task 9 - Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.
            var withSofiaPhone = from st in students
                                 where st.Phone.StartsWith("02") ||
                                 st.Phone.StartsWith("+3592") ||
                                 st.Phone.StartsWith("+359 2")
                                 select st;

            Console.WriteLine("\nStudents with phone in Sofia: ");
            foreach (var item in withSofiaPhone)
            {
                Console.WriteLine(item.ToString());
            }

            /* Task 10 - Print all students that have at least one mark Excellent (6).
             * Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.*/
            var excellent = from st in students
                            where st.Marks.Contains(6)
                            select new { Fullname = st.FirstName + " " + st.LastName, Marks = st.Marks };

            Console.WriteLine("\nStudents with excellent marks: ");
            foreach (var item in excellent)
            {
                Console.WriteLine("{0} {{ {1} }}", item.Fullname, string.Join(", ", item.Marks));
            }

            /* Task 11 - Write a similar program to the previous one to extract the students 
             * with exactly two marks "2". Use extension methods.*/
            var twoTwos = students.Where(st => st.Marks.Where(m => m == 2).Count() == 2);

            Console.WriteLine("\nStudents with exactly two marks 2: ");
            foreach (var item in twoTwos)
            {
                Console.WriteLine(item.ToString());
            }

            /* Task 12 - Extract and print the Marks of the students that enrolled in 2014 
             * (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).*/
            var enrolled2014 = from st in students
                               where st.FacultyNumber.EndsWith("14")
                               select st;

            Console.WriteLine("\nStudents enrolled in 2014: ");
            foreach (var item in enrolled2014)
            {
                Console.WriteLine(item.ToString());
            }

            /* Task 13 - Add a GroupName property to Student. Write a program that extracts all students grouped by
             * GroupName and then prints them on the console. Print all group names along with the students in each group.
             * Use the "group by into" LINQ operator. */
            var groupedByGroupName = from st in students
                                     group st by st.GroupName into g
                                     select new { GroupName = g.Key, students = g.ToList() };

            Console.WriteLine("\nStudents grouped by GroupName: ");
            foreach (var item in groupedByGroupName)
            {
                Console.WriteLine(item.GroupName);
                Console.WriteLine("\t{0}", string.Join("\n\t", item.students));
            }

            /* Task 14 - Create a class StudentSpecialty that holds specialty name and faculty number. 
             * Create a list of student specialties that specifies for eachs student his specialty. 
             * Print all student names alphabetically along with their faculty number and specialty name. Use the "join" LINQ operator*/
            var specialties = new List<StudentSpecialty>() 
            { 
            new StudentSpecialty("Web Developer", "734015"),
            new StudentSpecialty("QA", "023016"),
            new StudentSpecialty("Web Developer", "800014"),
            new StudentSpecialty("QA", "850014"),
            new StudentSpecialty("Web Developer", "851014"),
            new StudentSpecialty("Java Developer", "023116"),
            new StudentSpecialty("Java Developer", "734115")
            };

            var studentSpecialty = from st in students
                                   join sp in specialties
                                   on st.FacultyNumber equals sp.FacultyNumber
                                   orderby st.FirstName
                                   select new
                                   {
                                       FullName = st.FirstName + " " + st.LastName,
                                       FacNum = st.FacultyNumber,
                                       Specialty = sp.SpecialtyName
                                   };

            Console.WriteLine("\nStudents with specialties: ");
            foreach (var item in studentSpecialty)
            {
                Console.WriteLine("{0,-20} - {1,-20} - {2}", item.FullName, item.Specialty, item.FacNum);
            }
        }
    }
}