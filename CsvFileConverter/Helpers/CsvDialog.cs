using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsvFileConverter.Helpers
{
    public class CsvDialog
    {
        private OpenFileDialog _dialog;

        public CsvDialog()
        {
            _dialog = new OpenFileDialog();
            _dialog.FileName = "Document";
            _dialog.DefaultExt = ",csv";
            _dialog.Filter = "Comma saperated values(.csv)|*.csv";
        }

        public string GetFilePath()
        {
            bool? dialogResult = _dialog.ShowDialog();
            if (dialogResult == true)
              return _dialog.FileName;
            return null;
        }
    }
}
