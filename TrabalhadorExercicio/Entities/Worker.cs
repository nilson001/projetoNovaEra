using System.Collections.Generic;
using TrabalhadorExercicio.Entities.Enum;

namespace TrabalhadorExercicio.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name)
        {
            Name = name;
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContracts(HourContract contract)
        {
            Contracts.Add(contract);
        }

        
        public void RemoveContracts(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int years, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts )
            {
                if (contract.Date.Year == years && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
        
        
        
    }
    
    
    
    
}