using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebTestProject.Utils
{
    public static class WaitHelper
    {
        public static IWebElement WaitForElement(IWebDriver driver, By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(drv =>
            {
                var element = drv.FindElement(locator);
                return element.Displayed ? element : null;
            });
        }
    }
}
