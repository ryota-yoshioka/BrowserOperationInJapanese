using OpenQA.Selenium;
using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class テキストボックステスト : Webユニットテスト
{
    [TestMethod]
    public void TestMethod1()
    {
        var 画面 = WebForm画面.移動する();
        Assert.AreEqual("", 画面.テキストボックス.文字列);
        画面
            .テキストボックス.入力する("Selenium Test");
        Assert.AreEqual("Selenium Test", 画面.テキストボックス.文字列);
    }
}