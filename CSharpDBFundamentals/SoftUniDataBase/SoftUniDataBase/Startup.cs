using Gringots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDataBase
{
    class Startup
    {
        static void Main(string[] args)
        {
            //GetEmployeesFullInfo(); Task 3 DONE SUCCESSFULY -- Lines 28-35
            //GetAllEmployesAboveSalary(); Task 4 DONE SUCCESSFULY --Lines 36-43
            //GetEmployeesFromDepartment(); Task 5 - DONE SUCCESSFULY -- Lines 44-58
            //GetEmployeesFromDepartmentVersion();Task 5 official version DONE SUCCESSFULY -- Lines 59-71
            // AddAdressAndAssignItToEmployee(); Task 6 DONE SUCCESSFULY -- Lines 72-94
            //FindEmployeesInPeriod(); Task 7 - DONE SUCCESSFULY -- Lines 95-109
            //AddressesByTownName(); Task 8 - DONE SUCCESSFULY -- Lines 110-126
            //EmployeeWithId(); Task 9 - DONE SUCCESSFULY -- Lines 127-139
            //DepartmentsWithMoreThanFiveEmployees(); Task 10 - DONE SUCCESSFULY -- Lines 140-154
            //FindLatestTenProjects(); Task 11 - DONE SUCCESSFULY -- Lines 155-164
            //IncreaseSalaries(); Task 12 - DONE SUCCESSFULY -- Lines 165-182
            //FindEmployeesByFirstNameStartingWithSA();  Task 13 - DONE SUCCESSFULY -- Lines 183-191
            //FirstLetter();Task 14 - DONE SUCCESSFULY -- Lines 191-
            DeleteProjectById(); //
        }
        static void GetEmployeesFullInfo()
        {
            SoftUniContext data = new SoftUniContext();
            foreach (Employee emp in data.Employees.OrderBy(e => e.EmployeeID))
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.MiddleName} {emp.JobTitle} {emp.Salary}");
            }
        }
        static void GetAllEmployesAboveSalary()
        {
            SoftUniContext data = new SoftUniContext();
            foreach (Employee emp in data.Employees.OrderBy(e => e.EmployeeID).Where(e => e.Salary > 50000))
            {
                Console.WriteLine($"{emp.FirstName}");
            }
        }
        static void GetEmployeesFromDepartment()
        {
            int depID = 0;
            SoftUniContext data = new SoftUniContext();
            var department = data.Departments.Where(d => d.Name == "Research and Development");
            
            foreach (Department dep in department)
            {
                depID= dep.DepartmentID;
            }
            foreach (Employee emp in data.Employees.Where(e => e.DepartmentID == depID).OrderBy(e => e.Salary).ThenByDescending(e => e.FirstName))
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} from Research and Development - ${emp.Salary:F2}");
            }
        }
        static void GetEmployeesFromDepartmentVersion()
        {
            SoftUniContext data = new SoftUniContext();
            var employees = data.Employees
                                .Where(e => e.Department.Name == "Research and Development")
                                .OrderBy(e => e.Salary)
                                .ThenByDescending(e => e.FirstName);

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} from {emp.Department.Name} - ${emp.Salary:F2}");
            }
        }
        static void AddAdressAndAssignItToEmployee()
        {
            SoftUniContext data = new SoftUniContext();
            //Adding the new address
            var addressAdd = new Address()
            {
                AddressText = "Vitoshka 15",
                TownID = 4
            };
            data.Addresses.Add(addressAdd);
            data.SaveChanges();
            // Assigning the new address to employee with LastName = "Nakov"
            var address = data.Addresses.SingleOrDefault(a => a.AddressText == "Vitoshka 15");
            var employee = data.Employees.SingleOrDefault(e => e.LastName == "Nakov");
            employee.AddressID = address.AddressID;
            data.SaveChanges();

            var emp = data.Employees.Select(e => e).OrderByDescending(e => e.AddressID).Take(10);
            foreach (var element in emp)
            {
                Console.WriteLine($"{element.Address.AddressText}");
            }
        }
        static void FindEmployeesInPeriod()
        {
            SoftUniContext data = new SoftUniContext();
            var employees = data.Employees
                                    .Where(e => e.Projects.Count(x => (x.StartDate.Year >= 2001) && (x.StartDate.Year <= 2003)) > 0)
                                    .Take(30);
            foreach (var e in employees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} {e.Manager.FirstName}");
                foreach(var p in e.Projects)
                {
                    Console.WriteLine($"--{p.Name} {p.StartDate:M/d/yyyy h:mm:ss tt} {p.EndDate:M/d/yyyy h:mm:ss tt}");
                }
            }
        }
        static void AddressesByTownName()
        {
            SoftUniContext context = new SoftUniContext();
            List<Address> adresList = new List<Address>();
            adresList = context.Addresses
                                .OrderByDescending(a => a.Employees.Count())
                                .ThenBy(a => a.Town.Name)
                                .Take(10)
                                .ToList();
            foreach (Address adr in adresList)
            {
                int countEmployeesByAddr = context.Employees.Where(e => e.AddressID == adr.AddressID).Count();
                Console.WriteLine($"{adr.AddressText}, {adr.Town.Name} - {countEmployeesByAddr} employees ");
            }
        }
        static void EmployeeWithId()
        {
            SoftUniContext context = new SoftUniContext();
            Employee chosenEmployee = new Employee();
            chosenEmployee = context.Employees.Where(e => e.EmployeeID == 147).First();
            Console.WriteLine($"{chosenEmployee.FirstName} {chosenEmployee.LastName} {chosenEmployee.JobTitle}");
            List<Project> projects = chosenEmployee.Projects.OrderBy(p=>p.Name).ToList();
            foreach (Project proj in projects)
            {
                Console.WriteLine($"{proj.Name}");
            }
        }
        static void DepartmentsWithMoreThanFiveEmployees()
        {
            SoftUniContext context = new SoftUniContext();
            List<Department> departments = context.Departments.Where(d=>d.Employees.Count()>5).OrderBy(d => d.Employees.Count()).ToList();
            foreach (Department dep in departments)
            {
                Console.WriteLine($"{dep.Name} {dep.Manager.FirstName}");
                List<Employee> employees = dep.Employees.ToList();
                foreach (Employee emp in employees)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.JobTitle}");
                }
            }
        }
        static void FindLatestTenProjects()
        {
            SoftUniContext context = new SoftUniContext();
            List<Project> projects = context.Projects.OrderByDescending(p => p.StartDate).Take(10).ToList();
            string formatDate = "M/d/yyyy h:mm:ss tt";
            foreach (Project proj in projects.OrderBy(p=>p.Name))
            {
                Console.WriteLine($"{proj.Name} {proj.Description} {proj.StartDate:M/d/yyyy h:mm:ss tt} {proj.EndDate:M/d/yyyy h:mm:ss tt}");
            }
        }
        static void IncreaseSalaries()
        {
            SoftUniContext context = new SoftUniContext();
            List<Employee> employees = context.Employees
                    .Where(e => (e.Department.Name == "Engineering") 
                    || (e.Department.Name == "Tool Design") 
                    || (e.Department.Name == "Marketing") 
                    || (e.Department.Name == "Information Services"))
                    .ToList();
            foreach (Employee emp in employees)
            {
                emp.Salary *= 1.12m;
                Console.WriteLine($"{emp.FirstName} {emp.LastName} (${emp.Salary:f6})");
            }
            context.SaveChanges();
        }
        static void FindEmployeesByFirstNameStartingWithSA()
        {
            SoftUniContext context = new SoftUniContext();
            List<Employee> employees = context.Employees.Where(e => e.FirstName.Substring(0, 2).ToUpper() == "SA").ToList();
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} - {emp.JobTitle} - (${emp.Salary:f4})");
            }
        }
        static void FirstLetter()
        {
            GringotsContext context = new GringotsContext();
            List<string> firstLetters = new List<string>();
            foreach (WizzardDeposit wis in context.WizzardDeposits.Where(w => w.DepositGroup == "Troll Chest"))
            {
                firstLetters.Add(wis.FirstName.Substring(0, 1));
            }
            foreach (string f in firstLetters.Distinct().OrderBy(x=>x))
            {
                Console.WriteLine(f);
            }
        }
        static void DeleteProjectById()
        {
            SoftUniContext context = new SoftUniContext();
            Project project = context.Projects.Find(2);
            foreach (Employee emp in context.Employees)
            {
                emp.Projects.Remove(project); 
            }
            context.Projects.Remove(project);
            context.SaveChanges();
            foreach (Project proj in context.Projects.Take(10))
            {
                Console.WriteLine($"{proj.Name}");
            }

        }
    }
    
}
