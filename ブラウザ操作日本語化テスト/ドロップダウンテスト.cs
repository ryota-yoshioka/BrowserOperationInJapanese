using ブラウザ操作日本語化;

namespace ブラウザ操作日本語化テスト;

[TestClass]
public sealed class ドロップダウンテスト
{
    private readonly FormPage画面 画面;
    public ドロップダウンテスト() : base()
    {
        this.画面 = FormPage画面.移動する();
    }

    private void Twoを選択する()
    {
        this.画面.ドロップダウン.選択する("Two");
    }
    private void Fourを選択する()
    {
        this.画面.ドロップダウン.値で選択する("four");
    }
    private void StillLearningHowToCountApparentlyを選択する()
    {
        this.画面.ドロップダウン.順番で選択する(3);
    }

    private bool Twoが選択されている =>
        this.画面.ドロップダウン.選択されたオプション!.文字列 == "Two";
    private bool Fourが選択されている =>
        this.画面.ドロップダウン.選択されたオプション!.文字列 == "Four";
    private bool StillLearningHowToCountApparentlyが選択されている =>
        this.画面.ドロップダウン.選択されたオプション!.文字列 == "Still learning how to count, apparently";

    [TestMethod]
    public void SelectOption()
    {
        Fourを選択する();
        Assert.IsTrue(Fourが選択されている);

        Twoを選択する();
        Assert.IsTrue(Twoが選択されている);

        StillLearningHowToCountApparentlyを選択する();
        Assert.IsTrue(StillLearningHowToCountApparentlyが選択されている);
    }

    [TestMethod]
    public void SelectMultipleOption()
    {
        // var selectElement = driver.FindElement(By.Name("multi"));
        // var select = new SelectElement(selectElement);

        // var hamElement = driver.FindElement(By.CssSelector("option[value=ham]"));
        // var gravyElement = driver.FindElement(By.CssSelector("option[value='onion gravy']"));
        // var eggElement = driver.FindElement(By.CssSelector("option[value=eggs]"));
        // var sausageElement = driver.FindElement(By.CssSelector("option[value='sausages']"));

        // IList<IWebElement> optionList = select.Options;
        // IWebElement[] optionElements = selectElement.FindElements(By.TagName("option")).ToArray();
        // CollectionAssert.AreEqual(optionElements, optionList.ToArray());

        // IList<IWebElement> selectedOptionList = select.AllSelectedOptions;
        // IWebElement[] expectedSelection = { eggElement, sausageElement };
        // CollectionAssert.AreEqual(expectedSelection, selectedOptionList.ToArray());

        // select.SelectByValue("ham");
        // select.SelectByValue("onion gravy");
        // Assert.IsTrue(hamElement.Selected);
        // Assert.IsTrue(gravyElement.Selected);

        // select.DeselectByValue("eggs");
        // select.DeselectByValue("sausages");
        // Assert.IsFalse(eggElement.Selected);
        // Assert.IsFalse(sausageElement.Selected);
    }
}