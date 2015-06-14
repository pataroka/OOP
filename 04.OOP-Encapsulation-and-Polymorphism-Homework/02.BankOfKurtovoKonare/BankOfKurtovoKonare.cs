namespace _02.BankOfKurtovoKonare
{
    using System;

    public static class BankOfKurtovoKonare
    {
        public static void Main()
        {
            Loan loan1 = new Loan(new DateTime(2015, 1, 1), new Customer("Ivan", Entity.Individual), -10m, 100);
            loan1.DepositFunds(1m, new DateTime(2015, 2, 1));
            Console.WriteLine(loan1.CalculateInterest());
            Console.WriteLine(loan1.GetBalance());

            Mortgage mortgage = new Mortgage(new DateTime(2015, 1, 1), new Customer("SoftUni", Entity.Company), -10m, 1);
            mortgage.DepositFunds(1m, new DateTime(2015, 2, 1));
            Console.WriteLine(mortgage.CalculateInterest());
            Console.WriteLine(mortgage.GetBalance());

            Deposit deposit = new Deposit(new DateTime(2015, 1, 1), new Customer("Ivan", Entity.Individual), 10m, 100);
            deposit.DepositFunds(1m, new DateTime(2015, 2, 1));
            Console.WriteLine(deposit.CalculateInterest());
            Console.WriteLine(deposit.GetBalance());
        }
    }
}
