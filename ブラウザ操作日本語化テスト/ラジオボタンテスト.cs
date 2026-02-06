using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class ラジオボタンテスト : Webユニットテスト
{
    [TestMethod]
    public void TestMethod1()
    {
        var 画面 = WebForm画面.移動する();
        //Assert.AreEqual("Checked radio", 画面.Checkedラジオボタン.文字列);
        //Assert.AreEqual("Default radio", 画面.Defaultラジオボタン.文字列);
        Assert.IsTrue(画面.Checkedラジオボタン.選択されている);
        Assert.IsTrue(画面.Defaultラジオボタン.選択されていない);
        画面
            .Checkedラジオボタン.クリックする();
        Assert.IsTrue(画面.Checkedラジオボタン.選択されている);
        Assert.IsTrue(画面.Defaultラジオボタン.選択されていない);
        画面
            .Defaultラジオボタン.クリックする();
        Assert.IsTrue(画面.Checkedラジオボタン.選択されていない);
        Assert.IsTrue(画面.Defaultラジオボタン.選択されている);
        画面
            .Checkedラジオボタン.選択する();
        Assert.IsTrue(画面.Checkedラジオボタン.選択されている);
        Assert.IsTrue(画面.Defaultラジオボタン.選択されていない);
        画面
            .Checkedラジオボタン.選択する();
        Assert.IsTrue(画面.Checkedラジオボタン.選択されている);
        Assert.IsTrue(画面.Defaultラジオボタン.選択されていない);
        画面
            .Defaultラジオボタン.選択する();
        Assert.IsTrue(画面.Checkedラジオボタン.選択されていない);
        Assert.IsTrue(画面.Defaultラジオボタン.選択されている);
    }
}