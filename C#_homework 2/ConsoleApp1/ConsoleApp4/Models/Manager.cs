using ConsoleApp4.BaseEntity;

namespace ConsoleApp4.Models
{
   public class Manager : Employee
    {
        public double BaseSalary { get; set; }
        public Manager(string name, double baseSalary) : base(name)
        {
            BaseSalary = baseSalary;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + BaseSalary * 61.5;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
        }
    }
}
