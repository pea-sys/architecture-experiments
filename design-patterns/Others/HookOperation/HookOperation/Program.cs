using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookOperation
{
    /// <summary>
    /// HookOperationパターン・・・メソッドの実際の処理の前後に「フック」をつけておき、 前処理・後処理を別のクラスに行わせる
    /// 
    /// delegateでも同じことは出来ると思いますが、実装を閉じ込めるという点が肝なのかも
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Print> lst = new List<Print>()
            {
                new Print("NullHook"),
                new Print("LogHook", new LogHook())
            };
            lst.ForEach(x => x.Write());
            Console.ReadLine();
        }

    }
}
