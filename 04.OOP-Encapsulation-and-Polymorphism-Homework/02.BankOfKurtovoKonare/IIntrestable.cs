using System;

namespace _02.BankOfKurtovoKonare
{
    public interface IIntrestable
    {
        decimal CalculateInterest();

        decimal CalculateInterest(DateTime startDate, DateTime endDate);
    }
}