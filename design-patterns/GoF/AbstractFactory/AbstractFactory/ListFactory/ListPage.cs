using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace ListFactory
{
    internal class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author) 
        {
        }
        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"<html><head><title>{title}</title></head>");
            sb.AppendLine("<body>");
            sb.Append($"<h1>{title}</h1>");
            sb.AppendLine("<ul>");
            IEnumerator<Item> e = content.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.MakeHTML());
            }
            sb.AppendLine("</ul>");
            sb.Append($"<hr><address>{author}</address>");
            sb.AppendLine("</body></html>");
            return sb.ToString();
        }
    }
}
