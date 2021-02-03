using System;

namespace BankUnitTests
{
    /// <summary>   
    /// Bank Account demo class.   
    /// </summary>   
    public class BankAccount
    {
        public double Balance { get; private set; }
        public string CustomerName { get; private set; }

        private bool frozen;

        public BankAccount(string customerName, double balance)
        {
            this.CustomerName = customerName;
            this.Balance = balance;
            this.frozen = false;
        }

        public void Debit(double amount)
        {if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("Not enough money in the account");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Incorrect amount");
            }

            if (frozen)
            {
                throw new Exception("Account frozen");
            }

            Balance += amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Incorrect amount");
            }

            if (frozen)
            {
                throw new Exception("Account frozen");
            }

            Balance += amount;
        }

        public void FreezeAccount()
        {
            frozen = true;
        }

        public void UnfreezeAccount()
        {
            frozen = false;
        }

    }
}
