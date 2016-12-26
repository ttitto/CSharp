namespace AppointmentSystemWithMiixins
{
    public interface IRegistrationService
    {
        void Register(string name, string password);
        void ChangePassword(string name, string password, string newPassword);
    }
}
