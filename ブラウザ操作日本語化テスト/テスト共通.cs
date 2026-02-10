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
    }

    [AssemblyCleanup]
    public static void テスト終了時()
    {
        ブラウザ?.閉じる();
    }
}