using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AlapLINQ
{
    internal class Worker :Employee
    {
        public Worker(string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
        }

        public override void CutSalary(double value)
        {
            this.Salary -= value;
        }

        public override void RaiseSalary(double value)
        {
            this.Salary += value;
        }

        public override string ToString()
        {
            return $"Az adott dolgozó típusa {this.GetType().Name}" +
                $"\nNeve: {this.LastName} {this.FirstName}" +
                $"\nFizetése: {Salary}\n";
        }
    }
}
