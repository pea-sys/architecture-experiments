## Windows サービスの作成

https://learn.microsoft.com/ja-jp/dotnet/core/extensions/windows-service

Worker を使って Windows サービスを作る方法を確認してみた。  
昔作った際には timer の選定から気を付けるべき点があったりと
罠を踏みがちだった気がする。
Worker テンプレートを使えば、手戻り少なくサービスが作れるので良いと思う。  
あと、これは Windows10 の話になっちゃいますが、WIndows サービスの回復設定良いですね（もしかしたら昔からかあるかもですが知らなかった。）

実際、使用する場合には、バージョンアップのやり方を決めて作りこんでおく必要はありそうですね。

## ■ ログ

```pwsh
sc.exe create ".NET Joke Service" binpath="C:\Users\user\source\repos\WindowsServiceSample\bin\publish\WindowsServiceSample.exe"
[SC] CreateService SUCCESS
PS C:\Users\user> sc qfailure ".NET Joke Service"
[SC] QueryServiceConfig2 SUCCESS

SERVICE_NAME: .NET Joke Service
        RESET_PERIOD (in seconds)    : 0
        REBOOT_MESSAGE               :
        COMMAND_LINE                 :

PS C:\Users\user> sc.exe failure ".NET Joke Service" reset=0 actions=restart/60000/restart/60000/run/1000
[SC] ChangeServiceConfig2 SUCCESS
PS C:\Users\user> sc qfailure ".NET Joke Service"
[SC] QueryServiceConfig2 SUCCESS

SERVICE_NAME: .NET Joke Service
        RESET_PERIOD (in seconds)    : 0
        REBOOT_MESSAGE               :
        COMMAND_LINE                 :
        FAILURE_ACTIONS              : RESTART -- 遅延 = 60000 ミリ秒です。
                                       RESTART -- 遅延 = 60000 ミリ秒です。
                                       RUN PROCESS -- 遅延 = 1000 ミリ秒です。

PS C:\Users\user> sc.exe start ".NET Joke Service"

SERVICE_NAME: .NET Joke Service
        TYPE               : 10  WIN32_OWN_PROCESS
        STATE              : 2  START_PENDING
                                (NOT_STOPPABLE, NOT_PAUSABLE, IGNORES_SHUTDOWN)
        WIN32_EXIT_CODE    : 0  (0x0)
        SERVICE_EXIT_CODE  : 0  (0x0)
        CHECKPOINT         : 0x0
        WAIT_HINT          : 0x7d0
        PID                : 10116
        FLAGS              :
PS C:\Users\user> sc.exe stop ".NET Joke Service"

SERVICE_NAME: .NET Joke Service
        TYPE               : 10  WIN32_OWN_PROCESS
        STATE              : 3  STOP_PENDING
                                (STOPPABLE, NOT_PAUSABLE, ACCEPTS_SHUTDOWN)
        WIN32_EXIT_CODE    : 0  (0x0)
        SERVICE_EXIT_CODE  : 0  (0x0)
        CHECKPOINT         : 0x0
        WAIT_HINT          : 0x0
PS C:\Users\user> sc.exe delete ".NET Joke Service"
[SC] DeleteService SUCCESS
```
