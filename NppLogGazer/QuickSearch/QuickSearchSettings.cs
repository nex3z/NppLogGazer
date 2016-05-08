using NppLogGazer.Common.Setting;

namespace NppLogGazer.QuickSearch
{
    public class QuickSearchSettings : Settings<NppLogGazer.QuickSearch.QuickSearchSettings.QuickSearchConfig>
    {
        private static QuickSearchSettings instance = null;

        private QuickSearchSettings()
        {
        }

        public static QuickSearchSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new QuickSearchSettings();
                }
                return instance;
            }
        }

        public class QuickSearchConfig : Config {
            public bool ShowOnStartup { get; set; }
            public bool MatchWord { get; set; }
            public bool MatchCase { get; set; }
            public bool WrapSearch { get; set; }
            public bool IsRegExp { get; set; }

            public QuickSearchConfig()
            {
                Version = Main.PluginVersion;

                ShowOnStartup = false;
                MatchWord = false;
                MatchCase = false;
                WrapSearch = true;
                IsRegExp = false;
            }
        }
    }
}
