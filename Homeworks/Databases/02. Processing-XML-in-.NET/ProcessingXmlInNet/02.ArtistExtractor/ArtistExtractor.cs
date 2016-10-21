using System;
using System.Collections;
using System.Xml;

namespace _02.ArtistExtractor
{
    internal class ArtistExtractor
    {
        internal static void Main()
        {
            XmlDocument doc = new XmlDocument();
            string filePath = "../../../../catalog.xml";
            doc.Load(filePath);
            Hashtable table = new Hashtable();
            XmlNode catalog = doc.DocumentElement;
            foreach (XmlNode album in catalog.ChildNodes)
            {
                var currentArtist = album["artist"].InnerText;
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