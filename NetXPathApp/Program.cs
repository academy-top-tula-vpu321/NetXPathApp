using System.Xml;

string xmlFileName = @"D:\employees.xml";

XmlDocument xmlDocument = new XmlDocument();
xmlDocument.Load(xmlFileName);

XmlElement? root = xmlDocument.DocumentElement;

var nodeList = root.SelectNodes("//Employee[@position]");

foreach(XmlNode e in nodeList)
    Console.WriteLine(e.OuterXml);

