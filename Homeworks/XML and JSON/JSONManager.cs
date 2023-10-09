using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace XML_and_JSON
{
    public class JSONManager
    {
        private Data data;

        public JSONManager(Data data)
        {
            this.data = data;
        }

        public void Save(string fileName)
        {
            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(fileName, jsonData);
        }

        public Data Load(string fileName)
        {
            string jsonData = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<Data>(jsonData);
        }
    }

}
