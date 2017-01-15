using System;

namespace NullObjectsPattern
{
    internal class SoldArticle
    {
        public IWarranty MoneyBackGuarantee { get; }
        public IWarranty ExpressWarranty { get; }

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
            this.ExpressWarranty = express;
        }
    }
}
