using System;
using System.Linq;
using System.Xml.Linq;

namespace _12.LastFiveYearsAlbumsWithLINQ
{
    internal class LastFiveYearsAlbumsWithLINQ
    {
        internal static void Main()
        {
            string filePath = "../../../../catalog.xml";
            XDocument doc = XDocument.Load(filePath);
            var beforeFiveYears = DateTime.UtcNow.AddYears(-5).Year.ToString();
            var lastFiveYearsAlbums =
                from album in doc.Descendants("album")
                where album.Element("year").Value.CompareTo(beforeFiveYears) >= 0
                select album.Element("name");
            foreach (var item in lastFiveYearsAlbums)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();
        }
    }
}
