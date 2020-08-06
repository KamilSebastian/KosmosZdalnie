using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace KosmosZadanie.Data
{
    public class XmlHandler
    {
        public static void WriteXML(Wszechswiat wszechswiat)
        {

            XElement xml =
                new XElement("Wszechswiat",new XElement("Galaktyki",wszechswiat.Galaktyki.Select(i => new XElement("Galaktyka", new XElement("Nazwa", i.Nazwa), new XElement("Typ", i.Typ), i.Gwiazdy.Select(z => new XElement("Gwiazdy", new XElement("Gwiazda", new XElement("Nazwa",z.Nazwa), new XElement("Wiek", z.Wiek))))))));

            xml.Save("KosmosData.xml");

        }
        public static Wszechswiat DeserializeObject()
        {
            XmlSerializer serializer =
            new XmlSerializer(typeof(Wszechswiat));

            XElement Wszechswiat = XElement.Load(@"KosmosData.xml");

            XDocument doc = XDocument.Parse(Wszechswiat.ToString());
            var list = doc.Elements("Wszechswiat").Elements("Galaktyki").Select(x => x.Element("Galaktyka")).Select(y => Galaktyka.Create((string)y.Element("Nazwa"), (string)y.Element("Typ"), y.Elements("Gwiazdy").Select(u=> u.Element("Gwiazda")).Select(z => Gwiazda.Create((string)z.Element("Nazwa"),(int)z.Element("Wiek"))).ToList())).ToList();
            return new Wszechswiat(list);

        }
    }
}
