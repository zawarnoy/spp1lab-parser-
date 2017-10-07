namespace parser.Core.Habra
{
    class HabraSettings : IParserSettings
    {

        public HabraSettings(int start, int end)
        {
            EndPoint = end;
            StartPoint = start;
        }

        public string BaseUrl { get; set; } = "https://habrahabr.ru";

        public int EndPoint { get; set; }

        public string Prefix { get; set; } = "page{CurrentId}";

        public int StartPoint { get; set; }
    }
}
