namespace _02_EventAlap
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

            counter.KiiratasEvent += KiiratasEventtel;
            counter.Kiiratas(KiiratasSiman);


            Console.WriteLine("\n");

            counter.KiiratasIndexxel(KiiratasIndexxel);


            Console.WriteLine("\n\nLefutott");
        }

        static void KiiratasSiman(int num)
        {
            Console.WriteLine(num);
        }

        static void KiiratasIndexxel(int value, int index)
        {
            Console.WriteLine($"Az {index}. helyen található elem értéke: {value}");
        }

        static void KiiratasEventtel(int value)
        {
            Console.WriteLine($"Az event elsütésre került. A következő értéknél: {value}");
        }


    }
}
