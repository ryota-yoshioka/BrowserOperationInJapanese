using ブラウザ操作日本語化;

namespace SeleniumDocs.Elements
{
    [TestClass]
    public class InformationTest 
    {
        [TestMethod]
        public void TestInformationCommands(){
            // WebDriver driver = new ChromeDriver();
            var ブラウザ = ブラウザ操作日本語化テスト.テスト共通.ブラウザ!;
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);
            // TODO ブラウザ.暗黙の待機時間 = TimeSpan.FromMilliseconds(500);
            ブラウザ.暗黙の待機秒数 = 5;

            // // Navigate to Url
            // driver.Url= "https://www.selenium.dev/selenium/web/inputs.html";
            var 画面 = new 画面(ブラウザ.先頭画面, "https://www.selenium.dev/selenium/web/inputs.html");
            
            // // isDisplayed        
            // // Get boolean value for is element display
            // bool isEmailVisible = driver.FindElement(By.Name("email_input")).Displayed;
            bool isEmailVisible = テキストボックス.ByName(画面, "email_input").表示されている;
            Assert.AreEqual(isEmailVisible, true);

            // // isEnabled
            // // returns true if element is enabled else returns false
            // bool isEnabledButton = driver.FindElement(By.Name("button_input")).Enabled;
            bool isEnabledButton = テキストボックス.ByName(画面, "button_input").有効である;
            Assert.AreEqual(isEnabledButton, true);

            // // isSelected
            // // returns true if element is checked else returns false
            // bool isSelectedCheck = driver.FindElement(By.Name("checkbox_input")).Selected;
            bool isSelectedCheck = チェックボックス.ByName(画面, "checkbox_input").選択されている;
            Assert.AreEqual(isSelectedCheck, true);

            // // TagName
            // // returns TagName of the element
            // string tagNameInp = driver.FindElement(By.Name("email_input")).TagName;
            // Assert.AreEqual(tagNameInp, "input");

            // // Get Location and Size
            // // Get Location
            // IWebElement rangeElement = driver.FindElement(By.Name("range_input"));
            // Point point = rangeElement.Location;
            // Assert.IsNotNull(point.X);
            // // Get Size
            // int height=rangeElement.Size.Height;
            // Assert.IsNotNull(height);

            // // Retrieves the computed style property 'font-size' of field
            // string cssValue = driver.FindElement(By.Name("color_input")).GetCssValue("font-size");
            // TODO HTML要素.フォントサイズを取得する or HTML要素.フォントサイズ
            string cssValue = テキストボックス.ByName(画面, "color_input").Css属性を取得する("font-size");
            Assert.AreEqual(cssValue, "13.3333px");

            // // GetText

            // // Retrieves the text of the element
            // string text = driver.FindElement(By.TagName("h1")).Text;
            string text = new フォーム要素(画面.TagNameで要素を探す("h1")).文字列;
            Assert.AreEqual(text, "Testing Inputs");

            // // FetchAttributes
            // // identify the email text box
            // IWebElement emailTxt = driver.FindElement(By.Name("email_input"));
            テキストボックス emailTxt = テキストボックス.ByName(画面, "email_input");
            // fetch the value property associated with the textbox
            // string valueInfo = emailTxt.GetAttribute("value");
            string valueInfo = emailTxt.文字列!;
            Assert.AreEqual(valueInfo, "admin@localhost");
            
            // //Quit the driver
            // driver.Quit();
        }
    }
}