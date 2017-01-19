namespace NullObjectsPattern
{
    using System;

    internal class SoldArticle
    {
        public IWarranty MoneyBackGuarantee { get; private set; }
        public IWarranty ExpressWarranty { get; private set; }
        public IWarranty NotOperationalWarranty { get; }
        private IWarranty FailedCircuitryWarranty { get; set; }
        private Part Circuitry { get; set; }
        private IWarranty CircuitryWarranty { get; set; }

        public SoldArticle(IWarranty moneyBack, IWarranty express)
        {
            if (null == moneyBack)
            {
                throw new ArgumentNullException(nameof(moneyBack));
            }

            if (null == express)
            {
                throw new ArgumentNullException(nameof(express));
            }

            this.MoneyBackGuarantee = moneyBack;
            this.ExpressWarranty = VoidWarranty.Instance;
            this.NotOperationalWarranty = express;
            this.CircuitryWarranty = VoidWarranty.Instance;
        }

        public void VisibleDamage()
        {
            this.MoneyBackGuarantee = VoidWarranty.Instance;
        }

        public void NotOperational()
        {
            this.MoneyBackGuarantee = VoidWarranty.Instance;
            this.ExpressWarranty = this.NotOperationalWarranty;
        }

        public void InstallCircuitry(Part circuitry, IWarranty extendedWarranty)
        {
            this.Circuitry = circuitry;
            this.FailedCircuitryWarranty = extendedWarranty;
        }

        public void CircuitryNotOperational(DateTime detectedOn)
        {
            this.Circuitry.MarkDefective(detectedOn);
            this.CircuitryWarranty = this.FailedCircuitryWarranty;
        }

        public void ClaimCircuitryWarranty(Action onValidClaim)
        {
            this.CircuitryWarranty.Claim(this.Circuitry.DefectDetectedOn, onValidClaim);
        }
    }
}
