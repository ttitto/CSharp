namespace AppointmentSystemWithMiixins
{
    public class DomainService
    {
        private readonly IUserFactory userFactory;

        public DomainService(IUserFactory userFactory)
        {
            this.userFactory = userFactory;
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
            IUser user = this.userFactory.CreateUser(name);
            return this.userFactory.CreateRegistrantUser(user, password);
        }
    }
}
