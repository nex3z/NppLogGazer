using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace NppLogGazer.QuickSearch.Repository
{
    class KeywordRepository
    {
        BindingList<KeywordModel> KeywordList { get; set; }
        String FilePath;

        public KeywordRepository(String filePath)
        {
            this.FilePath = filePath;
            LoadFromFile(this.FilePath);
        }

        public void LoadFromFile(String filePath)
        {

            using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate))
            {
                XmlSerializer ser = new XmlSerializer(typeof(BindingList<KeywordModel>));
                try
                {
                    KeywordList = (BindingList<KeywordModel>)ser.Deserialize(fs);
                }
                catch (InvalidOperationException exception)
                {
                    // MessageBox.Show("Read file error: " + ex.Message + "\nPlease check " + fileName);
                }
            }
        }

        public void SaveToFile(String filePath)
        {
            try
            {
                TextWriter writer = new StreamWriter(filePath);
                XmlSerializer ser = new XmlSerializer(typeof(BindingList<KeywordModel>));
                ser.Serialize(writer, KeywordList);
            }
            catch (Exception exception)
            {
                // MessageBox.Show("Save file error: " + ex.Message);
            }
        }

    }
}
