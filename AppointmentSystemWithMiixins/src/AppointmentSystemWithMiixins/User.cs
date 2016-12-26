namespace AppointmentSystemWithMiixins
{
    using System;

    public class User : IUser
    {
        private readonly string name;
        private readonly string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public IApointment MakeAppointment(DateTime startTime)
        {
            return new Meeting(startTime, TimeSpan.FromHours(1));
        }
        public override string ToString()
        {
            return $"User (name: {name}, password: {password})";
        }
    }
}
