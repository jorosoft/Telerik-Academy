using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace _08.AlbumsExtractor
{
    internal class AlbumsExtractor
    {
        internal static void Main()
        {
            string filePath = "../../../../catalog.xml";
            string resultFilePath = "../../album.xml";
            var albums = new List<string>();
            var artists = new List<string>();
            using (XmlReader reader = XmlReader.Create(filePath))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "name")
                        {
                            albums.Add(reader.ReadElementString());
                        }

                        if (reader.Name == "artist")
                        {
                            artists.Add(reader.ReadElementString());
                        }
                    }
                }
            }

            Encoding encoding = Encoding.GetEncoding("utf-8");
            using (XmlTextWriter writer = new XmlTextWriter(resultFilePath, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");
                for (int i = 0; i < albums.Count; i++)
                {
                    WriteAlbum(writer, albums[i], artists[i]);
                }

                writer.WriteEndDocument();
                Console.WriteLine("XML FILE CREATED!");
                Console.WriteLine();
            }            
        }

        private static void WriteAlbum(XmlWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }
    }
}
