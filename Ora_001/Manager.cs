namespace Ora_001
{
    public class Manager : Employee
    {
        public Manager(int teamSize, string firstName, string lastName, double salary) : base(firstName, lastName, salary)
        {
            this.TeamSize = teamSize;
        }

        public int TeamSize { get; private set; }

        public override void CutSalary(double value)
        {
            this.Salary -= (value * 0.9); //10000 = 10000 - (1000*0.9)
        }

        public override void RaiseSalary(double value)
        {
            this.Salary += (value * 1.25);
        }

        public static Manager operator ++(Manager manager)
        {
            manager.TeamSize += 2;
            return manager;
        }

        public override string ToString()
        {
            return $"Az adott dolgozó típusa: {this.GetType().Name}\nNeve: {this.LastName} {this.FirstName}\nFizetés: {Salary}\nHozzá tartozó csapat mérete: {this.TeamSize}\n";
        }
    }
}
