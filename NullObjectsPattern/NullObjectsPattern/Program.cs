namespace NullObjectsPattern
{
    using System;


    class Program
    {
        static void ClaimWarranty(SoldArticle article)
        {
            DateTime now = DateTime.Now;
            if (article.MoneyBackGuarantee.IsValidOn(now))
            {
                Console.WriteLine("Offer money back.");
            }

            if (article.ExpressWarranty.IsValidOn(now))
            {
                Console.WriteLine("Offer repair.");
            }
        }

        static void Main(string[] args)
        {
            DateTime sellingDate = new DateTime(2016, 12, 20);
            TimeSpan moneyBackSpan = TimeSpan.FromDays(30);
            TimeSpan warrantySpan = TimeSpan.FromDays(365);

            IWarranty moneyBack = new TimeLimitedWarranty(sellingDate, moneyBackSpan);
            IWarranty warranty = new TimeLimitedWarranty(sellingDate, warrantySpan);
            
            SoldArticle goods = new SoldArticle(VoidWarranty.Instance, warranty);

            ClaimWarranty(goods);
            Console.ReadLine();
        }
    }
}
