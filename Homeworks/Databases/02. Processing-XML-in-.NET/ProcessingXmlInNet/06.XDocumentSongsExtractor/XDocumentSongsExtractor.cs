using System;
using System.Linq;
using System.Xml.Linq;

namespace _06.XDocumentSongsExtractor
{
    internal class XDocumentSongsExtractor
    {
        internal static void Main()
        {
            string filePath = "../../../../catalog.xml";
            XDocument doc = XDocument.Load(filePath);
            var songs =
                from song in doc.Descendants("song")
                select song.Element("title");

            foreach (var song in songs)
            {
                Console.WriteLine(song.Value);
            }
        }
    }
}
