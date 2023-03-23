using System.Transactions;
using System.Xml;

XmlDocument document = new XmlDocument();
document.Load("C:\\Users\\filip\\OneDrive\\Skrivbord\\sma_gentext.xml");

XmlNode? node = document.SelectSingleNode("/root/file/body/trans-unit[@id='42007']");

if (node != null)
{
    XmlNode? targetNode = node.SelectSingleNode("target");

    if (targetNode != null)
    {
        Console.WriteLine(targetNode.InnerText);
    }
}
else if (node == null)
{
    Console.WriteLine("No target found");
}

