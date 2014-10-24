namespace Infestation
{
    public class PowerCatalyst : Catalyst
    {
        public PowerCatalyst(int powerEffect = 3, int healthEffect = 0, int aggressionEffect = 0)
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            throw new System.NotImplementedException();
        }
    }
}