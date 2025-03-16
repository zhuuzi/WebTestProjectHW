using OpenQA.Selenium;

namespace WebTestProject.Pages
{
    public class ArticlePage
    {
        private readonly IWebDriver _driver;
        private static By ArticleTitleLocator => By.XPath("//*[@class='font-size-80-33'][.//text()]");

        public ArticlePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string GetArticleTitle()
        {
            var titleElement = _driver.FindElement(ArticleTitleLocator);
            return titleElement?.Text.Trim();
        }
    }
}
