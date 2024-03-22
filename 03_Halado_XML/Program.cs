using System.Collections.Generic;
using System.Xml.Linq;

namespace _03_Halado_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xml = new XDocument();

            XElement root = new XElement("Állatok");
            xml.Add(root);

            XElement emlosok = new XElement("Emlősök");

            emlosok.Add(new XElement("Róka", "Ravazdi"));
            emlosok.Add(new XElement("Farkas", "Vérszomjas"));
            emlosok.Add(new XElement("Őz", "Jámbor"));

            root.Add(emlosok);

            XElement hullok = new XElement("Hűllők");
            XElement kigyok = new XElement("Kígyók");
            kigyok.Add(new XElement("FeketeMamba", "Mérges")); //FONTOS, hogy az első tag: (Fekete mamba) között nem lehet Space
            kigyok.Add(new XElement("Vizisikló", "Ártalmatlan"));

            XElement gyikok = new XElement("Gyíkok");
            XAttribute attribute = new XAttribute("title", "Zsarnok");
            gyikok.Add(attribute);

            gyikok.Add(new XElement("Vakondgyíkfélék", "Vakond"));
            gyikok.Add(new XElement("Páncélosgyíkfélék", "Páncélosgyík"));


            hullok.Add(kigyok);
            hullok.Add(gyikok);
            root.Add(hullok);

            xml.Save("Allatok.xml");

            Console.WriteLine("Kiiírás sikeres\n\n");

            Console.WriteLine("Visszaolvasás");
            VisszaOlvasas();
        }

        static void VisszaOlvasas()
        {
            //if file.exist
            XDocument xml = XDocument.Load("Allatok.xml");

            XElement root = xml.Element("Állatok");

            XElement emlosok = root.Element("Emlősök");

            Console.WriteLine("Állatok");
            Console.WriteLine("\tEmlősök");

            foreach (var item in emlosok.Elements())
            {
                Console.WriteLine("\t\t"+item.Name);
            }


        }
    }
}
