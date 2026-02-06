using OpenQA.Selenium;
using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

public class FormPage画面 : 画面
{
    public ドロップダウン ドロップダウン;

    private FormPage画面() : base("https://www.selenium.dev/selenium/web/formPage.html")
    {
        this.ドロップダウン = new ドロップダウン(By.Name("selectomatic"));
    }

    public static FormPage画面 移動する()
    {
        return new FormPage画面();
    }
}