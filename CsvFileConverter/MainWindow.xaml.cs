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
        private OpenDialog _dialog;
        private XmlFileSaver<CommodityXml> _xmlFileSaver;
        private CommodityList _commoditiesList;
        private CommodityXml _commodityXml;

        public MainWindow()
        {
            InitializeComponent();
            _dialog = new OpenDialog();
            _xmlFileSaver = new XmlFileSaver<CommodityXml>(FileMode.Create);
            _commoditiesList = new CommodityList();
            _commodityXml = new CommodityXml();
        }

        private async void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var filePath = _dialog.GetFilePath();
                fileNameLabel.Content = $"Ścieżka pliku: {filePath}";
                _commoditiesList.CommoditiesList = await _commoditiesList.GetCommodityList(filePath);
                if (_commoditiesList.CommoditiesList.Count > 0)
                {
                    sortByNameBtn.IsEnabled = true;
                    sortByPriceBtn.IsEnabled = true;
                    searchByDescBtn.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas wczytywania: {ex.Message}", "Bład", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void SortByName_Click(object sender, RoutedEventArgs e)
        {
            _commodityXml.CommoditiesList = _commoditiesList.GetOrderByName();
            _xmlFileSaver.SaveToFile(_commodityXml, true);
        }

        private void SortByPrice_Click(object sender, RoutedEventArgs e)
        {
            _commodityXml.CommoditiesList = _commoditiesList.GetOrderByPrice();
            _xmlFileSaver.SaveToFile(_commodityXml, true);
        }


        private void searchByDesc_Click(object sender, RoutedEventArgs e)
        {
            var searchText = searchTextBox.Text;
            if (searchText.Length > 0)
                dataGrid.ItemsSource = _commoditiesList.SearchByDesc(searchText);
            else
                MessageBox.Show("Wprowadź frazę", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}
