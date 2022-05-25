using System.Collections.Generic;

namespace ProjectFileConverter
{
    public class AppSettings
    {
        public string LastTargetFormat { get; set; }
        public List<string> HistoryOutputDir { get; set; }
        public Identifier Identifier { get; set; }

        public string OpenSvipPath { get; set; }
        public string Theme { get; set; }
        public string DoneMessageAppearance { get; set; }
        public bool IsOpenOutputDir { get; set; }
        public bool IsShowCommandBeforeConverting { get; set; }
    }

    public class Identifier
    {
        public string InputIdentifier { get; set; }
        public string OutputIdentifier { get; set; }
    }
}
