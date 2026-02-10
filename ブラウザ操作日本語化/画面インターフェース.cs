namespace ブラウザ操作日本語化;

interface 画面インターフェース
{
    /// <summary>
    /// 画面のタイトル
    /// </summary>
    String タイトル { get; }

    public void ナビゲートする(string url);
    public Web要素 Idで要素を探す(string id);
    public Web要素 Nameで要素を探す(string name);
    public Web要素 TagNameで要素を探す(string tagName);
}