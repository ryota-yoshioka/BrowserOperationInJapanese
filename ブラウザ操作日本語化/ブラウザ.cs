namespace ブラウザ操作日本語化;

public abstract class ブラウザ
{
    public Webドライバ ドライバ;

    public ブラウザ(Webドライバ ドライバ)
    {
        this.ドライバ = ドライバ;
    }

    public void 閉じる()
    {
        ドライバ?.終了する();
    }

    /// <summary>
    /// 指定されたURLに移動する
    /// </summary>
    /// <param name="url">移動先のURL</param>
    public void 移動する(string url)
    {
        ドライバ.ナビゲートする(url);
    }

    public int 暗黙の待機秒数
    {
        get => ドライバ.デフォルトの待機秒数;
        set => ドライバ.デフォルトの待機秒数 = value;
    }
}