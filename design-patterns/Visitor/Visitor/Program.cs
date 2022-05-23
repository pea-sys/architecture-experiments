using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    /// <summary>
    /// Visitorパターン・・・データ構造と処理を分離します
    /// 
    /// ダブルディスパッチしたい場合に使用する
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Making root entries...");
                Directory rootdir = new Directory("root");
                Directory bindir = new Directory("bin");
                Directory tmpdir = new Directory("tmp");
                Directory usrdir = new Directory("usr");
                rootdir.Add(bindir);
                rootdir.Add(tmpdir);
                rootdir.Add(usrdir);
                bindir.Add(new File("vi", 10000));
                bindir.Add(new File("latex", 20000));
                rootdir.Accept(new ListVisitor());

                Console.WriteLine("");
                Console.WriteLine("Making user entries...");
                Directory yuki = new Directory("yuki");
                Directory hanako = new Directory("hanako");
                Directory taro = new Directory("taro");
                usrdir.Add(yuki);
                usrdir.Add(hanako);
                usrdir.Add(taro);
                yuki.Add(new File("diary.html", 100));
                yuki.Add(new File("Composite.java", 200));
                hanako.Add(new File("memo.tex", 300));
                taro.Add(new File("game.doc", 400));
                taro.Add(new File("junk.mail", 500));
                rootdir.Accept(new ListVisitor());
            }

            catch (FileTreatmentException e)
            {
                e.ToString();
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
