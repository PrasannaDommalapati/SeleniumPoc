using OpenQA.Selenium;
using System;

namespace SeleniumPoc
{
    public static class ElementExtension
    {
        public static void TypeInto(this By identifier, IWebDriver driver, string text)
        {
            try
            {
                driver.FindWebElement(identifier).SendKeys(text);
            }
            catch (Exception ex)
            {
                throw new SeleniumPocException(ex.Message);
            }
        }

        public static void EnterKeys(this By identifier, IWebDriver driver)
        {
            try
            {
                driver.FindWebElement(identifier).SendKeys(Keys.Enter);
            }
            catch (Exception ex)
            {
                throw new SeleniumPocException(ex.Message);
            }
        }

        public static void Clear(this By identifier, IWebDriver driver)
        {
            try
            {
                driver.FindWebElement(identifier).Clear();
            }
            catch (Exception ex)
            {
                throw new SeleniumPocException(ex.Message);
            }
        }

        public static void Click(this By identifier, IWebDriver driver)
        {
            try
            {
                driver.FindWebElement(identifier).Click();
            }
            catch (Exception ex)
            {
                throw new SeleniumPocException(ex.Message);
            }
        }

        public static string GetText(this By identifier, IWebDriver driver)
        {
            try
            {
                return driver.FindWebElement(identifier).Text;
            }
            catch (Exception ex)
            {
                throw new SeleniumPocException(ex.Message);
            }
        }

        public static bool IsElementEnabled(this By identifier, IWebDriver driver)
        {
            try
            {
                return driver.FindWebElement(identifier).Enabled;
            }
            catch (Exception ex)
            {
                throw new SeleniumPocException(ex.Message);
            }
        }

        public static bool IsElementDisplayed(this By identifier, IWebDriver driver)
        {
            try
            {
                return driver.FindWebElement(identifier).Displayed;
            }
            catch (Exception ex)
            {
                throw new SeleniumPocException(ex.Message);
            }
        }

        public static bool Selected(this By identifier, IWebDriver driver)
        {
            try
            {
                return driver.FindWebElement(identifier).Selected;
            }
            catch (Exception ex)
            {
                throw new SeleniumPocException(ex.Message);
            }
        }
    }
}