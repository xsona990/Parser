using System.Threading.Tasks;
using AngleSharp.Dom.Html;

namespace Parser
{
    interface IParser<T> where T : class
    {
      //  T Parse(IHtmlDocument document);
        T Parse(IHtmlDocument document, string querySelector, string className);
    }
}
