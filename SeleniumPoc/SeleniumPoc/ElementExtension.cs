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
    }
}
