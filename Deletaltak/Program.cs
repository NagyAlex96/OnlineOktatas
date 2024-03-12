using static Deletaltak.Counter;

namespace Deletaltak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SajatDelegate();



            Console.WriteLine("\n\nLefutott!");
        }

        static void SajatDelegate()
        {
            /* Mi a delegált?
                * Röviden: olyan típus, amiben el lehet tárolni különböző metódusokat / függvényeket. Mintha egy metódus lista lenne. Nem a legjobb megoldás, hiszen könnyen eltávolítható belőle egy metódus.
                * 
                * MultiCast delegate esetén mindegyik metódus lefut, amikor meghívjuk a delegáltat
                * 
                * Helyette érdemes "Event"-et használni

            */


            Counter counter = new Counter(5);

            counter.AddNumber(10);
            counter.AddNumber(20);
            counter.AddNumber(30);
            counter.AddNumber(40);
            counter.AddNumber(50);

            counter.Kiiratas(Kiiratas);

            ////Ilyen esetben minden hozzáadott metódus lefut <-- ez egy multiCast Delegate

            ////valami(2);
            ////Console.WriteLine("count: " + counter.Count);


            //foreach (var item in valami.GetInvocationList())
            //{
            //    Console.WriteLine($"Metódus: {item.Method.Name}");
            //}


            //KiiratasDelegate kiiratas = null;
            //kiiratas += Kiiratas1;
            //kiiratas += Kiiratas2;


            //kiiratas();
        }

        static void Kiiratas(int number)
        {
            Console.WriteLine(number);
        }


    }
}
