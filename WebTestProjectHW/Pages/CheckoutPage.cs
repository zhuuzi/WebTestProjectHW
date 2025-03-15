using OpenQA.Selenium;
using WebTestProject.Utils;

namespace WebTestProject.Pages
{
    public class CheckoutPage
    {
        private readonly IWebDriver driver;

        private readonly By nameField = By.Id("first-name");
        private readonly By lastNameField = By.Id("last-name");
        private readonly By postalCodeField = By.Id("postal-code");
        private readonly By continueButton = By.Id("continue");
        private readonly By orderOverviewMessage = By.XPath("//*[text()='Checkout: Overview']");

        public CheckoutPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterCheckoutDetails(string name, string address, string postalCode)
        {
            WaitHelper.WaitForElement(driver, nameField).SendKeys(name);
            WaitHelper.WaitForElement(driver, lastNameField).SendKeys(address);
            WaitHelper.WaitForElement(driver, postalCodeField).SendKeys(postalCode);
        }

        public void PlaceOrder()
        {
            WaitHelper.WaitForElement(driver, continueButton).Click();
        }

        public bool IsOrderOverviewMessageVisible() => WaitHelper.WaitForElement(driver, orderOverviewMessage).Displayed;
    }
}