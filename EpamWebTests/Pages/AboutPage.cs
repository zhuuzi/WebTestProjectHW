using OpenQA.Selenium;
using EpamWebTests.Utils;
using WebTestProject.Utils;
using System.Threading;

namespace EpamWebTests.Pages
{
    public class AboutPage
    {
        private readonly IWebDriver _driver;

        public AboutPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static By DownloadButton => By.XPath("//a[contains(@class, 'button-ui-23') and contains(@href, 'EPAM_Corporate_Overview')]");

        public void ClickDownloadButton()
        {
            var downloadButtonElement = WaitHelper.WaitForElement(_driver, DownloadButton);
            
            downloadButtonElement?.Click();
            Thread.Sleep(Constants.Timeouts.FileDownloadWait);
        }
    }
}