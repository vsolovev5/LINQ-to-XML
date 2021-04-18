using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LINQ_to_XML
{
    public class Task1
    {
        public string[] OpenTxt(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string[] lines = sr.ReadToEnd()
                        .Split(Environment.NewLine);

                return lines;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во время чтения файла.");
                return null;
            }
        }
        public string ConvertToXML(string[] lines)
        {
            XElement xmlTree1 = new XElement("Root");
            foreach (string line in lines)
            {
                xmlTree1.Add(new XElement("line", line));
            }
            string XML = xmlTree1.ToString();
            return XML;
        }
        
    }
}
