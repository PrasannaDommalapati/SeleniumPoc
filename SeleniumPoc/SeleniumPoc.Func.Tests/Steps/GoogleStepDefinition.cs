using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumPoc.Func.Tests.Pages;
using TechTalk.SpecFlow;

namespace SeleniumPoc.Func.Tests.Steps
{
    [Binding]
    public sealed class GoogleStepDefinition
    {

        private readonly IWebDriver Driver;
        private readonly TestContext TestContext;
        private GooglePage GooglePage;

        public GoogleStepDefinition(IWebDriver driver, TestContext testContext)
        {
            Driver = driver;
            TestContext = testContext;
        }

        [Given("I have '(.*)'")]
        public void GivenIHave(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        [When("I enter '(.*)'")]
        public void WhenIEnter(string keyword)
        {
            GooglePage = new GooglePage(Driver);

            GooglePage.SearchKeyword(keyword);
        }
    }
}