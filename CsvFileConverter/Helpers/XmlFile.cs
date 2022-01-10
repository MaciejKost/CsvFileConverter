using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CsvFileConverter.Helpers
{
    public class XmlFile<T>
    {
       // XmlSerializer _serializer = new XmlSerializer(typeof(T), new XmlRootAttribute("Flibble"));
        XmlSerializer _serializer = new XmlSerializer(typeof(T));
        public T Data { get; set; }
        public XmlFile()
        {

        }

        public void SaveToFile()
        {
            using var fs = new FileStream("CommodityList.xml", FileMode.Create);
            _serializer.Serialize(fs, Data);
            fs.Close();
        }

    }
}
