using OpenQA.Selenium;

namespace SeleniumPoc
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
