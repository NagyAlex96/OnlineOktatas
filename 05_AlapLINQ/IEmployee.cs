namespace _05_AlapLINQ
{
    internal interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }

        double Salary { get; set; }

        void RaiseSalary(double value);
        void CutSalary(double value);
    }
}