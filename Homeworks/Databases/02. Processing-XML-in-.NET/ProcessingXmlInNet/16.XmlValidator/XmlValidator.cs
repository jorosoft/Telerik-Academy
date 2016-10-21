using System;
using System.Xml.Linq;
using System.Xml.Schema;

namespace _16.XmlValidator
{
    internal class XmlValidator
    {
        internal static void Main()
        {
            string xmlFilePath = "../../../../catalog.xml";
            string xsdFilePath = "../../../../catalog.xsd";

            // Check with valid XML file
            ValidateXml(xmlFilePath, xsdFilePath);

            string invalidXmlFilePath = "../../../../invalid-catalog.xml";

            // Check with invalid XML file
            ValidateXml(invalidXmlFilePath, xsdFilePath);
        }

        private static void ValidateXml(string xmlFilePath, string xsdFilePath)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(null, xsdFilePath);
            XDocument doc = XDocument.Load(xmlFilePath);
            string msg = "";
            doc.Validate(
                schemas, 
                (o, e) => 
                {
                    msg += e.Message + Environment.NewLine;
                });

            Console.WriteLine(msg == "" ? $"XML Document '{xmlFilePath}' is valid!" : $"XML Document '{xmlFilePath}' is invalid: " + msg);
            Console.WriteLine();
        }
    }
}
