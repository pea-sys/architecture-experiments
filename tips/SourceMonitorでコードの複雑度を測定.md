# コードの複雑度を測定
今回は社内都合でpipが使えないのでLizardは見送り  
（パッケージマネージャーとしてのセキュリティ上の信頼性が低い）  
また、VB.NETも解析できる必要がある。

## SourceMonitor
* VB.NETが扱える
* 解析対象コンパイル環境構築不要なのも大きい

### 入手先
[SourceMonitor]  
https://www.derpaul.net/SourceMonitor/

### インストール後の設定
utf-8のファイルの解析を有効にする  
![1](https://github.com/pea-sys/.net-performance-experiments/assets/49807271/de62813f-8ae0-47e0-a440-26886084648a)

### その他注意事項
SorceMonitorがクラッシュする  
もうメンテナンスされていないので修復されることはないでしょう 


### 解析例
ここではILSpyの解析を行う
* 1. SorceMonitorのNewProjectを選択
* 2. 解析する言語を選択
* 3. 次へを選択
![1](https://github.com/pea-sys/.net-performance-experiments/assets/49807271/1ca9bb98-b313-4679-87b8-540066a6877f)
* 4. 解析結果記録ファイル名と解析対象ディレクトリを入力
![2](https://github.com/pea-sys/.net-performance-experiments/assets/49807271/591f46fb-d01a-49f1-b2e9-79705fac606c)
* 5. 何回か次へやOKを押すと解析が始まる
* 6. 解析結果を見る  
サマリーから関数の複雑度順に確認できる
```
Metrics Summary For Checkpoint 'Baseline'
--------------------------------------------------------------------------------------------

Parameter				Value
=========				=====
Project Directory			C:\Users\masami\source\repos\ILSpy\ILSpy\
Project Name				SourceMonitor
Checkpoint Name				Baseline
Created On				11 Nov 2023, 21:06:20
Files					270
Lines					37,125
Statements				17,599
Percent Comment Lines			12.8
Percent Documentation Lines		2.3
Classes, Interfaces, Structs		416
Methods per Class			4.53
Calls per Method			3.26
Statements per Method			5.77
Line Number of Most Complex Method	{undefined}
Name of Most Complex Method		TypeUsedByAnalyzer.ScanMethodBody(ITypeDefinition analyzedType, PEFile module, in MethodDefinition md, FindTypeDecoder decoder)
Maximum Complexity			53
Line Number of Deepest Block		{undefined}
Maximum Block Depth			9+
Average Block Depth			2.15
Average Complexity			2.79

--------------------------------------------------------------------------------------------
Most Complex Methods in 394 Class(es):	Complexity, Statements, Max Depth, Calls

AboutPage.{anonymous}()			5, 25, 5, 19
ActiveTabPageConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)	2, 3, 2, 0
AddToMainList.Execute(TextViewContext context)	4, 8, 4, 3
AnalyzeCommand.Execute(object parameter)	6, 7, 4, 4
AnalyzedAccessorTreeNode.AnalyzedAccessorTreeNode(IMethod analyzedMethod, string name)	2, 3, 3, 2
AnalyzedEventTreeNode.LoadChildren()	6, 11, 4, 8
AnalyzedFieldTreeNode.LoadChildren()	3, 5, 4, 4
AnalyzedMethodTreeNode.LoadChildren()	3, 5, 4, 4
AnalyzedModuleTreeNode.LoadChildren()	3, 5, 4, 4
AnalyzedPropertyTreeNode.LoadChildren()	5, 9, 4, 6
AnalyzedTypeTreeNode.LoadChildren()	3, 5, 4, 4
AnalyzerContext.GetMethodBody(IMethod method)	4, 8, 3, 2
AnalyzerEntityTreeNode.HandleAssemblyListChanged(ICollection<LoadedAssembly> removedAssemblies, ICollection<LoadedAssembly> addedAssemblies)	3, 5, 3, 2
AnalyzerHelpers.IsPossibleReferenceTo(EntityHandle member, PEFile module, IMethod analyzedMethod)	8, 15, 4, 5
・・・
省略
・・・

--------------------------------------------------------------------------------------------
Block Depth				Statements

0					2,801
1					2,677
2					6,030
3					3,183
4					1,657
5					790
6					309
7					104
8					45
9+					3
--------------------------------------------------------------------------------------------
```

![3](https://github.com/pea-sys/.net-performance-experiments/assets/49807271/13f4c373-5b45-4d7e-8a00-71606f492764)

* Comments:コメントの割合
* Avg Complexity:サイクロマチック複雑度(分岐)
* Avg Depth:ブロックの深さ
* Methods/Class: クラスに多くの責務を持たせすぎてないか。適切に分割できているか。

基本的にはAvg Complexityがもっとも大事な指標で、これが大きいと不具合が発生しやすい状況なので、複雑性を下げる対策をとる必要がある。  
Roslynを使ってvb.betのサイクロマティック複雑度を算出できそうですが、それはまた別の回で。

[参考]  
https://learn.microsoft.com/ja-jp/visualstudio/code-quality/code-metrics-cyclomatic-complexity?view=vs-2022  
https://www.codeproject.com/Articles/11719/Cyclomatic-Code-Complexity-Analysis-for-Microsoft