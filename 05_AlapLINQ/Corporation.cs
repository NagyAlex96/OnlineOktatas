using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AlapLINQ
{
    internal class Corporation
    {
        private string[] kNevek = { "Mike", "Elton", "Robert", "Tim", "Zena", "Ulrik", "India", "Olga", "Peter", "Anthony", "Steve", "Dalton", "Freia", "George", "Helga", "Jake", "Kimber", "Lena", "Xena", "Calvin", "Victor", "Blake", "Nina", "Mike" };

        private string[] vNevek = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Garcia", "Milner", "Wilson", "Taylor", "Moore", "Jackson", "Martin", "Robinson", "Scott", "Wright" };

        public Corporation(int employeeNumber)
        {
            this.Employees = new IEmployee[employeeNumber];
        }

        public IEmployee[] Employees { get; private set; }

        public void AddEmployee(Employee employee)
        {
            int i = 0;

            while (i < Employees.Length && Employees[i] != null)
            {
                i++;
            }

            if (i < Employees.Length)
            {
                Employees[i] = employee;
            }
            else
            {
                //throw new CorporationLimitReached(this.Employees.Length, $"Nem lehet több munkavállalót alkalmazni!");
            }
        }

        public IEmployee this[int index]
        {
            get => Employees[index];
            set => Employees[index] = value;
        }

        public Employee GenerateEmployee()
        {
            Random rand = new Random();
            int ertek = rand.Next(0, 100);
            Employee emp = null;
            if (ertek < 10)
            {
                int teamSize = rand.Next(3, 12);
                double salary = rand.Next(900000, 5000000);
                string fName = kNevek[rand.Next(0, kNevek.Length - 1)];
                string lName = vNevek[rand.Next(0, vNevek.Length - 1)];

                emp = new Manager(teamSize, fName, lName, salary);
            }
            else
            {
                double salary = rand.Next(200000, 800000);
                string fName = kNevek[rand.Next(0, kNevek.Length - 1)];
                string lName = vNevek[rand.Next(0, vNevek.Length - 1)];

                emp = new Worker(fName, lName, salary);
            }

            return emp;
        }
    }
}
