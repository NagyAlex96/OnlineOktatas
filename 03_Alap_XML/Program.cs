using System.Xml.Linq;

namespace _03_Alap_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xml = new XDocument();

            XElement root = new XElement("Állatok");
            xml.Add(root);

            XElement emlosok = new XElement("Emlősök");

            emlosok.Add(new XElement("Róka"));
            emlosok.Add(new XElement("Farkas"));
            emlosok.Add(new XElement("Őz"));

            root.Add(emlosok);

            xml.Save("Allatok.xml");
        }
    }
}
