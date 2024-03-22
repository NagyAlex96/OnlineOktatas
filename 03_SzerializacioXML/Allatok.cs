using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _03_SzerializacioXML
{

    [XmlRoot]
    [XmlInclude(typeof(Emlosok))]
    [XmlInclude(typeof(Hullok))]
    public class Allatok
    {

        public string Neve { get;  set; }
        public int Sulya { get;  set; }

    }
}
