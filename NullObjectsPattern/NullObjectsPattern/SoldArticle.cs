using System;

namespace NullObjectsPattern
{
    internal class SoldArticle
    {
        public IWarranty MoneyBackGuarantee { get; private set; }
        public IWarranty ExpressWarranty { get; private set; }
        public IWarranty NotOperationalWarranty { get; }

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
    }
}
