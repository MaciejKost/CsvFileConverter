using CsvFileConverter.Helpers;
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

namespace CsvFileConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CsvDialog _dialog;
        private FileReader _fileReader;
        public MainWindow()
        {
            InitializeComponent();
            _dialog = new CsvDialog();
            _fileReader = new FileReader();

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = await _fileReader.GetCommodityList(_dialog.GetFilePath());
        }
    }
}
