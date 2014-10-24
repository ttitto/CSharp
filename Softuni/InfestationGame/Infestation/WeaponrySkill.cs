namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class WeaponrySkill : Supplement
    {
        public WeaponrySkill(int powerEffect = 0, int healthEffect = 0, int aggressionEffect = 0)
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
        }
    }
}