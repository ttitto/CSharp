namespace AppointmentSystemWithMiixins
{
    public class DomainService
    {
        private readonly DataService dataService;

        public DomainService(DataService dataService)
        {
            this.dataService = dataService;
        }

        public IUser RegisterUser(string name, string password)
        {
            IRegistrantUser user = this.CreateUser(name, password);
            user.Register();
            return user;
        }

        public IUser ChangePassword(string name, string password, string newPassword)
        {
            IRegistrantUser user = this.CreateUser(name, password);
            user.ChangePassword(newPassword);
            return user;
        }

        private IRegistrantUser CreateUser(string name, string password)
        {
            IUser user = new User(name);
            return new PersistableUser(user, this.dataService, password);
        }
    }
}
