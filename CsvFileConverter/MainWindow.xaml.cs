using CsvFileConverter.Helpers;
using CsvFileConverter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace CsvFileConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CsvDialog _dialog;
        private FileReader _fileReader;
        private XmlFile<List<Commodity>> _xmlFile;
        public List<Commodity> commodityList;
        public MainWindow()
        {
            InitializeComponent();
            _dialog = new CsvDialog();
            commodityList = new List<Commodity>();
            _fileReader = new FileReader();
            _xmlFile = new XmlFile<List<Commodity>>();


        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            _xmlFile.Data = await _fileReader.GetCommodityList(_dialog.GetFilePath());
        }

        private void sortByName_Click(object sender, RoutedEventArgs e)
        {
            _xmlFile.Data.OrderBy(x => x.Name);
            _xmlFile.SaveToFile();
        }
    }
}
