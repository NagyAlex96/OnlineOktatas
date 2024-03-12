namespace Ora_001
{
    public abstract class Employee : IEmployee
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
                if (this.salary - value < 0)
                {
                    throw new NegativSalary(this.Salary - value, "A fizetés nm lehet kisebb 0-nál");
                }
                else
                {
                    salary = value;
                }
            }
        }

        public abstract override string ToString();

        public abstract void RaiseSalary(double value);

        public abstract void CutSalary(double value);
    }
}
