namespace XML_and_JSON
{
    using System;
    using System.IO;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Data data = new Data
            {
                Name = name,
                Age = age,
                Email = email
            };

            XMLManager xmlManager = new XMLManager(data);
            JSONManager jsonManager = new JSONManager(data);


            xmlManager.Save("data.xml");


            jsonManager.Save("data.json");

            Data xmlData = xmlManager.Load("data.xml");
            Console.WriteLine("Data from XML:");
            Console.WriteLine($"Name: {xmlData.Name}, Age: {xmlData.Age}, Email: {xmlData.Email}");

    
            Data jsonData = jsonManager.Load("data.json");
            Console.WriteLine("\nData from JSON:");
            Console.WriteLine($"Name: {jsonData.Name}, Age: {jsonData.Age}, Email: {jsonData.Email}");
        }
    }
}