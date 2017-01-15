namespace NullObjectsPattern
{
    using System;


    class Program
    {
        static void ClaimWarranty(SoldArticle article, bool isInGoodCondition, bool isBroken)
        {
            DateTime now = DateTime.Now;
            if (isInGoodCondition && !isBroken && article.MoneyBackGuarantee.IsValidOn(now) && article.MoneyBackGuarantee != null)
            {
                Console.WriteLine("Offer money back.");
            }

            if (isBroken && article.ExpressWarranty != null && article.ExpressWarranty.IsValidOn(now))
            {
                Console.WriteLine("Offer repair.");
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
