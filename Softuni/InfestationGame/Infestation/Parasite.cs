namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Parasite : Unit
    {
        public Parasite(string id)
            : base(id, UnitClassification.Biological, 1, 1, 1)
        {
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            var optimalUnit = from unit in attackableUnits
                              where unit.Equals(this)
                              orderby unit.Health
                              select unit;

            return optimalUnit.FirstOrDefault();
        }
    }
}