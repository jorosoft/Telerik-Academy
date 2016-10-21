using System;
using System.Xml;

namespace _11.LastFiveYearsAlbumsExtractor
{
    internal class LastFiveYearsAlbumsExtractor
    {
        internal static void Main()
        {
            XmlDocument doc = new XmlDocument();
            string filePath = "../../../../catalog.xml";
            doc.Load(filePath);
            var beforeFiveYears = DateTime.UtcNow.AddYears(-5).Year;
            string xPathQuery = "/catalog/album[year>" + beforeFiveYears + "]/name";
            XmlNodeList lastFiveYearsAlbums = doc.SelectNodes(xPathQuery);
            foreach (XmlNode album in lastFiveYearsAlbums)
            {
                Console.WriteLine(album.InnerText);
            }

            Console.WriteLine();
        }
    }
}
