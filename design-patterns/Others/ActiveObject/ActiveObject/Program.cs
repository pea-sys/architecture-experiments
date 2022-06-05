using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveObject
{
    /// <summary>
    /// ActiveObjectパターン・・・能動的なオブジェクトとしてオブジェクトが固有のスレッドを持つ(クライアント)
    /// 　　　　　　　　　　　　　ワーカースレッドが実処理を行うサーバーの役割
    /// 
    /// サンプルプログラムがやや難解だったのでメモ
    /// Scheduler・・・リクエストキューの出し入れ
    /// ActivationQueue・・・リクエストキュー
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            ActiveObject activeObject = ActiveObjectFactory.CreateActiveObject();

            Task.Run(() => new MakerClientThread("Alice",activeObject).Run());
            Task.Run(() => new MakerClientThread("Bobby",activeObject).Run());
            Task.Run(() => new DisplayClientThread("Chirs",activeObject).Run());

            Console.ReadKey();
        }
    }
}
