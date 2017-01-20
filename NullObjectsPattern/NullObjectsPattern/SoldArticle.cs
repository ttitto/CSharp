namespace NullObjectsPattern
{
    using System;
    using Common;

    internal class SoldArticle
    {
        public IWarranty MoneyBackGuarantee { get; private set; }
        public IWarranty ExpressWarranty { get; private set; }
        public IWarranty NotOperationalWarranty { get; }
        private IWarranty FailedCircuitryWarranty { get; set; }
        private Option<Part> Circuitry { get; set; } = Option<Part>.None();
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
            this.Circuitry = Option<Part>.Some(circuitry );
            this.FailedCircuitryWarranty = extendedWarranty;
        }

        public void CircuitryNotOperational(DateTime detectedOn)
        {

            this.Circuitry.Do(circuitry =>
            {
                circuitry.MarkDefective(detectedOn);
                this.CircuitryWarranty = this.FailedCircuitryWarranty;
            });
        }

        public void ClaimCircuitryWarranty(Action onValidClaim)
        {
            this.Circuitry.Do(circuitry =>
                 this.CircuitryWarranty.Claim(circuitry.DefectDetectedOn, onValidClaim));

        }
    }
}
