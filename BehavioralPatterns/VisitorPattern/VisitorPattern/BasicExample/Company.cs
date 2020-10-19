using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.BasicExample
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();

        public Company()
        {
            employees.Add(new Employee(1, "Kyle Kim", 50000, 100));
            employees.Add(new Employee(2, "Grace Lee", 60000, 90));
            employees.Add(new Employee(3, "Min Choi", 70000, 80));
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var emp in employees)
            {
                // Visit Method is an operation from outside.
                visitor.Visit(emp);
            }
        }

        internal void DisplayData()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.Id} {emp.Name} {emp.Salary}");
            }
        }
    }
}
