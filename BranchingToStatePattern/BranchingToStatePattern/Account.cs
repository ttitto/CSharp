namespace BranchingToStatePattern
{
    using System;

    internal class Account
    {
        public Account(Action onUnfreeze)
        {
            this.State = new NotVerified(onUnfreeze);
        }

        public decimal Balance { get; private set; }
        public IAccountState State { get; private set; }

        public void Deposit(decimal amount)
        {
            this.State = this.State.Deposit(() => { this.Balance += amount; });
        }

        public void Withdraw(decimal amount)
        {
            this.State = this.State.Deposit(() => { this.Balance -= amount; });
        }

        public void HolderVerified()
        {
            this.State = this.State.HolderVerified();
        }

        public void Close()
        {
            this.State = this.State.Close();
        }

        public void Freeze()
        {
            this.State = this.State.Freeze();
        }
    }
}
