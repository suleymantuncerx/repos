using System;

namespace CalisanYonetimi
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public virtual decimal CalculateBonus()
        {
            // Temel uygulama (varsa)
            return 0;
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        public override decimal CalculateBonus()
        {
            // Yönetici primi
            return Salary * 20m;
        }
    }

    public class Developer : Employee
    {
        public string About { get; set; }

        public override decimal CalculateBonus()
        {
            // Geliştiriciler primi
            return Salary * 10m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Id = 1,
                Name = "Suleyman Mert Tuncer",
                Salary = 12500,
                Department = "IT",
                TeamSize = 25,
            };

            Developer developer = new Developer
            {
                Id = 2,
                Name = "Ali",
                Salary = 5000,
                Department = "IT",
                About = "Frontend Developer"
            };

            Console.WriteLine($"Yönetici Primi: {manager.CalculateBonus()}");
            Console.WriteLine($"Geliştirici Primi: {developer.CalculateBonus()}");
        }
    }
}