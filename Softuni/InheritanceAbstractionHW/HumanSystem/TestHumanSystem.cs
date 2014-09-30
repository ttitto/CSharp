namespace HumanSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestHumanSystem
    {
        public static void Main()
        {
            Student pesho = new Student("pesho", "petrov", "20144567");
            Student gosho = new Student("gosho", "georgiev", "20141730");
            Student misho = new Student("misho", "mishev", "20142589");
            Student ganka = new Student("ganka", "gancheva", "20146547");
            Student sanya = new Student("sanya", "mincheva", "20145285");
            Student ivan = new Student("ivan", "ivanov", "20145687");
            Student dimitar = new Student("dimitar", "dimitrov", "20143698");
            Student damyan = new Student("damyan", "damyanov", "20149634");
            Student mihail = new Student("mihail", "petrov", "20147415");
            Student doncho = new Student("doncho", "donchev", "20145612");

            List<Student> students = new List<Student>()
            {
                pesho,
                gosho,
                misho,
                ganka,
                sanya,
                ivan,
                dimitar, 
                damyan,
                mihail,
                doncho
            };

            Worker kosta = new Worker("kosta", "kostadinov", 282m, 8f);
            Worker sancho = new Worker("sancho", "pansa", 382m, 6.5f);
            Worker penka = new Worker("penka", "kostadinova", 243m, 4.75f);
            Worker dimitrichka = new Worker("dimitrichka", "doynova", 152m, 2.75f);
            Worker darina = new Worker("darina", "stamatova", 182m, 5.5f);
            Worker zlatomir = new Worker("zlatomir", "zlatev", 242m, 7.5f);
            Worker petar = new Worker("petar", "donchev", 482m, 6f);
            Worker pencho = new Worker("pencho", "kubadinski", 578m, 9f);
            Worker marko = new Worker("marko", "totev", 439m, 8f);
            Worker kostadin = new Worker("kostadin", "haralambov", 658m, 9f);

            List<Worker> workers = new List<Worker>()
            {
                kosta,
                sancho,
                penka,
                dimitrichka,
                darina,
                zlatomir,
                petar,
                pencho,
                marko,
                kostadin
            };

            Console.WriteLine("Sorted Students:");
            var sortedStudents = students.OrderBy(st => st.FacultyNumber);
            foreach (var stud in sortedStudents)
            {
                Console.WriteLine(stud);
            }

            Console.WriteLine("\nSorted Workers: ");
            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour(5));
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker + string.Format(", hourly rate: {0:N2}", worker.MoneyPerHour(5)));
            }

            Console.WriteLine("\nSorted Humans: ");
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var sortedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}