using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AlapLINQ
{
    internal abstract class Employee : IEmployee
    {
        private string lastName, firstName;
        private double salary;

        public Employee(string firstName, string lastName, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public string FirstName { get => this.firstName; }
        public string LastName { get => this.lastName; }

        public double Salary
        {
            get => this.salary;
            set
            {
                //negatív esetén exception
                salary = value;
            }
        }

        public abstract override string ToString();

        public abstract void RaiseSalary(double value);

        public abstract void CutSalary(double value);
    }

}
