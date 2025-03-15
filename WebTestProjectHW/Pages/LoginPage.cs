using OpenQA.Selenium;
using WebTestProject.Utils;

namespace WebTestProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        private readonly By usernameField = By.Id("user-name");
        private readonly By passwordField = By.Id("password");
        private readonly By loginButton = By.Id("login-button");
        private readonly By errorMessage = By.XPath("//*[contains(@class, 'error-message')]");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsLoginPageVisible() => WaitHelper.WaitForElement(driver, loginButton).Displayed;

        public void EnterUsername(string username) => WaitHelper.WaitForElement(driver, usernameField).SendKeys(username);
        public void EnterPassword(string password) => WaitHelper.WaitForElement(driver, passwordField).SendKeys(password);
        public void ClickLogin() => WaitHelper.WaitForElement(driver, loginButton).Click();
        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
        }

        public bool IsErrorDisplayed() => WaitHelper.WaitForElement(driver, errorMessage).Displayed;
    }
}