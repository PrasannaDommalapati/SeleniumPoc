using BoDi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumPoc.Func.Tests.Steps
{
    [Binding]
    public sealed class Hooks
    {
        private IObjectContainer ObjectContainer { get; set; }

        private IWebDriver Driver { get; set; }

        public TestContext TestContext { get; set; }

        public Hooks(IObjectContainer objectContainer, TestContext context)
        {
            TestContext = context;
            ObjectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            ObjectContainer.RegisterInstanceAs<IWebDriver>(Driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
        }
    }
}
