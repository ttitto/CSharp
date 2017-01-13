namespace BranchingToStatePattern
{
    using System;

    internal class Account
    {
        public Account(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;

            this.ManageUnfreezing = this.StayUnfrozen;
        }

        private bool IsVerified { get; set; }
        private bool IsClosed { get; set; }
        private Action OnUnfreeze { get; }
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            if (this.IsClosed)
            {
                return;
            }

            ManageUnfreezing();
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (!this.IsVerified)
            {
                return;
            }
            if (this.IsClosed)
            {
                return;
            }

            this.ManageUnfreezing();
            this.Balance -= amount;
        }

        public void HolderVerified()
        {
            this.IsVerified = true;
        }

        public void Close()
        {
            this.IsClosed = true;
        }

        public void Freeze()
        {
            if (this.IsClosed)
            {
                return;
            }

            if (!this.IsVerified)
            {
                return;
            }

            this.ManageUnfreezing = this.Unfreeze;
        }

        private Action ManageUnfreezing { get; set; }


        private void Unfreeze()
        {
            this.OnUnfreeze();
            this.ManageUnfreezing = this.StayUnfrozen;
        }

        private void StayUnfrozen() { }
    }
}
