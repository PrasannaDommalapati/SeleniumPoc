using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumPoc.Func.Tests.Pages;
using TechTalk.SpecFlow;

namespace SeleniumPoc.Func.Tests.Steps
{
    [Binding]
    public sealed class YahooStepDefinition
    {
        private readonly IWebDriver Driver;
        private readonly TestContext TestContext;
        private YahooPage YahooPage;

        public YahooStepDefinition(IWebDriver driver, TestContext testContext)
        {
            Driver = driver;
            TestContext = testContext;
        }

        [Given(@"I when we have '(.*)'")]
        public void GivenIWhenWeHave(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        [When(@"I enter keyword '(.*)'")]
        public void WhenIEnterKeyword(string keyword)
        {
            YahooPage = new YahooPage(Driver);

            YahooPage.SearchYKeyword(keyword);
        }
    }
}
