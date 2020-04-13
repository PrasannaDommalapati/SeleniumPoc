using OpenQA.Selenium;
using SeleniumPoc.Extensions;

namespace SeleniumPoc.Func.Tests.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) => Driver = driver;

        private By UserName => By.Name("username");

        private By Password => By.Name("password");

        private By LoginBtn => By.ClassName("login");

        public void Login(string userName, string password)
        {
            UserName.TypeInto(Driver, userName);
            Password.TypeInto(Driver, password);

            LoginBtn.Click(Driver);
        }
    }
}
