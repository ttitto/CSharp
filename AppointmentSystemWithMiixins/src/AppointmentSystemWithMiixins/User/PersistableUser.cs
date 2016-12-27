namespace AppointmentSystemWithMiixins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class PersistableUser : IRegistrantUser, IUserVisitor
    {
        private readonly IUser user;
        private readonly IRegistrationService registrationService;
        private string password;
        private string name;

        public PersistableUser(IUser user, IRegistrationService registrationService, string password)
        {
            this.user = user;
            this.registrationService = registrationService;
            this.password = password;

            this.user.Accept(() => this);
        }

        public IAppointment MakeAppointment(DateTime startTime)
        {
            return this.user.MakeAppointment(startTime);
        }

        public void ChangePassword(string newPassword)
        {
            this.registrationService.ChangePassword(this.name, this.password, newPassword);
            this.password = newPassword;
        }

        public void Register()
        {
            this.registrationService.Register(this.name, this.password);
        }

        public void VisitUser(string name)
        {
            this.name = name;
        }

        public void Accept(Func<IUserVisitor> visitorFactory)
        {
            this.user.Accept(visitorFactory);
        }

        public override string ToString()
        {
            return $"PersistableUser (name={this.name}, password={this.password}"; 
        }
    }
}
