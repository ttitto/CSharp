namespace BranchingToStatePattern
{
    using System;

    public interface IAccountState
    {
        IAccountState Deposit(Action addToBalance);
        IAccountState WithDraw();
        IAccountState Freeze();
        IAccountState HolderVerified();
        IAccountState Close();
    }
}
