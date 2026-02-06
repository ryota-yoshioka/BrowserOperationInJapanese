using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class ボタンテスト : Webユニットテスト
{
    [TestMethod]
    public void TestMethod1()
    {
        暗黙の待機時間 = TimeSpan.FromSeconds(10);
        var 画面 = WebForm画面.移動する();
        Assert.AreEqual("Submit", 画面.テストボタン.文字列);
        画面
//            .テストボタン.押す()
            .テストボタン.押す();
        new WebDriverWait(Webドライバ, TimeSpan.FromSeconds(30))
            .Until(d => d.Title.Contains("Web form - target page"));
        Assert.AreEqual("Web form - target page", 画面.タイトル);
    }
}