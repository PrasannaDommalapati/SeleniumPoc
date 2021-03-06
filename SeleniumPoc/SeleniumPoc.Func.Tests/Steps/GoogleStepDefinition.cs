﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumPoc.Func.Tests.Pages;
using TechTalk.SpecFlow;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
namespace SeleniumPoc.Func.Tests.Steps
{
    [Binding]
    public sealed class GoogleStepDefinition
    {

        private readonly IWebDriver Driver;
        private readonly TestContext TestContext;
        private LoginPage LoginPage;

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

        [When("I enter '(.*)' and '(.*)'")]
        public void WhenIEnterAnd(string userName, string password)
        {
            LoginPage = new LoginPage(Driver);

            LoginPage.Login(userName, password);
        }
    }
}