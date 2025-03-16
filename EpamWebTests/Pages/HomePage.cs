using OpenQA.Selenium;
using WebTestProject.Utils;

namespace EpamWebTests.Pages
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        private static By AboutMenu => By.XPath("//a[contains(@class, 'top-navigation__item-link') and text()='About']");
        private static By InsightsMenu => By.XPath("//a[contains(@class, 'top-navigation__item-link') and text()='Insights']");
        private static By CookieAcceptButton = By.XPath("//*[@id='onetrust-accept-btn-handler']");

        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClickAboutMenu()
        {
            var aboutMenuElement = WaitHelper.WaitForElement(_driver, AboutMenu);
            aboutMenuElement?.Click();
        }

        public void ClickInsightsMenu()
        {
            var insightsMenuElement = WaitHelper.WaitForElement(_driver, InsightsMenu);
            insightsMenuElement?.Click();
        }

        public void AcceptCookies()
        {
            var cookieAcceptButtonElement = WaitHelper.WaitForElement(_driver, CookieAcceptButton);
            cookieAcceptButtonElement?.Click();
        }
    }
}