# Understandによるコード解析
テクトマトリクス社のunderstandを使用したソース解析を行います(基本有料なのでトライアル版で）。

### [ソース]
https://www.techmatrix.co.jp/product/understand/

### [使い方]
マニュアルは読まずに適当に使います。
今回はiLSpyを解析します。
https://github.com/icsharpcode/ILSpy

* プロジェクトを読み込む
![1](https://github.com/pea-sys/architecture-experiments/assets/49807271/69a2d0f7-0d61-4a51-9c58-a6270ee7cda5)
* 解析するプロジェクトを絞り込まない場合はスキップ押下
![2](https://github.com/pea-sys/architecture-experiments/assets/49807271/2e4b2cbf-20b4-4f56-ad3b-8d00748ddd03)
* プロジェクト作成後に詳細設定を構成するにチェックを入れてプロジェクトの作成
![3](https://github.com/pea-sys/architecture-experiments/assets/49807271/70ab2270-9c90-4ba5-a641-fe2a88806e49)
* 詳細設定が表示されるのでOK
![4](https://github.com/pea-sys/architecture-experiments/assets/49807271/fc53289d-a3e9-41d4-b6b8-18f1f2aea496)
* プロジェクトの解析を行う
![5](https://github.com/pea-sys/architecture-experiments/assets/49807271/256778c9-2586-485b-9332-55e526ffc5ca)
* 解析が終わると結果が表示されます
![6](https://github.com/pea-sys/architecture-experiments/assets/49807271/396292ec-c598-4c42-9140-993789c06690)
* モジュールの依存関係図も出力可能
![Dependencies-DirectoryStructure](https://github.com/pea-sys/architecture-experiments/assets/49807271/0491ce6e-4bd5-489d-a44e-6c61fc2016aa)
* ツリーマップも出力可能(面積は行数、色の濃さが複雑度)
![treemap](https://github.com/pea-sys/architecture-experiments/assets/49807271/94f2627e-3b36-427d-87ad-25f9258a32c3)

解析速度が速くて、サクサク扱える
また、グラフィカルなので使っていて楽しい。  
他にも色々できそう。