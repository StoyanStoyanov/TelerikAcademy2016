namespace Ex02HumanHierarchy
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; private set; }

        public decimal WorkHoursPerDay { get; private set; }

        public decimal GetMoneyPerHour()
        {
            return (this.WeekSalary / 5) / this.WorkHoursPerDay;
        }
    }
}