namespace BranchingToStatePattern
{
    using System;

    public interface IAccountState
    {
        IAccountState Deposit(Action addToBalance);
        IAccountState WithDraw(Action subtractFromBalance);
        IAccountState Freeze();
        IAccountState HolderVerified();
        IAccountState Close();
    }
}
