namespace ブラウザ操作日本語化;

/// <summary>
/// 操作するフレームの基底クラス
/// </summary>
public class フレーム : 画面
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    public フレーム(画面インターフェース インターフェース) : base(インターフェース)
    {
    }

    public static フレーム ById(画面 親画面, string id)
    {
        return new フレーム(親画面.Idでフレームを探す(id));
    }
    public static フレーム ByName(画面 親画面, string name)
    {
        return new フレーム(親画面.Nameでフレームを探す(name));
    }
}