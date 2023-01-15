using System;
using System.Globalization;
using TrabalhadorExercicio.Entities.Enum;
using TrabalhadorExercicio.Entities;

// Testando
//testando 3
namespace TrabalhadorExercicio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter department's name");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            string enterlevel = (Console.ReadLine());
            Enum.TryParse(enterlevel, out WorkerLevel level);
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
            
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i=1; i<n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                Double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContracts(contract);
                
            }
            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income: (MM/YYYY)");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int years = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": "+ worker.Income(years,month));
            Console.WriteLine("Testando code");
            
             
        }
    }
}