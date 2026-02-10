using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

public class FormPage画面 : 画面
{
    public ドロップダウン ドロップダウン;
    public ドロップダウン selectElement;

    private FormPage画面() : base(テスト共通.ブラウザ!, "https://www.selenium.dev/selenium/web/formPage.html")
    {
        this.ドロップダウン = ドロップダウン.ByName(this, "selectomatic");
        this.selectElement = ドロップダウン.ByName(this, "multi");
    }

    public static FormPage画面 移動する()
    {
        return new FormPage画面();
    }
}