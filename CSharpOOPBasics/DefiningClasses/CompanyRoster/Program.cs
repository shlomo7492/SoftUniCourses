using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i=0;i<n;i++)
            {
                string[] inputData = Console.ReadLine().Split(' ');
                employees.Add(new Employee(inputData));
            }
            decimal averageSalary = 0m;
            string departmentWithHighesAverageSalary = "";
            foreach (var department in employees.Select(e=>e.Department).Distinct())
            {
                decimal temp = employees.Where(e => e.Department == department).Select(e => e.Salary).Sum();
                if (averageSalary < temp)
                {
                    averageSalary = temp;
                    departmentWithHighesAverageSalary = department;
                }
            }
            Console.WriteLine($"Highest Average Salary: {departmentWithHighesAverageSalary}");
            foreach (var employee in employees.Where(e=>e.Department==departmentWithHighesAverageSalary).OrderByDescending(e=>e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }

        }
        public class Employee
        {
            private string name;
            private decimal salary;
            private string position;
            private string department;
            private string email;
            private int age;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    this.name = value;
                }
            }
            public decimal Salary
            {
                get
                {
                    return salary;
                }
                set
                {
                    this.salary = value;
                }
            }
            public string Position
            {
                get
                {
                    return position;
                }
                set
                {
                    this.position = value;
                }
            }
            public string Department
            {
                get
                {
                    return department;
                }
                set
                {
                    this.department = value;
                }
            }
            public string Email
            {
                get
                {
                    return email;
                }
                set
                {
                    this.email = value;
                }
            }
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    this.age = value;
                }
            }
            public Employee(string[] inputData)
            {
                try
                {
                    if (inputData.Length == 4)

                    {
                        this.name = inputData[0];
                        this.salary = decimal.Parse(inputData[1]);
                        this.position = inputData[2];
                        this.department = inputData[3];
                        this.email = "n/a";
                        this.age = -1;
                    }
                    else if (inputData.Length == 5)
                    {
                        int intVar = 0;
                        if (int.TryParse(inputData[4], out intVar))
                        {
                            this.name = inputData[0];
                            this.salary = decimal.Parse(inputData[1]);
                            this.position = inputData[2];
                            this.department = inputData[3];
                            this.email = "n/a";
                            this.age = intVar;
                        }
                        else
                        {
                            this.name = inputData[0];
                            this.salary = decimal.Parse(inputData[1]);
                            this.position = inputData[2];
                            this.department = inputData[3];
                            this.email = inputData[4];
                            this.age = -1;
                        }
                    }
                    else if (inputData.Length == 6)
                    {
                        this.name = inputData[0];
                        this.salary = decimal.Parse(inputData[1]);
                        this.position = inputData[2];
                        this.department = inputData[3];
                        this.email = inputData[4];
                        this.age = int.Parse(inputData[5]);
                    }
                }
                catch
                {
                    Console.WriteLine("Name,Salary,Position and Department are mandatory!");
                }
            }
        }

    }
}
