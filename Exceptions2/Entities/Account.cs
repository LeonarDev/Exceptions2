using Exceptions2.Entities.Exceptions;

namespace Exceptions2.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public Account()
        {
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new DomainException("Deposit error: The amount must be a positive value");
            }

            Balance += amount;
        }

        public void withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }

            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}
