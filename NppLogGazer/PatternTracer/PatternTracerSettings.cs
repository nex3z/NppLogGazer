using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NppLogGazer.PatternTracer
{
    public class PatternTracerSettings
    {
        public static string ConfigDir = "";
        public static string Version = Main.PluginVersion;
        public static string PluginName = Main.PluginName;
        public static Config Configs;

        public class Config
        {
            public string version = PatternTracerSettings.Version;
            public bool showOnStartup = false;
            public bool matchWord = false;
            public bool matchCase = false;
            public bool wrapSearch = true;
            public bool isRegExp = false;
        }

        public static void LoadConfigs()
        {
            string configFileName = Path.Combine(ConfigDir, PluginName + "PatternTracerConfig.xml");
            try
            {
                FileStream fs = new FileStream(configFileName, FileMode.Open);
                XmlSerializer ser = new XmlSerializer(typeof(Config));
                Configs = (Config)ser.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                // File.Delete(configFileName);
                // MessageBox.Show("ex " + ex.Message);
                Configs = new PatternTracerSettings.Config();
            }
        }

        public static void SaveConfigs()
        {
            string configFileName = Path.Combine(ConfigDir, PluginName + "PatternTracerConfig.xml");
            try
            {
                TextWriter writer = new StreamWriter(configFileName);
                XmlSerializer ser = new XmlSerializer(typeof(Config));
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
