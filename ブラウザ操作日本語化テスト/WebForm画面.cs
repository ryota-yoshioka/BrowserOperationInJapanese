using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

public class WebForm画面 : 画面
{
    public アンカー アンカー;
    public チェックボックス Checkedチェックボックス;
    public チェックボックス Defaultチェックボックス;
    public テキストボックス テキストボックス;
    public ボタン テストボタン;
    public ラジオボタン Checkedラジオボタン;
    public ラジオボタン Defaultラジオボタン;

    private WebForm画面() : base(テスト共通.ブラウザ!.先頭画面, "https://www.selenium.dev/selenium/web/web-form.html")
    {
        this.アンカー = アンカー.ByTagName(this, "a");
        this.Checkedチェックボックス = チェックボックス.ById(this, "my-check-1");
        this.Defaultチェックボックス = チェックボックス.ById(this, "my-check-2");
        this.テキストボックス = テキストボックス.ById(this, "my-text-id");
        this.テストボタン = ボタン.ByTagName(this, "button");
        this.Checkedラジオボタン = ラジオボタン.ById(this, "my-radio-1");
        this.Defaultラジオボタン = ラジオボタン.ById(this, "my-radio-2");
    }

    public static WebForm画面 移動する()
    {
        return new WebForm画面();
    }

    public void ReturnToIndexアンカーをクリックする()
    {
        this.アンカー.クリックする();
    }
}
