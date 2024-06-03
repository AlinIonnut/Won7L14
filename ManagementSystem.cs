using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Won7L14
{
    internal class ManagementSystem
    {
        private static ManagementSystem _managementSystem;
        private List<Employee> _employees;

        private ManagementSystem ()
        {
            _employees = new List<Employee> ();
        }

        public static ManagementSystem Instance => _managementSystem ??= new ManagementSystem();

        public void AddEmployee (Employee employee)
        {
            _employees.Add (employee);
        }

        public void RemoveEmployee (Guid id)
        {
            _employees.RemoveAll(e => e.Id == id);
        }

        public List<Employee> GetNoOfWellPayedEmployees (double salary)
        {
            return _employees.FindAll(e => e.Salary > salary);
        }

        public List<Employee> GetEmployeesByDepartment(Department department)
        {
            return _employees.FindAll(e => e.Department == department);
        }

        public Employee GetMaxSalary()
        {
            return _employees.OrderByDescending(e => e.Salary).FirstOrDefault();
        }

        public Employee GetMaxSalaryForDepartment(Department department)
        {
            return _employees.FindAll(e => e.Department == department).OrderByDescending(e => e.Salary).FirstOrDefault();
        }

        public double GetTotalCost()
        {
            return _employees.Sum(e => e.Salary);
        }

        public double GetTotalCostForDepartment(Department department)
        {
            return _employees.FindAll(e => e.Department == department).Sum(e => e.Salary);
        }

        public void IncreaseSalary(Guid id, double increase)
        {
            _employees.ForEach(e =>
            {
                if(e.Id == id)
                {
                    e.Salary = e.Salary * (increase/100) + e.Salary;
                }
            });
        }

        public void IncreaseSalaryForDepartment(Department department, double increase)
        {
            _employees.ForEach(e =>
            {
                if (e.Department == department)
                {
                    e.Salary = e.Salary * (increase / 100) + e.Salary;
                }
            });
        }


    }
}
