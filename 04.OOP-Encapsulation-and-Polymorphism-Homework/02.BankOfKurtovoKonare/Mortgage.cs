namespace _02.BankOfKurtovoKonare
{
    using System;
    using System.Linq;

    public class Mortgage : Account
    {
        public Mortgage(DateTime dateOpened, Customer customer, decimal balance, decimal interestRate)
            : base(dateOpened, customer, balance, interestRate)
        {
            if (balance >= 0)
            {
                throw new ArgumentOutOfRangeException("balance", "Balance of a mortgage account must be instantiated with a negative number!");
            }

            this.InterestModifier = dateOpened.AddMonths(customer.Entity.Equals(Entity.Individual) ? 6 : 12);
        }

        public override void DepositFunds(decimal funds, DateTime date)
        {
            if (this.Balance + funds > 0)
            {
                throw new ArgumentOutOfRangeException("funds", "Deposited sum cannot exceed the balance of the account!");
            }

            this.Balance += this.CalculateInterest(this.EventLog.Last().Key, date);
            this.Balance += funds;
            this.EventLog.Add(date, this.Balance);
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
            int halfInterestPeriod;

            if (startDate < this.InterestModifier)
            {
                if (endDate <= this.InterestModifier)
                {
                    period = 0;
                    halfInterestPeriod = (endDate.Month - startDate.Month) + (12 * (endDate.Year - startDate.Year));
                }
                else
                {
                    period = (endDate.Month - this.InterestModifier.Month) + (12 * (endDate.Year - this.InterestModifier.Year));
                    halfInterestPeriod = (this.InterestModifier.Month - startDate.Month) + (12 * (this.InterestModifier.Year - startDate.Year));
                }

                if (this.Customer.Entity.Equals(Entity.Individual))
                {
                    return this.Balance * (this.InterestRate / 100 * period);
                }
                
                return (this.Balance * (this.InterestRate / 200 * halfInterestPeriod)) + (this.Balance * (this.InterestRate / 100 * period));
            }

            period = (endDate.Month - startDate.Month) + (12 * (endDate.Year - startDate.Year));
            return this.Balance * (this.InterestRate / 100 * period);
        }
    }
}
