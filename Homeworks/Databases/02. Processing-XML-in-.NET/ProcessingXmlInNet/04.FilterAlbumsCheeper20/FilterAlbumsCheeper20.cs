using System;
using System.Xml;

namespace _04.FilterAlbumsCheeper20
{
    internal class FilterAlbumsCheeper20
    {
        internal static void Main()
        {
            XmlDocument doc = new XmlDocument();
            string filePath = "../../../../catalog.xml";
            string resultFilePath = "../../filteredCatalog.xml";
            doc.Load(filePath);
            string xPathQuery = "/catalog/album";
            XmlNodeList albums = doc.SelectNodes(xPathQuery);
            const decimal MaxPrice = 20;
            for (int i = albums.Count - 1; i >= 0; i--)
            {
                decimal currentPrice = Convert.ToDecimal(albums[i]["price"].InnerText);
                if (currentPrice > MaxPrice)
                {
                    albums.Item(i).ParentNode.RemoveChild(albums[i]);
                }
            }

            doc.Save(resultFilePath);

            doc.Load(resultFilePath);
            XmlNode root = doc.DocumentElement;
            Console.WriteLine("FILTERED ALBUMS:");
            Console.WriteLine("=================");
            foreach (XmlNode album in root.ChildNodes)
            {
                Console.WriteLine($"{album["artist"].InnerText} - {album["name"].InnerText}");
            }

            Console.WriteLine();
        }
    }
}
