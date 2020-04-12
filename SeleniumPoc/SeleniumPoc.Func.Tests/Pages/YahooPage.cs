using OpenQA.Selenium;

namespace SeleniumPoc.Func.Tests.Pages
{
    public class YahooPage : BasePage
    {
        public YahooPage(IWebDriver driver) : base(driver) => Driver = driver;

        public By YSearchField => By.Name("q");

        public void SearchYKeyword(string keyword)
        {
            YSearchField.TypeInto(Driver, keyword);
        }
    }
}
