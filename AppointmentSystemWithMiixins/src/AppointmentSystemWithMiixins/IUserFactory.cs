namespace AppointmentSystemWithMiixins
{
    public interface IUserFactory
    {
        IUser CreateUser(string name);
        IRegistrantUser CreateRegistrantUser(IUser user, string password);
    }
}
