using System;
using System.Collections;
using System.Xml;

namespace _03.ArtistExtractorByXpath
{
    internal class ArtistExtractorByXpath
    {
        internal static void Main()
        {
            XmlDocument doc = new XmlDocument();
            string filePath = "../../../../catalog.xml";
            doc.Load(filePath);
            string xPathQuery = "/catalog/album/artist";
            XmlNodeList artists = doc.SelectNodes(xPathQuery);
            Hashtable table = new Hashtable();
            foreach (XmlNode artist in artists)
            {
                var currentArtist = artist.InnerText;
                if (table.Contains(currentArtist))
                {
                    table[currentArtist] = (int)table[currentArtist] + 1;
                }
                else
                {
                    table.Add(currentArtist, 1);
                }
            }

            foreach (DictionaryEntry artist in table)
            {
                Console.WriteLine($"{artist.Key} - {artist.Value} albums");
            }

            Console.WriteLine();
        }
    }
}
