using CsvFileConverter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CsvFileConverter.Helpers
{
    [Serializable]
    [XmlRootAttribute("Towary")]
    class XmlFile
    {
        [XmlAttribute("test")]
        public List<Commodity> CommodityList { get; set; }

        /// <summary>
        /// Returns list sorted by name
        /// </summary>
        public List<Commodity> GetOrderByName()
        {
            return CommodityList != null ? CommodityList.OrderBy(n => n.Name).ToList() : null;
        }
        
        /// <summary>
        /// Returns list sorted by price
        /// </summary>
        public List<Commodity> GetOrderByPrice()
        {
            return CommodityList != null ? CommodityList.OrderByDescending(p => p.Price).ToList() : null;
        }

        /// <summary>
        /// Returns list where description A or B contain param
        /// </summary>
        /// <param name="desc">Searching parameter</param>
        /// <returns></returns>
        public List<Commodity> SearchByDesc(string desc)
        {
            return CommodityList != null ? CommodityList.Where(d => d.Description.A.Contains(desc) || d.Description.B.Contains(desc)).ToList() : null;
        }

    }
}
