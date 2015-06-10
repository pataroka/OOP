namespace _01.HumanStudentAndWorker
{
    public class Worker : Human
    {
        private const int WorkDays = 5;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            decimal mph = this.WeekSalary / (this.WorkHoursPerDay * WorkDays);
            return mph;
        }

        public override string ToString()
        {
            return string.Format("{0}, Weekly salary: {1}, Work hours per day: {2}, Wage per hour: {3}", base.ToString(), this.WeekSalary, this.WorkHoursPerDay, this.MoneyPerHour());
        }
    }
}
