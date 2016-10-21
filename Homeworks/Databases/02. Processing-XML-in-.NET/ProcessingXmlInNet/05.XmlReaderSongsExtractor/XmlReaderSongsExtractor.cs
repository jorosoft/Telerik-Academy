using System;
using System.Xml;

namespace _05.XmlReaderSongsExtractor
{
    internal class XmlReaderSongsExtractor
    {
        internal static void Main()
        {
            string filePath = "../../../../catalog.xml";
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                    (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
