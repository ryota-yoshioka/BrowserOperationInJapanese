using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public class テスト共通
{
    public static ブラウザ? ブラウザ;

    [AssemblyInitialize]
    public static void テスト開始時(TestContext context)
    {
        ブラウザ = new Chromeブラウザ();
        // ブラウザ = new Edgeブラウザ();
        // ブラウザ = Playwrightブラウザ.Chromeを起動する();
        // ブラウザ = Playwrightブラウザ.Edgeを起動する();
    }

    [AssemblyCleanup]
    public static void テスト終了時()
    {
        ブラウザ?.閉じる();
    }
}