namespace Infestation
{
    public class HealthCatalyst : Catalyst
    {
        public HealthCatalyst(int powerEffect = 0, int healthEffect = 3, int aggressionEffect = 0)
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            throw new System.NotImplementedException();
        }
    }
}