namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Marine : Human
    {
        public Marine(string id)
            : base(id)
        {
            this.AddSupplement(new WeaponrySkill());
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            var optimalUnits = from unit in attackableUnits
                               where unit.Power <= this.Aggression
                               orderby unit.Health descending
                               select unit;

            return optimalUnits.FirstOrDefault();
        }
    }
}