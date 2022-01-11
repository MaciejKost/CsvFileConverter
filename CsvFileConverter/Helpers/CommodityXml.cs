using CsvFileConverter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CsvFileConverter.Helpers
{
    [XmlRoot("Plik")]
    public class CommodityXml
    {
        [XmlArray("Towary")]
        [XmlArrayItem("Towar")]
        public List<Commodity> CommoditiesList { get; set; }
    }

    
}
