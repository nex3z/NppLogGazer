using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.QuickSearch.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace NppLogGazer.PatternTracer.Repository
{
    public class PatternRepository : IPatternRepository
    {
        private FileInfo file;

        public PatternRepository(FileInfo file)
        {
            this.file = file;
        }

        public List<PatternModel> GetAll()
        {
            if (!file.Exists)
            {
                return new List<PatternModel>();
            }

            using (FileStream fs = File.Open(file.FullName, FileMode.OpenOrCreate))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<PatternModel>));
                try
                {
                    List<PatternModel> patterns = (List<PatternModel>)ser.Deserialize(fs);
                    return patterns;
                }
                catch (Exception exception)
                {
                    throw (new LoadPatternListException(exception.Message));
                }
            }
        }

        public void ReplaceAll(List<PatternModel> patterns)
        {
            try
            {
                TextWriter writer = new StreamWriter(file.FullName);
                XmlSerializer ser = new XmlSerializer(typeof(List<PatternModel>));
                ser.Serialize(writer, patterns);
                writer.Close();
            }
            catch (Exception ex)
            {
                throw (new SavePatternListException(ex.Message));
            }
        }

    }
}
