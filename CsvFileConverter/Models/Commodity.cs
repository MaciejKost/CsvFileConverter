using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvFileConverter.Models
{
    public class Commodity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Description Description { get; set; } = new Description();

        public static Commodity FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            decimal price;
            NumberStyles style = NumberStyles.AllowDecimalPoint;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("pl-PL");
            Commodity commodity = new Commodity();
            commodity.Name = values[0];
            commodity.Price = Decimal.TryParse(values[1], style, culture, out price) ? price : 0.0M;
            commodity.Description.A = values[2];
            commodity.Description.B = values[3];
            return commodity;
        }

    }


}
