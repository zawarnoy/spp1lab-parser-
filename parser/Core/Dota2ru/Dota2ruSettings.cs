using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parser.Core.Dota2ru
{
    class Dota2ruSettings : IParserSettings
    {


        public string BaseUrl { get; set; } = "https://dota2.ru";

        public int EndPoint { get; set; }

        public string Prefix { get; set; } = null;

        public int StartPoint { get; set; }
    }
}
