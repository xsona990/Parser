using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    class ParserCreator
    {
        ParserWorker<ParsingResult[]> parser;

       public ParserCreator()
        {
            parser = new ParserWorker<ParsingResult[]>(new Parser());
            parser.ClassName = "g-i-tile-i-title clearfix";
            parser.QuerySelector = "div";
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }
        private void Parser_OnNewData(object arg1, ParsingResult[] arg2)
        {
            foreach (ParsingResult item in arg2)
            {
                Console.WriteLine(item.getText());
                Console.WriteLine("________________");
            }


        }

        private void Parser_OnCompleted(object obj)
        {
            Console.WriteLine("OK!");
        }

        public void parseBtn_Click()
        {
            parser.Settings = new ParserSettings("https://rozetka.com.ua/rock_drills/c153621/", "page={CurrentId}", 1, 2);
            parser.Start();
            Console.ReadKey();
        }
    }
}
