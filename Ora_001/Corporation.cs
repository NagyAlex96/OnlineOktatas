namespace Ora_001
{
    public class Corporation
    {
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
                throw new CorporationLimitReached(this.Employees.Length, $"Nem lehet több munkavállalót alkalmazni!");
            }
        }

        public IEmployee this[int index]
        {
            get => Employees[index];
            set => Employees[index] = value;
        }
    }
}
