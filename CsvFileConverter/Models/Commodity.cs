using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsvFileConverter.Models
{
    public class Commodity
    {
        [XmlElement("Nazwa")]
        public string Name { get; set; }

        [XmlElement("Cena")]
        public decimal Price { get; set; }
        [XmlElement("Opis")]
        public Description Description { get; set; } = new Description();

        public Commodity()
        {

        }
        public Commodity(string csvLine)
        {
            string[] values = csvLine.Split(';');
            NumberStyles style = NumberStyles.AllowDecimalPoint;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("pl-PL");
            Name = values[0];
            Price = Decimal.TryParse(values[1], style, culture, out decimal price) ? price : 0.0M;
            Description.A = values[2];
            Description.B = values[3];
        }

    }


}
