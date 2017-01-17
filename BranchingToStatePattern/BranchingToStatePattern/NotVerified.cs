namespace BranchingToStatePattern
{
    using System;

    internal class NotVerified : IAccountState
    {
        private Action OnUnfreeze { get; set; }

        public NotVerified(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        public IAccountState Close() => new Closed();

        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }

        public IAccountState Freeze() => this;

        public IAccountState HolderVerified() => new Active(this.OnUnfreeze);

        public IAccountState WithDraw(Action subtractFromBalance)
        {
            subtractFromBalance();
            return this;
        }
    }
}
