using System;
using System.Linq;
using System.Xml.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement srcTree = new XElement("Root",
                new XElement("Element", 1),
                new XElement("Element", 2),
                new XElement("Element", 3),
                new XElement("Element", 4),
                new XElement("Element", 5)
            );
            XElement xmlTree = new XElement("Root",
                new XElement("Child", 1),
                new XElement("Child", 2),
                from el in srcTree.Elements()
                where (int)el > 2
                select el
            );
            Console.WriteLine(xmlTree);
        }
    }
}
