using System.Diagnostics.Metrics;

namespace _01_DelegateEgyszeru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szamok counter = new Szamok(5);

            counter.AddNumber(10);
            counter.AddNumber(20);
            counter.AddNumber(30);
            counter.AddNumber(40);
            counter.AddNumber(50);

            counter.Kiiratas(Kiiratas);


            Console.WriteLine("\n\nLefutott");
        }

        static void Kiiratas(int num)
        {
            Console.WriteLine()
        }
    }
}
