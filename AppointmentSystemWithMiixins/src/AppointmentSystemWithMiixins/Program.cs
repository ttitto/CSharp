namespace AppointmentSystemWithMiixins
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void MassRegister(IEnumerable<IRegistrant> registrants)
        {
            foreach (IRegistrant registrant in registrants)
            {
                registrant.Register();
            }
        }

        static void ScramblePasswords(IEnumerable<IRegistrant> registrants)
        {
            foreach (IRegistrant registrant in registrants)
            {
                registrant.ChangePassword(Guid.NewGuid().ToString().Substring(0, 6));
            }
        }

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

            DataService service = new DataService();
            IEnumerable<IRegistrant> registrants = new IRegistrant[] {
                new PersistableUser(jill, service, "pwd"),
                new PersistableUser(jack, service, "pwd"),
                new PersistableUser(joe, service, "pwd"),
                new RegistrantGroup(group, "friends", "secret")
            };
            // MassRegister(registrants);
            ScramblePasswords(registrants);

            Console.ReadLine();
        }
    }
}
