using OpenQA.Selenium;

namespace ブラウザ操作日本語化;

/// <summary>
/// 操作する画面の基底クラス
/// </summary>
public class 画面
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public 画面()
    {
    }

    public 画面(string url)
    {
        ブラウザ.移動する(url);
    }

    /// <summary>
    /// 画面のタイトル
    /// </summary>
    public String タイトル => Webユニットテスト.Webドライバ.Title;
}