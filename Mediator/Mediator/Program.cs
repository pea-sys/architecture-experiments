using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    /// <summary>
    /// Mediatorパターン・・・複雑な処理を一箇所で調停する
    /// 
    /// 独立して発生する条件が複雑に絡まり、条件変化のタイミングの差異が不確実性を
    /// もたらす場合などに使える。保守しにくい分散されたロジックの見通しが取れるようになる。
    /// イベント駆動をメインにしていると必要になる場合が多そう
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
