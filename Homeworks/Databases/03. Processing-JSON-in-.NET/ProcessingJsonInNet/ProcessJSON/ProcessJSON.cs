using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ProcessJSON
{
    internal class ProcessJSON
    {
        private const string RssUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        private const string FilePath = "../../../rss.xml";

        internal static void Main()
        {
            try
            {
                DownloadRssToFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            

            var jsonObj = GetJsonFromRssFile();            
            var videos = GetVideoTitles(jsonObj);
            Console.WriteLine("============ VIDEO TITLES ============");
            foreach (var video in videos)
            {
                Console.WriteLine(video);
            }

            Console.WriteLine("======================================");
            Console.WriteLine();

            var pocosEntries = GetPocosEntriesFromJson(jsonObj);

            GenerateHtmlFile(pocosEntries);
        }

        private static void DownloadRssToFile()
        {
            WebClient wc = new WebClient();
            wc.DownloadFile(RssUrl, FilePath);
            Console.WriteLine("RSS File Downloaded!");
            Console.WriteLine();
        }

        private static JObject GetJsonFromRssFile()
        {
            var doc = XDocument.Load(FilePath);
            string json = JsonConvert.SerializeXNode(doc, Formatting.Indented);
            var jsonObj = JObject.Parse(json);
            Console.WriteLine("RSS File converted to JSON!");
            Console.WriteLine();
            return jsonObj;
        }

        private static IList<string> GetVideoTitles(JObject jsonObj)
        {
            var videoTitles = jsonObj["feed"]["entry"]
                .Select(v => (string)v["title"])
                .ToList<string>();

            return videoTitles;
        }

        private static IList<Entry> GetPocosEntriesFromJson(JObject jsonObj)
        {
            var entry = jsonObj["feed"]["entry"]
                .Select(e => JsonConvert.DeserializeObject<Entry>(e.ToString()))
                .ToList();

            Console.WriteLine("POCO Created!");
            Console.WriteLine();
            return entry;
        }

        private static void GenerateHtmlFile(IList<Entry> entries)
        {
            var fileData = new StringBuilder();
            fileData.AppendLine("<!DOCTYPE html>");
            fileData.AppendLine("<html>");
            fileData.AppendLine("<head>");
            fileData.AppendLine("   <title>Telerik Videos</title>");
            fileData.AppendLine("   <link rel='stylesheet' href='style.css' />");
            fileData.AppendLine("</head>");
            fileData.AppendLine("<body>");
            fileData.AppendLine("   <h1>Telerik Videos</h1>");
            fileData.AppendLine("   <ul>");

            foreach (var video in entries)
            {
                fileData.AppendLine("       <li>");
                fileData.AppendLine($"          <iframe src='{video.MediaGroup.MediaContent.Url}'></iframe>");
                fileData.AppendLine("       </li>");
            }         

            fileData.AppendLine("   </ul>");
            fileData.AppendLine("</body>");            
            fileData.AppendLine("</html>");

            var htmlFilePath = "../../../index.html";
            using (var writter = new StreamWriter(htmlFilePath))
            {
                writter.Write(fileData.ToString());
            }

            Console.WriteLine("HTML File Created!");
            Console.WriteLine();
        }
    }
}