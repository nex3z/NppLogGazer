using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace NppLogGazer.QuickSearch.Repository
{
    class KeywordRepository : IKeywordRepository
    {
        public BindingList<KeywordModel> KeywordList { get; set; }

        public KeywordRepository()
        {
            KeywordList = new BindingList<KeywordModel>();
        }

        public void Add(KeywordModel item)
        {
            if (item != null)
                KeywordList.Add(item);
        }

        public void RemoveItemAt(int position)
        {
            if (position >= 0 && position < KeywordList.Count)
                KeywordList.RemoveAt(position);
        }

        public void SwapItemAt(int first, int second)
        {
            if (first >= 0 && first < KeywordList.Count && second >= 0 && second < KeywordList.Count)
            {
                KeywordModel tmp = KeywordList[first];
                KeywordList[first] = KeywordList[second];
                KeywordList[second] = tmp;
            }
        }

        public void Load(String filePath)
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

        public void Save(String filePath)
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
