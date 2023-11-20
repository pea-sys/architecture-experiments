# ネットワーク上のパイプ
https://learn.microsoft.com/ja-jp/dotnet/standard/io/how-to-use-named-pipes-for-network-interprocess-communication

名前付きパイプは、パイプ サーバーと 1 つ以上のパイプ クライアントとの間でのプロセス間通信を提供します。 名前付きパイプには、ローカル コンピューター上のプロセス間通信を提供する匿名パイプと比較して、より多くの機能が用意されています。 名前付きパイプは、ネットワーク上の複数のサーバー インスタンスでの全二重通信、メッセージ ベースの通信、およびクライアント偽装をサポートしています。  
全てのパイプは named pipe filesystem (NPFS) のルートディレクトリに置かれ、ファイルベースのやり取りとして扱える。
