using System;

namespace AppointmentSystemWithMiixins
{
    public interface IUser
    {
        IApointment MakeAppointment(DateTime startTime);
    }
}