namespace _02.BankOfKurtovoKonare
{
    using System;
    using System.Collections.Generic;

    public abstract class Account : IIntrestable
    {
        private Dictionary<DateTime, decimal> eventLog = new Dictionary<DateTime, decimal>(); 

        public Account(DateTime dateOpened, Customer customer, decimal balance, decimal interestRate)
        {
            this.DateOpened = dateOpened;
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.EventLog = new Dictionary<DateTime, decimal> { { this.DateOpened, this.Balance } };
        }

        public DateTime DateOpened { get; private set; }

        public DateTime InterestModifier { get; protected set; }

        public Customer Customer { get; private set; }

        public decimal InterestRate { get; private set; }

        protected decimal Balance { get; set; }

        protected Dictionary<DateTime, decimal> EventLog { get; private set; } 

        public abstract void DepositFunds(decimal funds, DateTime date);

        public abstract decimal CalculateInterest();

        public abstract decimal CalculateInterest(DateTime startDate, DateTime endDate);

        public decimal GetBalance()
        {
            this.DepositFunds(0m, DateTime.Now);
            return this.Balance;
        }
    }
}