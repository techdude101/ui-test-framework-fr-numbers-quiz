using OpenQA.Selenium.Chrome;
using Reqnroll;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace UiTestFrameworkFrNumbersQuiz.Hooks
{
    [Binding]
    public class MyHooks : BaseDriver
    {

        [BeforeScenario]
        public void SetupWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            webDriver = new ChromeDriver();
        }

        [AfterScenario]
        public void CleanupWebDriver()
        {
            webDriver.Quit();
        }
    }
}
