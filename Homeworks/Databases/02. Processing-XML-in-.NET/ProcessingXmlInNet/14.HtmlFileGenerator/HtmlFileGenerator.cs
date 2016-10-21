using System;
using System.Xml.Xsl;

namespace _14.HtmlFileGenerator
{
    internal class HtmlFileGenerator
    {
        internal static void Main()
        {
            string xmlFilePath = "../../../../catalog.xml";
            string xslFilePath = "../../../../catalog.xsl";
            string htmlFilePath = "../../../../index.html";
            XslTransform xslt = new XslTransform();
            xslt.Load(xslFilePath);
            xslt.Transform(xmlFilePath, htmlFilePath);
            Console.WriteLine("HTML File Created!");
            Console.WriteLine();
        }
    }
}
