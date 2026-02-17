using ブラウザ操作日本語化;

namespace SeleniumDocs.Elements
{
    [TestClass]
    public class InteractionTest
    {
        [TestMethod]
        public void TestInteractionCommands()
        {
            // IWebDriver driver = new ChromeDriver();
            var ブラウザ = ブラウザ操作日本語化テスト.テスト共通.ブラウザ!;
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            // TODO ブラウザ.暗黙の待機時間 = TimeSpan.FromMilliseconds(500);
            ブラウザ.暗黙の待機秒数 = 5;

            // // Navigate to Url
            // driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/inputs.html");
            var 画面 = new 画面(ブラウザ.先頭画面, "https://www.selenium.dev/selenium/web/inputs.html");
            // // Click on the element 
            // IWebElement checkInput = driver.FindElement(By.Name("checkbox_input"));
            // checkInput.Click();
            var checkInput = チェックボックス.ByName(画面, "checkbox_input");
            checkInput.クリックする();

            // //Verify
            // Boolean isChecked = checkInput.Selected;
            Boolean isChecked = checkInput.選択されている;
            Assert.AreEqual(isChecked, false);

            // //SendKeys
            // // Clear field to empty it from any previous data
            // IWebElement emailInput = driver.FindElement(By.Name("email_input"));
            var emailInput = テキストボックス.ByName(画面, "email_input");
            emailInput.クリアする();
            //Enter Text
            String email = "admin@localhost.dev";
            // emailInput.SendKeys(email);
            emailInput.入力する(email);

            //Verify
            // String data = emailInput.GetAttribute("value");
            String data = emailInput.文字列!;
            Assert.AreEqual(data, email);


            //Clear Element
            // Clear field to empty it from any previous data
            // emailInput.Clear();
            emailInput.クリアする();
            // data = emailInput.GetAttribute("value");
            data = emailInput.文字列!;
            
            //Verify
            Assert.AreEqual(data, "");

            // //Quit the browser
            // driver.Quit();
        }
    }
}