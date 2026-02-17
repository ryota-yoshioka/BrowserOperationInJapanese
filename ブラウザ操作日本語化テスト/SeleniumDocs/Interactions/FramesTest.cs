using ブラウザ操作日本語化;

namespace SeleniumDocs.Interactions
{
  [TestClass]
    public class FramesTest
    {
        [TestMethod]
        public void TestFrames()
        {
            // WebDriver driver = new ChromeDriver();
            var ブラウザ = ブラウザ操作日本語化テスト.テスト共通.ブラウザ!;
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            // TODO ブラウザ.暗黙の待機時間 = TimeSpan.FromMilliseconds(500);
            ブラウザ.暗黙の待機秒数 = 5;

            // // Navigate to Url
            // driver.Url= "https://www.selenium.dev/selenium/web/iframes.html";
            var 画面 = new 画面(ブラウザ.先頭画面, "https://www.selenium.dev/selenium/web/iframes.html");
            //switch To IFrame using Web Element
            // IWebElement iframe = driver.FindElement(By.Id("iframe1"));
            var iframe = フレーム.ById(画面, "iframe1");
            //Switch to the frame
            // driver.SwitchTo().Frame(iframe);     ブラウザ操作日本語化には必要ない
            // Assert.AreEqual(true, driver.PageSource.Contains("We Leave From Here"));
            Assert.AreEqual(true, iframe.ページソース.Contains("We Leave From Here"));
            // //Now we can type text into email field
            // IWebElement emailE = driver.FindElement(By.Id("email"));
            var emailE = テキストボックス.ById(iframe, "email");
            // emailE.SendKeys("admin@selenium.dev");
            emailE.キー入力を送る("admin@selenium.dev");
            // emailE.Clear();
            emailE.クリアする();
            // driver.SwitchTo().DefaultContent();  ブラウザ操作日本語化には必要ない


            //switch To IFrame using name or id
            // IWebElement iframe1=driver.FindElement(By.Name("iframe1-name"));
            var iframe1 = フレーム.ByName(画面, "iframe1-name");
            //Switch to the frame
            // driver.SwitchTo().Frame(iframe1);    ブラウザ操作日本語化には必要ない
            // Assert.AreEqual(true, driver.PageSource.Contains("We Leave From Here"));
            Assert.AreEqual(true, iframe1.ページソース.Contains("We Leave From Here"));
            // IWebElement email = driver.FindElement(By.Id("email"));
            var email = テキストボックス.ById(iframe1, "email");
            //Now we can type text into email field
            // email.SendKeys("admin@selenium.dev");
            email.キー入力を送る("admin@selenium.dev");
            // email.Clear();
            email.クリアする();
            // driver.SwitchTo().DefaultContent();  ブラウザ操作日本語化には必要ない


            //switch To IFrame using index
            // driver.SwitchTo().Frame(0);          ブラウザ操作日本語化には必要ない
            // Assert.AreEqual(true, driver.PageSource.Contains("We Leave From Here"));
            Assert.AreEqual(true, iframe.ページソース.Contains("We Leave From Here"));

            //leave frame
            // driver.SwitchTo().DefaultContent();  ブラウザ操作日本語化には必要ない
            // Assert.AreEqual(true, driver.PageSource.Contains("This page has iframes"));
            Assert.AreEqual(true, 画面.ページソース.Contains("This page has iframes"));

            // //quit the browser
            // driver.Quit();
        }
    }
}