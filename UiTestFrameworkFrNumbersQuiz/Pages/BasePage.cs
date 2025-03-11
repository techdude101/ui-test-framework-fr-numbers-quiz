using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace UiTestFrameworkFrNumbersQuiz.Pages
{
    public class BasePage
    {
        IWebDriver webDriver;
        public String baseUrl;
        public int elementTimeoutInSeconds = 5;

        public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            baseUrl = Environment.GetEnvironmentVariable("BaseUrl") ?? "http://localhost:3000";
        }

        public void WaitForElementToBeDisplayed(By bySelector, int timeoutInSeconds)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(ExpectedConditions.ElementIsVisible(bySelector));
        }
    }
}
