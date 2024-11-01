using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TFLJourneyTestRun.StepDefinitions
{
    [Binding]
    public sealed class OpenBrowserStepDefinition
    {
        private IWebDriver driver;
        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver =new ChromeDriver();
            driver.Manage().Window.Maximize();
              }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://tfl.gov.uk/plan-a-journey";

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']")).Click();

        }

        [Then(@"Go to homepage")]
        public void ThenGoToHomepage()
        {
            driver.FindElement(By.XPath("//*[@id='InputFrom']")).SendKeys("Leicester Square Underground Station");
            driver.FindElement(By.XPath("//*[@id='InputTo']")).SendKeys("Covent Garden Underground Station");
            //var selectElement = new SelectElement(driver.FindElement(By.XPath("//*[@id='InputTo']")));
            //selectElement.SelectByText("London");
            driver.FindElement(By.XPath("//*[@id='plan-journey-button']")).Click();

            Thread.Sleep(5000);
            driver.Quit();
        }




    }
}

