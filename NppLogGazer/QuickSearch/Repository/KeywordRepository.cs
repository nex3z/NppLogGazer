using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.IO;
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

        public List<KeywordModel> GetAll()
        {
            if (!file.Exists)
            {
                return new List<KeywordModel>();
            }

            using (FileStream fs = File.Open(file.FullName, FileMode.OpenOrCreate))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<KeywordModel>));
                try
                {
                    List<KeywordModel> keywords = (List<KeywordModel>)ser.Deserialize(fs);
                    return keywords;
                }
                catch (Exception exception)
                {
                    throw (new LoadKeywordListException(exception.Message));
                }
            }
        }

        public void ReplaceAll(List<KeywordModel> keywords)
        {
            try
            {
                TextWriter writer = new StreamWriter(file.FullName);
                XmlSerializer ser = new XmlSerializer(typeof(List<KeywordModel>));
                ser.Serialize(writer, keywords);
                writer.Close();
            }
            catch (Exception ex)
            {
                throw (new SaveKeyworkListException(ex.Message));
            }
        }

    }
}
