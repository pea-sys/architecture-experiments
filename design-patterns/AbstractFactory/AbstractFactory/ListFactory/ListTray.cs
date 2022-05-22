using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace ListFactory
{
    internal class ListTray : Tray
    {
        public ListTray(string caption) : base(caption) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<li>");
            sb.AppendLine($"{caption}");
            sb.AppendLine("<ul>");
            IEnumerator<Item> e = tray.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.MakeHTML());
            }
            sb.AppendLine("</ul>");
            sb.AppendLine("</li>");
            return sb.ToString();
        }
    }
}
