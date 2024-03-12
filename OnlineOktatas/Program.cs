using ClassLibrary;

namespace OnlineOktatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Teszteléshez
                NUnit
                NUnit3TestAdapter
                Microsoft.NET.Test.Sdk        
            */

            Corporation corporation = new Corporation(5);

            List<Employee> employees = OwnFileReader.LoadData("file.txt");


            //foreach (Employee item in employees)
            //{
            //    corporation.AddEmployee(item);
            //}

            //foreach (IEmployee item in corporation.Employees)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Lefutott");
        }
    }
}
