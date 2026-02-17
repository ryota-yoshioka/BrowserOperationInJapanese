using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace ブラウザ操作日本語化;

public class Edgeドライバ : Seleniumドライバ
{
    public Edgeドライバ() : base(new EdgeDriver())
    {
    }

    public Edgeドライバ(EdgeOptions options) : base(new EdgeDriver(options))
    {
    }
}