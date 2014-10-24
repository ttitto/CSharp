namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InfestationSpores : Supplement
    {
        public InfestationSpores(int powerEffect = -1, int healthEffect = 0, int aggressionEffect = 20)
            : base(powerEffect, healthEffect, aggressionEffect)
        {

        }
    }
}