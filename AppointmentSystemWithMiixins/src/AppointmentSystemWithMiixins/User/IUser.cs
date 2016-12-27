namespace AppointmentSystemWithMiixins
{
    using System;

    public interface IUser
    {
        IAppointment MakeAppointment(DateTime startTime);
        void Accept(Func<IUserVisitor> visitorFactory);
    }
}