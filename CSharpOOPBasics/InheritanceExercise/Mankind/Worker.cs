using System;
using System.Text;

public class Worker : Human
{
    private const int WorkDaysPerWeek = 5;
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.weekSalary)}");
            }

            this.weekSalary = value;
        }
    }

    public decimal WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set
        {
            if (value < 1m || value > 12m)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.workHoursPerDay)}");
            }

            this.workHoursPerDay = value;
        }
    }

    public decimal CalculateSalaryPerHour()
    {
        return this.WeekSalary / (this.WorkHoursPerDay * WorkDaysPerWeek);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString())
            .AppendLine($"Week Salary: {this.WeekSalary:f2}")
            .AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
            .Append($"Salary per hour: {this.CalculateSalaryPerHour():f2}");

        return sb.ToString();
    }
}