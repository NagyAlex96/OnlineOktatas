namespace Ora_001
{
    internal class CorporationLimitReached : BasicException
    {
        public CorporationLimitReached(int employeeLimit,string message) : base(message)
        {
            this.EmployeeLimit = employeeLimit;
        }

        public int EmployeeLimit { get; private set; }
    }
}
