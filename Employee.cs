using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Won7L14
{
    internal class Employee
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }

        public Employee(string name, double salary, Department department)
        {
            Name = name;
            Id = Guid.NewGuid();
            Salary = salary;
            Department = department;
        }

        public override string ToString()
        {
            return $"Properties of the employee:{Id} ;{Name} ;{Salary} ;{Department} ";
        }
    }
}
