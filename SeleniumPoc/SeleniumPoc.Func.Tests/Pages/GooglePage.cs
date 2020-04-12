using OpenQA.Selenium;

namespace SeleniumPoc.Func.Tests.Pages
{
    public class GooglePage : BasePage
    {
        public GooglePage(IWebDriver driver) : base(driver) => Driver = driver;

        public By SearchField => By.Name("q");

        public void SearchKeyword(string keyword)
        {
            SearchField.TypeInto(Driver, keyword);
        }
    }
}
