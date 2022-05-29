using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    /// <summary>
    /// Commandパターン・・・命令をオブジェクトとして表現する
    /// 
    /// デバイスドライバの開発でお世話になっています
    /// 結果コード含めて、コマンドインターフェースを初めに定義しておくことで、テストが容易になります
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
            Application.Run(new Form());
        }
    }
}
