using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsvFileConverter.Helpers
{
    public class OpenDialog
    {
        private OpenFileDialog _dialog;
        public string FileName
        {
            get
            {
                return _dialog.SafeFileName;
            }
        }

        public OpenDialog()
        {
            _dialog = new OpenFileDialog
            {
                DefaultExt = ".csv",
                Filter = "Pliki tekstowe (,csv)|*.csv"
            };
        }
        /// <summary>
        /// Returns selected file path
        /// </summary>
        /// <returns>String or null when no file selected</returns>
        public string GetFilePath()
        {
            return _dialog.ShowDialog() == true ? _dialog.FileName : null;
        }
    }
}
