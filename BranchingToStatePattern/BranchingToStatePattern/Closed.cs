namespace BranchingToStatePattern
{
    using System;

    internal class Closed : IAccountState
    {
        public IAccountState Close() => this;

        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }

        public IAccountState Freeze() => this;

        public IAccountState HolderVerified() => this;

        public IAccountState WithDraw(Action subtractFromBalance) => this;
    }
}
