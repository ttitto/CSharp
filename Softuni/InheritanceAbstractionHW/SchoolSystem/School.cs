namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        public School(IList<SchoolClass> classes)
        {
            this.Classes = classes;
        }

        public IList<SchoolClass> Classes { get; set; }
    }
}