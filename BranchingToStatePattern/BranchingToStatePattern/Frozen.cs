namespace BranchingToStatePattern
{
    using System;

    internal class Frozen : IAccountState
    {
        private Action OnUnfreeze { get; }

        public Frozen(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            this.OnUnfreeze();
            addToBalance();
            return new Active(this.OnUnfreeze);
        }

        public IAccountState Freeze() => this;

        public IAccountState WithDraw()
        {
            this.OnUnfreeze();
            return new Active(this.OnUnfreeze);
        }

        public IAccountState HolderVerified() => this;

        public IAccountState Close() => new Closed();
    }
}
