using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NppLogGazer.Common.Setting
{
    public abstract class Settings<T> where T: Config, new()
    {
        public string ConfigDir { get; set; }

        public const string Version = Main.PluginVersion;
        public const string PluginName = Main.PluginName;

        private T configs;

        public T Configs
        {
            get
            {
                return configs;
            }
            protected set
            {
                configs = value;
            }
        }

        public void LoadConfigs()
        {
            string configFileName = Path.Combine(ConfigDir, PluginName + typeof(T).Name + ".xml");
            try
            {
                FileStream fs = new FileStream(configFileName, FileMode.Open);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                Configs = (T)ser.Deserialize(fs);
                fs.Close();
            }
            catch (Exception)
            {
                // File.Delete(configFileName);
                T ttt = new T();
                Configs = ttt;
            }
        }

        public void SaveConfigs()
        {
            string configFileName = Path.Combine(ConfigDir, PluginName + typeof(T).Name + ".xml");
            try
            {
                TextWriter writer = new StreamWriter(configFileName);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, Configs);
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex " + ex.Message);
                File.Delete(configFileName);
            }
        }
    }
}
