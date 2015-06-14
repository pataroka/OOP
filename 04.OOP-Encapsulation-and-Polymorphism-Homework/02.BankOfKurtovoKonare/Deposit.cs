namespace _02.BankOfKurtovoKonare
{
    using System;
    using System.Linq;

    public class Deposit : Account
    {
        public Deposit(DateTime dateOpened, Customer customer, decimal balance, decimal interestRate)
            : base(dateOpened, customer, balance, interestRate)
        {
            if (balance <= 0)
            {
                throw new ArgumentOutOfRangeException("balance", "Balance of a deposit account must be instantiated with a positive number!");
            }

            this.InterestModifier = dateOpened;
        }

        public override void DepositFunds(decimal funds, DateTime date)
        {
            this.Balance += funds;
            this.EventLog.Add(date, this.Balance);
        }

        public void WithdrawFunds(decimal funds, DateTime date)
        {
            this.Balance += this.CalculateInterest(this.EventLog.Last().Key, date);

            if (this.Balance - funds < 0)
            {
                throw new ArgumentOutOfRangeException("funds", "Funds withdrawn cannot exceed balance of the account!");
            }

            this.Balance += this.CalculateInterest(this.EventLog.Last().Key, date);
            this.Balance -= funds;
            this.EventLog.Add(date, this.Balance);
    }

        public override decimal CalculateInterest()
        {
            return this.CalculateInterest(this.DateOpened, DateTime.Now);
        }

        public override decimal CalculateInterest(DateTime startDate, DateTime endDate)
        {
            decimal interest = 0m;

            int period = 0;

            this.InterestModifier = startDate;

            if (startDate < this.DateOpened)
            {
                throw new ArgumentOutOfRangeException("startDate", "Startdate cannot be earlier than the date when account was opened!");
            }

            if (this.EventLog.Count == 1)
            {
                return 0m;
            }
            
            foreach (var pair in this.EventLog)
            {
                if (pair.Value < 1000)
                {
                    this.InterestModifier = pair.Key;
                    continue;
                }

                period = (pair.Key.Month - this.InterestModifier.Month) + (12 * (pair.Key.Year - this.InterestModifier.Year));
                interest += pair.Value * (this.InterestRate / 100 * period);
            }
            
            return interest;
        }
    }
}
