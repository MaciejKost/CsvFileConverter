using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsvFileConverter.Helpers
{
    class SaveDialog
    {
        private SaveFileDialog _dialog;

        public SaveDialog()
        {
            _dialog = new SaveFileDialog
            {
                DefaultExt = ".xml",
                Filter = "Pliki XML (.xml)|*.xml"
            };
        }

        /// <summary>
        /// Returns selected file path
        /// </summary>
        /// <returns>String or null when no file selected</returns>
        public string GetSavePath()
        {
            return _dialog.ShowDialog() == true ? _dialog.FileName : null;
        }
    }
}

