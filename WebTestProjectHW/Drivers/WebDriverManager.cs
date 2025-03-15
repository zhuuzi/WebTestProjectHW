using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebTestProject.Utils;

namespace WebTestProject.Drivers
{
    public static class WebDriverManager
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver(Environment.CurrentDirectory);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Timeouts.ImplicitWait);
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Timeouts.PageLoadTimeout);
                driver.Manage().Window.Maximize();
            }
            return driver;
        }

        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
