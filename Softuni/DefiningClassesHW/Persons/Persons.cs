using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class PersonsClass
    {
        static void Main(string[] args)
        {           
                List<Person> persons=new List<Person>(){
                    new Person("Ivan", 45),
                    new Person("Mitko", 24, "alabala@dir.bg"),
                    new Person("Petko", 14, "alabala@.dir.bg"),
                };
                persons.ForEach(p=>Console.WriteLine(p.ToString()));
        }
    }
}
