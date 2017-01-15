namespace NullObjectsPattern
{
    using System;

    internal class LifeTimeWarranty : IWarranty
    {
        private DateTime IssuingDate { get; }

        public LifeTimeWarranty(DateTime issuingDate)
        {
            this.IssuingDate = issuingDate;
        }

        public bool IsValidOn(DateTime date) => date.Date >= this.IssuingDate;
    }
}
