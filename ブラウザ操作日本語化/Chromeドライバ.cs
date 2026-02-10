using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ブラウザ操作日本語化;

public class Chromeドライバ : Webドライバ
{
    public Chromeドライバ() : base(new ChromeDriver())
    {
    }

    public Chromeドライバ(ChromeOptions options) : base(new ChromeDriver(options))
    {
        // string userDataDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        // Directory.CreateDirectory(userDataDir);
        // var options = new ChromeOptions()
        // {
        //     //BrowserVersion = null
        // };
        // options.AddArgument($"--user-data-dir={userDataDir}");
        // options.AddArgument("--no-sandbox");
        // options.AddArgument("--disable-dev-shm-usage");
    }
}