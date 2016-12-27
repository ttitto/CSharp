namespace AppointmentSystemWithMiixins
{
    public class UserFactory : IUserFactory
    {
        private readonly DataService dataService;

        public UserFactory(DataService dataService)
        {
            this.dataService = dataService;
        }

        public IRegistrantUser CreateRegistrantUser(IUser user, string password)
        {
            return new PersistableUser(user, this.dataService, password);
        }

        public IUser CreateUser(string name)
        {
            return new User(name);
        }
    }
}
