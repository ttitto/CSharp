using System;

namespace AppointmentSystemWithMiixins
{
    public class Meeting: IAppointment
    {
        private DateTime startTime;
        private TimeSpan timeSpan;

        public Meeting(DateTime startTime, TimeSpan timeSpan)
        {
            this.startTime = startTime;
            this.timeSpan = timeSpan;
        }

        public override string ToString()
        {
            return $"Meeting starting at {this.startTime}, taking {this.timeSpan} min.";
        }
    }
}