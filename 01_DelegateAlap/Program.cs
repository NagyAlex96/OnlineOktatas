namespace _01_DelegateAlap
{
    internal class Program
    {
        public delegate void CsakKiiratasDelegate();
        public delegate void SzamKiiratasDelegate(int value);

        static void Main(string[] args)
        {
            /* Mi a delegált?
                * Röviden: olyan típus, amiben el lehet tárolni különböző metódusokat / függvényeket. Mintha egy metódus lista lenne. Nem a legjobb megoldás, hiszen könnyen eltávolítható belőle egy metódus.
                * 
                * MultiCast delegate esetén mindegyik metódus lefut, amikor meghívjuk a delegáltat
                * 
                * Helyette érdemes "Event"-et használni

            */

            //egyszerű delegate
            //CsakKiiratasDelegate csakKiiratasDelegate = new CsakKiiratasDelegate(Kiiratas1);
            //csakKiiratasDelegate();


            //multicast delegate
            CsakKiiratasDelegate csakKiiratasDelegate = null;
            SzamKiiratasDelegate szamKiiratasDelegate = null;

           
            csakKiiratasDelegate += Kiiratas1;
            csakKiiratasDelegate += Kiiratas2;
            csakKiiratasDelegate();

            szamKiiratasDelegate += KiiratasSzam1;
            szamKiiratasDelegate += KiiratasSzam2;

            szamKiiratasDelegate(10);


            Console.WriteLine("\n\nLefutott");
        }


        static void Kiiratas1()
        {
            Console.WriteLine("Kiiratás1..");
        }        
        
        static void Kiiratas2()
        {
            Console.WriteLine("Kiiratás2..");
        }        
        

        static void KiiratasSzam1(int szam)
        {
            Console.WriteLine("Szam Kiiratás1.." + (szam+5));
        }   
        
        static void KiiratasSzam2(int szam)
        {
            Console.WriteLine("Szam Kiiratás2.." + (szam+10));
        }
    }
}
