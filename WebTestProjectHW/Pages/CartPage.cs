using OpenQA.Selenium;
using WebTestProject.Utils;

namespace WebTestProject.Pages
{
    public class CartPage
    {
        private readonly IWebDriver driver;
        private readonly By checkoutButton = By.Id("checkout");

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickCheckout()
        {
            WaitHelper.WaitForElement(driver, checkoutButton).Click();
        }
    }
}
