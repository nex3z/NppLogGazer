using NppLogGazer.Common.Setting;

namespace NppLogGazer.PatternTracer
{
    public class PatternTracerSettings : Settings<NppLogGazer.PatternTracer.PatternTracerSettings.PatternTracerConfig>
    {
        private static PatternTracerSettings instance = null;

        private PatternTracerSettings()
        {
        }

        public static PatternTracerSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PatternTracerSettings();
                }
                return instance;
            }
        }

        public class PatternTracerConfig : Config
        {
            public bool ShowOnStartup { get; set; }
            public bool MatchWord { get; set; }
            public bool MatchCase { get; set; }
            public bool WrapSearch { get; set; }
            public bool IsRegExp { get; set; }

            public PatternTracerConfig()
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
