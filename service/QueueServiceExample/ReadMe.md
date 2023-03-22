## QueueService のサンプル

https://learn.microsoft.com/ja-jp/dotnet/core/extensions/queue-service
公式ページの謳い文句としては、バックグラウンドでの作業項目のキューイングサービスを動かしたいケースで使用するとのこと。  
んー、でもコンソールアプリでも実現できそうだし、明確な差が腑に落ちていないので、同じ悩みをもつであろう人目線で少し調べてみました。
https://www.reddit.com/r/dotnet/comments/xizszs/worker_service_vs_console_application/

■ ご意見抜粋

- サービスの場合、問題が起きてクラッシュしても再起動されることで常駐が保証される(サービスの設定による)
- Linux ではコンソールアプリとサービスに明確な違いはない
- 取り合えずワーカーテンプレートがあるのだから、それを使った方が簡単に実現できる
