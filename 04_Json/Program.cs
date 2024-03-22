using Newtonsoft.Json;
using System.Xml.Serialization;

namespace _04_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Allatok> allatLista = new List<Allatok>();

            Allatok e1 = new Emlosok()
            {
                Neve = "Kutya",
                Sulya = 10,
                UtodokSzama = 6
            };

            Allatok e2 = new Emlosok()
            {
                Neve = "Macska",
                Sulya = 10,
                UtodokSzama = 6
            };

            Allatok h1 = new Hullok()
            {
                Neve = "Kígyó",
                Sulya = 10,
                TojasokSzama = 60
            };

            Allatok h2 = new Hullok()
            {
                Neve = "Gyík",
                Sulya = 10,
                TojasokSzama = 10
            };

            allatLista.Add(e1);
            allatLista.Add(e2);
            allatLista.Add(h1);
            allatLista.Add(h2);

            string content = JsonConvert.SerializeObject(allatLista, Formatting.Indented); //A formating nem kötelező, de ha nincs ott, akkor egy sorba írja ki a "Json"-t és úgy csúnya. Indented-el szépen rendezett lett

            File.WriteAllText("Allatok.json", content);
            content = File.ReadAllText("Allatok.json");
            Console.WriteLine("Kiiratás OK");

            List<Allatok> uj = JsonConvert.DeserializeObject<List<Allatok>>(content);

            Console.WriteLine("Beolvasás OK");
        }
    }
}
