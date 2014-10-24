namespace Infestation
{
    public abstract class Catalyst : Supplement
    {
        public Catalyst(int powerEffect = 0, int healthEffect = 0, int aggressionEffect = 0)
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }
    }
}