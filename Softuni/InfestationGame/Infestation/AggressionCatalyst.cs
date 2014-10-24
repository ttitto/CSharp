namespace Infestation
{
    public class AggressionCatalyst : Catalyst
    {
        public AggressionCatalyst(int powerEffect = 0, int healthEffect = 0, int aggressionEffect = 3)
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            base.ReactTo(otherSupplement);
        }
    }
}