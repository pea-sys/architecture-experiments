# VisualStudioでコードメトリックスの計算

* ソリューションを開いてコードメトリックスを計算するを実行します  

![1](https://github.com/pea-sys/architecture-experiments/assets/49807271/c66ac939-d684-457b-a96d-4e4257bac6b4)

Excelで出力できる。また、保守容易性という指標も導き出してくれる。
以下で計算するようです。  
https://learn.microsoft.com/ja-jp/visualstudio/code-quality/code-metrics-maintainability-index-range-and-meaning?view=vs-2019
```
Maintainability Index = MAX(0,(171 - 5.2 * ln(Halstead Volume) - 0.23 * (Cyclomatic Complexity) - 16.2 * ln(Lines of Code))*100 / 171)
Halstead Volume = 単語の数 * 1単語あたりのビット数
```


0 - 9 = 赤  
10 - 19 = 黄色  
20 - 100 = 緑  