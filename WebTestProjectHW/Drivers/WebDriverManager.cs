using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebTestProject.Utils;

namespace WebTestProject.Drivers
{
    public static class WebDriverManager
    {
        private static IWebDriver _driver;

        public static IWebDriver GetDriver(bool headless = false)
        {
            if (_driver == null)
            {
                var options = new ChromeOptions();

                if (headless)
                {
                    options.AddArgument("--headless");
                    options.AddArgument("--disable-gpu");
                    options.AddArgument("--window-size=1920,1080");
                }

                _driver = new ChromeDriver(options);
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Timeouts.ImplicitWait);
                _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Timeouts.PageLoadTimeout);
                _driver.Manage().Window.Maximize();
            }
            return _driver;
        }

        public static void QuitDriver()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver = null;
            }
        }
    }
}