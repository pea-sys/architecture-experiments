using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace TableFactory
{
    internal class TableTray : Tray
    {
        public TableTray(string caption) : base(caption) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<td>");
            sb.Append("<table width=\"100%\" border=\"1\"><tr>");
            sb.Append($"<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"{tray.Count}\"<b>{caption}</b></td>");
            sb.AppendLine("</tr>");
            sb.AppendLine("<tr>");
            IEnumerator<Item> e = tray.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.MakeHTML());
            }
            sb.Append("<tr></table>");
            sb.Append("</tr>");
            return sb.ToString();
        }
    }
}
