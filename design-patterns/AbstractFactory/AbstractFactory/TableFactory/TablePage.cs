using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace TableFactory
{
    internal class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"<html><head><title>{title}</title></head>");
            sb.Append("<body>\n");
            sb.AppendLine($"<h1>{title}</h1>");
            sb.Append("<table width=\"80%\" border=\"3\">\n");
            IEnumerator<Item> e = content.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append($"<tr>{e.Current.MakeHTML()}</tr>");
            }
            sb.AppendLine("</table>");
            sb.Append($"<hr><address>{author}</address>");
            sb.AppendLine("</body></html>");
            return sb.ToString();
        }
    }
}
