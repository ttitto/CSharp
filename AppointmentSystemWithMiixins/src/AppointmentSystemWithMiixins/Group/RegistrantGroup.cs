namespace AppointmentSystemWithMiixins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class RegistrantGroup : IRegistrantGroup, IUserGroupVisitor
    {
        private IUserGroup group;
        private string groupName;
        private string password;

        public RegistrantGroup(IUserGroup group, string groupName, string password)
        {
            this.group = group;
            this.groupName = groupName;
            this.password = password;
        }

        public void AddMember(IUser user)
        {
            this.group.AddMember(user);
        }

        public void Register()
        {
            Console.WriteLine($"Registering group'{this.groupName}' with password '{this.password}'.");
            this.group.Accept(() => this);
        }

        public void ChangePassword(string newPassword)
        {
            Console.WriteLine($"Changing '{this.groupName}' group password from '{this.password}' to '{newPassword}'.");
            this.password = newPassword;
        }

        public void Accept(Func<IUserGroupVisitor> visitorFactory)
        {
            this.group.Accept(visitorFactory);
        }

        public void VisitUser(string name)
        {
            Console.WriteLine($"\tAssociating {name} with group '{this.groupName}'");
        }
    }
}
