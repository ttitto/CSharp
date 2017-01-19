namespace NullObjectsPattern
{
    using System;

    internal class Part
    {
        public DateTime InstallmentDate { get; }
        public DateTime DefectDetectedOn { get; private set; }

        public Part(DateTime installmentDate)
        {
            this.InstallmentDate = installmentDate;
        }

        public void MarkDefective(DateTime withDate)
        {
            this.DefectDetectedOn = withDate;
        }
    }
}
