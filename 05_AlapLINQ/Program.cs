namespace _05_AlapLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int num = 10000;
            Corporation corporation = new Corporation(num);

            for (int i = 0; i < num; i++)
            {
                var temp = corporation.GenerateEmployee();
                corporation.AddEmployee(temp);
            }

            //corporation.AddEmployee(new Manager(5, "Mike", "Grabovski", 500));
            //corporation.AddEmployee(new Manager(7, "George", "Lucas", 750));

            //corporation.AddEmployee(new Worker("Steven", "Spielberg", 500));
            //corporation.AddEmployee(new Worker("Antony", "Hoppkings", 250));
            //corporation.AddEmployee(new Worker("Elton", "John", 350));


            //Agregáló függ
            var atlagFizu = corporation.Employees.Average(x => x.Salary);

            //EZ A METHOD SYNTAX
            var fizuFelettMSyntax = corporation.Employees.Where(x => x.Salary > 2500000).Select(y=> new
            {
                kNev = y.FirstName,
                fizu = y.Salary
            }).ToList();

            var valami = corporation.Employees.Where(x => x is Manager && (x as Manager).TeamSize > 10).Select(y=>new
            {
                kNev = y.FirstName,
                vNev = y.LastName,
                fizu = y.Salary
            }).OrderBy(x=>x.kNev).ToList();

            foreach (var f in valami)
            {
                Console.WriteLine(f);
            }

            //EZ A QUERY SYNTAX

            var fizuFelettQSyntax = (from X in corporation.Employees
                         where X.Salary > 2500000
                         select new
                         {
                             knev = X.FirstName,
                             fizu = X.Salary
                         }).ToList();


            ;
            Console.WriteLine("Lefutott");

        }
    }
}
