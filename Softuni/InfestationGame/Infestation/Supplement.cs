namespace Infestation
{
    public abstract class Supplement : ISupplement
    {
        private int powerEffect;
        private int healthEffect;
        private int aggressionEffect;

        public Supplement(int powerEffect = 0, int healthEffect = 0, int aggressionEffect = 0)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = aggressionEffect;
        }

        public int PowerEffect
        {
            get { return this.powerEffect; }
            protected set { this.powerEffect = value; }
        }

        public int HealthEffect
        {
            get { return this.healthEffect; }
            protected set { this.healthEffect = value; }
        }

        public int AggressionEffect
        {
            get { return this.aggressionEffect; }
            protected set { this.aggressionEffect = value; }
        }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
            this.AggressionEffect += otherSupplement.AggressionEffect;
            this.HealthEffect += otherSupplement.HealthEffect;
            this.PowerEffect += otherSupplement.PowerEffect;
        }
    }
}