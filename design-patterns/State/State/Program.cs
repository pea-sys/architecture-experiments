namespace State
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  
        ///  Stateパターン・・・状態をクラスとして管理します
        ///  
        ///  個人的にはデバイスドライバの開発で使用しています
        ///  テストがしやすいし、テスト漏れも発生しにくい
        ///  機能が多ければ多い程、Stateパターンの頑健性は役立つと感じてます
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SafeForm());
        }
    }
}