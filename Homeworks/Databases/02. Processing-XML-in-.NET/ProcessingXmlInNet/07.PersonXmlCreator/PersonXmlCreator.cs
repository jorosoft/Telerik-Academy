using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace _07.PersonXmlCreator
{
    internal class PersonXmlCreator
    {
        internal static void Main()
        {
            string txtFilePath = "../../person.txt";
            string xmlFilePath = "../../personXML.xml";
            var personData = new List<string>();
            using (var reader = new StreamReader(txtFilePath))
            {
                while (!reader.EndOfStream)
                {
                    personData.Add(reader.ReadLine());
                }
            }

            XElement personXml = new XElement(
                "person",
                new XElement("name", personData[0]),
                new XElement("address", personData[1]),
                new XElement("phone", personData[2]));

            personXml.Save(xmlFilePath);
            Console.WriteLine("XML FILE CREATED!");
            Console.WriteLine();
        }
    }
}
