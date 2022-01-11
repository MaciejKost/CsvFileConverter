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
        private XmlFileSaver<List<Commodity>> _xmlFileSaver;
        private XmlFile _xmlFile;

        public MainWindow()
        {
            InitializeComponent();
            _dialog = new CsvDialog();
            _fileReader = new FileReader();
            _xmlFileSaver = new XmlFileSaver<List<Commodity>>("CommodotyCsv.xml", FileMode.Create);
            _xmlFile = new XmlFile();
        }

        private async void openFile_Click(object sender, RoutedEventArgs e)
        {
            _xmlFile.CommodityList = await _fileReader.GetCommodityList(_dialog.GetFilePath());
            if (_xmlFile.CommodityList.Count > 0)
            {
                sortByNameBtn.IsEnabled = true;
                sortByPriceBtn.IsEnabled = true;
                searchByDescBtn.IsEnabled = true;
            }
        }

        private void sortByName_Click(object sender, RoutedEventArgs e)
        {
            _xmlFileSaver.SaveToFile(_xmlFile.GetOrderByName(), true);
        }

        private void sortByPrice_Click(object sender, RoutedEventArgs e)
        {
            _xmlFileSaver.SaveToFile(_xmlFile.GetOrderByPrice(), true);
        }


        private void searchByDesc_Click(object sender, RoutedEventArgs e)
        {
            var searchText = searchTextBox.Text;
            if (searchText.Length > 0)
                lvCommodity.ItemsSource = _xmlFile.SearchByDesc(searchText);
        }


    }
}
