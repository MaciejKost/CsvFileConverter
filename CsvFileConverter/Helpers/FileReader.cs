using CsvFileConverter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CsvFileConverter.Helpers
{
    public class FileReader
    {
        public FileReader()
        {

        }

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
