namespace AppointmentSystemWithMiixins
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            DomainService domain = new DomainService(new UserFactory(new DataService()));
            //IUser user = domain.RegisterUser("zoranh", "magicWord");
            //Console.WriteLine($"{user}\n");

            //IAppointment appointment = user.MakeAppointment(DateTime.Now.Date.AddHours(40));
            //Console.WriteLine($"{appointment}\n");

            //user = domain.ChangePassword("zoranh", "magicWord", "somethingmorecomplex");
            //Console.WriteLine($"{user}\n");

            IUser jill = domain.RegisterUser("Jill", "pwd");
            IUser joe = domain.RegisterUser("Joe", "pwd");
            IUser jack = domain.RegisterUser("Jack", "pwd");
            IUserGroup group = new UserGroup();

            group.AddMember(jill);
            group.AddMember(joe);
            group.AddMember(jack);

            IRegistrantGroup regGroup = new RegistrantGroup(group, "friends", "secret");
            regGroup.Register();

            Console.ReadLine();
        }
    }
}
