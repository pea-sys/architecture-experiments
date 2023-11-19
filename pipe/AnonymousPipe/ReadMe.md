# ローカルに閉じたパイプ
https://learn.microsoft.com/ja-jp/dotnet/standard/io/how-to-use-named-pipes-for-network-interprocess-communication

サンプルは親プロセスと子プロセスの通信を匿名パイプで行う  
匿名パイプは一方向通信で共有メモリで通信するので早い。  
匿名パイプはローカルで機能し、親プロセスの用意した共有メモリに読み書きすることで通信を行う

