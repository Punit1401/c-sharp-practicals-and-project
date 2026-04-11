
// A company pays employees weekly. Types:
// 1. Salaried → fixed salary
// 2. Hourly → hourly pay + overtime (>40 hrs)
// 3. Commission → % of sales
// 4. Salaried-Commission → base salary + % of sales (+10% bonus on base)

using System;

namespace lab_work_1
{
    abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract double Earnings();
    }

    // Salaried Employee
    class SalariedEmployee : Employee
    {
        public double WeeklySalary;

        public SalariedEmployee(string name, double salary) : base(name)
        {
            WeeklySalary = salary;
        }

        public override double Earnings()
        {
            return WeeklySalary;
        }
    }

    class HourlyEmployee : Employee
    {
        public double Hours, Rate;

        public HourlyEmployee(string name, double hours, double rate) : base(name)
        {
            Hours = hours;
            Rate = rate;
        }

        public override double Earnings()
        {
            if (Hours <= 40)
                return Hours * Rate;
            else
                return (40 * Rate) + ((Hours - 40) * Rate * 1.5);
        }
    }

    // Commission Employee
    class CommissionEmployee : Employee
    {
        public double Sales, Percentage;

        public CommissionEmployee(string name, double sales, double percent) : base(name)
        {
            Sales = sales;
            Percentage = percent;
        }

        public override double Earnings()
        {
            return Sales * Percentage;
        }
    }


    class SalariedCommissionEmployee : Employee
    {
        public double BaseSalary, Sales, Percentage;

        public SalariedCommissionEmployee(string name, double baseSalary, double sales, double percent)
            : base(name)
        {
            BaseSalary = baseSalary;
            Sales = sales;
            Percentage = percent;
        }

        public override double Earnings()
        {
            return (BaseSalary * 1.10) + (Sales * Percentage);
        }
    }

    class Company
    {
        static void Main()
        {
            Employee[] employees = new Employee[]
            {
                new SalariedEmployee("Punit", 5000),
                new HourlyEmployee("Rahul", 45, 100),
                new CommissionEmployee("Amit", 20000, 0.10),
                new SalariedCommissionEmployee("Neha", 4000, 15000, 0.08)
            };

            Console.WriteLine("---- Employee Weekly Earnings ----");

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + " earns: " + emp.Earnings());
            }

            Console.ReadLine();
        }
    }
}
