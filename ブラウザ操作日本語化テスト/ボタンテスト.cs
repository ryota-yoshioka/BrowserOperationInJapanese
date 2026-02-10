using System.Diagnostics;
using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class ボタンテスト
{
    [TestMethod]
    public void TestMethod1()
    {
        テスト共通.ブラウザ!.暗黙の待機秒数 = 10;
        var 画面 = WebForm画面.移動する();
        Assert.AreEqual("Submit", 画面.テストボタン.文字列);
        画面
            .テストボタン.押す();
        // new WebDriverWait(Webドライバ, TimeSpan.FromSeconds(30))
        //     .Until(d => d.Title.Contains("Web form - target page"));
        var stopwatch = Stopwatch.StartNew();
        while (stopwatch.ElapsedMilliseconds < 30000)
        {
            if (画面.タイトル.Contains("Web form - target page")) break;
            Task.Delay(500).Wait();
        }
        Assert.AreEqual("Web form - target page", 画面.タイトル);
    }
}