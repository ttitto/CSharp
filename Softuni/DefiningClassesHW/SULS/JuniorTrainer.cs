using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string fName, string lName, int age = 0)
            : base(fName, lName, age) { }
    }
}
