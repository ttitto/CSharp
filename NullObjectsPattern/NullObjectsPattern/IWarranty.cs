using System;

namespace NullObjectsPattern
{
    internal interface IWarranty
    {
        void Claim(DateTime onDate, Action onValidClaim);
    }
}