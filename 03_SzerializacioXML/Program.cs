using System.Xml.Serialization;

namespace _03_SzerializacioXML
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

            XmlSerializer xml = new XmlSerializer(typeof(List<Allatok>));

            FileStream file = File.Create("allatok.xml");


            xml.Serialize(file, allatLista);
            

            file.Close();

            Console.WriteLine("Lefutott a kiírás");

            StreamReader inFile = new StreamReader("allatok.xml");
            List<Allatok> allat = (List<Allatok>)xml.Deserialize(inFile);

            inFile.Close();

            Console.WriteLine("Lefutott a beolvasás");


        }


    }
}
