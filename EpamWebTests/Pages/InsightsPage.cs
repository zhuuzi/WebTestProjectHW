using OpenQA.Selenium;
using System.Threading;
using WebTestProject.Utils;

namespace EpamWebTests.Pages
{
    public class InsightsPage
    {
        private readonly IWebDriver _driver;

        public InsightsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private static By CarouselNextButton => By.XPath("//div[contains(@class, 'media-content')]//button[contains(@class, 'slider__right-arrow')]");
        private static By CarouselArticleTitle => By.XPath("//div[contains(@class, 'media-content')]//div[contains(@class, 'owl-item') and contains(@class, 'active')]//span[@class='font-size-60'][.//text()]");
        private static By ReadMoreButton => By.XPath("//div[contains(@class, 'media-content')]//div[contains(@class, 'owl-item') and contains(@class, 'active')]//a[contains(@class, 'custom-link') and contains(text(), 'Read More')]");

        public void SwipeCarousel(int times)
        {
            for (int i = 0; i < times; i++)
            {
                var nextButtonElement = WaitHelper.WaitForElement(_driver, CarouselNextButton);
                nextButtonElement?.Click();
                Thread.Sleep(1000);
            }
        }

        public string GetArticleTitle()
        {
            var articleTitleElement = WaitHelper.WaitForElement(_driver, CarouselArticleTitle);
            return articleTitleElement?.Text.Trim();
        }

        public void ClickReadMoreButton()
        {
            var readMoreButtonElement = WaitHelper.WaitForElement(_driver, ReadMoreButton);
            readMoreButtonElement?.Click();
        }
    }
}