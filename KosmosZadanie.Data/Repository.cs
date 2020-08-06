using System;
using System.Collections.Generic;

namespace KosmosZadanie.Data
{
    public class Repository
    {
        public Wszechswiat Wszechswiat { get; private set; }

        public Repository() {
            Wszechswiat = XmlHandler.DeserializeObject();
        }
        public void Save(Wszechswiat wszechswiat)
        {
            XmlHandler.WriteXML(Wszechswiat);
            Wszechswiat = wszechswiat;
        }
    }
}
