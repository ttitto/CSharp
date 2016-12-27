namespace AppointmentSystemWithMiixins
{
    using System;

    public interface IUserGroup
    {
        void AddMember(IUser user);
        void Accept(Func<IUserGroupVisitor> visitorFactory);
    }
}
