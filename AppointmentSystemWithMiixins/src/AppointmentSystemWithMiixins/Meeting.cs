using System;

namespace AppointmentSystemWithMiixins
{
    public class Meeting: IApointment
    {
        private DateTime startTime;
        private TimeSpan timeSpan;

        public Meeting(DateTime startTime, TimeSpan timeSpan)
        {
            this.startTime = startTime;
            this.timeSpan = timeSpan;
        }
    }
}