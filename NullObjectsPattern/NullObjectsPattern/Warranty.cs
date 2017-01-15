﻿namespace NullObjectsPattern
{
    using System;

    internal class TimeLimitedWarranty : IWarranty
    {
        private DateTime DateIssued { get; }
        private TimeSpan Duration { get; }

        public TimeLimitedWarranty(DateTime dateIssued, TimeSpan duration)
        {
            this.DateIssued = dateIssued;
            this.Duration = duration;
        }

        public bool IsValidOn(DateTime date) =>
            date.Date >= this.DateIssued && date.Date < this.DateIssued + this.Duration;
    }
}
