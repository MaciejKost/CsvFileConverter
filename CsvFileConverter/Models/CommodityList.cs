using CsvFileConverter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvFileConverter.Models
{
    class CommodityList
    {
        [XmlArrayItem("Stara")]
        public List<Commodity> CommoditiesList { get; set; }

        /// <summary>
        /// Returns list sorted by name
        /// </summary>
        public List<Commodity> GetOrderByName()
        {
            return CommoditiesList?.OrderBy(n => n.Name).ToList();
        }
        
        /// <summary>
        /// Returns list sorted by price
        /// </summary>
        public List<Commodity> GetOrderByPrice()
        {
            return CommoditiesList?.OrderByDescending(p => p.Price).ToList();
        }

        /// <summary>
        /// Returns list where description A or B contain param
        /// </summary>
        /// <param name="desc">Searching parameter</param>
        /// <returns></returns>
        public List<Commodity> SearchByDesc(string desc)
        {
            return CommoditiesList?.Where(d => d.Description.A.Contains(desc, StringComparison.InvariantCultureIgnoreCase) || d.Description.B.Contains(desc, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        /// <summary>
        /// Returns List<Commodity> from file
        /// </summary>
        /// <param name="filepath">File path</param>
        /// <returns></returns>
        public async Task<List<Commodity>> GetCommodityList(string filepath)
        {
            List<Commodity> list = new List<Commodity>();

            if (filepath == null)
                return list;

            using var sr = new StreamReader(filepath);
            while (true)
            {
                var line = await sr.ReadLineAsync();
                if (line == null)
                    break;
                list.Add(Commodity.FromCsv(line));
            }
            return list;
        }

    }
}
