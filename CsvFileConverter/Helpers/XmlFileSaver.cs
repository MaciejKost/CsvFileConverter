using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CsvFileConverter.Helpers
{
    public class XmlFileSaver<T> where T : class
    {
     
        private XmlSerializer _serializer = new XmlSerializer(typeof(T));

        public string _filepath { get; set; } = "myCsv.xml";
        public FileMode _fileMode { get; set; } = FileMode.Create;

        public XmlFileSaver()
        {

        }
        public XmlFileSaver(string filepath, FileMode fileMode)
        {
            _filepath = filepath;
            _fileMode = fileMode;
        }

        public void SaveToFile(T dataToSave, bool openAfterSave = false)
        {
            if (dataToSave == null)
                return;
            using var fs = new FileStream(_filepath, _fileMode);
            _serializer.Serialize(fs, dataToSave);
            fs.Close();
            if (openAfterSave)
            System.Diagnostics.Process.Start("explorer.exe", fs.Name);
        }


    }
}
