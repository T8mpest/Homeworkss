using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace XML_and_JSON
{
    public class XMLManager
    {
        private Data data;

        public XMLManager(Data data)
        {
            this.data = data;
        }

        public void Save(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                serializer.Serialize(stream, data);
            }
        }

        public Data Load(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Data));
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                return (Data)serializer.Deserialize(stream);
            }
        }
    }
}
