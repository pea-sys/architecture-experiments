using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HtmlWriter
    {
        private StreamWriter writer;

        // コンストラクタ
        public HtmlWriter(StreamWriter writer)
        {
            this.writer = writer;
        }
        // タイトルの出力
        public virtual void Title(string title)
        {
                writer.Write("<html>");
                writer.Write("<head>");
                writer.Write("<title>" + title + "</title>");
                writer.Write("</head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<h1>" + title + "</h1>");
        }
        public virtual void Paragraph(string msg)
        {
            writer.WriteLine($"<p>{msg}</p>");
        }
        public virtual void Link(string href, string caption)
        {
            Paragraph($"<a href=\"{href}\">{caption}</a>");
        }
        public virtual void Mailto(string mailaddr, string userName)
        {
            Link("mailto:" + mailaddr, userName);
        }
        public virtual void Close()
        {
            writer.Write("</body>");
            writer.WriteLine("</html>");
            writer.Close();
        }
    }
}
