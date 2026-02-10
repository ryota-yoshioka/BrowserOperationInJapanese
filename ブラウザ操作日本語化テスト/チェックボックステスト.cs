using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class チェックボックステスト
{
    [TestMethod]
    public void TestMethod1()
    {
        var 画面 = WebForm画面.移動する();
        //Assert.AreEqual("Checked checkbox", テスト画面.Checkedチェックボックス.文字列);
        //Assert.AreEqual("Default checkbox", テスト画面.Defaultチェックボックス.文字列);
        Assert.IsTrue(画面.Checkedチェックボックス.選択されている);
        Assert.IsTrue(画面.Defaultチェックボックス.選択されていない);
        画面.Checkedチェックボックス.クリックする();
        画面.Defaultチェックボックス.クリックする();
        Assert.IsTrue(画面.Checkedチェックボックス.選択されていない);
        Assert.IsTrue(画面.Defaultチェックボックス.選択されている);
        画面
            .Checkedチェックボックス.選択する();
        Assert.IsTrue(画面.Checkedチェックボックス.選択されている);
        画面
            .Checkedチェックボックス.選択する();
        Assert.IsTrue(画面.Checkedチェックボックス.選択されている);
        画面
            .Checkedチェックボックス.解除する();
        Assert.IsTrue(画面.Checkedチェックボックス.選択されていない);
        画面
            .Defaultチェックボックス.解除する();
        Assert.IsTrue(画面.Defaultチェックボックス.選択されていない);
    }
}