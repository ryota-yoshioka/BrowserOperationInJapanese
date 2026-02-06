using OpenQA.Selenium;
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

    private WebForm画面() : base("https://www.selenium.dev/selenium/web/web-form.html")
    {
        this.アンカー = new アンカー(By.TagName("a"));
        this.Checkedチェックボックス = new チェックボックス(By.Id("my-check-1"));
        this.Defaultチェックボックス = new チェックボックス(By.Id("my-check-2"));
        this.テキストボックス = new テキストボックス(By.Id("my-text-id"));
        this.テストボタン = new ボタン(By.TagName("button"));
        this.Checkedラジオボタン = new ラジオボタン(By.Id("my-radio-1"));
        this.Defaultラジオボタン = new ラジオボタン(By.Id("my-radio-2"));
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
