namespace AppointmentSystemWithMiixins
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            DomainService domain = new DomainService(new UserFactory(new DataService()));
            IUser user = domain.RegisterUser("zoranh", "magicWord");
            Console.WriteLine($"{user}\n");

            IAppointment appointment = user.MakeAppointment(DateTime.Now.Date.AddHours(40));
            Console.WriteLine($"{appointment}\n");

            user = domain.ChangePassword("zoranh", "magicWord", "somethingmorecomplex");
            Console.WriteLine($"{user}\n");

            Console.ReadLine();
        }
    }
}
