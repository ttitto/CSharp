namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestAnimals
    {
        public static void Main()
        {
            Animal jaba = new Frog("baba jaba", 1, Genders.Female);
            Animal kekerica = new Frog("kekerica", 3, Genders.Female);

            Animal sharo = new Dog("sharo", 3, Genders.Male);
            Animal sara = new Dog("sara", 2, Genders.Female);
            Animal oldy = new Dog("oldy", 12, Genders.Male);

            Animal puhi = new Kitten("puhi", 2);
            Animal tommy = new Tomcat("tommy", 4);
            Animal mouseKiller = new Cat("mousy", 5, Genders.Male);

            List<Animal> animals = new List<Animal>()
            {
                jaba, 
                kekerica,
                sharo,
                sara,
                puhi,
                tommy,
                mouseKiller,
                oldy
            };
            var groupedAnimals = from animal in animals
                                 group animal by animal.GetType().Name into g
                                 select new { GroupName = g.Key, AverageAge = g.ToList().Average(an => an.Age) };
            foreach (var animal in groupedAnimals)
            {
                Console.WriteLine("{0} - average age: {1:N2}", animal.GroupName, animal.AverageAge);
            }

            puhi.ProduceSound();
            oldy.ProduceSound();
            jaba.ProduceSound();
        }
    }
}