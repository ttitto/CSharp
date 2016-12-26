namespace AppointmentSystemWithMiixins
{
    using System;

    public class User : IUser
    {
        private readonly string name;

        public User(string name)
        {
            this.name = name;
        }

        public void Accept(Func<IUserVisitor> visitorFactory)
        {
            visitorFactory().VisitUser(this.name);
        }

        public IAppointment MakeAppointment(DateTime startTime)
        {
            return new Meeting(startTime, TimeSpan.FromHours(1));
        }
        public override string ToString()
        {
            return $"User (name: {name})";
        }
    }
}
