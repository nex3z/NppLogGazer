using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NppLogGazer.QuickSearch.Repository
{
    public class KeywordRepository : IKeywordRepository
    {
        private FileInfo file;

        public KeywordRepository(FileInfo file)
        {
            this.file = file;
        }

        public IList<KeywordModel> GetAll()
        {
            if (!file.Exists)
            {
                return new List<KeywordModel>();
            }

            using (FileStream fs = File.Open(file.FullName, FileMode.OpenOrCreate))
            {
                XmlSerializer ser = new XmlSerializer(typeof(BindingList<KeywordModel>));
                try
                {
                    IList<KeywordModel> keywords = (IList<KeywordModel>)ser.Deserialize(fs);
                    return keywords;
                }
                catch (InvalidOperationException exception)
                {
                    throw (new LoadKeywordListException(exception.Message));
                }
            }
        }

        public void ReplaceAll(IList<KeywordModel> keywords)
        {
            try
            {
                TextWriter writer = new StreamWriter(file.FullName);
                XmlSerializer ser = new XmlSerializer(typeof(IList<KeywordModel>));
                ser.Serialize(writer, keywords);
                writer.Close();
            }
            catch (Exception ex)
            {
                File.Delete(file.FullName);
                throw (new SaveKeyworkListException(ex.Message));
            }
        }

    }
}
