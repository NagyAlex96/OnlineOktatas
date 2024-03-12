namespace Ora_001
{
    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }

        double Salary { get; set; }

        void RaiseSalary(double value);
        void CutSalary(double value);


    }
}
