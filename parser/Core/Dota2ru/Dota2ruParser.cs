using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace parser.Core.Dota2ru 
{
    class Dota2ruParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {

            var list = new List<string>();

            var items = document.QuerySelectorAll("h3").Where(item => item.ClassName != null
            && item.ClassName.Contains("title"));

            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }

           // string[] lol = { document.DocumentElement.OuterHtml, "" };
           // return lol;
            return list.ToArray();
        }
    }
}
