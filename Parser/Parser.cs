using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace Parser
{
    class Parser : IParser<ParsingResult[]>
    {
        public Parser()
        { }
        public ParsingResult[] Parse(IHtmlDocument document, string querySelector, string className)
        {
            var list = new List<ParsingResult>();
            var items = document.QuerySelectorAll(querySelector).Where(item => item.ClassName != null && item.ClassName.Contains(className));
            foreach (var item in items)
            {
                list.Add(new ParsingResult(item.TextContent, item.OuterHtml));
            }
            return list.ToArray();
        }
    }

    public class ParsingResult
    {
        string textContent { get; set;}
        string outerHTML { get; set; }

        public string getText()
        {
            return textContent;
        }

        public ParsingResult(string textContent, string outerHTML)
        {
            this.textContent = textContent;
            this.outerHTML = outerHTML;
        }
    }

}


