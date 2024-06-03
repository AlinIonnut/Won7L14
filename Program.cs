using Won7L14;

var system = ManagementSystem.Instance;

var firstEmployee = new Employee("Mircea Popescu", 3500, Department.Testing);
var secondEmployee = new Employee("Gina Mina", 4000, Department.Development);
var thirdEmployee = new Employee("Mihai Adrian", 5000, Department.Maintenance);
var fourthEmployee = new Employee("Andreea Bogdan", 4300,Department.HumanResources);

system.AddEmployee(firstEmployee);
system.AddEmployee(secondEmployee);
system.AddEmployee(thirdEmployee);
system.AddEmployee(fourthEmployee);

Console.WriteLine(" --- The max salary is --- ");
Console.WriteLine(system.GetMaxSalary());

Console.WriteLine(" --- The salaries that are over 4000 are --- ");
var wellPaidEmployees = system.GetNoOfWellPayedEmployees(4000);
Console.WriteLine(string.Join("\n", wellPaidEmployees.Select(e => e.ToString())));

Console.WriteLine(" --- The employees from testing deparment are --- ");
var employeeFromTesting = system.GetEmployeesByDepartment(Department.Testing);
Console.WriteLine(string.Join("\n", employeeFromTesting.Select(e => e.ToString())));

Console.WriteLine(" --- The max salary from human resource department is ---");
Console.WriteLine(system.GetMaxSalaryForDepartment(Department.HumanResources));

Console.WriteLine(" --- The total cost of the salaries is ---");
Console.WriteLine(system.GetTotalCost());

Console.WriteLine(" --- The increase salary for development department is --- ");
system.IncreaseSalaryForDepartment(Department.Development, 25);

var employeeFromDevelopment = system.GetEmployeesByDepartment(Department.Development);
Console.WriteLine(string.Join("\n", employeeFromDevelopment.Select(e => e.ToString())));