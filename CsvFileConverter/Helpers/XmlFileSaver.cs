using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CsvFileConverter.Helpers
{
    public class XmlFileSaver<T> where T : class
    {
     
        private XmlSerializer _serializer = new XmlSerializer(typeof(T),);
        private SaveDialog _saveDialog = new SaveDialog();
  
        public string _filepath { get; set; }
        public FileMode _fileMode { get; set; } = FileMode.Create;

        public XmlFileSaver()
        {

        }
        public XmlFileSaver(FileMode fileMode)
        {
            _fileMode = fileMode;
        }

        /// <summary>
        /// Method to save data in file
        /// </summary>
        /// <param name="dataToSave">Data to save</param>
        /// <param name="openAfterSave">If true file will auto open</param>
        public void SaveToFile(T dataToSave, bool openAfterSave = false)
        {
            if (dataToSave == null)
                return;
            _filepath = _saveDialog.GetSavePath();
            if (_filepath == null)
                return;

            using var fs = new FileStream(_filepath, _fileMode);
            _serializer.Serialize(fs, dataToSave);
            fs.Close();
            if (openAfterSave)
            System.Diagnostics.Process.Start("explorer.exe", fs.Name);
        }


    }
}
