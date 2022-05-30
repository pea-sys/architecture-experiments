using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace TableFactory
{
    internal class TableLink : Link
    {
        public TableLink(string caption, string url) : base(caption, url) { }

        public override string MakeHTML()
        {
            return $"<td><a href=\"{url}\">{caption}</a></td>\n";
        }
    }
}
