using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeesCount = int.Parse(Console.ReadLine());

            List<Department> departments = new List<Department>();

            for (int i = 0; i < employeesCount; i++)
            {
                string[] employeeArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                string name = employeeArgs[0];
                decimal salary = decimal.Parse(employeeArgs[1]);
                string departmentName = employeeArgs[2];

                if (!departments.Any(d => d.Name == departmentName))
                {
                    departments.Add(new Department(departmentName));
                }

                Department department = departments.First(d => d.Name == departmentName);
                department.Employees.Add(new Employee(name, salary, departmentName));
            }

            var highestPaidDepartment = departments.First(d => d.AverageSalary == departments.Max(d => d.AverageSalary));

            Console.WriteLine($"Highest Average Salary: {highestPaidDepartment.Name}");

            foreach (var e in highestPaidDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{e.Name} {e.Salary:f2}");
            }
        }
    }

    public class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }



        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }
    }

    public class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Employees = new List<Employee>();
        }



        public string Name { get; set; }

        public List<Employee> Employees { get; set; }

        public decimal AverageSalary => this.Employees.Average(e => e.Salary);
    }
}
