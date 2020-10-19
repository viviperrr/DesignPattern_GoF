using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.BasicExample
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Score { get; set; }

        public Employee(int id, string name, decimal salary, int score)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Score = score;
        }
    }
}
