namespace _02.BankOfKurtovoKonare
{
    using System;
    using System.Linq;

    public class Loan : Account
    {
        public Loan(DateTime dateOpened, Customer customer, decimal balance, decimal interestRate)
            : base(dateOpened, customer, balance, interestRate)
        {
            if (balance >= 0)
            {
                throw new ArgumentOutOfRangeException("balance", "Balance of a loan account must be instantiated with a negative number!");
            }

            this.InterestModifier = dateOpened.AddMonths(customer.Entity.Equals(Entity.Individual) ? 3 : 2);
        }
        
        public override void DepositFunds(decimal funds, DateTime date)
        {
            if (this.Balance + funds > 0)
            {
                throw new ArgumentOutOfRangeException("funds", "Deposited sum cannot exceed the balance of the account!");
            }

            if (date <= this.InterestModifier)
            {
                this.Balance += funds;
                this.EventLog.Add(date, this.Balance);
            }
            else
            {
                this.Balance += this.CalculateInterest(this.EventLog.Last().Key, date);
                this.Balance += funds;
                this.EventLog.Add(date, this.Balance);
            }
        }

        public override decimal CalculateInterest()
        {
            return this.CalculateInterest(this.DateOpened, DateTime.Now);
        }

        public override decimal CalculateInterest(DateTime startDate, DateTime endDate)
        {
            if (startDate < this.DateOpened)
            {
                throw new ArgumentOutOfRangeException("startDate", "Startdate cannot be earlier than the date when account was opened!");
            }

            int period;

            if (startDate < this.InterestModifier)
            {
                period = (endDate.Month - this.InterestModifier.Month) + (12 * (endDate.Year - this.InterestModifier.Year));

                period = period < 0 ? 0 : period;

                return this.Balance * (this.InterestRate / 100 * period);
            }

            period = (endDate.Month - startDate.Month) + (12 * (endDate.Year - startDate.Year));
            return this.Balance * (this.InterestRate / 100 * period);
        }
    }
}
