namespace NullObjectsPattern
{
    internal class SoldArticle
    {
        public Warranty MoneyBackGuarantee { get; }
        public Warranty ExpressWarranty { get; }

        public SoldArticle(Warranty moneyBack, Warranty express)
        {
            this.MoneyBackGuarantee = moneyBack;
            this.ExpressWarranty = express;
        }
    }
}
