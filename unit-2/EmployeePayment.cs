// Question:
// Implement payroll system using polymorphism.
// SalariedCommissionEmployee gets 10% bonus on base salary.

using System;

namespace lab_work_1
{
    // Abstract Base Class
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
        double salary;

        public SalariedEmployee(string name, double salary) : base(name)
        {
            this.salary = salary;
        }

        public override double Earnings()
        {
            return salary;
        }
    }

    // Hourly Employee
    class HourlyEmployee : Employee
    {
        double hours, rate;

        public HourlyEmployee(string name, double hours, double rate) : base(name)
        {
            this.hours = hours;
            this.rate = rate;
        }

        public override double Earnings()
        {
            if (hours <= 40)
                return hours * rate;
            else
                return (40 * rate) + ((hours - 40) * rate * 1.5);
        }
    }

    // Commission Employee
    class CommissionEmployee : Employee
    {
        double sales, percent;

        public CommissionEmployee(string name, double sales, double percent) : base(name)
        {
            this.sales = sales;
            this.percent = percent;
        }

        public override double Earnings()
        {
            return sales * percent;
        }
    }

    // Salaried + Commission Employee (with 10% bonus)
    class SalariedCommissionEmployee : Employee
    {
        double baseSalary, sales, percent;

        public SalariedCommissionEmployee(string name, double baseSalary, double sales, double percent)
            : base(name)
        {
            this.baseSalary = baseSalary;
            this.sales = sales;
            this.percent = percent;
        }

        public override double Earnings()
        {
            // 10% bonus added
            return (baseSalary * 1.10) + (sales * percent);
        }
    }

    // Main Class
    class EmployeePayment
    {
        static void Main()
        {
            Employee[] emp = new Employee[]
            {
                new SalariedEmployee("Punit", 5000),
                new HourlyEmployee("Rahul", 45, 100),
                new CommissionEmployee("Amit", 20000, 0.10),
                new SalariedCommissionEmployee("Neha", 4000, 15000, 0.08)
            };

            Console.WriteLine("---- Payroll System ----");

            foreach (Employee e in emp)
            {
                Console.WriteLine(e.Name + " earns: " + e.Earnings());
            }

            Console.ReadLine();
        }
    }
}
