using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class アンカーテスト
{
    [TestMethod]
    public void TestMethod1()
    {
        var 画面 = WebForm画面.移動する();
        Assert.AreEqual("Return to index", 画面.アンカー.文字列);

        画面.ReturnToIndexアンカーをクリックする();
        Assert.AreEqual("Index of Available Pages", 画面.タイトル);
    }
}