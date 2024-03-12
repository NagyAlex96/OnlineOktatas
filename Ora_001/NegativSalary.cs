namespace Ora_001
{
    internal class NegativSalary : BasicException
    {
        public NegativSalary(double salary, string message) : base(message)
        {
            this.Salary = salary;
        }
        public double Salary { get; private set; }
    }
}
