using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class PageMaker
    {
        public static void MakeWelcomePage(string mailAddr, string fileName)
        {
            try
            {
                var mailprop = Database.GetProperties("maildata");
                var userName = mailprop.Get(mailAddr);
                var writer =
                    new HtmlWriter(new StreamWriter(fileName, false, Encoding.Default));
                writer.Title($"Welcome to {userName}'s page!");
                writer.Paragraph($"{userName}のページへようこそ。");
                writer.Paragraph("メールまっていますね。");
                writer.Mailto(mailAddr, userName);
                writer.Close();
                Console.WriteLine($"{fileName} is created for {mailAddr} ({userName})");
            }
            catch (IOException e)
            {
                Console.Error.WriteLine(e.StackTrace);
            }
        }
    }
}
